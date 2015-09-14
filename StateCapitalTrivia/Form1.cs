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
                // read all lines from file and store them in an array
                string[] lines = System.IO.File.ReadAllLines("stateCapitals.txt");
                // instantiate an array for each question
                string[] questionOne = new string[6];
                string[] questionTwo = new string[6];
                string[] questionThree = new string[6];
                string[] questionFour = new string[6];
                // copy each question into separate arrays
                Array.Copy(lines, 0, questionOne, 0, 6);
                Array.Copy(lines, 6, questionTwo, 0, 6);
                Array.Copy(lines, 12, questionThree, 0, 6);
                Array.Copy(lines, 18, questionFour, 0, 6);

                // testing array copy works as intended for my purposes
                //foreach (string line in questionFour)
                //{

                //    textBox1.Text += line;
                //    textBox1.Text += "\r\n";

                //}
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
