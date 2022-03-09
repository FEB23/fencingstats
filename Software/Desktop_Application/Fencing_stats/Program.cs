using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Fencing_stats
{
    
        static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
         
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //sets path of set up file 
            string setup_file = @"D:\fencing_stats.txt";
            
            //checks if setup file exists
            if (!File.Exists(setup_file))
            {
                //if not start setup process
                Application.Run(new Setup());
            }
            else
            {
                //if so start application
                Application.Run(new Main_Window());
            }
            
        }
    }
}
