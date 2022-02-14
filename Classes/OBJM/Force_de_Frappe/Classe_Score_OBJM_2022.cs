using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_2022
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_2022(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6, String Saisie7, String Saisie8)
        {
            if (Saisie1 != "")
            {
                calcul(Convert.ToInt32(Saisie1));
            }
            if (Saisie2 != "")
            {
                calcul(Convert.ToInt32(Saisie2));
            }
            if (Saisie3 != "")
            {
                calcul(Convert.ToInt32(Saisie3));
            }
            if (Saisie4 != "")
            {
                calcul(Convert.ToInt32(Saisie4));
            }
            if (Saisie5 == "true")
            {
                calcul2();
            }
            if (Saisie6 == "true")
            {
                calcul2();
            }
            if (Saisie7 == "true")
            {
                calcul2();
            }
            if (Saisie8 == "true")
            {
                calcul2();
            }

            Score_ObjS = Score;
            if (Score >= 7)
            {
                Score = 7;
            }
            Scores_Joueur = Score;
        }

        private void calcul(int Donne)
        {
            if (Donne == 1 || Donne == 2)
            {
                Score += (Donne * 2);
                return;
            }
        }

        private void calcul2()
        {
            Score += 3;
            return;
        }
    }
}