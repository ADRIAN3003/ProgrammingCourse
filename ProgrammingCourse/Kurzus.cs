using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse
{
    class Kurzus
    {
        public string Neve { get; private set; }

        public char Neme { get; private set; }

        public int Finanszirozas { get; private set; }

        public int Befizetett { get; private set; }

        public List<int> Szazalek { get; private set; }

        public const int Honap = 5;



        public Kurzus(string neve, char neme, int finanszirozas, int befizetett, int prog, int graf, int architekt, int mestint)
        {
            Neve = neve;
            Neme = neme;
            Finanszirozas = finanszirozas;
            Befizetett = befizetett;
            Szazalek = new List<int>();
            Szazalek.Add(prog);
            Szazalek.Add(graf);
            Szazalek.Add(architekt);
            Szazalek.Add(mestint);
        }
    }
}
