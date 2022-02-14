using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_1013
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_1013(String Saisie1, String Saisie2, String Saisie3, String Saisie4)
        {
            if (Saisie1 != "")
            {
                Calcul(Convert.ToInt16(Saisie1));
            }
            if (Saisie2 != "")
            {
                Calcul(Convert.ToInt16(Saisie2));
            }
            if (Saisie3 != "")
            {
                Calcul(Convert.ToInt16(Saisie3));
            }
            if (Saisie4 != "")
            {
                Calcul(Convert.ToInt16(Saisie4));
            }
            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void Calcul(int Donnee)
        {
            if (Donnee == 1)
            {
                Score += 3;
            }
            if (Donnee == 2)
            {
                Score += 5;
            }
        }
    }
}
