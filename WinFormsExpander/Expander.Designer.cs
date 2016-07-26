namespace WinFormsExpander
{
    partial class Expander
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.expandButton = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.expandButton);
            this.splitContainer.Panel1.Controls.Add(this.header);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.AutoScrollMinSize = new System.Drawing.Size(150, 50);
            this.splitContainer.Size = new System.Drawing.Size(148, 93);
            this.splitContainer.SplitterDistance = 27;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // expandButton
            // 
            this.expandButton.Image = global::WinFormsExpander.Properties.Resources.Collapse;
            this.expandButton.Location = new System.Drawing.Point(4, 0);
            this.expandButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.expandButton.MinimumSize = new System.Drawing.Size(16, 24);
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(16, 24);
            this.expandButton.TabIndex = 1;
            this.expandButton.TabStop = false;
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.header.Location = new System.Drawing.Point(22, 0);
            this.header.MaximumSize = new System.Drawing.Size(0, 25);
            this.header.MinimumSize = new System.Drawing.Size(75, 25);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(75, 25);
            this.header.TabIndex = 0;
            this.header.Text = "Header";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Expander
            // 
            this.AutoScroll = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(150, 25);
            this.Name = "Expander";
            this.Size = new System.Drawing.Size(148, 93);
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button expandButton;
    }
}
