using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Fencing_stats
{
    //class for implementing public functions 
    class public_functions
    {
        //function to extract parameter from setup file 
        public string display_information_from_setup_file(int index)
        {
            //inheriting of Encryption class
            Fencing_stats.Encryption encryption = new Fencing_stats.Encryption();
            //reads every line of encrypted setup file
            string[] lines = File.ReadAllLines(@"D:\fencing_stats.txt");
            
            //returns decrypted line at specified index of setup_file
            return encryption.Decrypt(lines[index]);
        }
    }
}
