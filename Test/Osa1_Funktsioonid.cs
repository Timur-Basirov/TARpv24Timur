using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TARpv24Timur
{
    internal class Osa1_Funktsioonid
    {
        public static float Kalkulaator(float arv1, float arv2)
        {
            float k = arv1 * arv2;
            return k;
        }
        public static string Kuu_nimetus(int kuu_nr)
        {
            string kuu = "";
            switch (kuu_nr)
            {
                case 1: kuu = "Jaanuar"; break;
                case 2: kuu = "Veebruar"; break;
                case 3: kuu = "Märts"; break;
                case 4: kuu = "Aprill"; break;
                case 5: kuu = "Mai"; break;
                case 6: kuu = "Juuni"; break;
                case 7: kuu = "Juuli"; break;
                case 8: kuu = "August"; break;
                case 9: kuu = "September"; break;
                case 10: kuu = "Oktoober"; break;
                case 11: kuu = "November"; break;
                case 12: kuu = "Detsember"; break;

                default:
                    kuu = "Viga";
                    break;
            }
            return kuu;
        }
        public static string Hooaeg(int kuu_nr)
        {
            string hoo = "";
            if (kuu_nr==1 || kuu_nr==2 || kuu_nr==12)
            {
                hoo = "Talv";
            }
            else if (kuu_nr>2 && kuu_nr<6) //3,4,5
            {
                hoo = "Kevad";
            }
            else if (kuu_nr > 5 && kuu_nr < 9) //6,7,8
            {
                hoo = "Suvi";
            }
            else if (kuu_nr > 8 && kuu_nr < 12) //9,10,11
            {
                hoo = "Sügis";
            }
            else
            {
                hoo = "???";
            }
                return hoo;
        }

        public static string Piletid(int age)
        {
            string info = "???";
            if (age > 0 && age < 6)
            {
                info = "Tasuta Pilet";
            }
            else if (age > 5 && age < 15)
            {
                info = "Lapse pilet";

            }
            else if (age > 14 && age < 66)
            {
                info = "Tavaline pilet (täishind)";
            }
            else if (age > 65 && age < 100)
            {
                info = "Sooduspilet";
            }

            else
            {
                info = "Tekkis viga, vanus on väiksem kui 0 või suurem kui 100.";
            }
            return info;
        }
        public static string temperatuur(int temp)
        {
            string info = "???";
            if (temp < 18)
            {
                info = "külm";
            }
            else if (temp > 24)
            {
                info = "Kuum";
            }
            else
            { 
                info = "Just õige";
            }
            return (info);

        }
        public static string mees_pikkus(int pikkus)
        {
            string info = "???";
            if (pikkus<170)
            {
                info = "низкий";
            }
            if (pikkus > 183)
            {
                info = "высокий";

            }
            else 
            {
                info = "средний";
            }
            return (info);
        }
        public static string naine_pikkus(int pikkus)
        {  
            string info = "???";
            if (pikkus < 160)
            {
                info = "низкий";
            }
            if (pikkus > 172)
            {
                info = "высокий";

            }
            else
            {
                info = "средний";
            }
            return (info);
        }  
    }
}
