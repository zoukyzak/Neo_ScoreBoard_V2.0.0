using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_015
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJS_015(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5)
        {
            if (Saisie1 == "true")
            {
                Score = Score + 3;
            }
            if (Saisie2 == "true")
            {
                Score = Score + 3;
            }
            if (Saisie3 == "true")
            {
                Score = Score + 3;
            }
            if (Saisie4 == "true")
            {
                Score = Score + 3;
            }
            if (Saisie5 == "true")
            {
                Score = Score + 3;
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
