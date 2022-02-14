using System;

namespace CPV9.Classes
{
    class Classe_Score_Peinture
    {
        public int Scores_Joueur = 10;
        public int Score_ObjS { get; set; }

        private int Score = 10;

        public Classe_Score_Peinture(String Saisie1)
        {
            if (Saisie1 != "")
            {
                if (Convert.ToInt32(Saisie1) >= 1)
                {
                    Score = Score - Convert.ToInt32(Saisie1);
                }
                if (Score <= 0)
                {
                    Score = 0;
                }
            }
            else
            {
                Score = 10;
            }
            Score_ObjS = Score;
            Scores_Joueur = Score;
        }
    }
}
