using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Training_rankings
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
       
        static void Main()
        {
            string fileName = @"D:\\fencing_stats.txt";
            Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);
            if (!File.Exists(fileName))
            {
                Application.Run(new setup_window());
            }
            Application.Run(new Main_Window());
           



        }
    }
}
