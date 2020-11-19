﻿using System;
using DotNetCore_DLL;
using DotNetStandard_DLL;

namespace DotNetCore_App
{
    class Program
    {
        static void Main(string[] args)
        {
            CDotNetStandardDLL std = new CDotNetStandardDLL();
            CMyDotNetCoreClass core = new CMyDotNetCoreClass();

            Console.WriteLine(core.GetNewName());
            Console.WriteLine(std.GetNewName());
        }
    }
}
