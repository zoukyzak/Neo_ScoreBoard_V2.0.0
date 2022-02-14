using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_SM_111
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJC_SM_111(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5)
        {
            calcul(Saisie1);
            calcul(Saisie2);
            calcul(Saisie3);
            calcul(Saisie4);
            calcul(Saisie5);
            Score_ObjS = Score;
            Scores_Joueur = Score;
        }

        private void calcul(string Donne1)
        {
            if (Donne1 == "true")
            {
                Score += 3;
                return;
            }
            else
            {
                return;
            }
        }
    }
}
