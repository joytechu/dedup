
using Dedup.Interfaces;

namespace Dedup
{
    partial class Dedup
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
            this.components = new System.ComponentModel.Container();
            this.findButton = new System.Windows.Forms.Button();
            this.duplicateFilesListBox = new System.Windows.Forms.ListBox();
            this.fileScanProgress = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.DedupPathLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(12, 27);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // duplicateFilesListBox
            // 
            this.duplicateFilesListBox.FormattingEnabled = true;
            this.duplicateFilesListBox.ItemHeight = 15;
            this.duplicateFilesListBox.Location = new System.Drawing.Point(12, 56);
            this.duplicateFilesListBox.Name = "duplicateFilesListBox";
            this.duplicateFilesListBox.Size = new System.Drawing.Size(216, 154);
            this.duplicateFilesListBox.TabIndex = 3;
            // 
            // fileScanProgress
            // 
            this.fileScanProgress.Location = new System.Drawing.Point(12, 415);
            this.fileScanProgress.Name = "fileScanProgress";
            this.fileScanProgress.Size = new System.Drawing.Size(533, 23);
            this.fileScanProgress.TabIndex = 5;
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(12, 2);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(75, 23);
            this.selectFolderButton.TabIndex = 6;
            this.selectFolderButton.Text = "...";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // DedupPathLabel
            // 
            this.DedupPathLabel.AutoSize = true;
            this.DedupPathLabel.Location = new System.Drawing.Point(93, 6);
            this.DedupPathLabel.Name = "DedupPathLabel";
            this.DedupPathLabel.Size = new System.Drawing.Size(35, 15);
            this.DedupPathLabel.TabIndex = 7;
            this.DedupPathLabel.Text = "PATH";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(267, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 309);
            this.panel1.TabIndex = 8;
            // 
            // Dedup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DedupPathLabel);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.fileScanProgress);
            this.Controls.Add(this.duplicateFilesListBox);
            this.Controls.Add(this.findButton);
            this.Name = "Dedup";
            this.Text = "Dedup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ListBox duplicateFilesListBox;

        private System.Windows.Forms.ProgressBar fileScanProgress;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.Label DedupPathLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
    }
}

