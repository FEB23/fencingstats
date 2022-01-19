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
    public partial class StartBox : Form
    {
        
        public string fencer_Name = "";
        public StartBox()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Training_rankings.Main_Window Main = new Training_rankings.Main_Window();
            Main.NAME = textBox1.Text.ToString();
            Main.Show();
        }

        private void StartBox_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
