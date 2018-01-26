using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Bohater:IComparable<Bohater>
    {
        private int hp;

        public Bohater(int hp)
        {
            this.hp = hp;
        }
        public virtual bool ZadajCios(int p2)
        {
            if (hp > 50) ;
            {
                return true;
            }
            return false;
        }

        public int CompareTo(Bohater other)
             {
            return this.hp.CompareTo(other.hp);
            }
        }
    }

