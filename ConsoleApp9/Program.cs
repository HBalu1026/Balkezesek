using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
namespace ConsoleApp9
{
    internal class Program
    {
        public static string Mittomen(string bemenet)
        {
            string kimenet = "";
            return kimenet;
        }


        static void Main(string[] args)
        {
            string[] fajl = File.ReadAllLines("balkezesek.csv");
            
            //3
            Console.WriteLine("3.feladat: " + (fajl.Length - 1));

            //4
            Console.WriteLine("4.feladat:");
            for (int i = 0; i < fajl.Length; i++)
            {
                string[] splittelt = fajl[i].Split(' ');
                if (Convert.ToInt32(splittelt[2]) <= 1999)
                {
                    Console.WriteLine("\t" + splittelt[0] + ", " + (Convert.ToInt32(splittelt[4]) * 2,54) + " cm");
                }
            }

            //5


            //6
            double osszes = 0;
            for (int i = 0; i < fajl.Length; i++)
            {
                string[] splittelt = fajl[i].Split(' ');
                osszes += Convert.ToInt32(splittelt[3]);
            }




            Console.ReadKey();
        }
    }
}