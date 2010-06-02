using System;
using System.Collections.Generic;
using System.Text;
using CoreListMaker;

namespace ListMusicMaker
{
    class PlayListmakerApp : PlayListMaker
    {
        public PlayListmakerApp()
            : base(new ServiceFuncGUI())
        {

        }


    }
}
