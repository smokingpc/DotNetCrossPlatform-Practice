using System;

namespace DotNetStandard_DLL
{
    public class CDotNetStandardDLL
    {
        public string Name = "DotNetStandard 2 class";
        private int Count = 999;
        public string GetNewName()
        {
            Count--;
            return Name + $"[{Count}]";
        }

    }
}
