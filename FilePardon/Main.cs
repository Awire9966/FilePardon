using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace FilePardon
{
    public partial class Main : Form
    {
        static string CD = Application.StartupPath+@"\";
        public Main()
        {
            InitializeComponent();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(CD + "current.bat", File.ReadAllText(CD + "PardonFileTemplate.bat").Replace("fileextention", textBox2.Text));
            Process.Start(CD + "current.bat");        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog.FileName;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText(CD + "current.bat", File.ReadAllText(CD + "PardonFileTypeTemplate.bat").Replace("fileextention", textBox3.Text));
            Process.Start(CD + "current.bat");
        }
    }
}
