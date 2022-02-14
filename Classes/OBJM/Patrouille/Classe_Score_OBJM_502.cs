using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_502
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_502(String Saisie1, String Saisie2, String Saisie3, String Saisie4)
        {
            Calcul(Saisie1);
            Calcul(Saisie2);
            Calcul(Saisie3);
            Calcul(Saisie4);
            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void Calcul(string Donnee)
        {
            if (Donnee == "true")
            {
                Score += 5;
                return;
            }
        }
    }
}
