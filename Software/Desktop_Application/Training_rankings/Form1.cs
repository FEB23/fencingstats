using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training_rankings
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            Training_rankings.StartBox start_BOX= new Training_rankings.StartBox();
            Training_rankings.Communication Com = new Training_rankings.Communication();
            InitializeComponent();
            richTextBox2.Text = DateTime.Now.ToString();
            richTextBox1.Text = Com.getfencerName;
        }

        private void Score_Text()
        {
            Training_rankings.Communication Komm = new Training_rankings.Communication();
            string Name = richTextBox1.Text.ToString();
            string wins = textBox1.Text;
            float Wins = 0;
            if (wins != "")
            {
                Wins = float.Parse(wins);
            }
            else
            {
                Wins = 0;
            }
            float Matches = 0;
            string matches = textBox2.Text;
            if (matches != "")
            {
                Matches = float.Parse(matches);
            }
            else
            {
                Matches = 0;
            }
                      
            string defeats = textBox3.Text;
            float Defeats = 0;
            if (defeats!="")
            {
                 Defeats = float.Parse(defeats);
            }
            else
            {
                Defeats = 0;
            }
            if (Matches != Wins + Defeats )
            {

                MessageBox.Show("Type your wins losses and matches in again.");
            }
            else
            {
                float Score = ((Wins * 10) - (Defeats * -2)) / Matches;
                textBox4.Text = Score.ToString();
                MessageBox.Show(Name + " here is your Score: " + Score.ToString());
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Score_Text();
            
        }
               
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
