using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TARpv24Timur
{
    public class Osa3_Funktsioonid
    {
        internal class Inimene
        {
            public string eesnimi;
            public int synniaasta = 2000;

            public Inimene() { }

            public Inimene(string eesnimi)
            {
                this.eesnimi = eesnimi;
            }
            //public static double[] Tekstist_arvud()
            //{
            //    Console.WriteLine("Sisesta arvud koma või tühikuga eraldatult: ");
            //    string sisend = Console.ReadLine();
            //    char[] eraldajad = new char[] { ' ' };

            //    string[] osad = sisend.Split(eraldajad, StringSplitOptions.RemoveEmptyEntries);

            //    double[] arvud = new double[osad.Length];
            //    for (int i = 0; i < osad.Length; i++)
            //    {
            //        arvud[i] = Convert.ToDouble(osad[i]);
            //    }
            //    return arvud;
            //}
            //public static Tuple<double, double, double> AnalüüsiArve(double[] arvud)
            //{
            //    double summa = arvud.Sum();
            //    double keskmine = arvud.Average();
            //    double korrutis = 1;
            //    foreach (double arv in arvud)
            //    {
            //        korrutis *= arv;
            //    }

            //    return Tuple.Create(summa, keskmine, korrutis);
            //}
            //public static int[] GenereeriRuudud(int min,int max)
            //{
            Random rnd = new Random();
            //int n = rnd.Next(min, max);
            //int m = rnd.Next(min, max);
            //Console.WriteLine(m);
            //Console.WriteLine(n);
            //Console.WriteLine(Math.Min(n, m));
            //int[] massive = new int[Math.Abs(m-n)];
            //int k = 0;

            //if (m<n)
            //{
            //    for (int i =m; i<=n ; i++)
            //    {
            //        massive[k] = i * 1;
            //        k++;

            //    }
            //}
            //else
            //{
            //    for (int i = n; i<=m ;i++)
            //    {
            //        massive[k] = i * 1;
            //        k++;
            //    }
            //}
            //return massive;

        }
    }
}

