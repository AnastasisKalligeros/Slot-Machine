using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slot_machine
{
    class Player
    {
        public String Firstname { get; set; }

        public String Surname { get; set; }
        
            public String WelcomePlayer()
        {
            return "WELCOME " + Firstname + " " + Surname; ;
        }
    }
}
