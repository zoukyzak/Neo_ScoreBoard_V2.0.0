using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_017
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJS_017(String Saisie1, String Saisie2)
        {
            if (Saisie1 != "")
            {
                Score = Score + (Convert.ToInt16(Saisie1) * 3);
            }
            if (Saisie2 != "")
            {
                Score = Score + (Convert.ToInt16(Saisie2) * 2);
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
