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
            this.m_welcomeLable = new System.Windows.Forms.Label();
            this.m_FindFolderButton = new System.Windows.Forms.Button();
            this.m_menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickPlaylistFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_GObutton
            // 
            this.m_GObutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_GObutton.Location = new System.Drawing.Point(305, 285);
            this.m_GObutton.Name = "m_GObutton";
            this.m_GObutton.Size = new System.Drawing.Size(75, 23);
            this.m_GObutton.TabIndex = 0;
            this.m_GObutton.Text = "GO!!!";
            this.m_GObutton.UseVisualStyleBackColor = true;
            this.m_GObutton.Click += new System.EventHandler(this.m_GObutton_Click);
            // 
            // m_ListFileTextBox
            // 
            this.m_ListFileTextBox.Location = new System.Drawing.Point(113, 48);
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
            this.m_ListFilelabel.Location = new System.Drawing.Point(6, 49);
            this.m_ListFilelabel.Name = "m_ListFilelabel";
            this.m_ListFilelabel.Size = new System.Drawing.Size(101, 16);
            this.m_ListFilelabel.TabIndex = 2;
            this.m_ListFilelabel.Text = "List File Path:";
            // 
            // m_FindListbutton
            // 
            this.m_FindListbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_FindListbutton.Location = new System.Drawing.Point(340, 45);
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
            this.m_NewFolderlabel.Location = new System.Drawing.Point(6, 80);
            this.m_NewFolderlabel.Name = "m_NewFolderlabel";
            this.m_NewFolderlabel.Size = new System.Drawing.Size(136, 16);
            this.m_NewFolderlabel.TabIndex = 4;
            this.m_NewFolderlabel.Text = "New Folder Name:";
            // 
            // m_newFolderTextBox
            // 
            this.m_newFolderTextBox.Location = new System.Drawing.Point(142, 80);
            this.m_newFolderTextBox.Name = "m_newFolderTextBox";
            this.m_newFolderTextBox.Size = new System.Drawing.Size(192, 20);
            this.m_newFolderTextBox.TabIndex = 5;
            // 
            // m_viewFilesrichTextBox
            // 
            this.m_viewFilesrichTextBox.Location = new System.Drawing.Point(9, 106);
            this.m_viewFilesrichTextBox.Name = "m_viewFilesrichTextBox";
            this.m_viewFilesrichTextBox.Size = new System.Drawing.Size(371, 156);
            this.m_viewFilesrichTextBox.TabIndex = 7;
            this.m_viewFilesrichTextBox.Text = "";
            this.m_viewFilesrichTextBox.TextChanged += new System.EventHandler(this.m_viewFilesrichTextBox_TextChanged);
            // 
            // m_progressBar
            // 
            this.m_progressBar.Location = new System.Drawing.Point(9, 268);
            this.m_progressBar.Name = "m_progressBar";
            this.m_progressBar.Size = new System.Drawing.Size(371, 11);
            this.m_progressBar.TabIndex = 8;
            // 
            // m_backgroundWorker
            // 
            this.m_backgroundWorker.WorkerReportsProgress = true;
            // 
            // m_welcomeLable
            // 
            this.m_welcomeLable.AutoSize = true;
            this.m_welcomeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_welcomeLable.ForeColor = System.Drawing.SystemColors.Desktop;
            this.m_welcomeLable.Location = new System.Drawing.Point(6, 24);
            this.m_welcomeLable.Name = "m_welcomeLable";
            this.m_welcomeLable.Size = new System.Drawing.Size(45, 16);
            this.m_welcomeLable.TabIndex = 9;
            this.m_welcomeLable.Text = "label1";
            // 
            // m_FindFolderButton
            // 
            this.m_FindFolderButton.Location = new System.Drawing.Point(341, 80);
            this.m_FindFolderButton.Name = "m_FindFolderButton";
            this.m_FindFolderButton.Size = new System.Drawing.Size(39, 23);
            this.m_FindFolderButton.TabIndex = 10;
            this.m_FindFolderButton.Text = "pick";
            this.m_FindFolderButton.UseVisualStyleBackColor = true;
            this.m_FindFolderButton.Click += new System.EventHandler(this.m_FindFolderButton_Click);
            // 
            // m_menuStrip
            // 
            this.m_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.m_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.m_menuStrip.Name = "m_menuStrip";
            this.m_menuStrip.Size = new System.Drawing.Size(386, 24);
            this.m_menuStrip.TabIndex = 11;
            this.m_menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickPlaylistFileToolStripMenuItem,
            this.pickFolderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // pickPlaylistFileToolStripMenuItem
            // 
            this.pickPlaylistFileToolStripMenuItem.Name = "pickPlaylistFileToolStripMenuItem";
            this.pickPlaylistFileToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.pickPlaylistFileToolStripMenuItem.Text = "Pick Playlist File";
            this.pickPlaylistFileToolStripMenuItem.Click += new System.EventHandler(this.pickPlaylistFileToolStripMenuItem_Click);
            // 
            // pickFolderToolStripMenuItem
            // 
            this.pickFolderToolStripMenuItem.Name = "pickFolderToolStripMenuItem";
            this.pickFolderToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.pickFolderToolStripMenuItem.Text = "Pick Folder";
            this.pickFolderToolStripMenuItem.Click += new System.EventHandler(this.pickFolderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(386, 316);
            this.Controls.Add(this.m_FindFolderButton);
            this.Controls.Add(this.m_welcomeLable);
            this.Controls.Add(this.m_progressBar);
            this.Controls.Add(this.m_viewFilesrichTextBox);
            this.Controls.Add(this.m_newFolderTextBox);
            this.Controls.Add(this.m_NewFolderlabel);
            this.Controls.Add(this.m_FindListbutton);
            this.Controls.Add(this.m_ListFilelabel);
            this.Controls.Add(this.m_ListFileTextBox);
            this.Controls.Add(this.m_GObutton);
            this.Controls.Add(this.m_menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.m_menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Power Oz software- PLayList Maker ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.m_menuStrip.ResumeLayout(false);
            this.m_menuStrip.PerformLayout();
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
        private System.Windows.Forms.Label m_welcomeLable;
        private System.Windows.Forms.Button m_FindFolderButton;
        private System.Windows.Forms.MenuStrip m_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickPlaylistFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

