using System.Diagnostics;
using System.IO;

namespace SoundFilesConverter
{
    public partial class Form1 : Form
    {
        List<string> files = new List<string>();
        FolderBrowserDialog dialog = new FolderBrowserDialog();
        bool Abort = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            selectFolder();
        }





        private void selectFolder()
        {



            if (!isCheckboxSelected())
                return;
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                Abort = true;
                return;
            }
            else
            {
                Abort = false;
            }
            infoListBox.Items.Clear();
            string[] getFiles = Directory.GetFiles(dialog.SelectedPath);
            for (int i = 0; i < getFiles.Length; i++)
            {
                if (getFiles[i].EndsWith(getStartCheckbox()) || getFiles[i].EndsWith(getStartCheckbox().ToUpper()))
                {
                    files.Add(getFiles[i]);
                    infoListBox.Items.Add("File: " + getFiles[i].Split("\\").Last() + " Added to que.");
                }
            }
            if (files.Count == 0)
            {
                infoListBox.Items.Clear();
                infoListBox.Items.Add($"No {getStartCheckbox()} files in this file, try another one!");
                return;
            }


        }


        string getEndCheckbox()
        {
            if (toMKV.Checked)
            {
                return "." + toMKV.Text.ToLower();
            }
            else if (toMP3.Checked)
            {
                return "." + toMP3.Text.ToLower();
            }
            else
            {
                return "";
            }
        }

        string getStartCheckbox()
        {
            if (fromMKV.Checked)
            {
                return "." + fromMKV.Text.ToLower();
            }
            else if(fromMP3.Checked)
            {
                return "." + fromMP3.Text.ToLower();
            }
            else
            {
                return "";
            }
        }

        bool isCheckboxSelected()
        {
            if ((fromMKV.Checked || fromMP3.Checked) && (toMKV.Checked || toMP3.Checked))
            {
                return true;
            }else
            {
                MessageBox.Show("Please select a file type!");
                return false;
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            convertFiles();
        }

        void updateProgressBar(int current_item)
        {
            int progress = (current_item * 100) / files.Count ;
            progressBar.Value = progress;
        }

        void convertFiles()
        {
            if (Abort)
            {
                MessageBox.Show("Plesae select a Folder!");
                return;
            }
            if (files.Count == 0)
            {
                infoListBox.Items.Clear();
                infoListBox.Items.Add($"No {getStartCheckbox()} files were added to the que!");
                return;
            }

            if (!isCheckboxSelected())
                return;
            if (getStartCheckbox() == getEndCheckbox())
            {
                MessageBox.Show("Can not convert to the same file type!!");
                return;
            }

            string outputFile;

            // Path to the FFmpeg executable
            string ffmpegPath = @"..\..\..\ffmpeg-master-latest-win64-gpl\ffmpeg-master-latest-win64-gpl\bin\ffmpeg.exe";

            

            // Set up FFmpeg process
            Process process = new Process();
            process.StartInfo.FileName = ffmpegPath;
            
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;

            
            infoListBox.Items.Clear();
            for (int i = 0; i < files.Count; i++)
            {
                outputFile = "";
                for (int j = 0; j < files[0].Split("\\").Length - 1; j++)
                {
                    outputFile += files[0].Split("\\")[j] + "\\";
                }
                Directory.CreateDirectory(outputFile + "OUT");
                outputFile += "OUT\\" + files[i].Split("\\").Last();
                if (getStartCheckbox() == ".mkv" && getEndCheckbox() == ".mp3")
                {
                    outputFile += ".mp3";
                    process.StartInfo.Arguments = $"-i \"{files.ElementAt(i)}\" -vn -ar 44100 -ac 2 -ab 192k -f mp3 \"{outputFile}\"";
                } else if (getStartCheckbox() == ".mp3" && getEndCheckbox() == ".mkv")
                {
                    outputFile += ".mkv";
                    process.StartInfo.Arguments = $"-i \"{files.ElementAt(i)}\" -vn -ar 44100 -ac 2 \"{outputFile}\"";
                }

                // Start FFmpeg process
                process.Start();
                process.WaitForExit();
                updateProgressBar(i);
                infoListBox.Items.Add($"Done: {outputFile.Split("\\").Last()}");
            }
            updateProgressBar(0);
            infoListBox.Items.Add($"Done!!!");
        }
    }
}