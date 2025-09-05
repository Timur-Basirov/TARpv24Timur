using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TARpv24Timur
{
    internal class StartClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Tere,mis on sinu nimi?");
            string nimi = Console.ReadLine();
            if (nimi.ToLower() == "juku")
            {
                Console.WriteLine("Oi,Tsau Juku, lähme kinos");
                int age = rnd.Next(-1, 100);
                string pilet_info = Osa1_Funktsioonid.Piletid(age);
                Console.WriteLine($"Oi, Juku, sul on {age} aastat vana, Me võime osta - {pilet_info}");
            }
            else
            {
                Console.WriteLine($"Sinu nimi on {nimi.ToLower()}, aga ma ootan Juku");
            }

            Console.WriteLine("Mis on sinu nimi?");
            string nimi1 = Console.ReadLine();
            Console.WriteLine("Nimetage sõbra nimi");
            string nimi2 = Console.ReadLine();
            Console.WriteLine($"Õnnitlen teid {nimi1} ja {nimi2}, täna istute te koos!");

            Console.WriteLine("Nimetage esimese seina pikkus:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nimetage teise seina pikkus:");
            int b = int.Parse(Console.ReadLine());

            int vastus1 = a * b;

            Console.WriteLine($"Sinu põranda pindala on {vastus1}m^2");

            Console.WriteLine("Kas soovite, et ma aitaksin teil remondikulud välja arvutada? (Jah või Ei?)");
            string KasutajaVastus = Console.ReadLine();
            if (KasutajaVastus.ToLower() == "jah")
            {
                Console.Write("Nimetage 1 ruutmeetri põranda hind");
                int maksus = int.Parse(Console.ReadLine());
                vastus1 = vastus1 * maksus;
                Console.WriteLine($"Põranda vahetamise maksumus on {vastus1}");
            }
            else if (KasutajaVastus.ToLower() == "ei")
            {
                Console.WriteLine("Ei taha, siis ei taha.");
            }
            else
            {
                Console.WriteLine("Järgmine kord vali jah või ei");
            }

            Console.WriteLine("nimetage hind ja ma arvestan teile 30% allahindlust!");
            decimal hind = Console.Read();
            int percent = 30;
            decimal soodus = hind * percent / 100;
            decimal lhind = hind - soodus;
            Console.WriteLine($"Soodushind on {lhind}");


            Console.WriteLine("Mis temperatuur on sinu korteris?");
            int temp = int.Parse(Console.ReadLine());

            string temp_info = Osa1_Funktsioonid.temperatuur(temp);
            Console.WriteLine($"Sinu toas - {temp_info}");

            Console.WriteLine("Mis sugu sa oled?");
            string sugu = Console.ReadLine();
            if (sugu.ToLower() == "mees")
            {
                Console.WriteLine("Kui pikk sa oled?");
                int pikkus = int.Parse(Console.ReadLine());
                string pikkus_info = Osa1_Funktsioonid.mees_pikkus(pikkus);
                Console.WriteLine($"Sinu pikkus on {pikkus} ja sina on - {pikkus_info}");

            }

            if (sugu.ToLower() == "naine")
            {
                Console.WriteLine("Kui pikk sa oled?");
                int pikkus = int.Parse(Console.ReadLine());
                string pikkus_info = Osa1_Funktsioonid.naine_pikkus(pikkus);
                Console.WriteLine($"Sinu pikkus on {pikkus} ja sina on - {pikkus_info}");
            }
            else
            {
                Console.WriteLine("Sellist asja pole olemas.");
            }



            ////teine osa valikud
            //int kuu_number=rnd.Next(1,12);
            //string nimetus=Osa1_Funktsioonid.Kuu_nimetus(kuu_number);
            //Console.WriteLine($"Nr: {kuu_number} - {nimetus}");
            //Console.WriteLine("Kas tahad dekodeerida arv->nimetusse?");
            //string vastus = Console.ReadLine();
            //if (vastus.ToLower() != "jah")
            //{
            //    Console.WriteLine("Ei taha, siis ei taha");

            //}
            //else
            //{
            //    try
            //    {
            //        Console.Write("Nr:");
            //        kuu_number = int.Parse(Console.ReadLine());
            //        Console.WriteLine(Osa1_Funktsioonid.Hooaeg(kuu_number));
            //    }
            //    catch (Exception e) 
            //    {
            //        Console.WriteLine(e);
            //    }
            //}

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.Blue;

            //Console.WriteLine("Tere tulemast! Mis on sinu nimi?");
            //string tekst=Console.ReadLine();
            //Console.WriteLine($"{tekst}, Rõõm näha!");
            //Console.Clear();
            //int a = 1000;
            //char taht = 'A';
            //Console.Write($"Esimene arv on {a}, Sisesta b=...");
            //int b=int.Parse(Console.ReadLine());
            //Console.WriteLine("Esimene arv on {0}, Sisesta {1}. Summa on {2}",a,b,a+b);
            //Console.Clear() ;
            //Console.WriteLine("Ujukomaarv");
            //double d = double.Parse(Console.ReadLine());
            //Console.WriteLine(d);
            //Console.WriteLine("Float");
            //float f = float.Parse(Console.ReadLine());
            //Console.WriteLine(f);
            //bool t = true;

            //Console.Clear();

            //a = rnd.Next(-100,200);
            //Console.WriteLine(a);

            //float vastus = Osa1_Funktsioonid.Kalkulaator(f,a);
            //Console.WriteLine($"Kalkulaatori tulemus: {vastus}");
        }
    }
}
