﻿using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_1031
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_1031(String Saisie1, String Saisie2, String Saisie3, String Saisie4)
        {
            if (Saisie1 != "") { if (Convert.ToInt16(Saisie1) >= 1) { Calcul(Convert.ToInt16(Saisie1)); }; };
            if (Saisie2 != "") { if (Convert.ToInt16(Saisie2) >= 1) { Calcul(Convert.ToInt16(Saisie2)); }; };
            if (Saisie3 != "") { if (Convert.ToInt16(Saisie3) >= 1) { Calcul(Convert.ToInt16(Saisie3)); }; };
            if (Saisie4 != "") { if (Convert.ToInt16(Saisie4) >= 1) { Calcul(Convert.ToInt16(Saisie4)); }; };

            Score_ObjS = Score;
            if (Score >= 15) { Score = 15; };
            Scores_Joueur = Score;
        }

        private void Calcul(int Donné)
        {
            if (Donné >= 1 && Donné <=3) { Score += Donné ; return; };
            if (Donné >= 4) { Score += 3; return; };
        }

    }
}

