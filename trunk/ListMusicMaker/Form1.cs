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
            DialogResult result =  dlg.ShowDialog();

            switch (result)
            {
                case DialogResult.None:
                break;
                case DialogResult.OK:
                    m_ListFilelabel.Text = dlg.FileName;
                break;
                    
            }



            
        }
    }
}
