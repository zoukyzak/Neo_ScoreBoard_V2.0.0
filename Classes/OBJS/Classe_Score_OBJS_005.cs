using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_005
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJS_005(String Saisie1)
        {
            if (Saisie1 != "")
            {
                if (Convert.ToInt32(Saisie1) >= 1)
                {
                    Score = Score + (Convert.ToInt32(Saisie1) / 10);
                }
            }
            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }
    }
}
