using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_007
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJS_007(String Saisie1, String Saisie2, String Saisie3, String Spit1 , String Spit2, String Spit3)
        {
            if (Spit1 == "true")
            {
                Score = Score + 3;
                Saisie1 = "false";
            }
            if (Spit2 == "true")
            {
                Score = Score + 3;
                Saisie2 = "false";
            }
            if (Spit3 == "true")
            {
                Score = Score + 3;
                Saisie3 = "false";
            }
            if (Saisie1 == "true")
            {
                Score = Score + 5;
            }
            if (Saisie2 == "true")
            {
                Score = Score + 5;
            }
            if (Saisie3 == "true")
            {
                Score = Score + 5;
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
