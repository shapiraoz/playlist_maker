using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Microsoft.Win32;

using System.Text;
using System.Windows.Forms;

namespace ListMusicMaker
{
    public partial class MainForm : Form
    {
        string MSG_AGAIN = "Do you what to copy all files again ?";

        private PlayListmakerApp m_PlayListMaker;


        public MainForm()
        {
            InitializeComponent();
            m_PlayListMaker = new PlayListmakerApp(ref m_backgroundWorker);
            m_welcomeLable.Text = m_PlayListMaker.CORE_VERSION + m_PlayListMaker.GetVersion();
            m_backgroundWorker.DoWork += new DoWorkEventHandler(Bw_DoWork);
            m_backgroundWorker.WorkerReportsProgress = true;
            m_backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(Bw_ProgressChanged);
        }

        private void m_GObutton_Click(object sender, EventArgs e)
        {
            if ((m_GObutton.Text == "Recopy") &&
                        (MessageBox.Show(MSG_AGAIN, m_PlayListMaker.APP_NAME, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes))
                runProgram();
            else 
            {
                runProgram();
                m_GObutton.Text = "Recopy";
            }

        }
        
        private void runProgram()
        {
            if (!m_backgroundWorker.IsBusy)
            {
                m_backgroundWorker.RunWorkerAsync();
               
            }
           
        }

        private void  FindPlayListFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = "*.m3u ,*.wpl";
            dlg.Filter = "m3u list file(*.m3u) |*.m3u| wpl list file (*.wpl)|*.wpl";
            dlg.Title = "Choose Wpl or m3u file ";
            DialogResult result =  dlg.ShowDialog();

            switch (result)
            {
                case DialogResult.None:
                break;
                case DialogResult.OK:
                if (dlg.CheckFileExists)
                {
                    m_PlayListMaker.FilePath = dlg.FileName;
                    m_ListFileTextBox.Text = dlg.FileName;
                }
               break;
            }
        }

        private void FindFolder()
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            DialogResult result = folderDialog.ShowDialog();
            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    m_newFolderTextBox.Text = folderDialog.SelectedPath;
                    break;
            }
        }


        private void m_FindListbutton_Click(object sender, EventArgs e)
        {
            FindPlayListFile();                         
        }
        
        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
           
            if (m_newFolderTextBox.Text == null || m_ListFileTextBox.Text == null)
                MessageBox.Show("please insert all the correct file and folder path ", m_PlayListMaker.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);

            m_PlayListMaker.NewFolderName = m_newFolderTextBox.Text;
            m_PlayListMaker.CreateCore(m_ListFileTextBox.Text,m_newFolderTextBox.Text);
            m_PlayListMaker.GO();
                     
        }

        private void Bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState == "Clear") m_viewFilesrichTextBox.Clear();
            else m_viewFilesrichTextBox.AppendText(e.UserState.ToString());
            m_progressBar.Value = e.ProgressPercentage;
        }


      
       
        private void m_viewFilesrichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void m_FindFolderButton_Click(object sender, EventArgs e)
        {
            FindFolder();

        }

        private void pickPlaylistFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindPlayListFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pickFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindFolder();
        }

        private void m_ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runProgram();
        }
       
    }
}
