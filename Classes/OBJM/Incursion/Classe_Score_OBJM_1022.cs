using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_1022
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_1022(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6, String Saisie7)
        {
            if (Saisie1 == "true") { Score += 2; };
            if (Saisie2 == "true") { Score += 2; };
            if (Saisie3 == "true") { Score += 2; };
            if (Saisie4 == "true") { Score += 2; };
            if (Saisie5 == "true") { Score += 2; };
            if (Saisie6 == "true") { Score += 3; };
            if (Saisie7 == "true") { Score += 3; };
            
            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }       
    }
}
