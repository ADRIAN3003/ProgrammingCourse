﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Properties
{
    class Kurzus
    {
        public string Neve { get; private set; }

        public char Neme { get; private set; }

        public int Finanszirozas { get; private set; }

        public int Befizetett { get; private set; }

        public int Prog { get; private set; }

        public int Graf { get; private set; }

        public int Architekt { get; private set; }

        public int Mestint { get; private set; }

        public Kurzus(string neve, char neme, int finanszirozas, int befizetett, int prog, int graf, int architekt, int mestint)
        {
            Neve = neve;
            Neme = neme;
            Finanszirozas = finanszirozas;
            Befizetett = befizetett;
            Prog = prog;
            Graf = graf;
            Architekt = architekt;
            Mestint = mestint;
        }
    }
}
