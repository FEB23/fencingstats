using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fencing_stats
{
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
        }

       

        private void updateInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fencing_stats.Setup setup = new Fencing_stats.Setup();
            setup.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Fencing_stats.Input_fights input_fights = new Fencing_stats.Input_fights();
            
            input_fights.Show();
        }

        private void Main_Window_Load(object sender, EventArgs e)
        {

        }

        private void exit_button_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh_ui_button_Click(object sender, EventArgs e)
        {
            
        }

        private void training_points_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
