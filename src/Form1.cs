using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dedup
{
    public partial class Dedup : Form
    {
        private int totalFileCount = 0;
        private Dictionary<string, string> dict = new Dictionary<string, string>();
        private int dupCount = 0;
        private string path = @"W:\Pictures";
        private string fileExtension = "*.jpg";
        private int processedFileCount = 0;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

        public Dedup()
        {
            InitializeComponent();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;

            fileScanProgress.Step = 1;
            fileScanProgress.Value = 0;
        }

        private void BackgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            fileScanProgress.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            totalFileCount = Directory.GetFiles(path, fileExtension, SearchOption.AllDirectories).Length;

            string[] files = Directory.GetFiles(path, fileExtension, SearchOption.AllDirectories);
            foreach (var file in files)
            {
                processedFileCount++;
                var process = 100 / totalFileCount * processedFileCount;
                using (var md5 = MD5.Create())
                {
                    using (var stream = System.IO.File.OpenRead(file))
                    {
                        var hash = md5.ComputeHash(stream);
                        var str = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();


                        if (!dict.ContainsKey(str))
                            dict.Add(str, file);
                        else
                            dupCount++;


                        Console.WriteLine(str);
                    }
                }
                backgroundWorker1.ReportProgress(process);
            }


            Console.WriteLine($"Files {processedFileCount}");
            Console.WriteLine($"duplicates {dupCount}");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
