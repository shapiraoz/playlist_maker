using System;
using System.Collections.Generic;
using System.Text;
using CoreListMaker;
using System.Windows.Forms;
using System.ComponentModel;

namespace ListMusicMaker
{
    class PlayListmakerApp : PlayListMaker
    {
        public PlayListmakerApp(ref BackgroundWorker BG_worker)
            : base(new ServiceFuncGUI(ref BG_worker))
        {
            CreateCore();
            
        }
        
        public override void GO()
        {
            base.GO();
        }
       
    }
}
