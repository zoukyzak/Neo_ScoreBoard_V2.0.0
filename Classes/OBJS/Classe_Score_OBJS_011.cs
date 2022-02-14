using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_011
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJS_011(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6, String Saisie7, String Saisie8, String Saisie9, String Saisie10)
        {
            if (Saisie1 != "" && Saisie6 !="")
            {
                if ((Convert.ToInt16(Saisie1) > Convert.ToInt16(Saisie6)) && (Convert.ToInt16(Saisie1) >= 3))
                {
                    Score += 3;                   
                }                
            }
            if (Saisie2 != "" && Saisie7 != "")
            {
                if ((Convert.ToInt16(Saisie2) > Convert.ToInt16(Saisie7)) && (Convert.ToInt16(Saisie2) >= 3))
                {
                    Score += 3;
                }                
            }
            if (Saisie3 != "" && Saisie8 != "")
            {
                if ((Convert.ToInt16(Saisie3) > Convert.ToInt16(Saisie8)) && (Convert.ToInt16(Saisie3) >= 3))
                {
                    Score += 3;
                }
            }
            if (Saisie4 != "" && Saisie9 != "")
            {
                if ((Convert.ToInt16(Saisie4) > Convert.ToInt16(Saisie9)) && (Convert.ToInt16(Saisie4) >= 3))
                {
                    Score += 3;
                }
            }
            if (Saisie5 != "" && Saisie10 != "")
            {
                if ((Convert.ToInt16(Saisie5) > Convert.ToInt16(Saisie10)) && (Convert.ToInt16(Saisie5) >= 3))
                {
                    Score += 3;
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
