﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_Ork_139
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;
        public Classe_Score_OBJC_Ork_139(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5)
        {
            Calcul(Saisie1);
            Calcul(Saisie2);
            Calcul(Saisie3);
            Calcul(Saisie4);
            Calcul(Saisie5);

            Score_ObjS = Score;
            if (Score >= 15) { Score = 15; };
            Scores_Joueur = Score;
        }

        private void Calcul(String D)
        {
            if (D != "") { if (Convert.ToInt32(D) >= 2) { Score += 3; }; };
            if (D != "") { if (Convert.ToInt32(D) == 4) { Score += 2; }; };
        }
    }
}
