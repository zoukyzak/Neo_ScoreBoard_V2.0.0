using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_3002
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_3002(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6, String Saisie7, String Saisie8, String Saisie9, String Saisie10)
        {
            if (Saisie1 == "true" && Saisie2 != "")
            {
                calcul(Convert.ToInt32(Saisie2));
            }
            if (Saisie3 == "true" && Saisie4 != "")
            {
                calcul(Convert.ToInt32(Saisie4));
            }
            if (Saisie5 == "true" && Saisie6 != "")
            {
                calcul(Convert.ToInt32(Saisie6));
            }
            if (Saisie7 == "true" && Saisie8 != "")
            {
                calcul(Convert.ToInt32(Saisie8));
            }
            if (Saisie9 == "true" && Saisie10 != "")
            {
                calcul(Convert.ToInt32(Saisie10));
            }

            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void calcul(int Donne1)
        {
            if (Donne1 == 1)
            {
                Score += 4;
                return;
            }
            if (Donne1 == 2)
            {
                Score += 8;
                return;
            }
            else
            {
                return;
            }
        }
    }
}
