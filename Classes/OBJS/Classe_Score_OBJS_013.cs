using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_013
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJS_013(String In2, String In3, String In4, String In5, String Out2, String Out3, String Out4, String Out5)
        {
            if (In2 == "true")
            {
                Score = Score + 4;
            }
            if (In3 == "true")
            {
                Score = Score + 4;
            }
            if (In4 == "true")
            {
                Score = Score + 4;
            }
            if (In5 == "true")
            {
                Score = Score + 4;
            }
            if (Out2 == "true")
            {
                Score = Score + 2;
            }
            if (Out3 == "true")
            {
                Score = Score + 2;
            }
            if (Out4 == "true")
            {
                Score = Score + 2;
            }
            if (Out5 == "true")
            {
                Score = Score + 2;
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
