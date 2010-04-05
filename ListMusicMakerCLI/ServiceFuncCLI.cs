using System;
using System.Collections.Generic;
using System.Text;
using CoreListMaker;

namespace ListMusicMakerCLI
{
    class ServiceFuncCLI: IServiceMake
    {
        public void PrintResult(string message)
        {
           Console.WriteLine(message);
        }

    }
}
