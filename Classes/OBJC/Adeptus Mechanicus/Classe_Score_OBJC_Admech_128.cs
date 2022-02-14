using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_Admech_128
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJC_Admech_128(String Saisie1)
        {
            if (Saisie1 != "")
            {
                VALEUR(Convert.ToInt32(Saisie1));
            }

            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void VALEUR(int Donne1)
        {

            Score = (3 * Donne1);
            return;
        }
    }
}
