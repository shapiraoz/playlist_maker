using System;
using System.Collections.Generic;
using System.Text;
using CoreListMaker;
using System.Text.RegularExpressions;

namespace ListMusicMakerCLI
{
    class PlayListMakerCLI:PlayListMaker
    {
        const string WELCOME_STRING = "Power Oz software - PlaylistMaker version : ";
       

        public PlayListMakerCLI(string filePath, string newFolderName):base(filePath,newFolderName)
        {
            m_CoreMake.ServiceFunc = new ServiceFuncCLI();
            m_CoreMake.ServiceFunc.PrintResult(WELCOME_STRING + GetVersion()+"\n");
        }
        
        public override void GO()
        {
            base.GO();
        }

        
    }
}
