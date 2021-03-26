using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Dedup
{
    public partial class Dedup : Form
    {
        public Dedup()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Dedup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileCount = 0;
            var dict = new Dictionary<string, string>();
            var dupCount = 0;

            var path = @"W:\Pictures";
            string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                fileCount++;
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

            }


            Console.WriteLine($"Files {fileCount}");
            Console.WriteLine($"duplicates {dupCount}");
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
