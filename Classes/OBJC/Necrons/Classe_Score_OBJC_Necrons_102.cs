using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_Necrons_102
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJC_Necrons_102(String Saisie1, String Saisie2, String Saisie3, String Saisie4, string Saisie5)
        {
            if (Saisie1 != "")
            {
                calcul(Convert.ToInt32(Saisie1));
            }
            if (Saisie2 != "")
            {
                calcul(Convert.ToInt32(Saisie2));
            }
            if (Saisie3 != "")
            {
                calcul(Convert.ToInt32(Saisie3));
            }
            if (Saisie4 != "")
            {
                calcul(Convert.ToInt32(Saisie4));
            }
            if (Saisie5 != "")
            {
                calcul(Convert.ToInt32(Saisie5));
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
                Score += 2;
                return;
            }
            if (Donne1 == 2)
            {
                Score += 3;
                return;
            }
            if (Donne1 == 3)
            {
                Score += 5;
                return;
            }
            else
            {
                return;
            }
        }
    }
}
