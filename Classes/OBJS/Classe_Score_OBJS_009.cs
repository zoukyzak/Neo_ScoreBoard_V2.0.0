using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_009
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJS_009(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5)
        {
            if (Saisie1 != "")
            {
                if (Convert.ToInt16(Saisie1) == 3)
                {
                    Score = Score + 2;
                }
                if (Convert.ToInt16(Saisie1) == 4)
                {
                    Score = Score + 3;
                }
            }
            if (Saisie2 != "")
            {
                if (Convert.ToInt16(Saisie2) == 3)
                {
                    Score = Score + 2;
                }
                if (Convert.ToInt16(Saisie2) == 4)
                {
                    Score = Score + 3;
                }
            }
            if (Saisie3 != "")
            {
                if (Convert.ToInt16(Saisie3) == 3)
                {
                    Score = Score + 2;
                }
                if (Convert.ToInt16(Saisie3) == 4)
                {
                    Score = Score + 3;
                }
            }
            if (Saisie4 != "")
            {
                if (Convert.ToInt16(Saisie4) == 3)
                {
                    Score = Score + 2;
                }
                if (Convert.ToInt16(Saisie4) == 4)
                {
                    Score = Score + 3;
                }
            }
            if (Saisie5 != "")
            {
                if (Convert.ToInt16(Saisie5) == 3)
                {
                    Score = Score + 2;
                }
                if (Convert.ToInt16(Saisie5) == 4)
                {
                    Score = Score + 3;
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
