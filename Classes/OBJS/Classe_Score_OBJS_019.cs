using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_019
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJS_019(String Saisie1)
        {
            if (Saisie1 != "")
            {
                if (Convert.ToInt32(Saisie1) >= 2 && Convert.ToInt32(Saisie1) < 4)
                {
                    Score = 8;
                }
                if (Convert.ToInt32(Saisie1) >= 4)
                {
                    Score = 15;
                }
            }
            else
            {
                Score = 0;
            }
            Score_ObjS = Score;
            Scores_Joueur = Score;
        }
    }
}
