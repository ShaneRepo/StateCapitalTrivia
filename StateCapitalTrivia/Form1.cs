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
        // user answer variables
        int userAnswer;
        int score;
        int count;
        Boolean proceed = false;  
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
                          
                // load questions
                labelState.Text = questionOne[0];
                listBox1.Items.Add(questionOne[1]);
                listBox1.Items.Add(questionOne[2]);
                listBox1.Items.Add(questionOne[3]);
                listBox1.Items.Add(questionOne[4]);

                //listBox1.Items.Add(answerOne);
                //listBox1.Items.Add(answerTwo);
                //listBox1.Items.Add(answerThree);
                //listBox1.Items.Add(answerFour);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            labelAnswer.Text = "";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Error!! Select a capitol!");
                    
                }
                else
                {
                    userAnswer = listBox1.SelectedIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
