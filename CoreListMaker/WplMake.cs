using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;


namespace CoreListMaker
{
    public class WplMake:Amake
    {
        public WplMake(string filePath)
        {
            
            if (!File.Exists(filePath)) throw (new Exception("Error:file not exist"));
            else
            {
                TextReader fileStr= new StreamReader(filePath,Encoding.UTF8);
                string xmlContent = fileStr.ReadToEnd();   
                m_wplListFile = new XmlDocument();
                m_wplListFile.LoadXml(xmlContent);
                m_FilesList = new List<string>();
            }
        }
        
        public override void ReadData()
        {
            XmlNodeList fileSorce = m_wplListFile.GetElementsByTagName("media");
            for (int i = 0; i < fileSorce.Count; ++i)
            {
                m_FilesList.Add(fileSorce[i].Attributes.Item(0).InnerText);
                
                             // XmlAttributeCollection fileAttribute = fileSorce[i].Attributes.ToString\;
              //  m_FilesList.Add(fileDetail.Substring(12,fileDetail.Length - fileDetail.LastIndexOfAny(new char[]{'t','i','d'})));
            }
        }

        
        private XmlDocument m_wplListFile;
    }
}
