using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_Necrons_100
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJC_Necrons_100(String Saisie1)
        {
            if (Saisie1 != "")
            {
                Score += (3 * (Convert.ToInt32(Saisie1)));
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
