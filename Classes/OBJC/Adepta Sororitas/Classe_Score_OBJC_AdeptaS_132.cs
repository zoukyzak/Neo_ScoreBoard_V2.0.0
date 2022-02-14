using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_AdeptaS_132
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;
        public Classe_Score_OBJC_AdeptaS_132(string Saisie1, string Saisie2, string Saisie3, string Saisie4, string Saisie5, string Saisie6, string Saisie7, string Saisie8, string Saisie9, string Saisie10)
        {
            Comparatif(Saisie1, Saisie2);
            Comparatif(Saisie3, Saisie4);
            Comparatif(Saisie5, Saisie6);
            Comparatif(Saisie7, Saisie8);
            Comparatif(Saisie9, Saisie10);

            Score_ObjS = Score;
            if (Score >= 12)
            {
                Score = 12;
            }
            Scores_Joueur = Score;
        }

        private void Comparatif(string Donnée1, string Donnée2)
        {
            int x = 0;
            int y = 0;
            int z = 0;
            if (Donnée2 != "")
            {
                if (Convert.ToInt32(Donnée2) >= 2)
                {
                    x = 2;
                }
            }
            if (Donnée1 != "")
            {
                if (Convert.ToInt32(Donnée1) >= 2)
                {
                    y = 1;
                }
            }
            if (Donnée1 != "" && Donnée2 != "")
            {
                z = Convert.ToInt32(Donnée1) + Convert.ToInt32(Donnée2);
            }
            if (x > y)
            {
                Score += 2;
            }
            if (y > x)
            {
                Score++;
            }
            if (z >= 3)
            {
                Score++;
            }
        }
    }

}

