using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_003
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS_003 { get; set; }

        private int Score = 0;

        public Classe_Score_OBJS_003(String Saisie1)
        {
            if (Saisie1 != "")
            {
                if (Convert.ToInt32(Saisie1) > 0 && Convert.ToInt32(Saisie1) < 4)
                {
                    if (Convert.ToInt32(Saisie1) == 1)
                    {
                        Score = 4;
                    }
                    if (Convert.ToInt32(Saisie1) == 2)
                    {
                        Score = 9;
                    }
                    if (Convert.ToInt32(Saisie1) >= 3)
                    {
                        Score = 15;
                    }
                    Score_ObjS_003 = Score;
                }
            }
            Scores_Joueur = Score;
        }
    }
}
