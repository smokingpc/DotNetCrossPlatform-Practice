using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DotNetCore_DLL;
using DotNetStandard_DLL;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CDotNetStandardDLL std = new CDotNetStandardDLL();
            CMyDotNetCoreClass core = new CMyDotNetCoreClass();

            textBox1.AppendText($"DotNet STD => {std.GetNewName()}\r\n");
            textBox1.AppendText($"DotNet CORE => {core.GetNewName()}\r\n");
        }
    }
}
