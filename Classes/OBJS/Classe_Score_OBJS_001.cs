using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_001
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS_001 { get; set; }

        private int Score = 0;


        public Classe_Score_OBJS_001(String Saisie1, String Saisie2)
        {
            if (Saisie1 != "")
            {
                if (Convert.ToInt32(Saisie1) > 0)
                {
                    Score = Convert.ToInt32(Saisie1) * 3;
                    if (Saisie2 == "true")
                    {
                        Score++;
                    }
                    Score_ObjS_001 = Score;
                    if (Score >= 15)
                    {
                        Score = 15;
                    }
                    Scores_Joueur = Score;
                }
            }
        }
    }
}
