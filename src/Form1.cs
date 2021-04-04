using Dedup.Core;
using Dedup.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Dedup
{
    public partial class Dedup : Form, INotifyPropertyChanged
    {
        #region private members
        private int totalFileCount = 0;
        private Dictionary<string, string> dict = new Dictionary<string, string>();
        private int dupCount = 0;
        private string _path = "";
        private string fileExtension = "*.*";
        private int processedFileCount = 0;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public event PropertyChangedEventHandler PropertyChanged;
        private IFileHasher _hasher;
        #endregion

        #region properties
        public string Path
        {
            get
            {
                return _path;
            }

            set
            {
                if (value != _path)
                {
                    _path = value;
                    NotifyPropertyChanged("Path");
                }
            }
        }
        #endregion

        public Dedup()
        {
            InitializeComponent();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;

            fileScanProgress.Step = 1;
            fileScanProgress.Value = 0;
            //_hasher = hasher;

            DedupPathLabel.DataBindings.Add(new Binding("Text", this, "Path"));
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach(var s in dict.Keys)
            {
                duplicateFilesListBox.Items.Add(s);
            }
        }

        #region methods
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void BackgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            fileScanProgress.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                totalFileCount = Directory.GetFiles(Path, fileExtension, SearchOption.AllDirectories).Length;

                string[] files = Directory.GetFiles(Path, fileExtension, SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    processedFileCount++;
                    var process = 100 / totalFileCount * processedFileCount;

                    var hashstr = _hasher.GetHash(file);
                    if (!dict.ContainsKey(hashstr))
                        dict.Add(hashstr, file);
                    else
                        dupCount++;
                    backgroundWorker1.ReportProgress(process);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                Path = dlg.SelectedPath;
            }
        }
        #endregion

    }
}
