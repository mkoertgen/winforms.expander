using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExpanderApp
{
    [Designer(typeof (ExpanderDesigner))]
    public partial class Expander : UserControl
    {
        private static readonly Bitmap DefaultCollapseImage = Properties.Resources.Collapse;
        private static readonly Bitmap DefaultExpandImage = Properties.Resources.Expand;

        private Image _collapseImage = DefaultCollapseImage;
        private Image _expandImage = DefaultExpandImage;

        [Category("Appearance"), DefaultValue(typeof (int), "25")]
        // ReSharper disable once MemberInitializerValueIgnored
        public int CollapsedHeight { get; } = 25;

        public int ExpandedHeight { get; private set; }

        [Category("Appearance"), DefaultValue(typeof(int), "25")]
        public int MinimumContentHeight { get; set; } = 25;

        public Expander()
        {
            InitializeComponent();

            header.Click += (sender, args) => IsExpanded = !IsExpanded;

            CollapsedHeight = splitContainer.SplitterDistance;
        }

        public override Size MinimumSize => GetMinimumSize();

        [Category("Appearance"), DefaultValue(typeof (string), "Header")]
        public string Header
        {
            get { return header.Text; }
            set { header.Text = value; }
        }

        [Category("Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel Content => splitContainer.Panel2;

        [Category("Appearance"), DefaultValue(typeof(bool), "true")]
        public bool IsExpanded
        {
            get { return !splitContainer.Panel2Collapsed; }
            set
            {
                if (splitContainer.Panel2Collapsed != value) return;
                if (!CanToggle) return;

                splitContainer.Panel2Collapsed = !value;
                header.Image = value ? CollapseImage : ExpandImage;

                if (value)
                {
                    MaximumSize = new Size(MaximumSize.Width, 0);
                    Size = new Size(Size.Width, ExpandedHeight);
                }
                else
                {
                    ExpandedHeight = ClientRectangle.Height;
                    MaximumSize = new Size(MaximumSize.Width, CollapsedHeight);
                    Size = new Size(Size.Width, CollapsedHeight);
                }

                ExpandedChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        internal bool CanToggle
        {
            get { return IsExpanded || header.Enabled; }
            set { header.Enabled = value || IsExpanded; }
        }

        public event EventHandler ExpandedChanged;

        [Category("Appearance")]
        public Image CollapseImage
        {
            get { return _collapseImage; }
            set { _collapseImage = value ?? DefaultCollapseImage; }
        }

        [Category("Appearance")]
        public Image ExpandImage
        {
            get { return _expandImage; }
            set { _expandImage = value ?? DefaultExpandImage; }
        }

        private Size GetMinimumSize()
        {
            var minHeight = CollapsedHeight;
            if (IsExpanded) minHeight += splitContainer.SplitterWidth + MinimumContentHeight;
            return new Size(150, minHeight);
        }
    }

    public class ExpanderDesigner : ParentControlDesigner
    {
        private Expander _expander;

        public override void Initialize(IComponent component)
        {
            base.Initialize(component);

            _expander = (Expander) Control;
            EnableDesignMode(_expander.Content, "Content");
        }
    }
}
