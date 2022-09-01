using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_002
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS_002 { get; set; }

        private int Score = 0;

        public Classe_Score_OBJS_002(String Saisie1, String Saisie2, String Saisie3, string Saisie4)
        {
            if (Saisie1 != "")
            {
                if (Convert.ToInt32(Saisie1) > 0)
                {
                    Score = Convert.ToInt32(Saisie1);
                    Score_ObjS_002 = Score;
                }
            }
            if (Saisie2 != "")
            {
                if (Convert.ToInt32(Saisie2) > 0)
                {
                    Score = Score + (Convert.ToInt32(Saisie2) * 2);
                    Score_ObjS_002 = Score;
                }
            }
            if (Saisie3 != "")
            {
                if (Convert.ToInt32(Saisie3) > 0)
                {
                    Score = Score + (Convert.ToInt32(Saisie3) * 3);
                    Score_ObjS_002 = Score;
                }
            }
            if (Saisie4 != "")
            {
                if (Convert.ToInt32(Saisie4) > 0)
                {
                    Score = Score + (Convert.ToInt32(Saisie4) * 4);
                    Score_ObjS_002 = Score;
                }
            }
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }
    }
}
