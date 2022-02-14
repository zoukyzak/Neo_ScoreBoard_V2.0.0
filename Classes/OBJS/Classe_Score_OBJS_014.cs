using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_014
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJS_014(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5)
        {
            if (Saisie1 != "")
            {
                if (Convert.ToInt16(Saisie1) > 0)
                {
                    Score = Score + Convert.ToInt16(Saisie1);
                }
            }
            if (Saisie2 != "")
            {
                if (Convert.ToInt16(Saisie2) > 0)
                {
                    Score = Score + Convert.ToInt16(Saisie2);
                }
            }
            if (Saisie3 != "")
            {
                if (Convert.ToInt16(Saisie3) > 0)
                {
                    Score = Score + Convert.ToInt16(Saisie3);
                }
            }
            if (Saisie4 != "")
            {
                if (Convert.ToInt16(Saisie4) > 0)
                {
                    Score = Score + Convert.ToInt16(Saisie4);
                }
            }
            if (Saisie5 != "")
            {
                if (Convert.ToInt16(Saisie5) > 0)
                {
                    Score = Score + Convert.ToInt16(Saisie5);
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
