using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;
using System.IO;

//[assembly: AssemblyVersionAttribute("1.0.0.0")]
//[assembly: AssemblyTitleAttribute("PlayList Maker main core")]

namespace CoreListMaker
{
    public class PlayListMaker
    {
        const string ERR_MSG_PATH_NOT_FILED = "playlist file not empty";
        const string ERR_MSG_NOT_RIGHT_EXT = "incorrect file extention";
        const string MSG_COPY_FILES = "copying all files....(will take a while)";
        const string MSG_DONE_COPYING = "done copying all file .";

        public PlayListMaker(string[] args,IServiceMake service)
        {
            m_serviceFuncs = service; 

        }

        public PlayListMaker(string filePath, string newFolderName,IServiceMake service)
        {
            m_serviceFuncs = service; 
            CreateCore(filePath, newFolderName);
        }

        public void CreateCore()
        {
            m_CoreMake = new Amake(m_serviceFuncs);
            
        }

        public void CreateCore(string filePath, string newFolderName)
        {
          
            

            if (m_m3uPath.IsMatch(filePath))
            {
                m_CoreMake = new M3uMake(filePath);
            }
            else
            {
                m_CoreMake = (m_wplPath.IsMatch(filePath)) ? new WplMake(filePath) : null;
            }
            if (m_CoreMake == null) throw (new Exception(ERR_MSG_PATH_NOT_FILED));
            
            m_filePath = filePath;
            m_newFolderName = newFolderName;
            
        }

        public virtual void GO()
        {
            if (m_filePath.Length == 0) throw (new Exception(ERR_MSG_PATH_NOT_FILED));
            else
            {
                m_CoreMake.ReadData();
                m_CoreMake.CreateFolderOutPut(m_newFolderName);
                m_serviceFuncs.PrintResult(MSG_COPY_FILES+"\n");
                m_CoreMake.CopyAllFiles(m_serviceFuncs);
                
            }

        }

        protected string GetVersion()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        public string FilePath
        {
            get { return m_filePath; }
            set { m_filePath = value; }
        }

        public string NewFolderName
        {
            get { return m_newFolderName; }
            set { m_newFolderName = value; }
        }
        

        protected Amake m_CoreMake;
        protected Regex m_m3uPath = new Regex("[:a-zA-Z0-9א-ת_\\ ]+.[mM]3[uU]$");
        protected Regex m_wplPath = new Regex("[:a-zA-Z0-9א-ת_\\ ]+.[Ww][Pp][Ll]$");
        protected IServiceMake m_serviceFuncs;
        private string m_filePath;
        private string m_newFolderName;
       

       
    }
}
