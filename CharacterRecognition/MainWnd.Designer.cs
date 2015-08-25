namespace CharacterRecognition
{
    partial class MainWnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWnd));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnAnalyzeImage = new System.Windows.Forms.Button();
            this.rtbOcrResult = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStripOCR = new System.Windows.Forms.StatusStrip();
            this.statusLabelOCR = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.statusStripOCR.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox.Location = new System.Drawing.Point(12, 61);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(565, 529);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // btnAnalyzeImage
            // 
            this.btnAnalyzeImage.Location = new System.Drawing.Point(912, 609);
            this.btnAnalyzeImage.Name = "btnAnalyzeImage";
            this.btnAnalyzeImage.Size = new System.Drawing.Size(121, 34);
            this.btnAnalyzeImage.TabIndex = 2;
            this.btnAnalyzeImage.Text = "Analyze";
            this.btnAnalyzeImage.UseVisualStyleBackColor = true;
            this.btnAnalyzeImage.Click += new System.EventHandler(this.btnAnalyzeImage_Click);
            // 
            // rtbOcrResult
            // 
            this.rtbOcrResult.Location = new System.Drawing.Point(583, 61);
            this.rtbOcrResult.Name = "rtbOcrResult";
            this.rtbOcrResult.Size = new System.Drawing.Size(450, 529);
            this.rtbOcrResult.TabIndex = 3;
            this.rtbOcrResult.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Invoice";
            // 
            // statusStripOCR
            // 
            this.statusStripOCR.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripOCR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelOCR});
            this.statusStripOCR.Location = new System.Drawing.Point(0, 653);
            this.statusStripOCR.Name = "statusStripOCR";
            this.statusStripOCR.Size = new System.Drawing.Size(1045, 25);
            this.statusStripOCR.TabIndex = 6;
            this.statusStripOCR.Text = "Ready";
            // 
            // statusLabelOCR
            // 
            this.statusLabelOCR.Name = "statusLabelOCR";
            this.statusLabelOCR.Size = new System.Drawing.Size(50, 20);
            this.statusLabelOCR.Text = "Ready";
            // 
            // MainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 678);
            this.Controls.Add(this.statusStripOCR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbOcrResult);
            this.Controls.Add(this.btnAnalyzeImage);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Recognition";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.statusStripOCR.ResumeLayout(false);
            this.statusStripOCR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnAnalyzeImage;
        private System.Windows.Forms.RichTextBox rtbOcrResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStripOCR;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelOCR;
    }
}

