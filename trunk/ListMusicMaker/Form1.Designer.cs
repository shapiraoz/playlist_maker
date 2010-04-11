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
            this.m_GObutton = new System.Windows.Forms.Button();
            this.m_ListFileTextBox = new System.Windows.Forms.TextBox();
            this.m_ListFilelabel = new System.Windows.Forms.Label();
            this.m_FindListbutton = new System.Windows.Forms.Button();
            this.m_NewFolderlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Path_button = new System.Windows.Forms.Button();
            this.m_viewFilesrichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // m_GObutton
            // 
            this.m_GObutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_GObutton.Location = new System.Drawing.Point(305, 243);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Path_button
            // 
            this.Path_button.Location = new System.Drawing.Point(341, 56);
            this.Path_button.Name = "Path_button";
            this.Path_button.Size = new System.Drawing.Size(39, 23);
            this.Path_button.TabIndex = 6;
            this.Path_button.Text = "Path";
            this.Path_button.UseVisualStyleBackColor = true;
            // 
            // m_viewFilesrichTextBox
            // 
            this.m_viewFilesrichTextBox.Location = new System.Drawing.Point(9, 96);
            this.m_viewFilesrichTextBox.Name = "m_viewFilesrichTextBox";
            this.m_viewFilesrichTextBox.Size = new System.Drawing.Size(371, 141);
            this.m_viewFilesrichTextBox.TabIndex = 7;
            this.m_viewFilesrichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 278);
            this.Controls.Add(this.m_viewFilesrichTextBox);
            this.Controls.Add(this.Path_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.m_NewFolderlabel);
            this.Controls.Add(this.m_FindListbutton);
            this.Controls.Add(this.m_ListFilelabel);
            this.Controls.Add(this.m_ListFileTextBox);
            this.Controls.Add(this.m_GObutton);
            this.Name = "MainForm";
            this.Text = "Power Oz software- PLayList Maker ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_GObutton;
        private System.Windows.Forms.TextBox m_ListFileTextBox;
        private System.Windows.Forms.Label m_ListFilelabel;
        private System.Windows.Forms.Button m_FindListbutton;
        private System.Windows.Forms.Label m_NewFolderlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Path_button;
        private System.Windows.Forms.RichTextBox m_viewFilesrichTextBox;
    }
}

