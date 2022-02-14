using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_SM_BA_113
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJC_SM_BA_113(String Saisie1, String Saisie2, String Saisie3)
        {
            if (Saisie1 == "true")
            {
                Score += 5;
                if (Saisie2 == "true")
                {
                    Score += 5;
                    if (Saisie3 == "true")
                    {
                        Score += 5;
                    }
                }
            }
            else
            {
                return;
            }
            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }


    }
}
