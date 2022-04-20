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
            folderBrowserDialog1.ShowDialog();
            DirectoryInfo dinfo = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            long Size = GetDirectorySize(dinfo);
            if (dinfo.GetDirectories("*", SearchOption.AllDirectories).Length != 0)
            {
                for (int i = 0; i < dinfo.GetDirectories("*", SearchOption.AllDirectories).Length; i++)
                {
                    Size = GetDirectorySize(dinfo.GetDirectories("*", SearchOption.AllDirectories)[i]);
                    dataGridView1.Rows.Add(dinfo.GetDirectories("*", SearchOption.AllDirectories)[i].Name, Size.ToString());
                }
            }
            else
            {
                dataGridView1.Rows.Add(dinfo.Name, Size);
            }
        }

        private long GetDirectorySize(DirectoryInfo dinfo)
        {
            long mass = 0;
            for (int i = 0; i < Directory.GetFiles(dinfo.FullName).Length; i++)
            {
                mass += new FileInfo(Directory.GetFiles(dinfo.FullName)[i]).Length;
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
