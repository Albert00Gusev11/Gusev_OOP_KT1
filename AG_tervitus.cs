using System;
using System.Collections.Generic;
using System.Text;

namespace Gusev_OOP_KT1
{
    internal class AG_tervitus
    {
        public string nimi;
        public string vastus;

        public string tere()
        {
            if (nimi != "")
            {
                vastus = "Tere, " + nimi + "!";
            }
            else
            {
                vastus = "Sissege oma nimi";
            }
            return vastus;
        }
    }
}
