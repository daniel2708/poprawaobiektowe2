using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaTest klas = new KlasaTest(1);
            klas.Druga();
            klas.TestMetoda(1);

        LinkedList<double> liczby = new LinkedList<double>();
        liczby.AddFirst(3);
        liczby.AddFirst(3.5);
        liczby.AddFirst(4);
        liczby.AddFirst(4.5);
        liczby.AddFirst(5);

        foreach (var element in liczby)
        {
            Console.WriteLine(element);
        }
        List<Bohater> bohaterzy = new List<Bohater>();
        bohaterzy.Add(new Bohater(500));
        bohaterzy.Add(new Bohater(100));
        bohaterzy.Add(new Elf(80, "Czarodziej"));
        bohaterzy.Add(new Elf(453, "Łucznik"));
        bohaterzy.Add(new Ork(123, 5000));
        bohaterzy.Add(new Ork(823, 1400));

        bohaterzy.Sort();

        foreach (var element in bohaterzy)
        {
            Console.WriteLine(element);
        }
        Sport sport1 = Sport.Utworz("Zawody1");

        string wejscie = Console.ReadLine();
        double liczba = 0;
        Double.TryParse(wejscie, out liczba);
        Bohater boh = new Bohater(2);

        var dict = new Dictionary<string, List<int>>
{
	{"sadasd", new List<int>{101, 102, 103}},
	{"sadasd", new List<int>{201, 202, 203}},       
};
            
            
        Console.ReadKey();
        }
    }
}
