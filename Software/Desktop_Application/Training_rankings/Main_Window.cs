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
    
    public partial class Main_Window : Form

    {
        public  string NAME;
        
        private int fights;
        
        Training_rankings.Input_Results input = new Training_rankings.Input_Results();
        List<int> points_wins = new List<int>();
        List<int> op_points_wins = new List<int>();
        List<int> points_loss = new List<int>();
        List<int> op_points_loss = new List<int>();
        int wins;
        string Name;
        int defeats;
        public Main_Window()
        {
            

            InitializeComponent();
            richTextBox2.Text = DateTime.Now.ToString();
            
            richTextBox1.Text = NAME;
        }

        private void Score_Text()
        {      
            
            
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

        private void parse_values()
        {
            
            if (textBox1.Text != "")
            {
                wins = int.Parse(textBox1.Text);
                defeats = int.Parse(textBox2.Text);
            }
        }
        private void start_Process_Click(object sender, EventArgs e)
        {
            
           
            score_Input(wins, 5, 5);
            //Score_Text();
            
        }
        private void score_Input(int total, int wins, int defeatses )
        {
            for( int i = 0; i< wins; i++)
            {
                input.Show();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

    }
}
