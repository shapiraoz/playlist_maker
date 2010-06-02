using System;
using System.Collections.Generic;
using System.Text;
using CoreListMaker;
using System.Text.RegularExpressions;
using System.Collections;
using System.IO;
using System.Xml;

namespace ListMusicMakerCLI
{
    class PlayListMakerCLI:PlayListMaker
    {
        const string WELCOME_STRING = "Power Oz software - PlaylistMaker \n core version : ";
        const string CMD_HELP1 = "/?";
        const string CMD_HELP2 = "-help";
        const string CMD_CREATE = "create";

        
        
        public PlayListMakerCLI(string[] args):base(args,new ServiceFuncCLI())
        {
            CreateCore();
            m_serviceFuncs.PrintResult(WELCOME_STRING + GetVersion());
            int i = 0;
            
            foreach (string s in args)
            {
                switch (s.ToLower())
                {
                    case CMD_HELP1:
                    case CMD_HELP2:
                        PrintHelp();
                        i++;
                    break;
                    case CMD_CREATE:
                        if ((args[i + 1].Length > 1) && (args[i + 2].Length > 1))
                        {
                            FilePath = args[i + 1];
                            NewFolderName = args[i + 2];
                            CreateCore(FilePath,NewFolderName);
                            GO();
                        }
                        else
                        {
                            m_serviceFuncs.PrintResult("file path not insert or folder path");
                        }
                    break;
                  }
                
            }
        }

        public PlayListMakerCLI(string filePath, string newFolderName)
            : base(filePath, newFolderName, new ServiceFuncCLI())
        {
                       
        }

        void PrintHelp()
        {
            m_serviceFuncs.PrintResult("help");
        }

        public override void GO()
        {
            base.GO();
        }
        
        //private XmlNodeList GetCommandListFromXml()
        //{
        //   // string xmlpath = Path.GetDirectoryName(Application.ExecutablePath)+"\\Profile.xml";

        //    TextReader fileStr = new StreamReader(xmlpath, Encoding.UTF8);
        //    string xmlContent = fileStr.ReadToEnd();
        //    XmlDocument profileDoc = new XmlDocument();
        //    profileDoc.LoadXml(xmlContent);
        //    return profileDoc.GetElementsByTagName("commands");
        //}

        private void InitCommandDictionary()
        {

        ////    XmlNodeList commandList = GetCommandListFromXml();
        //    for (int i = 0; i < commandList.Count; i++)
        //    {
        //       // commandList[i].Attributes.Item(0).InnerText; // name
        //    }
        //   //  m_CommandDictionary.Add(CMD_HELP1,
        }

        private Dictionary<string, string> m_CommandDictionary = new Dictionary<string, string>();

     
        
    }
}
