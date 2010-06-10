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
        
        public void PrintResult(string message, float percentage)
        {
            Console.WriteLine(message);
        }

        public void ClearResult() { }
    }
}
