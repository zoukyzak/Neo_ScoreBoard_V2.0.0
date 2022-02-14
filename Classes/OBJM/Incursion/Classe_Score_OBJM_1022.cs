using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_1022
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_1022(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6, String Saisie7, String Saisie8, String Saisie9, String Saisie10)
        {
            if (Saisie1 == "true")
            {
                Calcul_Obj(1);
            }
            if (Saisie2 == "true")
            {
                Calcul_Sg();
            }
            if (Saisie3 == "true")
            {
                Calcul_Obj(2);
            }
            if (Saisie4 == "true")
            {
                Calcul_Sg();
            }
            if (Saisie5 == "true")
            {
                Calcul_Obj(3);
            }
            if (Saisie6 == "true")
            {
                Calcul_Sg();
            }
            if (Saisie7 == "true")
            {
                Calcul_Obj(4);
            }
            if (Saisie8 == "true")
            {
                Calcul_Sg();
            }
            if (Saisie9 == "true")
            {
                Calcul_Obj(5);
            }
            if (Saisie10 == "true")
            {
                Calcul_Sg();
            }
            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void Calcul_Obj(int DonneeA)
        {
            Score += (DonneeA);
        }
        private void Calcul_Sg()
        {
            Score += 1;
        }
    }
}
