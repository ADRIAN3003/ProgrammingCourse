using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgrammingCourse
{
    class Program
    {
        static List<Kurzus> kurzus = new List<Kurzus>();
        static void Main(string[] args)
        {
            MasodikFeladat();
            HarmadikFeladat();
            NegyedikFeladat();
            OtodikFeladat();
            HatodikFeladat();

            Console.ReadKey();
        }

        private static void HatodikFeladat()
        {
            Console.WriteLine("6. feladat:\n\tÁllásajánlatot kap:");
            int max = 2;
            int jelenleg = 0;
            foreach (var item in kurzus)
            {
                if (item.Finanszirozas == 2 && item.Befizetett == 0)
                {
                    bool elert = true;

                    foreach (var szazalek in item.Szazalek)
                    {
                        if (szazalek < 51 && jelenleg <= max)
                        {
                            elert = false;
                        }
                    }

                    if (elert)
                    {
                        jelenleg++;
                        Console.WriteLine("\t" + item.Neve + "\t" + item.Szazalek.Sum());
                    }
                }
            }
        }

        private static void OtodikFeladat()
        {
            Console.WriteLine("5. feladat:\n\tA következő diákoknak van tandíjelmaradása:");
            foreach (var item in kurzus)
            {
                if (item.Finanszirozas == 0 && item.Befizetett < 2600)
                {
                    Console.WriteLine("\t" + item.Neve);
                } 
                else if (item.Finanszirozas == 1 && Kurzus.Honap * 312 > item.Befizetett)
                {
                    Console.WriteLine("\t" + item.Neve);
                } 
                else if (item.Finanszirozas == 2 && Kurzus.Honap > 10 && item.Befizetett < 4000)
                {
                    Console.WriteLine("\t" + item.Neve);
                }
            }
        }

        private static void NegyedikFeladat()
        {
            Console.WriteLine("4. feladat:");
            Console.WriteLine("\tFiúk átlagteljesítménye: " + Math.Round(kurzus.Where(x => x.Neme == 'm').Average(y => y.Szazalek.Average()), 2) + "%");
            Console.WriteLine("\tLányok átlagteljesítménye: " + Math.Round(kurzus.Where(x => x.Neme == 'f').Average(y => y.Szazalek.Average()), 2) + "%");
        }

        private static void HarmadikFeladat()
        {
            Console.WriteLine("3. feladat:\n\tA tanfolyamra " + kurzus.Count + " fő iratkozott be.");
        }

        private static void MasodikFeladat()
        {
            using (StreamReader sr = new StreamReader("coursedata.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string[] tmp = sr.ReadLine().Split(';');
                    kurzus.Add(new Kurzus(tmp[0], Convert.ToChar(tmp[1]), Convert.ToInt32(tmp[2]), Convert.ToInt32(tmp[3].TrimStart('$')), Convert.ToInt32(tmp[4]), Convert.ToInt32(tmp[5]), Convert.ToInt32(tmp[6]), Convert.ToInt32(tmp[7])));
                }
            }
        }
    }
}
