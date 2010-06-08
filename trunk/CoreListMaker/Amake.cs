
using System;
using System.Collections.Generic;

using System.Text;
using System.Xml;
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
            FileInfo f = new FileInfo(filePath);
            m_mainDirPath = f.Directory.FullName;
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
                m_targetPath = m_mainDirPath + "\\" + m_targetPath;
                Directory.CreateDirectory(m_mainDirPath + "\\" + m_targetPath);
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
                    string src = (File.Exists(s)) ? s : (m_mainDirPath + "\\" + s);
                    
                    try
                    {

                        File.Copy(src, m_targetPath + "\\" + fileName.ToString(), true);
                        serviceFunc.PrintResult(COPY_FILE_MSG + fileName.ToString(), (count / m_itemsCont));
                    }
                    catch (System.IO.FileNotFoundException ex)
                    {
                        serviceFunc.PrintResult(CANT_COPY_MSG + ex.Message, (count / m_itemsCont));
                    }
                    catch (System.IO.DirectoryNotFoundException ex1)
                    {
                        serviceFunc.PrintResult(CANT_COPY_MSG + ex1.Message, (count / m_itemsCont));
                    }
                    catch (System.UnauthorizedAccessException ex2)
                    {
                        serviceFunc.PrintResult(CANT_COPY_MSG + ex2.Message, (count / m_itemsCont));
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
        protected Regex FILE_NAME_FORMAT = new Regex("[A-Za-z0-9 -. א-ת ()]+.[flacMmPp3]$");
        protected Regex END = new Regex("[\n\r]");
        protected string m_filePath;
        protected string m_mainDirPath;
       
       
        

        
        
    }
}
