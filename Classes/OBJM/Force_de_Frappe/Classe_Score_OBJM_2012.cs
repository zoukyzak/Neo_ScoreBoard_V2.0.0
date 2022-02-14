using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_2012
    {

        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_2012(String Saisie1)
        {
            if (Saisie1 != "")
            {
                if (Convert.ToInt32(Saisie1) == 1)
                {
                    Score = 5;
                }
                if (Convert.ToInt32(Saisie1) == 2)
                {
                    Score = 15;
                }
            }


            Score_ObjS = Score;
            Scores_Joueur = Score;
        }
    }
}
