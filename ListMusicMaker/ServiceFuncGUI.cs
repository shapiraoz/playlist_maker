using System;
using System.Collections.Generic;
using System.Text;
using CoreListMaker;
using System.Windows.Forms;

namespace ListMusicMaker
{
    class ServiceFuncGUI: IServiceMake
    {
        public ServiceFuncGUI(RichTextBox richTextBox)
        {
            m_richTextBox = richTextBox;
        }

      

        RichTextBox m_richTextBox;

        #region IServiceMake Members

        public void PrintResult(string message)
        {
            m_richTextBox.AppendText(message);
        }

        #endregion
    }
}
