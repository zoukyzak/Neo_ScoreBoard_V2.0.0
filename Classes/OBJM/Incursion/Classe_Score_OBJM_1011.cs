using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_1011
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_1011(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6, String Saisie7, String Saisie8, String Saisie9, String Saisie10)
        {
            Calcul(Saisie1, Saisie2);
            Calcul(Saisie3, Saisie4);
            Calcul(Saisie5, Saisie6);
            Calcul(Saisie7, Saisie8);
            Calcul(Saisie9, Saisie10);
            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void Calcul(string DonneeA, String DonneeB)
        {
            if (DonneeA == "true" && DonneeB == "true")
            {
                Score += 3;
                return;
            }
            if (DonneeA == "true" || DonneeB == "true")
            {
                Score += 2;
                return;
            }
            else
            {
                return;
            }
           
        }
    }
}