namespace ExpanderApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._expanderTablePanel1 = new ExpanderApp.ExpanderTablePanel();
            this.expander1 = new ExpanderApp.Expander();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.expander2 = new ExpanderApp.Expander();
            this.button1 = new System.Windows.Forms.Button();
            this.expander3 = new ExpanderApp.Expander();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this._expanderTablePanel1.SuspendLayout();
            this.expander1.Content.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.expander2.Content.SuspendLayout();
            this.expander3.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitTablePanel1
            // 
            this._expanderTablePanel1.ColumnCount = 1;
            this._expanderTablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._expanderTablePanel1.Controls.Add(this.expander1, 0, 0);
            this._expanderTablePanel1.Controls.Add(this.expander2, 0, 1);
            this._expanderTablePanel1.Controls.Add(this.expander3, 0, 2);
            this._expanderTablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._expanderTablePanel1.Location = new System.Drawing.Point(0, 0);
            this._expanderTablePanel1.Name = "_expanderTablePanel1";
            this._expanderTablePanel1.RowCount = 3;
            this._expanderTablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._expanderTablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._expanderTablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._expanderTablePanel1.Size = new System.Drawing.Size(1126, 792);
            this._expanderTablePanel1.SplitterSize = 6;
            this._expanderTablePanel1.TabIndex = 3;
            // 
            // expander1
            // 
            this.expander1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expander1.AutoScroll = true;
            this.expander1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expander1.CollapseImage = ((System.Drawing.Image)(resources.GetObject("expander1.CollapseImage")));
            // 
            // expander1.Content
            // 
            this.expander1.Content.AutoScroll = true;
            this.expander1.Content.Controls.Add(this.tabControl1);
            this.expander1.ExpandImage = ((System.Drawing.Image)(resources.GetObject("expander1.ExpandImage")));
            this.expander1.IsExpanded = true;
            this.expander1.Location = new System.Drawing.Point(3, 3);
            this.expander1.MinimumSize = new System.Drawing.Size(150, 25);
            this.expander1.Name = "expander1";
            this.expander1.Size = new System.Drawing.Size(1120, 257);
            this.expander1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1118, 227);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1110, 201);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1110, 201);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // expander2
            // 
            this.expander2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expander2.AutoScroll = true;
            this.expander2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expander2.CollapseImage = ((System.Drawing.Image)(resources.GetObject("expander2.CollapseImage")));
            // 
            // expander2.Content
            // 
            this.expander2.Content.AutoScroll = true;
            this.expander2.Content.AutoScrollMinSize = new System.Drawing.Size(150, 50);
            this.expander2.Content.Controls.Add(this.button1);
            this.expander2.ExpandImage = ((System.Drawing.Image)(resources.GetObject("expander2.ExpandImage")));
            this.expander2.Header = "Header2";
            this.expander2.IsExpanded = true;
            this.expander2.Location = new System.Drawing.Point(3, 266);
            this.expander2.MinimumSize = new System.Drawing.Size(150, 25);
            this.expander2.Name = "expander2";
            this.expander2.Size = new System.Drawing.Size(1120, 114);
            this.expander2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // expander3
            // 
            this.expander3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expander3.AutoScroll = true;
            this.expander3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expander3.CollapseImage = global::ExpanderApp.Properties.Resources.Collapse;
            // 
            // expander3.Content
            // 
            this.expander3.Content.AutoScroll = true;
            this.expander3.Content.AutoScrollMinSize = new System.Drawing.Size(150, 50);
            this.expander3.Content.Controls.Add(this.checkBox1);
            this.expander3.ExpandImage = global::ExpanderApp.Properties.Resources.Expand;
            this.expander3.Header = "Header3";
            this.expander3.IsExpanded = true;
            this.expander3.Location = new System.Drawing.Point(3, 386);
            this.expander3.MinimumSize = new System.Drawing.Size(150, 25);
            this.expander3.Name = "expander3";
            this.expander3.Size = new System.Drawing.Size(1120, 403);
            this.expander3.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(42, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 792);
            this.Controls.Add(this._expanderTablePanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this._expanderTablePanel1.ResumeLayout(false);
            this.expander1.Content.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.expander2.Content.ResumeLayout(false);
            this.expander3.Content.ResumeLayout(false);
            this.expander3.Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Expander expander1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Expander expander2;
        private Expander expander3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private ExpanderTablePanel _expanderTablePanel1;
    }
}

