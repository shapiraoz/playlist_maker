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
            PlayListMakerCLI playlistMakerCLI = new PlayListMakerCLI(args);
            //playlistMakerCLI.GO();
       }
    }
}
