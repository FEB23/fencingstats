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

namespace Training_rankings
{
    public partial class setup_window : Form
    {
        public setup_window()
        {
            InitializeComponent();
        }

        public void create_txt_File()
        {
            string fileName = @"D:\\fencing_stats.txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    byte[] name = new UTF8Encoding(true).GetBytes(name_box.Text+"\n");
                    fs.Write(name, 0, name.Length);
                    byte[] weapon = new UTF8Encoding(true).GetBytes(weapon_box.Text+"\n");
                    fs.Write(weapon, 0, weapon.Length);
                    byte[] birthdate = new UTF8Encoding(true).GetBytes(birthdate_box.Text+"\n");
                    fs.Write(birthdate, 0, birthdate.Length);
                }

                // Open the stream and read it back.    
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void done_button_Click(object sender, EventArgs e)
        {
            create_txt_File();
            MessageBox.Show("Setup process finished! Please restart application!");
            this.Close();
        }
    }
}
