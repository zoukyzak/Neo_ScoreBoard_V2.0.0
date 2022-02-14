using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_008
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJS_008(String Saisie1, String Saisie2, String Saisie3)
        {
            if (Saisie1 == "true")
            {
                Score += 5;
                if (Saisie2 != "" && Saisie3 != "")
                {
                    if (Convert.ToInt16(Saisie2) > Convert.ToInt16(Saisie3))
                    {
                        Score += 3;
                    }
                }
            }

            Score_ObjS = Score;
            if (Score >= 8)
            {
                Score = 8;
            }
            Scores_Joueur = Score;
        }
    }
}
