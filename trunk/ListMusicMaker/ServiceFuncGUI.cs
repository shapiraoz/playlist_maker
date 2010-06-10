using System;
using System.Collections.Generic;
using System.Text;
using CoreListMaker;
using System.Windows.Forms;
using System.ComponentModel;

namespace ListMusicMaker
{
    class ServiceFuncGUI: IServiceMake
    {
         string m_showtext;
         BackgroundWorker m_BackgroundWorker;
         public ServiceFuncGUI(ref BackgroundWorker BG_worker)
         {
             m_BackgroundWorker = BG_worker;
         }


        #region IServiceMake Members

        public void PrintResult(string message)
        {
           m_showtext+=message="\n";
        }

        public void PrintResult(string message, float percentage)
        {
           m_BackgroundWorker.ReportProgress((int)(percentage * 100), message + "\n");
        }

        public void ClearResult()
        {
            m_BackgroundWorker.ReportProgress(1,"Clear");
        }
        #endregion
    }
}
