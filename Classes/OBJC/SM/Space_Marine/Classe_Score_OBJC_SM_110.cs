using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_SM_110
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJC_SM_110(String Saisie1, String Saisie2, String Saisie3, string CA)
        {
            if (Saisie1 != "" && CA == "Nachmund")
            {
                calcul(Convert.ToInt32(Saisie1));
            }
            if (Saisie1 != "" && CA == "Nephilim")
            {
                int Donne1 = Convert.ToInt32(Saisie1);
                if (Donne1 >= 1)
                {
                    Donne1 = Donne1 * 2;
                    if (Donne1 >= 5)
                    {
                        Donne1 = 5;
                    }
                    Score += Donne1;
                }                
            }
            if (Saisie2 != "")
            {
                calcul(Convert.ToInt32(Saisie2));
            }
            if (Saisie3 != "")
            {
                calcul(Convert.ToInt32(Saisie3));
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
            if (Donne1 >= 1)
            {
                if (Donne1 >= 5)
                {
                    Donne1 = 5;
                }
                Score += (Donne1);
                return;
            }
            else
            {
                return;
            }
        }
    }
}
