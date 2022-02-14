using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_016
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJS_016(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5)
        {
            int x = 0;
            if (Saisie1 == "true"){ x++;};
            if (Saisie2 == "true"){ x++;};
            if (Saisie3 == "true"){ x++;};
            if (Saisie4 == "true"){ x++;};
            if (Saisie5 == "true"){ x++;};

            if (x == 1){ Score = 3;};
            if (x == 2){ Score = 7;};
            if (x >= 3){ Score = 12;};

            Score_ObjS = Score;
            Scores_Joueur = Score;
        }

        
        
    }
}
