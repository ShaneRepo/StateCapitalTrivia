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
                // answer index variables
                int answerOne = int.Parse(questionOne[5]);
                int answerTwo = int.Parse(questionTwo[5]);
                int answerThree = int.Parse(questionThree[5]);
                int answerFour = int.Parse(questionFour[5]);
                // user answer variables
                int userOne;
                int userTwo;
                int userThree;
                int userFour;
                int score;
                labelState.Text = questionOne[0];
                radioButton1.Text = questionOne[1];
                radioButton2.Text = questionOne[2];
                radioButton3.Text = questionOne[3];
                radioButton4.Text = questionOne[4];
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            labelAnswer.Text = "";
        }
    }
}
