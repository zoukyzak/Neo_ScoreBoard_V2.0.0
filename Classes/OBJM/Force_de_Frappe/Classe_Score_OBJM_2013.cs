using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_2013
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_2013(String Saisie1, String Saisie2, String Saisie3, String Saisie4)
        {
            if (Saisie1 != "")
            {
                Score += Convert.ToInt32(Saisie1);
            }
            if (Saisie2 != "")
            {
                Score += Convert.ToInt32(Saisie2);
            }
            if (Saisie3 != "")
            {
                Score += Convert.ToInt32(Saisie3);
            }
            if (Saisie4 != "")
            {
                Score += Convert.ToInt32(Saisie4);
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
