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
        
        public M3uMake(string filePath):base(filePath)
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
                for (int i = 0; i < allContentArr.Length; i++)
                {
                    allContentArr[i] = allContentArr[i].Trim('\n');
                    if ((!LINE_SEPARATE.IsMatch(allContentArr[i]) && (allContentArr[i]!="")))
                    {
                        m_FilesList.Add(allContentArr[i].Substring(0, allContentArr[i].Length));
                    }

                    
                }
            }
            m_itemsCont = m_FilesList.Count;
            
        }

        private TextReader m_m3uListFile;
        private Regex LINE_SEPARATE = new Regex("#EXT[A-Z0-9:]+");
        
    }
}
