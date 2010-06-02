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
        public MainForm()
        {
            InitializeComponent();
            m_PlayListMaker = new PlayListmakerApp(m_viewFilesrichTextBox);
            m_backgroundWorker.DoWork += new DoWorkEventHandler(Bw_DoWork);
            

        }

        private void m_GObutton_Click(object sender, EventArgs e)
        {
            if (!m_backgroundWorker.IsBusy)
            {
                m_backgroundWorker.RunWorkerAsync();
            }
        }

        private void m_FindListbutton_Click(object sender, EventArgs e)
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
        
        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            if (m_newFolderTextBox.Text == null || m_ListFileTextBox.Text == null)
                MessageBox.Show("error", "please insert all the correct date");

            m_PlayListMaker.NewFolderName = m_newFolderTextBox.Text;
            m_PlayListMaker.GO();
        }

        private void Bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
               
        }


        private PlayListmakerApp m_PlayListMaker;
       
        private void m_viewFilesrichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}
