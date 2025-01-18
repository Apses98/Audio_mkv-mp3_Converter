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
            tabControl = new TabControl();
            conversionTab = new TabPage();
            downloadingTab = new TabPage();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            selectDownloadPathButton = new Button();
            downloadPathLabel = new Label();
            Somelabel = new Label();
            splitContainer3 = new SplitContainer();
            splitContainer8 = new SplitContainer();
            addYoutubeVideoLinkButton = new Button();
            youtubeVideoLinkTextbox = new TextBox();
            splitContainer9 = new SplitContainer();
            splitContainer11 = new SplitContainer();
            downloadVideoTypeMp4RadioButton = new RadioButton();
            downloadVideoTypeMp3RadioButton = new RadioButton();
            youtubeLinksListbox = new ListBox();
            splitContainer10 = new SplitContainer();
            downloadButton = new Button();
            progressBar1 = new ProgressBar();
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
            tabControl.SuspendLayout();
            conversionTab.SuspendLayout();
            downloadingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer8).BeginInit();
            splitContainer8.Panel1.SuspendLayout();
            splitContainer8.Panel2.SuspendLayout();
            splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer9).BeginInit();
            splitContainer9.Panel1.SuspendLayout();
            splitContainer9.Panel2.SuspendLayout();
            splitContainer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer11).BeginInit();
            splitContainer11.Panel1.SuspendLayout();
            splitContainer11.Panel2.SuspendLayout();
            splitContainer11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer10).BeginInit();
            splitContainer10.Panel1.SuspendLayout();
            splitContainer10.Panel2.SuspendLayout();
            splitContainer10.SuspendLayout();
            SuspendLayout();
            // 
            // selectFolderButton
            // 
            selectFolderButton.Dock = DockStyle.Fill;
            selectFolderButton.Location = new Point(0, 0);
            selectFolderButton.Name = "selectFolderButton";
            selectFolderButton.Size = new Size(270, 220);
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
            toGroupbox.Size = new Size(300, 220);
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
            fromGroupbox.Size = new Size(245, 220);
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
            convertButton.Size = new Size(274, 229);
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
            infoListBox.Size = new Size(545, 229);
            infoListBox.TabIndex = 0;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(3, 3);
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
            splitContainer4.Size = new Size(823, 452);
            splitContainer4.SplitterDistance = 220;
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
            splitContainer5.Size = new Size(823, 220);
            splitContainer5.SplitterDistance = 270;
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
            splitContainer6.Size = new Size(549, 220);
            splitContainer6.SplitterDistance = 245;
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
            splitContainer7.Size = new Size(823, 229);
            splitContainer7.SplitterDistance = 274;
            splitContainer7.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(conversionTab);
            tabControl.Controls.Add(downloadingTab);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(837, 486);
            tabControl.TabIndex = 2;
            // 
            // conversionTab
            // 
            conversionTab.Controls.Add(splitContainer4);
            conversionTab.Location = new Point(4, 24);
            conversionTab.Name = "conversionTab";
            conversionTab.Padding = new Padding(3);
            conversionTab.Size = new Size(829, 458);
            conversionTab.TabIndex = 0;
            conversionTab.Text = "Converter";
            conversionTab.UseVisualStyleBackColor = true;
            // 
            // downloadingTab
            // 
            downloadingTab.Controls.Add(splitContainer1);
            downloadingTab.Location = new Point(4, 24);
            downloadingTab.Name = "downloadingTab";
            downloadingTab.Padding = new Padding(3);
            downloadingTab.Size = new Size(829, 458);
            downloadingTab.TabIndex = 1;
            downloadingTab.Text = "YT Downloader";
            downloadingTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer3);
            splitContainer1.Size = new Size(823, 452);
            splitContainer1.SplitterDistance = 62;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(selectDownloadPathButton);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(downloadPathLabel);
            splitContainer2.Panel2.Controls.Add(Somelabel);
            splitContainer2.Size = new Size(823, 62);
            splitContainer2.SplitterDistance = 274;
            splitContainer2.TabIndex = 0;
            // 
            // selectDownloadPathButton
            // 
            selectDownloadPathButton.Dock = DockStyle.Fill;
            selectDownloadPathButton.Location = new Point(0, 0);
            selectDownloadPathButton.Name = "selectDownloadPathButton";
            selectDownloadPathButton.Size = new Size(274, 62);
            selectDownloadPathButton.TabIndex = 0;
            selectDownloadPathButton.Text = "Change download path";
            selectDownloadPathButton.UseVisualStyleBackColor = true;
            selectDownloadPathButton.Click += selectDownloadPathButton_Click;
            // 
            // downloadPathLabel
            // 
            downloadPathLabel.Location = new Point(3, 24);
            downloadPathLabel.Name = "downloadPathLabel";
            downloadPathLabel.Size = new Size(539, 38);
            downloadPathLabel.TabIndex = 1;
            downloadPathLabel.Text = "label1";
            // 
            // Somelabel
            // 
            Somelabel.AutoSize = true;
            Somelabel.Dock = DockStyle.Top;
            Somelabel.Location = new Point(0, 0);
            Somelabel.Name = "Somelabel";
            Somelabel.Size = new Size(117, 15);
            Somelabel.TabIndex = 0;
            Somelabel.Text = "Files will be saved to:";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(splitContainer8);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer9);
            splitContainer3.Size = new Size(823, 386);
            splitContainer3.SplitterDistance = 76;
            splitContainer3.TabIndex = 0;
            // 
            // splitContainer8
            // 
            splitContainer8.Dock = DockStyle.Fill;
            splitContainer8.Location = new Point(0, 0);
            splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            splitContainer8.Panel1.Controls.Add(addYoutubeVideoLinkButton);
            // 
            // splitContainer8.Panel2
            // 
            splitContainer8.Panel2.Controls.Add(youtubeVideoLinkTextbox);
            splitContainer8.Size = new Size(823, 76);
            splitContainer8.SplitterDistance = 274;
            splitContainer8.TabIndex = 0;
            // 
            // addYoutubeVideoLinkButton
            // 
            addYoutubeVideoLinkButton.Dock = DockStyle.Fill;
            addYoutubeVideoLinkButton.Location = new Point(0, 0);
            addYoutubeVideoLinkButton.Name = "addYoutubeVideoLinkButton";
            addYoutubeVideoLinkButton.Size = new Size(274, 76);
            addYoutubeVideoLinkButton.TabIndex = 0;
            addYoutubeVideoLinkButton.Text = "Add video to List";
            addYoutubeVideoLinkButton.UseVisualStyleBackColor = true;
            addYoutubeVideoLinkButton.Click += addYoutubeVideoLinkButton_Click;
            // 
            // youtubeVideoLinkTextbox
            // 
            youtubeVideoLinkTextbox.Dock = DockStyle.Fill;
            youtubeVideoLinkTextbox.Location = new Point(0, 0);
            youtubeVideoLinkTextbox.Multiline = true;
            youtubeVideoLinkTextbox.Name = "youtubeVideoLinkTextbox";
            youtubeVideoLinkTextbox.Size = new Size(545, 76);
            youtubeVideoLinkTextbox.TabIndex = 0;
            // 
            // splitContainer9
            // 
            splitContainer9.Dock = DockStyle.Fill;
            splitContainer9.Location = new Point(0, 0);
            splitContainer9.Name = "splitContainer9";
            splitContainer9.Orientation = Orientation.Horizontal;
            // 
            // splitContainer9.Panel1
            // 
            splitContainer9.Panel1.Controls.Add(splitContainer11);
            // 
            // splitContainer9.Panel2
            // 
            splitContainer9.Panel2.Controls.Add(splitContainer10);
            splitContainer9.Size = new Size(823, 306);
            splitContainer9.SplitterDistance = 157;
            splitContainer9.TabIndex = 0;
            // 
            // splitContainer11
            // 
            splitContainer11.Dock = DockStyle.Fill;
            splitContainer11.Location = new Point(0, 0);
            splitContainer11.Name = "splitContainer11";
            // 
            // splitContainer11.Panel1
            // 
            splitContainer11.Panel1.Controls.Add(downloadVideoTypeMp4RadioButton);
            splitContainer11.Panel1.Controls.Add(downloadVideoTypeMp3RadioButton);
            // 
            // splitContainer11.Panel2
            // 
            splitContainer11.Panel2.Controls.Add(youtubeLinksListbox);
            splitContainer11.Size = new Size(823, 157);
            splitContainer11.SplitterDistance = 274;
            splitContainer11.TabIndex = 1;
            // 
            // downloadVideoTypeMp4RadioButton
            // 
            downloadVideoTypeMp4RadioButton.AutoSize = true;
            downloadVideoTypeMp4RadioButton.Location = new Point(19, 40);
            downloadVideoTypeMp4RadioButton.Name = "downloadVideoTypeMp4RadioButton";
            downloadVideoTypeMp4RadioButton.Size = new Size(95, 19);
            downloadVideoTypeMp4RadioButton.TabIndex = 1;
            downloadVideoTypeMp4RadioButton.TabStop = true;
            downloadVideoTypeMp4RadioButton.Text = "mp4 ( video )";
            downloadVideoTypeMp4RadioButton.UseVisualStyleBackColor = true;
            // 
            // downloadVideoTypeMp3RadioButton
            // 
            downloadVideoTypeMp3RadioButton.AutoSize = true;
            downloadVideoTypeMp3RadioButton.Location = new Point(19, 15);
            downloadVideoTypeMp3RadioButton.Name = "downloadVideoTypeMp3RadioButton";
            downloadVideoTypeMp3RadioButton.Size = new Size(96, 19);
            downloadVideoTypeMp3RadioButton.TabIndex = 0;
            downloadVideoTypeMp3RadioButton.TabStop = true;
            downloadVideoTypeMp3RadioButton.Text = "mp3 ( audio )";
            downloadVideoTypeMp3RadioButton.UseVisualStyleBackColor = true;
            // 
            // youtubeLinksListbox
            // 
            youtubeLinksListbox.Dock = DockStyle.Fill;
            youtubeLinksListbox.FormattingEnabled = true;
            youtubeLinksListbox.ItemHeight = 15;
            youtubeLinksListbox.Location = new Point(0, 0);
            youtubeLinksListbox.Name = "youtubeLinksListbox";
            youtubeLinksListbox.Size = new Size(545, 157);
            youtubeLinksListbox.TabIndex = 0;
            // 
            // splitContainer10
            // 
            splitContainer10.Dock = DockStyle.Fill;
            splitContainer10.Location = new Point(0, 0);
            splitContainer10.Name = "splitContainer10";
            splitContainer10.Orientation = Orientation.Horizontal;
            // 
            // splitContainer10.Panel1
            // 
            splitContainer10.Panel1.Controls.Add(downloadButton);
            // 
            // splitContainer10.Panel2
            // 
            splitContainer10.Panel2.Controls.Add(progressBar1);
            splitContainer10.Size = new Size(823, 145);
            splitContainer10.SplitterDistance = 80;
            splitContainer10.TabIndex = 0;
            // 
            // downloadButton
            // 
            downloadButton.Dock = DockStyle.Fill;
            downloadButton.Location = new Point(0, 0);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(823, 80);
            downloadButton.TabIndex = 0;
            downloadButton.Text = "Start Downloading";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click += downloadButton_Click;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Fill;
            progressBar1.Location = new Point(0, 0);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(823, 61);
            progressBar1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 486);
            Controls.Add(tabControl);
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
            tabControl.ResumeLayout(false);
            conversionTab.ResumeLayout(false);
            downloadingTab.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer8.Panel1.ResumeLayout(false);
            splitContainer8.Panel2.ResumeLayout(false);
            splitContainer8.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer8).EndInit();
            splitContainer8.ResumeLayout(false);
            splitContainer9.Panel1.ResumeLayout(false);
            splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer9).EndInit();
            splitContainer9.ResumeLayout(false);
            splitContainer11.Panel1.ResumeLayout(false);
            splitContainer11.Panel1.PerformLayout();
            splitContainer11.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer11).EndInit();
            splitContainer11.ResumeLayout(false);
            splitContainer10.Panel1.ResumeLayout(false);
            splitContainer10.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer10).EndInit();
            splitContainer10.ResumeLayout(false);
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
        private TabControl tabControl;
        private TabPage conversionTab;
        private TabPage downloadingTab;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button selectDownloadPathButton;
        private Label Somelabel;
        private Label downloadPathLabel;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer8;
        private Button addYoutubeVideoLinkButton;
        private TextBox youtubeVideoLinkTextbox;
        private SplitContainer splitContainer9;
        private ListBox youtubeLinksListbox;
        private SplitContainer splitContainer10;
        private Button downloadButton;
        private ProgressBar progressBar1;
        private SplitContainer splitContainer11;
        private RadioButton downloadVideoTypeMp3RadioButton;
        private RadioButton downloadVideoTypeMp4RadioButton;
    }
}