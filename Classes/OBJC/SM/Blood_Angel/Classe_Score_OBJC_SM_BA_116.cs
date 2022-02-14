using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_SM_BA_116
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJC_SM_BA_116(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6, String Saisie7, String Saisie8, String Saisie9, String Saisie10)
        {
            VALEUR(Saisie1, Saisie2);
            VALEUR(Saisie3, Saisie4);
            VALEUR(Saisie5, Saisie6);
            VALEUR(Saisie7, Saisie8);
            VALEUR(Saisie9, Saisie10);

            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void VALEUR(string Donne1, string Donne2)
        {
            if (Donne1 != "" & Donne2 != "")
            {
                if (Convert.ToInt32(Donne1) < Convert.ToInt32(Donne2))
                {
                    Score += 4;
                    return;
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }
    }
}
