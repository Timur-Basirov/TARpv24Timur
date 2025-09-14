using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StartClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.OutputEncoding = Encoding.UTF8;

            Sonastik sonastik = new Sonastik();
            bool edasi = true;

            while (edasi)
            {
                Console.WriteLine("\nVali tegevus:");
                Console.WriteLine("1 - Otsi pealinna maakonna järgi");
                Console.WriteLine("2 - Otsi maakonda pealinna järgi");
                Console.WriteLine("3 - Lisa uus maakond ja pealinn");
                Console.WriteLine("4 - Mang");
                Console.WriteLine("0 - Exit");

                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                        Console.Write("Sisesta maakonna nimi: ");
                        string maakond = Console.ReadLine();
                        string pealinn = sonastik.LeiaPealinn(maakond);
                        if (pealinn != null)
                            Console.WriteLine($"Maakonna {maakond} pealinn on {pealinn}");
                        else
                            Console.WriteLine("Sellist maakonda sõnastikus ei ole.");
                        break;

                    case "2":
                        Console.Write("Sisesta pealinna nimi: ");
                        string linn = Console.ReadLine();
                        string maakondName = sonastik.LeiaMaakond(linn);
                        if (maakondName != null)
                            Console.WriteLine($"{linn} on maakonnas {maakondName}");
                        else
                            Console.WriteLine("Sellist pealinna sõnastikus ei ole.");
                        break;

                    case "3":
                        Console.Write("Sisesta uus maakonna nimi: ");
                        string uusMaakond = Console.ReadLine();
                        Console.Write("Sisesta uus pealinna nimi: ");
                        string uusPealinn = Console.ReadLine();
                        sonastik.LisaMaakond(uusMaakond, uusPealinn);
                        break;

                    case "4":
                        sonastik.TestiTeadmisi();
                        break;

                    case "0":
                        edasi = false;
                        break;

                    default:
                        Console.WriteLine("Vale valik, proovi uuesti.");
                        break;
                }
            }
            // 4.Osa Failid  

            //Osa4_funktsioonid.Kirjuta_failisse();
            //Console.WriteLine("Faili nimi: ");
            //string failinimi = Console.ReadLine();
            //Osa4_funktsioonid.Failide_lugemine(failinimi);

            //// Ülesanne 2
            //double[] arvud = Osa3_funktsioonid.Tekstist_arvud();
            //var tulemus = Osa3_funktsioonid.AnalüüsiArve(arvud);
            //Console.WriteLine($"Summa: {tulemus.Item1:F2}, Keskmine: {tulemus.Item2:F2}, Korrutis: {tulemus.Item3:F2}");




            // 3. Osa Massiivid, List, Kordused
            //List<string> nimed = new List<string>();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"{i + 1}. Nimi: ");
            //    nimed.Add(Console.ReadLine());
            //}
            //foreach (string nimi in nimed)
            //{
            //    Console.WriteLine(nimi);
            //}
            //int[] arvud = new int[10];
            //int j = 0;
            //while (j<10)
            //{
            //    Console.WriteLine(j + 1);
            //    arvud[j] = rnd.Next(1, 101);
            //    j++;
            //}
            //foreach (int arv in arvud)
            //{
            //    Console.WriteLine(arv);
            //}

            //List<Isik> isikud = new List<Isik>();
            //j = 0;
            //do
            //{
            //    Console.WriteLine(j + 1);
            //    Isik isik = new Isik();
            //    Console.Write("Eesnimi: ");
            //    isik.eesnimi = Console.ReadLine();
            //    isikud.Add(isik);
            //    j++;
            //} while (j < 10);
            //isikud.Sort((x, y) => x.eesnimi.CompareTo(y.eesnimi));
            //Console.WriteLine($"Kokku on {isikud.Count()} isikud");
            //foreach (Isik isik in isikud)
            //{
            //    isik.Prindi_andmed();
            //}
            //Console.WriteLine($"Kolmandal kohal on {isikud[2].eesnimi} isik");



            ////2. Osa Valikud
            //int kuu_number=rnd.Next(1,12);
            //string nimetus = Osa1_funktsioonid.Kuu_nimetus(kuu_number);
            //Console.WriteLine( $"Nr: {kuu_number}-{nimetus}");
            //Console.WriteLine("Kas tahad dekodeerida arv->nimetusse?");
            //string vastus=Console.ReadLine();
            //if (vastus.ToLower() != "jah")
            //{
            //    Console.WriteLine("Ei taha, siis ei taha");
            //}
            //else
            //{
            //    try
            //    {
            //        Console.Write("Nr: ");
            //        kuu_number=int.Parse(Console.ReadLine());
            //        Console.WriteLine(Osa1_funktsioonid.Hooaeg(kuu_number));
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //    }  
            //}


            ////I. Osa Andmetüübid, Alamfunktsioon
            //Console.OutputEncoding = Encoding.UTF8;

            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.DarkRed;

            //Console.WriteLine("Tere tulemast! Mis on simu nimi?");
            //string tekst=Console.ReadLine();
            //Console.WriteLine($"{tekst}, Rõõm näha!");
            //int a = 1000;
            //char taht = 'A';
            //Console.Write($"Esimene arv on {a}, Sisesta b=...");
            //int b=int.Parse(Console.ReadLine());
            //Console.WriteLine("Esimene arv on {0}, Sisesta {1}. Summa on {2}",a,b,a +b);
            //Console.WriteLine("Ujukomaarv");
            //double d=double.Parse(Console.ReadLine());
            //Console.WriteLine(d);
            //float f=float.Parse(Console.ReadLine());
            //Console.WriteLine(f);
            //bool t = true;

            //a = rnd.Next(-100,200);
            //Console.WriteLine(a);
            //float vastus=Osa1_funktsioonid.Kalkulaator(f,a);
            //Console.WriteLine($"Kalkulaatori tulemus: {vastus}");

        }
    }

}
