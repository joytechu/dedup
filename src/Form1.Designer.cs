
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
            this.button1 = new System.Windows.Forms.Button();
            this.duplicateFilesListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fileScanProgress = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.DedupPathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(234, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 255);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // fileScanProgress
            // 
            this.fileScanProgress.Location = new System.Drawing.Point(12, 415);
            this.fileScanProgress.Name = "fileScanProgress";
            this.fileScanProgress.Size = new System.Drawing.Size(533, 23);
            this.fileScanProgress.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // Dedup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.DedupPathLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fileScanProgress);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.duplicateFilesListBox);
            this.Controls.Add(this.button1);
            this.Name = "Dedup";
            this.Text = "Dedup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox duplicateFilesListBox;
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.ProgressBar fileScanProgress;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label DedupPathLabel;
    }
}

