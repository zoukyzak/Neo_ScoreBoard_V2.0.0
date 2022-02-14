using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_1033
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_1033(String Saisie1, String Saisie2, String Saisie3, String Saisie4)
        {
            int Quart = 0;
            if (Saisie1 == "true")
            {
                Quart += 1;
            }
            if (Saisie2 == "true")
            {
                Quart += 1;
            }
            if (Saisie3 == "true")
            {
                Quart += 1;
            }
            if (Saisie4 == "true")
            {
                Quart += 1;
            }
            if (Quart >= 1)
            {
                Score += 3;
            }
            if (Quart >= 2)
            {
                Score += 3;
            }
            if (Quart >= 3)
            {
                Score += 4;
            }
            if (Quart >= 4)
            {
                Score += 5;
            }
            Score_ObjS = Score;
            Scores_Joueur = Score;
        }
    }
}
