using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_SM_BA_114
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJC_SM_BA_114(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5)
        {
            VALEUR(Saisie1);
            VALEUR(Saisie2);
            VALEUR(Saisie3);
            VALEUR(Saisie4);
            VALEUR(Saisie5);

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
