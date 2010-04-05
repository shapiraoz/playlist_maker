using System;
using System.Collections.Generic;

using System.Text;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

namespace CoreListMaker
{
    public class M3uMake : Amake
    {
        
        public M3uMake(string filePath)
        {
            if (!File.Exists(filePath)) throw (new Exception("Error:file not exist"));
            else 
            {
                m_m3uListFile = new StreamReader(filePath,Encoding.Default);
                m_FilesList = new List<string>();
            }
        }
       
        public override void ReadData()
        {
            string allContent;
            string[] allContentArr;
            
            if (m_m3uListFile == null) throw (new Exception("internal Error : m_FilesList empty "));
            else
            {
                allContent = m_m3uListFile.ReadToEnd();
                
                allContentArr = allContent.Split('\r');
                Match match =  LINE_SEPARATE.Match(allContent);
                for (int i = 2; i < allContentArr.Length; i+=3)
                {
                    string temp = allContentArr[i];
                    Match fileName = FILE_NAME_FORMAT.Match(temp);
                    MatchCollection newS = END.Matches(temp, 0);

                    int lastEnd = newS[newS.Count - 1].Index + 1;
                    temp.Substring(lastEnd, temp.Length - 1);
                   m_FilesList.Add(allContentArr[i]);   
                }
            }
            
            
        }

        private TextReader m_m3uListFile;
        private Regex LINE_SEPARATE = new Regex("#EXTINF:");
        
    }
}
