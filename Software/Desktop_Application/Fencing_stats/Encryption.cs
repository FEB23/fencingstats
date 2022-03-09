using System;
using System.Collections.Generic;
using System.Text;

namespace Fencing_stats
{
    class Encryption
    {
        string key = "WNiyuVBktb";
        public string Encrypt(string text)
        {
            
            if (key != string.Empty)
            {
                //der verschlüsselte Text
                string encrypted = string.Empty;
                //Die Stelle des Schlüssels, die angibt, um wieviel ein Buchstabe verschoben werden soll
                int keyindex = 0;

                foreach (char c in text)
                {
                    int asciinr = (int)c;//die Nummer des Zeichens in der ASCII-Tabelle
                    //Nummer wird um Wert des Zeichens des Schlüssels erhöht,
                    //das an der Stelle von keyindex steht
                    asciinr += (int)key[keyindex];

                    if (asciinr > 255)
                        asciinr -= 255;

                    //hinzufügen des verschlüsselten Zeichens zum verschlüsselten string
                    encrypted += (char)asciinr;

                    keyindex++;
                    if (keyindex > key.Length - 1)
                        keyindex = 0;
                }
                return encrypted;
            }
            else
                //wenn der Schlüssel leer ist, wird der Text nicht verschlüsselt
                return text;
        }


        /// <summary>
        /// Entschlüsselt einen Text, der mit dem Ceasar-Chiffre-Verfahren verschlüsselt wurde
        /// </summary>
        /// <param name="text">Der zu entschlüsselnde Text</param>
        /// <param name="key">Der Schlüssel</param>
        /// <returns>Gibt den Text entschlüsselt zurück</returns>
        public string Decrypt(string text)
        {
            if (key != string.Empty)
            {
                //der entschlüsselte Text
                string decrypted = string.Empty;
                //Die Stelle des Schlüssels, die angibt, um wieviel ein Buchstabe verschoben werden soll
                int keyindex = 0;

                foreach (char c in text)
                {
                    int asciinr = (int)c;//Der Wert des Zeichens in der ASCII-Tabelle
                    asciinr -= (int)key[keyindex];

                    if (asciinr < 0)
                        asciinr = 255 + asciinr;

                    decrypted += (char)asciinr;
                    keyindex++;
                    if (keyindex > key.Length - 1)
                        keyindex = 0;
                }
                return decrypted;
            }
            else
                //wenn der Schlüssel leer ist, wird der Text nicht entschlüsselt
                return text;
        }
    }
}
