using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Elf : Bohater
    {
        private string magia;

        public Elf(int hp, string magia)
            : base(hp)
        {
            this.magia = magia;
        }

        public override bool ZadajCios(int p3)
        {
            if (magia == "Czarodziej");
            {
                return false;
            }
            return true;
        }
    }
}