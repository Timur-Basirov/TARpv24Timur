using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv24Timur
{
    internal class StartClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Tere tulemast! Mis on sinu nimi?");
            string tekst=Console.ReadLine();
            Console.WriteLine($"{tekst}, Rõõm näha!");
            Console.Clear();
            int a = 1000;
            char taht = 'A';
            Console.Write($"Esimene arv on {a}, Sisesta b=...");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine("Esimene arv on {0}, Sisesta {1}. Summa on {2}",a,b,a+b);
            Console.Clear() ;
            Console.WriteLine("Ujukomaarv");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine(d);
            Console.WriteLine("Float");
            float f = float.Parse(Console.ReadLine());
            Console.WriteLine(f);
            bool t = true;

            Console.Clear();

            Random rnd = new Random();
            a = rnd.Next(-100,200);
            Console.WriteLine(a);

            float vastus = Osa1_Funktsioonid.Kalkulaator(f,a);
            Console.WriteLine($"Kalkulaatori tulemus: {vastus}");
        }
    }
}
