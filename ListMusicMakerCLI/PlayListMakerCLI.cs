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
        const string LINE = "\n**********************************\n";
        
        
        
        const string CMD_HELP1 = "/?";
        const string CMD_HELP2 = "-help";
        const string CMD_CREATE = "create";
        const int PAD_SIZE = 8;
        
        
        public PlayListMakerCLI(string[] args):base(new ServiceFuncCLI())
        {
            CreateCore();
            InitCommandDictionary();
            m_serviceFuncs.PrintResult(LINE + WELCOME_STRING + GetVersion()+LINE);
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
            m_serviceFuncs.PrintResult("\nhelp :\n");
            foreach( KeyValuePair<string, string> commandPair in m_CommandDictionary)
            {
                m_serviceFuncs.PrintResult(commandPair.Key+ " - " +commandPair.Value);
            }
            m_serviceFuncs.PrintResult("\nend help.");
           
        }

        public override void GO()
        {
            base.GO();
        }
        
      
        private void InitCommandDictionary()
        {
            m_CommandDictionary.Add(CMD_HELP1.PadRight(PAD_SIZE,' '),EXPL_HELP);
            m_CommandDictionary.Add(CMD_HELP2.PadRight(PAD_SIZE,' '), EXPL_HELP);
            m_CommandDictionary.Add(CMD_CREATE.PadRight(PAD_SIZE,' '), EXPL_CREATE);
        }

        private void CreateHelpFile()
        {

        }

        private Dictionary<string, string> m_CommandDictionary = new Dictionary<string, string>();

        #region 

        const string EXPL_HELP = "Show help page and expline all command";
        const string EXPL_CREATE = "Create listfilePath [new folder folderpath] newFolderName \n\tfolderPath - can be new folder if the folder is not exit ListMusicMaker will make it. \n\tnewFolderName - string for new folder - this new folder will create at the execution default path";
        

        #endregion


    }
}
