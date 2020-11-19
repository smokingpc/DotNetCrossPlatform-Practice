using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetStandard_DLL;
using DotNetCore_DLL;

namespace WinConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //.Net Framework APP can't reference to .Net Core DLL...
            CDotNetStandardDLL std = new CDotNetStandardDLL();
            CMyDotNetCoreClass core = new CMyDotNetCoreClass();

            Console.WriteLine(core.GetNewName());
            Console.WriteLine(std.GetNewName());
        }
    }
}
