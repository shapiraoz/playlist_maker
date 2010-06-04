using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;
using System.IO;

namespace CoreListMaker
{
    public class PlayListMaker
    {

        const string welcome_string = "Power Oz software - PlaylistMaker \ncore version : ";
        const string Line = "-------------------------------------------";
        public string MSG_LINE{get { return Line; }} 
        const string complete_work = "Done copying all files.";
        public string MSG_DONE_COPYING{get { return complete_work; } } 
        public string MSG_WELCOME_STRING{ get { return welcome_string; } }
        const string ERR_MSG_PATH_NOT_FILED = "playlist file not empty";
        const string ERR_MSG_NOT_RIGHT_EXT = "incorrect file extention";
        const string MSG_CREATE_FOLDER = "confirm folder exist (will create if not)";
        const string MSG_COPY_FILES = "copying all files....(will take a while)";
        
        public PlayListMaker(IServiceMake service)
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
                m_serviceFuncs.PrintResult(MSG_LINE, 0);
                m_serviceFuncs.PrintResult(MSG_CREATE_FOLDER,0);
                m_CoreMake.CreateFolderOutPut(m_newFolderName);
                m_serviceFuncs.PrintResult(MSG_LINE, 0);
                m_serviceFuncs.PrintResult(MSG_COPY_FILES+"\n",0);
                m_CoreMake.CopyAllFiles(m_serviceFuncs);
                m_serviceFuncs.PrintResult(MSG_LINE,0);
                m_serviceFuncs.PrintResult(MSG_DONE_COPYING,0);
            }

        }

        public string GetVersion()
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
        public IServiceMake m_serviceFuncs;
        private string m_filePath;
        private string m_newFolderName;
       

       
    }
}
