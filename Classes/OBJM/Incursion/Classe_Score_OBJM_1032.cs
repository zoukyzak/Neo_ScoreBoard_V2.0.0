using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_1032
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_1032(String Saisie1, String Saisie2)
        {
            int Unitee75 = (Convert.ToInt32(Saisie1) / 4) * 300;
            int Unitee50 = (Convert.ToInt32(Saisie1) / 2) * 100;
            int Unitee25 = (Convert.ToInt32(Saisie1) / 4) * 100;
            if (Convert.ToInt32(Saisie2) * 100 > Unitee25)
            {
                Score = 5;
            }
            if (Convert.ToInt32(Saisie2) * 100 > Unitee50)
            {
                Score = 10;
            }
            if (Convert.ToInt32(Saisie2) * 100 > Unitee75)
            {
                Score = 15;
            }

            Score_ObjS = Score;
            Scores_Joueur = Score;
        }
    }
}
