using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_2023
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;
        private int Donne = 0;

        public Classe_Score_OBJM_2023(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5)
        {

            if (Saisie1 == "true")
            {
                Donne += 1;
            }
            if (Saisie2 == "true")
            {
                Donne += 1;
            }
            if (Saisie3 == "true")
            {
                Donne += 1;
            }
            if (Saisie4 == "true")
            {
                Donne += 1;
            }
            if (Saisie5 == "true")
            {
                Donne += 1;
            }

            if (Donne == 1) { Score = 3; };
            if (Donne == 2) { Score = 6; };
            if (Donne == 3) { Score = 10; };
            if (Donne == 4) { Score = 15; };
            if (Donne == 5) { Score = 15; };


            Score_ObjS = Score;
            Scores_Joueur = Score;
        }
    }
}
