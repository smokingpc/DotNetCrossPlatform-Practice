using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DotNetStandard_DLL;
//using DotNetCore_DLL;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //.Net Framework APP can't reference to .Net Core DLL!
            //you can only compile this project IF you remove reference to .Net Core DLL project...
            CDotNetStandardDLL std = new CDotNetStandardDLL();
            //CMyDotNetCoreClass core = new CMyDotNetCoreClass();
            textBox1.AppendText(std.GetNewName() + "__ABCDEFG\r\n");
        }
    }
}
