using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_2033
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_2033(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5)
        {
            calcul(Convert.ToBoolean(Saisie1));
            calcul(Convert.ToBoolean(Saisie2));
            calcul(Convert.ToBoolean(Saisie3));
            calcul(Convert.ToBoolean(Saisie4));
            calcul(Convert.ToBoolean(Saisie5));

            Score_ObjS = Score;
            if (Score >= 15) { Score = 15; };
            Scores_Joueur = Score;
        }

        private void calcul(Boolean Donne)
        {
            if (Donne == true) { Score += 3; };            
        }
    }
}