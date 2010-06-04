namespace ListMusicMaker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.m_GObutton = new System.Windows.Forms.Button();
            this.m_ListFileTextBox = new System.Windows.Forms.TextBox();
            this.m_ListFilelabel = new System.Windows.Forms.Label();
            this.m_FindListbutton = new System.Windows.Forms.Button();
            this.m_NewFolderlabel = new System.Windows.Forms.Label();
            this.m_newFolderTextBox = new System.Windows.Forms.TextBox();
            this.m_viewFilesrichTextBox = new System.Windows.Forms.RichTextBox();
            this.m_progressBar = new System.Windows.Forms.ProgressBar();
            this.m_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // m_GObutton
            // 
            this.m_GObutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_GObutton.Location = new System.Drawing.Point(305, 263);
            this.m_GObutton.Name = "m_GObutton";
            this.m_GObutton.Size = new System.Drawing.Size(75, 23);
            this.m_GObutton.TabIndex = 0;
            this.m_GObutton.Text = "GO!!!";
            this.m_GObutton.UseVisualStyleBackColor = true;
            this.m_GObutton.Click += new System.EventHandler(this.m_GObutton_Click);
            // 
            // m_ListFileTextBox
            // 
            this.m_ListFileTextBox.Location = new System.Drawing.Point(113, 28);
            this.m_ListFileTextBox.MaximumSize = new System.Drawing.Size(221, 20);
            this.m_ListFileTextBox.Name = "m_ListFileTextBox";
            this.m_ListFileTextBox.Size = new System.Drawing.Size(221, 20);
            this.m_ListFileTextBox.TabIndex = 1;
            this.m_ListFileTextBox.WordWrap = false;
            // 
            // m_ListFilelabel
            // 
            this.m_ListFilelabel.AutoSize = true;
            this.m_ListFilelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ListFilelabel.Location = new System.Drawing.Point(6, 29);
            this.m_ListFilelabel.Name = "m_ListFilelabel";
            this.m_ListFilelabel.Size = new System.Drawing.Size(101, 16);
            this.m_ListFilelabel.TabIndex = 2;
            this.m_ListFilelabel.Text = "List File Path:";
            // 
            // m_FindListbutton
            // 
            this.m_FindListbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_FindListbutton.Location = new System.Drawing.Point(340, 25);
            this.m_FindListbutton.Name = "m_FindListbutton";
            this.m_FindListbutton.Size = new System.Drawing.Size(40, 23);
            this.m_FindListbutton.TabIndex = 3;
            this.m_FindListbutton.Text = "Pick";
            this.m_FindListbutton.UseVisualStyleBackColor = true;
            this.m_FindListbutton.Click += new System.EventHandler(this.m_FindListbutton_Click);
            // 
            // m_NewFolderlabel
            // 
            this.m_NewFolderlabel.AutoSize = true;
            this.m_NewFolderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_NewFolderlabel.Location = new System.Drawing.Point(6, 60);
            this.m_NewFolderlabel.Name = "m_NewFolderlabel";
            this.m_NewFolderlabel.Size = new System.Drawing.Size(136, 16);
            this.m_NewFolderlabel.TabIndex = 4;
            this.m_NewFolderlabel.Text = "New Folder Name:";
            // 
            // m_newFolderTextBox
            // 
            this.m_newFolderTextBox.Location = new System.Drawing.Point(142, 60);
            this.m_newFolderTextBox.Name = "m_newFolderTextBox";
            this.m_newFolderTextBox.Size = new System.Drawing.Size(192, 20);
            this.m_newFolderTextBox.TabIndex = 5;
            // 
            // m_viewFilesrichTextBox
            // 
            this.m_viewFilesrichTextBox.Location = new System.Drawing.Point(9, 96);
            this.m_viewFilesrichTextBox.Name = "m_viewFilesrichTextBox";
            this.m_viewFilesrichTextBox.Size = new System.Drawing.Size(371, 144);
            this.m_viewFilesrichTextBox.TabIndex = 7;
            this.m_viewFilesrichTextBox.Text = "";
            this.m_viewFilesrichTextBox.TextChanged += new System.EventHandler(this.m_viewFilesrichTextBox_TextChanged);
            // 
            // m_progressBar
            // 
            this.m_progressBar.Location = new System.Drawing.Point(9, 246);
            this.m_progressBar.Name = "m_progressBar";
            this.m_progressBar.Size = new System.Drawing.Size(367, 11);
            this.m_progressBar.TabIndex = 8;
            // 
            // m_backgroundWorker
            // 
            this.m_backgroundWorker.WorkerReportsProgress = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 298);
            this.Controls.Add(this.m_progressBar);
            this.Controls.Add(this.m_viewFilesrichTextBox);
            this.Controls.Add(this.m_newFolderTextBox);
            this.Controls.Add(this.m_NewFolderlabel);
            this.Controls.Add(this.m_FindListbutton);
            this.Controls.Add(this.m_ListFilelabel);
            this.Controls.Add(this.m_ListFileTextBox);
            this.Controls.Add(this.m_GObutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Power Oz software- PLayList Maker ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_GObutton;
        private System.Windows.Forms.TextBox m_ListFileTextBox;
        private System.Windows.Forms.Label m_ListFilelabel;
        private System.Windows.Forms.Button m_FindListbutton;
        private System.Windows.Forms.Label m_NewFolderlabel;
        private System.Windows.Forms.TextBox m_newFolderTextBox;
        private System.Windows.Forms.RichTextBox m_viewFilesrichTextBox;
        private System.Windows.Forms.ProgressBar m_progressBar;
        private System.ComponentModel.BackgroundWorker m_backgroundWorker;
    }
}

