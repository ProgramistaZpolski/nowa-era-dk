using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NowaEraDK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void DecNE()
        {
            
            string filename;
            string[] filePaths = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory+"\\app\\data\\game\\");
            foreach (string myfile in filePaths)
            {
                filename = Path.ChangeExtension(myfile, ".swf");
                System.IO.File.Move(myfile, filename);
            }
            progressBar1.Value += 65;
            System.IO.File.Move(AppDomain.CurrentDomain.BaseDirectory + "\\app\\data\\game\\video_8_4.swf", AppDomain.CurrentDomain.BaseDirectory + "\\app\\data\\game\\video_8_4.flv");
            filePaths = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "\\app\\data\\lib\\");
            foreach (string myfile in filePaths)
            {
                filename = Path.ChangeExtension(myfile, ".swf");
                System.IO.File.Move(myfile, filename);
            }
            progressBar1.Value += 30;
            filePaths = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "\\app\\data\\video\\");
            foreach (string myfile in filePaths)
            {
                filename = Path.ChangeExtension(myfile, ".png");
                System.IO.File.Move(myfile, filename);
            }
            progressBar1.Value = 100;
        }
        public void ComNE()
        {

            string filename;
            string[] filePaths = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "\\app\\data\\game\\");
            foreach (string myfile in filePaths)
            {
                filename = Path.ChangeExtension(myfile, ".ne");
                System.IO.File.Move(myfile, filename);
            }
            progressBar1.Value = 50;
            System.IO.File.Move(AppDomain.CurrentDomain.BaseDirectory + "\\app\\data\\game\\video_8_4.ne", AppDomain.CurrentDomain.BaseDirectory + "\\app\\data\\game\\video_8_4.ne");
            filePaths = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "\\app\\data\\lib\\");
            foreach (string myfile in filePaths)
            {
                filename = Path.ChangeExtension(myfile, ".ne");
                System.IO.File.Move(myfile, filename);
            }
            progressBar1.Value = 75;
            filePaths = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "\\app\\data\\video\\");
            foreach (string myfile in filePaths)
            {
                filename = Path.ChangeExtension(myfile, ".ne");
                System.IO.File.Move(myfile, filename);
            }
            progressBar1.Value = 100;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                DecNE();
            }
            else
            {
                ComNE();
            }
        }
    }
}
