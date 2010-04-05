using System;
using System.Collections.Generic;
using System.Text;
using CoreListMaker;
using System.Text.RegularExpressions;

namespace ListMusicMakerCLI
{
    class PlayListMakerCLI:PlayListMaker
    {
        //const string ERR_MSG_PATH_NOT_FILED = "playlist file not empty";
        //const string ERR_MSG_NOT_RIGHT_EXT = "incorrect file extention";
        public PlayListMakerCLI(string filePath, string newFolderName):base(filePath,newFolderName)
        {
            
        }
        //public PlayListMakerCLI(string  filePath,string newFolderName)
        //{
        //    if (m_m3uExtension.IsMatch(filePath))
        //    {
        //        m_CoreMake = new M3uMake(filePath);
        //    }
        //    else
        //    {
        //        m_CoreMake =(m_wplExtension.IsMatch(filePath))? new WplMake(filePath) : null;    
        //    }
        //    if (m_CoreMake == null) throw (new  Exception(ERR_MSG_PATH_NOT_FILED)) ;
            
        //    m_filePath = filePath;
        //    m_newFolderName = newFolderName;
        //}

        public override void GO()
        {
            //if (m_filePath.Length == 0) throw (new Exception(ERR_MSG_PATH_NOT_FILED));
            //else
            //{
            //    m_CoreMake.ReadData();
            m_CoreMake.ServiceFunc = new ServiceFuncCLI();
            base.GO();
            //    m_CoreMake.CreateFolderOutPut(m_newFolderName);
            //    m_CoreMake.CopyAllFiles();
            //}

        }

        //Amake m_CoreMake; 
        //Regex m_m3uExtension = new Regex("[:a-zA-Z0-9א-ת_\\ ]+.[mM]3[uU]$");
        //Regex m_wplExtension = new Regex("[:a-zA-Z0-9א-ת_\\ ]+.[Ww][Pp][Ll]$");

        //private string m_filePath;
        //private string m_newFolderName;
    }
}
