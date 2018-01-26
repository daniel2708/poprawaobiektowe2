using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Sport
    {
        private string nazwa;

        private Sport(string nazwa)
        {
            this.nazwa = nazwa;
        }
        public static Sport Utworz(string nazwa)
        {
            return new Sport(nazwa);
        }
    }
}
