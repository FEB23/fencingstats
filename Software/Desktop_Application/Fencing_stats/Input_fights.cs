using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.IO;
using System.Diagnostics;

namespace Fencing_stats
{

    public partial class Input_fights : Form
    {
        public List<int> op_hit = new List<int>();
        public List<int> your_hit = new List<int>();
        public Input_fights()
        {
            InitializeComponent();
        }
        public int calculate_total_hit(List<int> hit)
        {
            int tot_hit = 0;
            for (int i = 0; i < hit.ToArray().Length; i++)
            {
                tot_hit = tot_hit + hit[i];
            }
            return tot_hit;
        }

        public int calculate_wins(List<int> op_hit,List<int> you_hit)
        {
            int wins_t = 0;
            for(int i = 0; i< op_hit.ToArray().Length; i++)
            {
                if(op_hit[i]< you_hit[i])
                {
                    wins_t += 1;
                }
                else
                {
                    //do nothing
                }
            }
            return wins_t;
        }

        private void calculate_scores(List<int> op_hit, List<int> yourhit)
        {
            
            int your_hit = calculate_total_hit(yourhit);
            int opponents_hit = calculate_total_hit(op_hit); ;
            
            int total_fights = op_hit.ToArray().Length;
           
            int total_hit = your_hit+opponents_hit;
            
            int wins = calculate_wins(op_hit,yourhit);
            
            int losses =total_fights - wins;

            int point_difference = your_hit -opponents_hit;
            int hit_average = total_hit/total_fights;
            
            int opponents_hit_average= opponents_hit/total_fights;
            
            int yourhit_average = your_hit/total_fights;


            using (StreamWriter writer = new StreamWriter(@"D:\fencing_stat_exports.txt"))
            {

                writer.WriteLine("Your hits: "+your_hit.ToString());
                writer.WriteLine("Opponents hits: "+opponents_hit.ToString());
                writer.WriteLine("Total hits: " + total_hit.ToString());
                writer.WriteLine("Your total fights: "+total_fights.ToString());

               

                writer.WriteLine("Your wins: "+wins.ToString());

                writer.WriteLine("Your losses: "+losses.ToString());

                writer.WriteLine("Difference in Points: "+point_difference.ToString());

                writer.WriteLine("Average hits per fight: "+hit_average.ToString());
                writer.WriteLine("Hit average of your opponent: "+opponents_hit_average.ToString());
                writer.WriteLine("Your hit average: "+yourhit_average.ToString());
            }
           
           /* var fileToOpen = @"D:\fencing_stat_exports.txt";
            var process = new System.Diagnostics.Process();
            process.StartInfo = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = fileToOpen
            };

            process.Start();
           */
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(@"D:\results_of_fights.txt"))
            {

                writer.WriteLine(fight_1_your.Text.ToString());
                writer.WriteLine(fight_1_op.Text.ToString());

                writer.WriteLine(fight_2_your.Text.ToString());
                writer.WriteLine(fight_2_op.Text.ToString());

                writer.WriteLine(fight_3_your.Text.ToString());
                writer.WriteLine(fight_3_op.Text.ToString());

                writer.WriteLine(fight_4_your.Text.ToString());
                writer.WriteLine(fight_4_op.Text.ToString());

                writer.WriteLine(fight_5_your.Text.ToString());
                writer.WriteLine(fight_5_op.Text.ToString());

                writer.WriteLine(fight_6_your.Text.ToString());
                writer.WriteLine(fight_6_op.Text.ToString());

                writer.WriteLine(fight_7_your.Text.ToString());
                writer.WriteLine(fight_7_op.Text.ToString());

                writer.WriteLine(fight_8_your.Text.ToString());
                writer.WriteLine(fight_8_op.Text.ToString());
                File.SetAttributes(@"D:\inputs_between.txt", FileAttributes.Normal);

            }
            using (StreamReader file = new StreamReader(@"D:\results_of_fights.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    if (counter % 2 == 0)
                    {
                        your_hit.Add(Int16.Parse(ln));
                    }
                    else
                    {
                        op_hit.Add(Int16.Parse(ln));
                    }
                    Console.WriteLine(ln);
                    counter++;
                }
                file.Close();

                calculate_scores(op_hit, your_hit);
                MessageBox.Show("Calculation Complete!\n You will now return to the main window! \n Please click the refresh Button to see scores!", "Completed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(@"notepad.exe", @"D:\fencing_stat_exports.txt");
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}