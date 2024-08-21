using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImageCutter
{

    public partial class Form1 : Form
    {
        private string filePath = "";
        private int interval = 3;
        public Form1()
        {
            InitializeComponent();
            intervalInput.Value = interval;
            fileLabel.Text = "";
            linkLabel1.LinkArea = new LinkArea(0, 6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Video Files|*.avi;*.mp4;*.mkv;*.mov;*.wmv;*.flv;*.webm";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filePath = openFileDialog1.FileName + "." + openFileDialog1.DefaultExt;
                    error.Text = "";
                    fileLabel.Text = filePath;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
            linkToFiles.Enabled = false;
        }

        private void intervalInput_ValueChanged(object sender, EventArgs e)
        {
            interval = (int)intervalInput.Value;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (filePath == "")
            {
                error.Text = "Please select a video";
                error.ForeColor = Color.Red;
                return;
            }
            error.ForeColor = Color.Black;
            var progress = new Progress<int>(percent =>
            {
                error.Text = percent.ToString() + "%";
            });

            await Task.Run(() => ExtractImage.extractImage(filePath, interval, progress));


            error.Text = "Done!";
            linkToFiles.Enabled = true;
        }

        private void linkToFiles_Click(object sender, EventArgs e)
        {
            string directoryPath = Path.GetDirectoryName(filePath) ?? "";
            string newDirectoryPath = Path.Combine(directoryPath, "images");
            if (Directory.Exists(newDirectoryPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = newDirectoryPath,
                    FileName = "explorer.exe"
                };

                Process.Start(startInfo);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the URL in the default web browser
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/SkyeRenda",
                UseShellExecute = true
            });
            linkLabel1.LinkVisited = true;
        }
    }
}
