using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_018
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;
        private int i = 0;

        public Classe_Score_OBJS_018(String Saisie1, String Saisie2, String Saisie3, String Saisie4)
        {
            if (Saisie1 == "true" || Saisie2 == "true" || Saisie3 == "true" || Saisie4 == "true")
            {
                if (Saisie1 == "true"){i ++;};
                if (Saisie2 == "true"){i ++;};
                if (Saisie3 == "true"){i ++;};
                if (Saisie4 == "true"){i ++;};
                if (i == 2){Score = 4;};
                if (i == 3){Score = 8;};
                if (i == 4){Score = 12;};
            }
            else
            {
                Score = 0;
            }
            Score_ObjS = Score;
            Scores_Joueur = Score;
        }
    }
}
