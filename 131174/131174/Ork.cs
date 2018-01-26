using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Ork : Bohater
    {
        public int walka;

        public Ork(int hp, int walka)
            : base(walka)
        {
            this.walka = walka;
        }
        public override bool ZadajCios(int p3)
        {
            if (walka > 1000) ;
            {
                return true;
            }
            return false;
        }
    }
}