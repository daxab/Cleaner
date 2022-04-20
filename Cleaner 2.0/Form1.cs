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

namespace Cleaner_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              
        }

        private long GetDirectorySize(string path)
        {
            long mass = 0;
            folderBrowserDialog1.ShowDialog();

            for (int i = 0; i < SearchDirectory(path).Length + SearchFile(path).Length; i++)
            {
                mass += SearchFile(path)[i].Length;
            }
            return mass;
        }
        static string[] SearchDirectory(string patch)
        {
            string[] ReultSearch = Directory.GetDirectories(patch);
            return ReultSearch;
        }
        static string[] SearchFile(string patch)
        {
            string[] ReultSearch = Directory.GetFiles(patch);
            return ReultSearch;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
