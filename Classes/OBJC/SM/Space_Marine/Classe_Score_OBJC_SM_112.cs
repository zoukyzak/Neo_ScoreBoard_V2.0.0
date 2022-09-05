using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_SM_112
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJC_SM_112(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6, String Saisie7, String Saisie8, String Saisie9, String Saisie10, String Saisie11, String Saisie12, String Saisie13, String Saisie14, String Saisie15,String CA)
        {
            VALEUR(Saisie1);
            VALEUR(Saisie2);
            VALEUR(Saisie3);
            VALEUR(Saisie4);
            VALEUR(Saisie5);
            HONNEUR(Saisie6);
            HONNEUR(Saisie7);
            HONNEUR(Saisie8);
            HONNEUR(Saisie9);
            HONNEUR(Saisie10);
            DEVOIR(Saisie11 , CA);
            DEVOIR(Saisie12 , CA);
            DEVOIR(Saisie13 , CA);
            DEVOIR(Saisie14 , CA);
            DEVOIR(Saisie15 , CA);
            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void VALEUR(string Donne1)
        {
            if (Donne1 == "true")
            {
                Score += 1;
                return;
            }
            else
            {
                return;
            }
        }
        private void HONNEUR(string Donne2)
        {
            if (Donne2 == "true")
            {
                Score += 1;
                return;
            }
            else
            {
                return;
            }
        }
        private void DEVOIR(string Donne3, String CA)
        {
            if (Donne3 == "true")
            {
                if (CA == "Nachmund")
                {
                    Score += 2;
                }
                if (CA == "Nephilim")
                {
                    Score++;
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
