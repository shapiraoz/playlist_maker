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
        }

        private void m_GObutton_Click(object sender, EventArgs e)
        {

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
                    m_path = dlg.FileName;
                    m_ListFilelabel.Text = dlg.FileName;
                }
               break;
                    
            }

           

            
        }
  //      private PlayListmakerApp m_PlayListMaker;
        private string m_path;
        private string m_newFolderName;
    }
}
