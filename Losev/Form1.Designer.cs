namespace Losev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SortButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.generateTsButton = new System.Windows.Forms.ToolStripButton();
            this.openTsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SortButton
            // 
            this.SortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SortButton.Enabled = false;
            this.SortButton.Location = new System.Drawing.Point(240, 364);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(87, 23);
            this.SortButton.TabIndex = 0;
            this.SortButton.Text = "Сортировка";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Enabled = false;
            this.searchButton.Location = new System.Drawing.Point(149, 364);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateTsButton,
            this.openTsButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(339, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // generateTsButton
            // 
            this.generateTsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.generateTsButton.Image = ((System.Drawing.Image)(resources.GetObject("generateTsButton.Image")));
            this.generateTsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.generateTsButton.Name = "generateTsButton";
            this.generateTsButton.Size = new System.Drawing.Size(94, 22);
            this.generateTsButton.Text = "Сгенерировать";
            this.generateTsButton.Click += new System.EventHandler(this.generateTsButton_Click);
            // 
            // openTsButton
            // 
            this.openTsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openTsButton.Image = ((System.Drawing.Image)(resources.GetObject("openTsButton.Image")));
            this.openTsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openTsButton.Name = "openTsButton";
            this.openTsButton.Size = new System.Drawing.Size(58, 22);
            this.openTsButton.Text = "Открыть";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 399);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.SortButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(355, 438);
            this.MinimumSize = new System.Drawing.Size(355, 438);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SortButton;
        private Button searchButton;
        private ToolStrip toolStrip1;
        private ToolStripButton generateTsButton;
        private ToolStripButton openTsButton;
    }
}