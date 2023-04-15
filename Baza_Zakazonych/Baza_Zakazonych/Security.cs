using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza_Zakazonych
{
    class Security
    {
        public bool Sec1(string a)
        {
            if (a != "1" && a != "2" && a != "3" && a != "4" && a != "5" && a != "6" && a != "Q" && a != "q")
            {
                return false;
            }
            return true;
        }
        public bool Sec2(int a)
        {
            if(a != 1 && a != 2)
            {
                return false;
            }
            return true;
        }
    }
}
