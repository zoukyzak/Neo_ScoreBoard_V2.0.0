﻿using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_006
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJS_006(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6, String Saisie7, String Saisie8, String Saisie9, String Saisie10)
        {
            if (Saisie1 != "" & Saisie2 != "")
            {
                if (Convert.ToInt32(Saisie1) > Convert.ToInt32(Saisie2))
                {
                    Score = Score + 3;
                }
            }
            if (Saisie3 != "" & Saisie4 != "")
            {
                if (Convert.ToInt32(Saisie3) > Convert.ToInt32(Saisie4))
                {
                    Score = Score + 3;
                }
            }
            if (Saisie5 != "" & Saisie6 != "")
            {
                if (Convert.ToInt32(Saisie5) > Convert.ToInt32(Saisie6))
                {
                    Score = Score + 3;
                }
            }
            if (Saisie7 != "" & Saisie8 != "")
            {
                if (Convert.ToInt32(Saisie7) > Convert.ToInt32(Saisie8))
                {
                    Score = Score + 3;
                }
            }
            if (Saisie9 != "" & Saisie10 != "")
            {
                if (Convert.ToInt32(Saisie9) > Convert.ToInt32(Saisie10))
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
