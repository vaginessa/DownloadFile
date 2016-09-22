using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadFile
{
    public partial class Form1 : Form
    {

        string downloadadress;
        string folderpath;
        string standardpath;
        
        public Form1()
        {
            folderpath = "c:\\Users\\";
            folderpath += System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1];
            folderpath += "\\Desktop\\";
            standardpath = folderpath;

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

             downloadadress = textBox1.Text;

            //Download file from downloadadress
            // save to folderpath
            WebClient webClient = new WebClient();


            string[] temp = downloadadress.Split('/');
            string filename = temp[temp.Length-1];

            folderpath += filename;
            try {
                Console.WriteLine("Downloading file : " + filename + " from : " + downloadadress);
                
                webClient.DownloadFile(downloadadress, @folderpath);

                Console.WriteLine("Saved to : " + folderpath);
            }
            catch {
                textBox1.Text = "Failed to download file.";
            }
            // Console.WriteLine(downloadadress + " " + folderpath);

            folderpath = standardpath;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // if textBox2 is valid adress
            folderpath = textBox2.Text;
        }
    }
}
