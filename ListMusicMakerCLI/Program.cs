using System;
using System.Collections.Generic;
using System.Text;
using CoreListMaker;

namespace ListMusicMakerCLI
{
    class Program
    {

       
        
        static void Main(string[] args)
        {
            PlayListMakerCLI playlistMakerCLI = new PlayListMakerCLI(args[0], args[1]);
            playlistMakerCLI.GO();
            //WplMake w1 = new WplMake(args[0]);
            //w1.ServiceFunc = new ServiceFuncCLI();
            //w1.ReadData();
            //w1.CreateFolderOutPut(args[1]);
            //w1.CopyAllFiles();
            //M3uMake m1 = new M3uMake(args[0]);
            //m1.ServiceFunc = new ServiceFuncCLI();
            //m1.ReadData();
            //m1.CreateFolderOutPut(args[1]);
            //m1.CopyAllFiles();
        }
    }
}
