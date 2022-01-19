using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_rankings
{
    class Communication 
    {
        private string fencer_NAME;
        public string setfencerName
        {
            set
            {
                 fencer_NAME = value;

            }
        }
        public string getfencerName
        {
            get
            {
                return fencer_NAME;
            }
        }
            
    }
}
