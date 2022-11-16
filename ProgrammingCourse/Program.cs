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

            Console.ReadKey();
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
                    kurzus.Add(new Kurzus(tmp[0], Convert.ToChar(tmp[1]), Convert.ToInt32(tmp[2]), tmp[3], Convert.ToInt32(tmp[4]), Convert.ToInt32(tmp[5]), Convert.ToInt32(tmp[6]), Convert.ToInt32(tmp[7])));
                }
            }
        }
    }
}
