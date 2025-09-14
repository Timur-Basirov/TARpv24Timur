using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Osa4_funktsioonid
    {
        public static void Kirjuta_failisse()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt"); //@"..\..\..\Kuud.txt"
                StreamWriter text = new StreamWriter(path, true); // true = lisa lõppu
                Console.WriteLine("Sisesta mingi tekst: ");
                string lause = Console.ReadLine();
                text.WriteLine(lause);
                text.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }
        }
        public static void Failide_lugemine(string failinimi)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, failinimi);
                StreamReader text = new StreamReader(path);
                string laused = text.ReadToEnd();
                text.Close();
                Console.WriteLine(laused);
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }
        }
        public static List<string> Ridade_lugemine(string failinimi)
        {
            List<string> read = new List<string>();
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, failinimi);
                StreamReader text = new StreamReader(path);
                while (!text.EndOfStream)
                {
                    string rida = text.ReadLine();
                    read.Add(rida);
                }
                text.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }
            return read;
        }
    }
}
