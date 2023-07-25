using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiązkaTelefoniczna
{   
     class Kontakt
    {
        public Kontakt(string name, string number)
        {
            Nazwa = name;
            Numer=number;
        }

        public string Nazwa { get; set; }
        public string Numer { get; set; }
    }
}

