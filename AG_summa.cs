using System;
using System.Collections.Generic;
using System.Text;

namespace Gusev_OOP_KT1
{
    internal class AG_summa
    {
        public float Arv1;
        public float Arv2;
        public string tehing = "";
        public float result;

        public float arvutus()
        {
            if (tehing == "+")
            {
                result = Arv1 + Arv2;
            }
            else if (tehing == "-")
            {
                result = Arv1 - Arv2;
            }

            return (result);
        }
    }
}
