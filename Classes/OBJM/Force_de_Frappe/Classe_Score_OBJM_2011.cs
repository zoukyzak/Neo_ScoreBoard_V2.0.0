using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_2011
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_2011(String Saisie1, String Saisie2)
        {
            if (Saisie1 != "" && Saisie2 != "")
            {
                int Unitee75 = (Convert.ToInt32(Saisie1) * 75);
                int Unitee50 = (Convert.ToInt32(Saisie1) * 50);
                int Unitee25 = (Convert.ToInt32(Saisie1) * 25);
                if (Convert.ToInt32(Saisie2) * 100 >= Unitee25)
                {
                    Score = 5;
                }
                if (Convert.ToInt32(Saisie2) * 100 >= Unitee50)
                {
                    Score = 10;
                }
                if (Convert.ToInt32(Saisie2) * 100 >= Unitee75)
                {
                    Score = 15;
                }
            }


            Score_ObjS = Score;
            Scores_Joueur = Score;
        }
    }
}
