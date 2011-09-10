
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace CoreListMaker
{
    public class Amake
    {
        const string COPY_FILE_MSG = "copying file :";
        const string CANT_COPY_MSG = "error can't copy file : ";
        const string ERR_MSG_TARGET_NOT_FONUD = "internal Error: target not init";
        
        public virtual void ReadData(){}
        
        public Amake(string filePath)
        {
            m_filePath = filePath;
            m_mainDirPath = new FileInfo(filePath).Directory.FullName;
        }

        public float GetNumItems()
        {
            return m_itemsCont;
        }

        public void CreateFolderOutPut(string Path)
        {
            m_targetPath = Path;
            Directory.CreateDirectory(Path);

        }

        public Amake(IServiceMake service)
        {
           
        }


        public void CopyAllFiles(IServiceMake serviceFunc)
        {
            if (m_targetPath.Length == 0) throw (new Exception(ERR_MSG_TARGET_NOT_FONUD));

            if (!Directory.Exists(m_targetPath))
            {
                m_targetPath = Path.Combine(m_mainDirPath , m_targetPath);
                Directory.CreateDirectory(m_targetPath);
            }
            else
            {
                float count = 1;
                foreach (string s in m_FilesList)
                {
                    string temps = s;
                    temps = temps.Contains("[") ? temps.Replace('[', '(') : temps;
                    temps = temps.Contains("]") ? temps.Replace(']', ')') : temps;
                    Match fileName = FILE_NAME_FORMAT.Match(temps);
                    string src = (File.Exists(s)) ? s : Path.Combine(m_mainDirPath ,s);
                    
                    try
                    {

                        File.Copy(src, Path.Combine(m_targetPath , fileName.ToString()), true);
                        serviceFunc.PrintResult(COPY_FILE_MSG + fileName.ToString(), (count / m_itemsCont));
                    }
                    catch (System.Exception ex3)
                    {
                        serviceFunc.PrintResult(CANT_COPY_MSG + ex3.Message, (count / m_itemsCont));
                    }
                    ++count;
                }
            }
        }

        protected float m_itemsCont;
        protected List<string> m_FilesList;
        protected string m_targetPath;
        protected Regex FILE_NAME_FORMAT = new Regex("[A-Za-z0-9 -. א-ת ()]+.[flacMmPp3wa]$");
        protected Regex END = new Regex("[\n\r]");
        protected string m_filePath;
        protected string m_mainDirPath;
       
       
        

        
        
    }
}
