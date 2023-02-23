namespace SoundFilesConverter
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.toGroupbox = new System.Windows.Forms.GroupBox();
            this.toMP3 = new System.Windows.Forms.RadioButton();
            this.toMKV = new System.Windows.Forms.RadioButton();
            this.fromGroupbox = new System.Windows.Forms.GroupBox();
            this.fromMP3 = new System.Windows.Forms.RadioButton();
            this.fromMKV = new System.Windows.Forms.RadioButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.convertButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.infoListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toGroupbox.SuspendLayout();
            this.fromGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(822, 415);
            this.splitContainer1.SplitterDistance = 197;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.selectFolderButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.toGroupbox);
            this.splitContainer2.Panel2.Controls.Add(this.fromGroupbox);
            this.splitContainer2.Size = new System.Drawing.Size(822, 197);
            this.splitContainer2.SplitterDistance = 219;
            this.splitContainer2.TabIndex = 0;
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectFolderButton.Location = new System.Drawing.Point(0, 0);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(219, 197);
            this.selectFolderButton.TabIndex = 0;
            this.selectFolderButton.Text = "Select Folder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // toGroupbox
            // 
            this.toGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toGroupbox.Controls.Add(this.toMP3);
            this.toGroupbox.Controls.Add(this.toMKV);
            this.toGroupbox.Location = new System.Drawing.Point(3, 89);
            this.toGroupbox.Name = "toGroupbox";
            this.toGroupbox.Size = new System.Drawing.Size(584, 100);
            this.toGroupbox.TabIndex = 1;
            this.toGroupbox.TabStop = false;
            this.toGroupbox.Text = "Convert to";
            // 
            // toMP3
            // 
            this.toMP3.AutoSize = true;
            this.toMP3.Location = new System.Drawing.Point(7, 47);
            this.toMP3.Name = "toMP3";
            this.toMP3.Size = new System.Drawing.Size(49, 19);
            this.toMP3.TabIndex = 0;
            this.toMP3.TabStop = true;
            this.toMP3.Text = "MP3";
            this.toMP3.UseVisualStyleBackColor = true;
            // 
            // toMKV
            // 
            this.toMKV.AutoSize = true;
            this.toMKV.Location = new System.Drawing.Point(7, 22);
            this.toMKV.Name = "toMKV";
            this.toMKV.Size = new System.Drawing.Size(50, 19);
            this.toMKV.TabIndex = 0;
            this.toMKV.TabStop = true;
            this.toMKV.Text = "MKV";
            this.toMKV.UseVisualStyleBackColor = true;
            // 
            // fromGroupbox
            // 
            this.fromGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromGroupbox.Controls.Add(this.fromMP3);
            this.fromGroupbox.Controls.Add(this.fromMKV);
            this.fromGroupbox.Location = new System.Drawing.Point(3, 3);
            this.fromGroupbox.Name = "fromGroupbox";
            this.fromGroupbox.Size = new System.Drawing.Size(584, 100);
            this.fromGroupbox.TabIndex = 0;
            this.fromGroupbox.TabStop = false;
            this.fromGroupbox.Text = "Convert From";
            // 
            // fromMP3
            // 
            this.fromMP3.AutoSize = true;
            this.fromMP3.Location = new System.Drawing.Point(6, 47);
            this.fromMP3.Name = "fromMP3";
            this.fromMP3.Size = new System.Drawing.Size(49, 19);
            this.fromMP3.TabIndex = 0;
            this.fromMP3.TabStop = true;
            this.fromMP3.Text = "MP3";
            this.fromMP3.UseVisualStyleBackColor = true;
            // 
            // fromMKV
            // 
            this.fromMKV.AutoSize = true;
            this.fromMKV.Location = new System.Drawing.Point(6, 22);
            this.fromMKV.Name = "fromMKV";
            this.fromMKV.Size = new System.Drawing.Size(50, 19);
            this.fromMKV.TabIndex = 0;
            this.fromMKV.TabStop = true;
            this.fromMKV.Text = "MKV";
            this.fromMKV.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.convertButton);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.progressBar);
            this.splitContainer3.Panel2.Controls.Add(this.infoListBox);
            this.splitContainer3.Size = new System.Drawing.Size(822, 214);
            this.splitContainer3.SplitterDistance = 220;
            this.splitContainer3.TabIndex = 0;
            // 
            // convertButton
            // 
            this.convertButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convertButton.Location = new System.Drawing.Point(0, 0);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(220, 214);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 190);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(598, 24);
            this.progressBar.TabIndex = 1;
            // 
            // infoListBox
            // 
            this.infoListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoListBox.FormattingEnabled = true;
            this.infoListBox.ItemHeight = 15;
            this.infoListBox.Location = new System.Drawing.Point(0, 0);
            this.infoListBox.Name = "infoListBox";
            this.infoListBox.Size = new System.Drawing.Size(598, 184);
            this.infoListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 415);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 532);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(838, 454);
            this.Name = "Form1";
            this.Text = "Converter";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toGroupbox.ResumeLayout(false);
            this.toGroupbox.PerformLayout();
            this.fromGroupbox.ResumeLayout(false);
            this.fromGroupbox.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private Button selectFolderButton;
        private GroupBox toGroupbox;
        private GroupBox fromGroupbox;
        private Button convertButton;
        private ListBox infoListBox;
        private RadioButton toMP3;
        private RadioButton toMKV;
        private RadioButton fromMP3;
        private RadioButton fromMKV;
        private ProgressBar progressBar;
    }
}