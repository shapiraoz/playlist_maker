using System;
using System.Collections.Generic;
using System.Text;
using CoreListMaker;
using System.Windows.Forms;

namespace ListMusicMaker
{
    class PlayListmakerApp : PlayListMaker
    {
        public PlayListmakerApp(RichTextBox richTextBox)
            : base(new ServiceFuncGUI(richTextBox))
        {
            CreateCore();
        }

     

    }
}
