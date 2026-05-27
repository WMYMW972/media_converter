using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace 转换格式
{
    public partial class Form1 : Form
    {
        private string GetFfmpegPath()
        {
            return Path.Combine(Application.StartupPath, "Tool", "ffmpeg.exe");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.AllowDrop = true;
            listBox2.AllowDrop = true;
            listBox3.AllowDrop = true;

            listBox1.DragEnter += ListBox_DragEnter;
            listBox1.DragDrop += listBox1_DragDrop;
            listBox2.DragEnter += ListBox_DragEnter;
            listBox2.DragDrop += listBox2_DragDrop;
            listBox3.DragEnter += ListBox_DragEnter;
            listBox3.DragDrop += listBox3_DragDrop;
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void image_Click(object sender, EventArgs e)
        {
            index.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void redio_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            index.Visible = false;
        }

        private void video_Click(object sender, EventArgs e)
        {
            index.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private List<string> filePaths = new List<string>();
        private List<string> audioFilePaths = new List<string>();
        private List<string> videoFilePaths = new List<string>();

        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                string ext = Path.GetExtension(file).ToLower();
                if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" ||
                    ext == ".gif" || ext == ".tiff" || ext == ".tif" || ext == ".webp" || ext == ".heic")
                {
                    listBox2.Items.Add(Path.GetFileName(file));
                    filePaths.Add(file);
                }
            }
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                string ext = Path.GetExtension(file).ToLower();
                if (ext == ".mp3" || ext == ".wav" || ext == ".flac" || ext == ".aac" ||
                    ext == ".m4a" || ext == ".ogg" || ext == ".wma" || ext == ".opus" || ext == ".ncm")
                {
                    listBox1.Items.Add(Path.GetFileName(file));
                    audioFilePaths.Add(file);
                }
            }
        }

        private void listBox3_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                string ext = Path.GetExtension(file).ToLower();
                if (ext == ".mp4" || ext == ".avi" || ext == ".mkv" || ext == ".mov" ||
                    ext == ".webm" || ext == ".flv" || ext == ".wmv" || ext == ".m4v" ||
                    ext == ".ts" || ext == ".mts" || ext == ".m2ts" || ext == ".3gp")
                {
                    listBox3.Items.Add(Path.GetFileName(file));
                    videoFilePaths.Add(file);
                }
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Title = "请选择文件";
            dialog.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff;*.tif;*.webp;*.heic";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                listBox2.Items.Clear();
                filePaths.Clear();

                foreach (string filePath in dialog.FileNames)
                {
                    string fileName = Path.GetFileName(filePath);
                    listBox2.Items.Add(fileName);
                    filePaths.Add(filePath);
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (filePaths.Count == 0)
            {
                MessageBox.Show("请先选择文件");
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("请先选择目标格式");
                return;
            }
            string targetFormat = comboBox1.SelectedItem.ToString().ToUpper();

            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
                return;

            string saveFolder = folderBrowserDialog1.SelectedPath;
            int successCount = 0;

            for (int i = 0; i < filePaths.Count; i++)
            {
                try
                {
                    using (var image = SixLabors.ImageSharp.Image.Load(filePaths[i]))
                    {
                        string nameWithoutExt = Path.GetFileNameWithoutExtension(filePaths[i]);
                        string savePath = Path.Combine(saveFolder, nameWithoutExt + "." + targetFormat.ToLower());

                        switch (targetFormat)
                        {
                            case "JPG":
                            case "JPEG":
                                using (var newImage = new Image<Rgba32>(image.Width, image.Height, SixLabors.ImageSharp.Color.White))
                                {
                                    newImage.Mutate(ctx => ctx.DrawImage(image, new SixLabors.ImageSharp.Point(0, 0), 1f));
                                    newImage.SaveAsJpeg(savePath);
                                }
                                break;

                            case "PNG":
                                image.SaveAsPng(savePath);
                                break;

                            case "BMP":
                                image.SaveAsBmp(savePath);
                                break;

                            case "GIF":
                                image.SaveAsGif(savePath);
                                break;

                            case "TIFF":
                                image.SaveAsTiff(savePath);
                                break;

                            case "WEBP":
                                image.SaveAsWebp(savePath);
                                break;

                            default:
                                MessageBox.Show($"不支持的格式：{targetFormat}");
                                return;
                        }

                        successCount++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"处理 {Path.GetFileName(filePaths[i])} 失败：{ex.Message}");
                }
            }

            MessageBox.Show($"转换完成！成功 {successCount} 个文件。");
            System.Diagnostics.Process.Start(saveFolder);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            index.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index.Visible = true;
            panel1.Visible = false;
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void ra_1_Click(object sender, EventArgs e)
        {
            if (audioFilePaths.Count == 0)
            {
                MessageBox.Show("请先选择音频文件");
                return;
            }

            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("请先选择目标格式");
                return;
            }
            string targetFormat = comboBox2.SelectedItem.ToString().ToLower();

            string ffmpeg = GetFfmpegPath();
            if (!File.Exists(ffmpeg))
            {
                MessageBox.Show("找不到 ffmpeg.exe，请放到 Tool 文件夹里");
                return;
            }

            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
                return;

            string saveFolder = folderBrowserDialog1.SelectedPath;
            int successCount = 0;

            for (int i = 0; i < audioFilePaths.Count; i++)
            {
                try
                {
                    string currentPath = audioFilePaths[i];
                    string originalPath = audioFilePaths[i];

                    if (Path.GetExtension(currentPath).ToLower() == ".ncm")
                    {
                        string ncmdumpPath = Path.Combine(Application.StartupPath, "Tool", "ncmdump.exe");

                        if (!File.Exists(ncmdumpPath))
                        {
                            MessageBox.Show("找不到 ncmdump.exe，请放到 Tool 文件夹里");
                            return;
                        }

                        System.Diagnostics.ProcessStartInfo ncmPsi = new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = ncmdumpPath,
                            Arguments = $"\"{currentPath}\"",
                            CreateNoWindow = true,
                            UseShellExecute = false
                        };

                        using (System.Diagnostics.Process p = System.Diagnostics.Process.Start(ncmPsi))
                        {
                            p.WaitForExit();
                            if (p.ExitCode != 0)
                            {
                                MessageBox.Show($"解密失败：{Path.GetFileName(currentPath)}，错误代码：{p.ExitCode}");
                                continue;
                            }
                        }

                        string dir = Path.GetDirectoryName(currentPath);
                        string baseName = Path.GetFileNameWithoutExtension(currentPath);
                        string[] matches = Directory.GetFiles(dir, baseName + ".*")
                                                      .Where(f => !f.EndsWith(".ncm"))
                                                      .ToArray();

                        if (matches.Length > 0)
                            currentPath = matches[0];
                        else
                        {
                            MessageBox.Show($"解密后找不到文件：{Path.GetFileName(currentPath)}");
                            continue;
                        }
                    }

                    string nameWithoutExt = Path.GetFileNameWithoutExtension(originalPath);
                    string savePath = Path.Combine(saveFolder, nameWithoutExt + "." + targetFormat);

                    System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = ffmpeg,
                        Arguments = $"-i \"{currentPath}\" -y \"{savePath}\"",
                        CreateNoWindow = true,
                        UseShellExecute = false
                    };

                    using (System.Diagnostics.Process p = System.Diagnostics.Process.Start(psi))
                    {
                        p.WaitForExit();
                    }

                    if (currentPath != originalPath)
                    {
                        try { File.Delete(currentPath); } catch { }
                    }

                    successCount++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"处理 {Path.GetFileName(audioFilePaths[i])} 失败：{ex.Message}");
                }
            }

            MessageBox.Show($"转换完成！成功 {successCount} 个文件。");
            System.Diagnostics.Process.Start(saveFolder);
        }

        private void ra_2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            index.Visible = true;
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e) { }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Title = "请选择音频文件";
            dialog.Filter = "音频文件|*.mp3;*.wav;*.flac;*.aac;*.m4a;*.ogg;*.wma;*.opus;*.ncm";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                audioFilePaths.Clear();

                foreach (string filePath in dialog.FileNames)
                {
                    string fileName = Path.GetFileName(filePath);
                    listBox1.Items.Add(fileName);
                    audioFilePaths.Add(filePath);
                }
            }
        }


        private void vid_bu_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            index.Visible = true;
        }

        private void vid_bu1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Title = "请选择视频文件";
            dialog.Filter = "视频文件|*.mp4;*.avi;*.mkv;*.mov;*.webm;*.flv;*.wmv;*.m4v;*.ts;*.mts;*.m2ts;*.3gp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                listBox3.Items.Clear();
                videoFilePaths.Clear();

                foreach (string filePath in dialog.FileNames)
                {
                    string fileName = Path.GetFileName(filePath);
                    listBox3.Items.Add(fileName);
                    videoFilePaths.Add(filePath);
                }
            }
        }

        private void vid_bu2_Click(object sender, EventArgs e)
        {
            if (videoFilePaths.Count == 0)
            {
                MessageBox.Show("请先选择视频文件");
                return;
            }

            if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("请先选择目标格式");
                return;
            }
            string targetFormat = comboBox3.SelectedItem.ToString().ToLower();

            string ffmpeg = GetFfmpegPath();
            if (!File.Exists(ffmpeg))
            {
                MessageBox.Show("找不到 ffmpeg.exe，请放到 Tool 文件夹里");
                return;
            }

            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
                return;

            string saveFolder = folderBrowserDialog1.SelectedPath;
            int successCount = 0;

            for (int i = 0; i < videoFilePaths.Count; i++)
            {
                try
                {
                    string nameWithoutExt = Path.GetFileNameWithoutExtension(videoFilePaths[i]);
                    string savePath = Path.Combine(saveFolder, nameWithoutExt + "." + targetFormat);

                    System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = ffmpeg,
                        Arguments = $"-i \"{videoFilePaths[i]}\" -y \"{savePath}\"",
                        CreateNoWindow = true,
                        UseShellExecute = false
                    };

                    using (System.Diagnostics.Process p = System.Diagnostics.Process.Start(psi))
                    {
                        p.WaitForExit();
                    }

                    successCount++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"处理 {Path.GetFileName(videoFilePaths[i])} 失败：{ex.Message}");
                }
            }

            MessageBox.Show($"转换完成！成功 {successCount} 个文件。");
            System.Diagnostics.Process.Start(saveFolder);
        }

        private void panel3_Paint(object sender, PaintEventArgs e) { }

        private void del_vid_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex < 0)
            {
                MessageBox.Show("请先选中要移除的文件");
                return;
            }

            int index = listBox3.SelectedIndex;
            listBox3.Items.RemoveAt(index);
            videoFilePaths.RemoveAt(index);
        }

        private void del_ima_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex < 0)
            {
                MessageBox.Show("请先选中要移除的文件");
                return;
            }

            int index = listBox2.SelectedIndex;
            listBox2.Items.RemoveAt(index);
            filePaths.RemoveAt(index);
        }

        private void del_ra_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("请先选中要移除的文件");
                return;
            }

            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
            audioFilePaths.RemoveAt(index);
        }
    }
}