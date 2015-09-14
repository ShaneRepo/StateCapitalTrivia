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

namespace StateCapitalTrivia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string text;
                StreamReader inputfile;
                //inputfile = File.OpenText("stateCapitals.txt");
                string[] lines = System.IO.File.ReadAllLines("stateCapitals.txt");
                foreach (string line in lines)
                {
                    // Use a tab to indent each line of the file.
                    textBox1.Text += line;
                    textBox1.Text += "\r\n";

                }
                //while (!inputfile.EndOfStream)
                //{
                //    text = inputfile.ReadLine();
                //    textBox1.Text += text;
                //    textBox1.Text += "\r\n";
                //}
                //inputfile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
