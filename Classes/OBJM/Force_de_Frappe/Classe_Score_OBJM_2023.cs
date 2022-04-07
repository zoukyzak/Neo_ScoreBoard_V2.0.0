using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_2023
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_2023(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5)
        {
            Calcul(Convert.ToBoolean(Saisie1));
            Calcul(Convert.ToBoolean(Saisie2));
            Calcul(Convert.ToBoolean(Saisie3));
            Calcul(Convert.ToBoolean(Saisie4));
            Calcul(Convert.ToBoolean(Saisie5));

            Score_ObjS = Score;
            Scores_Joueur = Score;
        }
        private void Calcul(Boolean Donnee)
        {
            if (Donnee == true) { Score += 3; };
        }
    }
}
