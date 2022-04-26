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

namespace Fencing_stats
{

    public partial class Setup : Form
    {
       
        
        public Setup()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Fencing_stats.Encryption encryption = new Fencing_stats.Encryption();
            
            using (StreamWriter writer = new StreamWriter(@"D:\fencing_stats.txt"))
            {
                writer.WriteLine(encryption.Encrypt(name_box.Text));
                writer.WriteLine(encryption.Encrypt(weapon_box.Text));
                writer.WriteLine(encryption.Encrypt(birthdate.Value.Date.ToString()));
                
            }
            




            MessageBox.Show("Setup Complete, please restart Application!", "Completed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            //creates .json file to store date from initial setup

            /*            List<fencer_info> _data = new List<fencer_info>();
                        _data.Add(new fencer_info()
                        {
                            name = name_box.Text,
                            weapon = weapon_box.Text,
                            birthdate = birthdate.Value.ToString(),
                        }) ;

                        string json = JsonSerializer.Serialize(_data);
                        File.WriteAllText(@"D:\fencing_stats.json", json);
              File.WriteAllTextAsync(@"D:\fencing_stats.txt", name_box.Text);
            File.WriteAllTextAsync(@"D:\fencing_stats.txt", weapon_box.Text);
            File.WriteAllTextAsync(@"D:\fencing_stats.txt", birthdate.Value.ToString());


            */
        }
    }
}
