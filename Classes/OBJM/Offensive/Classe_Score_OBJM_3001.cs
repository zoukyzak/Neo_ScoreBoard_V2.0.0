using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_3001
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_3001(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6, String Saisie7, String Saisie8, String Saisie9, String Saisie10, String Saisie11, String Saisie12)
        {
            if (Saisie1 != "" && Saisie2 != "" && Saisie3 != "")
            {
                calcul(Saisie1, Convert.ToInt32(Saisie2), Convert.ToInt32(Saisie3));
            }
            if (Saisie4 != "" && Saisie5 != "" && Saisie6 != "")
            {
                calcul(Saisie4, Convert.ToInt32(Saisie5), Convert.ToInt32(Saisie6));
            }
            if (Saisie7 != "" && Saisie8 != "" && Saisie9 != "")
            {
                calcul(Saisie7, Convert.ToInt32(Saisie8), Convert.ToInt32(Saisie9));
            }
            if (Saisie10 != "" && Saisie11 != "" && Saisie12 != "")
            {
                calcul(Saisie10, Convert.ToInt32(Saisie11), Convert.ToInt32(Saisie12));
            }

            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void calcul(string Donne1, int Donne2, int Donne3)
        {
            if (Donne1 == "true")
            {
                if (Donne2 > Donne3)
                {
                    Score += 5;
                }
                return;
            }
            else
            {
                return;
            }
        }
    }
}
