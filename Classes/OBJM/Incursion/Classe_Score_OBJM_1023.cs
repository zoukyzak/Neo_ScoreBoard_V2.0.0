using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_1023
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_1023(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6, String Saisie7, String Saisie8, String Saisie9, String Saisie10, String Saisie11, String Saisie12, String Saisie13, String Saisie14, String Saisie15, String Saisie16, String Saisie17, String Saisie18, String Saisie19, String Saisie20)
        {
            if (Saisie1 == "true")
            {
                Calcul(1);
            }
            if (Saisie2 == "true")
            {
                Calcul(2);
            }
            if (Saisie3 == "true")
            {
                Calcul(4);
            }
            if (Saisie4 == "true")
            {
                Calcul(8);
            }
            if (Saisie5 == "true")
            {
                Calcul(1);
            }
            if (Saisie6 == "true")
            {
                Calcul(2);
            }
            if (Saisie7 == "true")
            {
                Calcul(4);
            }
            if (Saisie8 == "true")
            {
                Calcul(8);
            }
            if (Saisie9 == "true")
            {
                Calcul(1);
            }
            if (Saisie10 == "true")
            {
                Calcul(2);
            }
            if (Saisie11 == "true")
            {
                Calcul(4);
            }
            if (Saisie12 == "true")
            {
                Calcul(8);
            }
            if (Saisie13 == "true")
            {
                Calcul(1);
            }
            if (Saisie14 == "true")
            {
                Calcul(2);
            }
            if (Saisie15 == "true")
            {
                Calcul(4);
            }
            if (Saisie16 == "true")
            {
                Calcul(8);
            }
            if (Saisie17 == "true")
            {
                Calcul(1);
            }
            if (Saisie18 == "true")
            {
                Calcul(2);
            }
            if (Saisie19 == "true")
            {
                Calcul(4);
            }
            if (Saisie20 == "true")
            {
                Calcul(8);
            }
            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void Calcul(int Donné)
        {
            Score += Donné;
        }

    }
}
