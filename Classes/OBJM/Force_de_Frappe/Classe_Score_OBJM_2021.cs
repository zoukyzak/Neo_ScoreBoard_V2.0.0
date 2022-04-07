using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_2021
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_2021(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6)
        {
            Control(Saisie1);
            Control(Saisie2);
            Control(Saisie3);
            Control(Saisie4);
            Control(Saisie5);
            
            if (Saisie6 == "true") { Score += 5; };

            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void Control(string Donne)
        {
            if (Donne == "true")
            {
                Score += 2;
                return;
            }            
        }
    }
}
