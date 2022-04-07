using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_2032
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_2032(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6, String Saisie7, String Saisie8, String Saisie9, String Saisie10)
        {
            calcul(Saisie1, Saisie6);
            calcul(Saisie2, Saisie7);
            calcul(Saisie3, Saisie8);
            calcul(Saisie4, Saisie9);
            calcul(Saisie5, Saisie10);
            Score_ObjS = Score;
            if (Score >= 15) { Score = 15; };
            Scores_Joueur = Score;
        }

        private void calcul(String Donne1, String Donne2)
        {
            if (Donne1 == "true" && Donne2 == "true")
            {
                Score += 3;
                return;
            }
            if (Donne1 == "true" || Donne2 == "true")
            {
                Score += 2;
                return;
            }
            else
            {
                return;
            }
        }
    }
}
