﻿
namespace CoreListMaker
{
    public interface IServiceMake
    {
        void PrintResult(string message);
        void PrintResult(string message, float percentage);
        void ClearResult();
    }

}
