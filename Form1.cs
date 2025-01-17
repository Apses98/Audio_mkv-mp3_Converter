using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


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

        private void prog_init(object sender, EventArgs e)
        {
            
            _ = check_ffmpeg();
        }

        static async Task check_ffmpeg()
        {
            if (!File.Exists("ffmpeg\\ffmpeg-master-latest-win64-lgpl-shared\\bin\\ffmpeg.exe"))
            {
                
                
                string ffmpegDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg");

                if (!File.Exists(Path.Combine(ffmpegDirectory, "ffmpeg.exe")))
                {
                    Directory.CreateDirectory(ffmpegDirectory);

                    string ffmpegZipPath = Path.Combine(ffmpegDirectory, "ffmpeg.zip");
                    //string ffmpegZipUrl = "https://github.com/BtbN/FFmpeg-Builds/releases/download/latest/ffmpeg-master-latest-win64-gpl.zip";
                    string ffmpegZipUrl = "https://github.com/BtbN/FFmpeg-Builds/releases/download/latest/ffmpeg-master-latest-win64-lgpl-shared.zip";
                    //MessageBox.Show("Please wait...\nDownloading ffmpeg (It is needed to convert you files!)\nThe program will open soon, You don't need to reopen it.");

                    /**
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(ffmpegZipUrl, ffmpegZipPath);
                    }

                    
                    **/
                    try
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            
                            using (HttpResponseMessage response = await client.GetAsync(ffmpegZipUrl, HttpCompletionOption.ResponseHeadersRead))
                            {
                                HttpResponseMessage httpResponseMessage = response.EnsureSuccessStatusCode(); 

                                using (Stream contentStream = await response.Content.ReadAsStreamAsync(),
                                               fileStream = new FileStream(ffmpegZipPath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
                                {
                                    await contentStream.CopyToAsync(fileStream);
                                }
                            }
                        }

                        ZipFile.ExtractToDirectory(ffmpegZipPath, ffmpegDirectory);
                        File.Delete(ffmpegZipPath);

                    }
                    catch (Exception)
                    {
                        
                    }
                    
                }
            }
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
                    infoListBox.Items.Add("File: " + getFiles[i].Split("\\").Last() + " Added to queue.");
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
            //progressBar.Value = progress;
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
            string ffmpegPath = @"ffmpeg\ffmpeg-master-latest-win64-gpl\ffmpeg-master-latest-win64-gpl\bin\ffmpeg.exe";

            

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