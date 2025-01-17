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
            selectFolderButton = new Button();
            toGroupbox = new GroupBox();
            toMP3 = new RadioButton();
            toMKV = new RadioButton();
            fromGroupbox = new GroupBox();
            fromMP3 = new RadioButton();
            fromMKV = new RadioButton();
            convertButton = new Button();
            infoListBox = new ListBox();
            splitContainer4 = new SplitContainer();
            splitContainer5 = new SplitContainer();
            splitContainer6 = new SplitContainer();
            splitContainer7 = new SplitContainer();
            toGroupbox.SuspendLayout();
            fromGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.Panel1.SuspendLayout();
            splitContainer6.Panel2.SuspendLayout();
            splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer7).BeginInit();
            splitContainer7.Panel1.SuspendLayout();
            splitContainer7.Panel2.SuspendLayout();
            splitContainer7.SuspendLayout();
            SuspendLayout();
            // 
            // selectFolderButton
            // 
            selectFolderButton.Dock = DockStyle.Fill;
            selectFolderButton.Location = new Point(0, 0);
            selectFolderButton.Name = "selectFolderButton";
            selectFolderButton.Size = new Size(275, 237);
            selectFolderButton.TabIndex = 0;
            selectFolderButton.Text = "Select Folder";
            selectFolderButton.UseVisualStyleBackColor = true;
            selectFolderButton.Click += selectFolderButton_Click;
            // 
            // toGroupbox
            // 
            toGroupbox.Controls.Add(toMP3);
            toGroupbox.Controls.Add(toMKV);
            toGroupbox.Dock = DockStyle.Fill;
            toGroupbox.Location = new Point(0, 0);
            toGroupbox.Name = "toGroupbox";
            toGroupbox.Size = new Size(303, 237);
            toGroupbox.TabIndex = 1;
            toGroupbox.TabStop = false;
            toGroupbox.Text = "Convert to";
            // 
            // toMP3
            // 
            toMP3.AutoSize = true;
            toMP3.Location = new Point(7, 47);
            toMP3.Name = "toMP3";
            toMP3.Size = new Size(49, 19);
            toMP3.TabIndex = 0;
            toMP3.TabStop = true;
            toMP3.Text = "MP3";
            toMP3.UseVisualStyleBackColor = true;
            // 
            // toMKV
            // 
            toMKV.AutoSize = true;
            toMKV.Location = new Point(7, 22);
            toMKV.Name = "toMKV";
            toMKV.Size = new Size(50, 19);
            toMKV.TabIndex = 0;
            toMKV.TabStop = true;
            toMKV.Text = "MKV";
            toMKV.UseVisualStyleBackColor = true;
            // 
            // fromGroupbox
            // 
            fromGroupbox.Controls.Add(fromMP3);
            fromGroupbox.Controls.Add(fromMKV);
            fromGroupbox.Dock = DockStyle.Fill;
            fromGroupbox.Location = new Point(0, 0);
            fromGroupbox.Name = "fromGroupbox";
            fromGroupbox.Size = new Size(251, 237);
            fromGroupbox.TabIndex = 0;
            fromGroupbox.TabStop = false;
            fromGroupbox.Text = "Convert From";
            // 
            // fromMP3
            // 
            fromMP3.AutoSize = true;
            fromMP3.Location = new Point(6, 47);
            fromMP3.Name = "fromMP3";
            fromMP3.Size = new Size(49, 19);
            fromMP3.TabIndex = 0;
            fromMP3.TabStop = true;
            fromMP3.Text = "MP3";
            fromMP3.UseVisualStyleBackColor = true;
            // 
            // fromMKV
            // 
            fromMKV.AutoSize = true;
            fromMKV.Location = new Point(6, 22);
            fromMKV.Name = "fromMKV";
            fromMKV.Size = new Size(50, 19);
            fromMKV.TabIndex = 0;
            fromMKV.TabStop = true;
            fromMKV.Text = "MKV";
            fromMKV.UseVisualStyleBackColor = true;
            // 
            // convertButton
            // 
            convertButton.Dock = DockStyle.Fill;
            convertButton.Enabled = false;
            convertButton.Location = new Point(0, 0);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(279, 246);
            convertButton.TabIndex = 0;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // infoListBox
            // 
            infoListBox.Dock = DockStyle.Fill;
            infoListBox.FormattingEnabled = true;
            infoListBox.ItemHeight = 15;
            infoListBox.Location = new Point(0, 0);
            infoListBox.Name = "infoListBox";
            infoListBox.Size = new Size(554, 246);
            infoListBox.TabIndex = 0;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Margin = new Padding(2);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(splitContainer5);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(splitContainer7);
            splitContainer4.Size = new Size(837, 486);
            splitContainer4.SplitterDistance = 237;
            splitContainer4.SplitterWidth = 3;
            splitContainer4.TabIndex = 1;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(selectFolderButton);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(splitContainer6);
            splitContainer5.Size = new Size(837, 237);
            splitContainer5.SplitterDistance = 275;
            splitContainer5.TabIndex = 0;
            // 
            // splitContainer6
            // 
            splitContainer6.Dock = DockStyle.Fill;
            splitContainer6.Location = new Point(0, 0);
            splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            splitContainer6.Panel1.Controls.Add(fromGroupbox);
            // 
            // splitContainer6.Panel2
            // 
            splitContainer6.Panel2.Controls.Add(toGroupbox);
            splitContainer6.Size = new Size(558, 237);
            splitContainer6.SplitterDistance = 251;
            splitContainer6.TabIndex = 0;
            // 
            // splitContainer7
            // 
            splitContainer7.Dock = DockStyle.Fill;
            splitContainer7.Location = new Point(0, 0);
            splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            splitContainer7.Panel1.Controls.Add(convertButton);
            // 
            // splitContainer7.Panel2
            // 
            splitContainer7.Panel2.Controls.Add(infoListBox);
            splitContainer7.Size = new Size(837, 246);
            splitContainer7.SplitterDistance = 279;
            splitContainer7.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 486);
            Controls.Add(splitContainer4);
            MaximizeBox = false;
            MaximumSize = new Size(853, 525);
            MinimizeBox = false;
            MinimumSize = new Size(853, 525);
            Name = "Form1";
            Text = "Converter";
            Load += prog_init;
            toGroupbox.ResumeLayout(false);
            toGroupbox.PerformLayout();
            fromGroupbox.ResumeLayout(false);
            fromGroupbox.PerformLayout();
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            splitContainer6.Panel1.ResumeLayout(false);
            splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer6).EndInit();
            splitContainer6.ResumeLayout(false);
            splitContainer7.Panel1.ResumeLayout(false);
            splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer7).EndInit();
            splitContainer7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button selectFolderButton;
        private GroupBox toGroupbox;
        private GroupBox fromGroupbox;
        private Button convertButton;
        private ListBox infoListBox;
        private RadioButton toMP3;
        private RadioButton toMKV;
        private RadioButton fromMP3;
        private RadioButton fromMKV;
        private SplitContainer splitContainer4;
        private SplitContainer splitContainer5;
        private SplitContainer splitContainer6;
        private SplitContainer splitContainer7;
    }
}