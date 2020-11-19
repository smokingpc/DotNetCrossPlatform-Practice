using System;

namespace DotNetCore_DLL
{
    public class CMyDotNetCoreClass
    {
        public string Name = "DotNetCore3.1 class";
        private int Count = 0;
        public string GetNewName()
        {
            Count++;
            return Name + $"[{Count}]";
        }
    }
}
