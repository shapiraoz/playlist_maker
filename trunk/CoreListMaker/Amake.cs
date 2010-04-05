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

        public virtual void ReadData()
        {
           
        }

        public void CreateFolderOutPut(string Path)
        {
            m_targetPath = Path;
            Directory.CreateDirectory(Path);

        }

        
        public void CopyAllFiles()
        {
            if (m_targetPath.Length == 0) throw (new Exception("internal Error: target not init"));
            
            else
            {
                foreach (string s in m_FilesList)
                {
                    string temps = s;
                    temps = temps.Contains("[") ? temps.Replace('[', '(') : temps;
                    temps = temps.Contains("]") ? temps.Replace(']', ')') : temps;
                    Match fileName = FILE_NAME_FORMAT.Match(temps);
                    MatchCollection newS = END.Matches(s, 0);
                   
                    int lastEnd = newS[newS.Count - 1].Index+1;
                    try
                    {

                        File.Copy(s.Substring(lastEnd, temps.Length - 1), Directory.GetCurrentDirectory() + "\\" + m_targetPath + "\\" + fileName.ToString(), true);
                        m_ServiceFunc.PrintResult(COPY_FILE_MSG + fileName.ToString());
                    }
                    catch (System.IO.FileNotFoundException ex)
                    {

                    }
                    catch (System.IO.DirectoryNotFoundException ex1)
                    {

                    }
                    catch (System.UnauthorizedAccessException ex2)
                    {

                    }

               }
            }
        }

        protected List<string> m_FilesList;
        protected string m_targetPath;
        protected Regex FILE_NAME_FORMAT = new Regex("[A-Za-z0-9 -. א-ת ()]+.[flacMmPp3]$");
        protected Regex END = new Regex("[\n\r]");
        
        private IServiceMake m_ServiceFunc;
        public IServiceMake ServiceFunc
        {
            get { return m_ServiceFunc; }
            set { m_ServiceFunc = value; }
        }
    }
}
