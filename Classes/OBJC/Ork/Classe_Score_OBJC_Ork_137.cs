﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_Ork_137
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;
        public Classe_Score_OBJC_Ork_137(string Saisie1, string Saisie2, string Saisie3, string Saisie4, string Saisie5, string Saisie6, string Saisie7, string Saisie8, string Saisie9, string Saisie10, string Saisie11, string Saisie12, string Saisie13, string Saisie14, string Saisie15, string CA)
        {
            Comparatif(Saisie1, Saisie6, Saisie11, CA);
            Comparatif(Saisie2, Saisie7, Saisie12, CA);
            Comparatif(Saisie3, Saisie8, Saisie13, CA);
            Comparatif(Saisie4, Saisie9, Saisie14, CA);
            Comparatif(Saisie5, Saisie10, Saisie15, CA);

            Score_ObjS = Score;
            if (Score >= 15) { Score = 15; };
            Scores_Joueur = Score;
        }

        private void Comparatif(string Donnée1, string Donnée2, String Donnée3, String CA)
        {
            int compta = 0;
            int Val = 3;
            if (CA == "Nephilim") { Val = 2; };
                if (Donnée1 == "true") { compta += Val;  };
                if (Donnée2 == "true") { compta += Val;  };
                if (Donnée3 == "true") { compta += Val;  };
            if (compta >= 5) { compta = 5; };
            Score += compta;
        }
    }
}
