using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ExpanderApp
{
    public class ExpanderTablePanel : TableLayoutPanel
    {
        // mostly copied from http://stackoverflow.com/a/31086890/2592915
        // adapted for expander

        private int _sizingRow = -1;
        private int _currentRow = -1;
        private Point _mdown = Point.Empty;
        private int _oldHeight = -1;
        private bool _isNormal;
        private readonly List<RectangleF> _tlpRows = new List<RectangleF>();
        private int[] _rowHeights = new int[0];

        [Category("Appearance"), DefaultValue(typeof(int), "6")]
        public int SplitterSize { get; set; }

        [Category("Appearance"), DefaultValue(typeof(int), "28")]
        public int MinRowHeight { get; set; }


        public ExpanderTablePanel()
        {
            MouseDown += SplitTablePanel_MouseDown;
            MouseMove += SplitTablePanel_MouseMove;
            MouseUp += SplitTablePanel_MouseUp;
            MouseLeave += SplitTablePanel_MouseLeave;
            SplitterSize = 6;
            MinRowHeight = 28;

            foreach (var expander in Controls.OfType<Expander>())
                expander.ExpandedChanged += Expander_ExpandedChanged;
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            var expander = e.Control as Expander;
            if (expander != null)
                expander.ExpandedChanged += Expander_ExpandedChanged;
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
            var expander = e.Control as Expander;
            if (expander != null)
                expander.ExpandedChanged -= Expander_ExpandedChanged;
        }

        private void Expander_ExpandedChanged(object sender, EventArgs e)
        {
            var expander = sender as Expander;
            if (expander == null) return;

            var row = GetRow(expander);
            if (row < 0) return;

            var newHeight = expander.IsExpanded ? expander.ExpandedHeight : expander.CollapsedHeight;

            // special case: last row. Cannot be set by splitter, must be expander toggle
            var isLastRow = (row == RowCount - 1);
            if (isLastRow)
            {
                row--;
                newHeight = _rowHeights[row] + _rowHeights[row + 1] - newHeight;
            }

            SizeRow(row, newHeight);
        }

        private void SplitTablePanel_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void SplitTablePanel_MouseUp(object sender, MouseEventArgs e)
        {
            GetRowRectangles(SplitterSize);
        }

        private void SplitTablePanel_MouseMove(object sender, MouseEventArgs e)
        {
            // one-time initialization, defer until we have valid _rowHeights
            if (!_isNormal) NomalizeRowStyles();

            if (_tlpRows.Count <= 0) GetRowRectangles(SplitterSize);
            if (_rowHeights.Length <= 0) _rowHeights = GetRowHeights();

            if (e.Button == MouseButtons.Left)
            {
                if (_sizingRow < 0) return;
                var newHeight = _oldHeight + e.Y - _mdown.Y;
                SizeRow(_sizingRow, newHeight);
            }
            else
            {
                _currentRow = -1;
                for (var i = 0; i < _tlpRows.Count; i++)
                    if (_tlpRows[i].Contains(e.Location)) { _currentRow = i; break; }
                Cursor = _currentRow >= 0 ? Cursors.SizeNS : Cursors.Default;
            }
        }

        private void SplitTablePanel_MouseDown(object sender, MouseEventArgs e)
        {
            _mdown = Point.Empty;
            _sizingRow = -1;
            if (_currentRow < 0) return;
            _sizingRow = _currentRow;
            _oldHeight = _rowHeights[_sizingRow];
            _mdown = e.Location;
        }

        private void GetRowRectangles(float size)
        {   // get a list of mouse sensitive rectangles
            var sz = size / 2f;
            var y = 0f;
            var w = ClientSize.Width;
            var rw = GetRowHeights();

            _tlpRows.Clear();
            for (var i = 0; i < rw.Length - 1; i++)
            {
                y += rw[i];
                _tlpRows.Add(new RectangleF(0, y - sz, w, size));
            }
        }

        private void SizeRow(int row, int newHeight)
        {   // change the height of one row
            if (newHeight == 0) return;
            if (row < 0) return;

            _rowHeights = GetRowHeights();
            // skip if no row heights
            if (row >= _rowHeights.Length)
                return;

            newHeight = CoerceRowHeight(row, newHeight);
            if (newHeight == _rowHeights[row]) return;

            SuspendLayout();

            RowStyles[row] = new RowStyle(SizeType.Absolute, newHeight);

            var isLastRow = (row == RowCount - 1);
            if (!isLastRow)
            {
                // adjust adjacent row
                var delta = newHeight - _rowHeights[row];
                var newHeight2 = _rowHeights[row + 1] - delta;
                RowStyles[row + 1] = new RowStyle(SizeType.Absolute, newHeight2);
            }

            ResumeLayout();

            _rowHeights = GetRowHeights();

            GetRowRectangles(SplitterSize);
        }

        private int CoerceRowHeight(int row, int newHeight)
        {
            if (newHeight == _rowHeights[row]) return newHeight;

            // coerce height by control min/max size (e.g. expander)
            var minHeight = MinRowHeight;
            var maxHeight = newHeight;

            var c1 = GetControlFromPosition(0, row);
            // preserve c1 min/max size
            var c1MaxH = c1.MaximumSize.Height;
            if (c1MaxH > 0) maxHeight = Math.Min(maxHeight, c1MaxH - SplitterSize);
            var c1MinH = c1.MinimumSize.Height;
            if (c1MinH > 0) minHeight = Math.Max(minHeight, c1MinH + SplitterSize);

            newHeight = Math.Max(Math.Min(newHeight, maxHeight), minHeight);

            // coerce adjacent row
            var deltaHeight = newHeight - _rowHeights[row];
            if (deltaHeight == 0) return newHeight;

            var c2 = GetControlFromPosition(0, row + 1);
            var c2HeightToBe = _rowHeights[row + 1] - deltaHeight;
            if (deltaHeight > 0) // c1 wants to grow
            {
                // preserve c2.minsize
                var c2MinH = c2.MinimumSize.Height;
                if (c2MinH > 0)
                {
                    c2MinH += SplitterSize;
                    if (c2HeightToBe < c2MinH)
                        newHeight -= (c2MinH - c2HeightToBe);
                }
            }
            else // c1 wants to shrink
            {
                // preserve c1.maxsize
                var c2MaxH = c2.MaximumSize.Height;
                if (c2MaxH > 0)
                {
                    c2MaxH += SplitterSize;
                    if (c2HeightToBe > c2MaxH)
                        newHeight += (c2HeightToBe - c2MaxH);
                }
            }

            return newHeight;
        }

        private void NomalizeRowStyles()
        {
            // set all rows to absolute and the last one to percent=100!
            if (_rowHeights.Length <= 0) return;
            _rowHeights = GetRowHeights();
            RowStyles.Clear();
            for (var i = 0; i < RowCount - 1; i++)
            {
                var rowStyle = new RowStyle(SizeType.AutoSize);
                if (i < _rowHeights.Length)
                    rowStyle = new RowStyle(SizeType.Absolute, _rowHeights[i]);
                RowStyles.Add(rowStyle);
            }
            RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            _isNormal = true;
        }
    }
}
