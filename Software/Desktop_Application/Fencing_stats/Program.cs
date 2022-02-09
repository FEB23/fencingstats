using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Fencing_stats
{
    class fencer_info
    {

        public string name { get; set; }
        public string weapon { get; set; }

        public string birthdate { get; set; }
    }
        static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string setup_file = @"D:\fencing_stats.json";
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!File.Exists(setup_file))
            {
                Application.Run(new Setup());
            }
            else
            {
                using (StreamReader r = new StreamReader(setup_file))
                {
                    string json = r.ReadToEnd();
                    List<fencer_info> fencer_inf = Newtonsoft.Json.JsonConvert.DeserializeObject<List<fencer_info>>(json);
                    
                }
                Application.Run(new Main_Window());
            }
            
        }
    }
}
