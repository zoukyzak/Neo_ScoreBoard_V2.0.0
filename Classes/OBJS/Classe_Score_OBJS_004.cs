using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_004
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJS_004(String Saisie1)
        {
            if (Saisie1 != "")
            {
                if (Convert.ToInt32(Saisie1) == 1)
                {
                    Score = 13;
                }
                if (Convert.ToInt32(Saisie1) == 2)
                {
                    Score = 10;
                }
                if (Convert.ToInt32(Saisie1) == 3)
                {
                    Score = 6;
                }
                if (Convert.ToInt32(Saisie1) == 4)
                {
                    Score = 3;
                }
                if (Convert.ToInt32(Saisie1) == 5)
                {
                    Score = 1;
                }
                Score_ObjS = Score;
            }
            Scores_Joueur = Score;
        }
    }
}
