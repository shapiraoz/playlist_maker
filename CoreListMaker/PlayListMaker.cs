using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;

namespace CoreListMaker
{
    public class PlayListMaker
    {
        const string ERR_MSG_PATH_NOT_FILED = "playlist file not empty";
        const string ERR_MSG_NOT_RIGHT_EXT = "incorrect file extention";
        const string MSG_COPY_FILES = "copying all files....(will take a while)";

        public PlayListMaker(string filePath, string newFolderName)
        {
            if (m_m3uExtension.IsMatch(filePath))
            {
                m_CoreMake = new M3uMake(filePath);
            }
            else
            {
                m_CoreMake =(m_wplExtension.IsMatch(filePath))? new WplMake(filePath) : null;    
            }
            if (m_CoreMake == null) throw (new  Exception(ERR_MSG_PATH_NOT_FILED)) ;
            
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
                m_CoreMake.ServiceFunc.PrintResult(MSG_COPY_FILES);
                m_CoreMake.CopyAllFiles();
            }

        }
        protected string GetVersion()
        {
            Assembly assembly = Assembly.GetEntryAssembly();
            AssemblyVersionAttribute[] attributes =
                assembly.GetCustomAttributes(typeof(AssemblyVersionAttribute), false)
                    as AssemblyVersionAttribute[];

            if (attributes != null && attributes.Length == 1)
            {
                return attributes[0].Version;
            }
            else return null;
        }

        protected Amake m_CoreMake;
        protected Regex m_m3uExtension = new Regex("[:a-zA-Z0-9א-ת_\\ ]+.[mM]3[uU]$");
        protected Regex m_wplExtension = new Regex("[:a-zA-Z0-9א-ת_\\ ]+.[Ww][Pp][Ll]$");

        private string m_filePath;
        private string m_newFolderName;
    }
}
