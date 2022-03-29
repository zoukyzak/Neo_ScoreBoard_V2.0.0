using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_2022
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_2022(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6, String Saisie7, String Saisie8, String Saisie9, String Saisie10, String Saisie11, String Saisie12, String Saisie13, String Saisie14, String Saisie15)
        {
            Control(Saisie1, Saisie2, Saisie3);
            Control(Saisie4, Saisie5, Saisie6);
            Control(Saisie7, Saisie8, Saisie9);
            Control(Saisie10, Saisie11, Saisie12);
            Control(Saisie13, Saisie14, Saisie15);

            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void Control(String DonneeZDDE, String DonneeNML, String DonneeZDDA)
        {
            int ScoreControl = 0;
            if (DonneeZDDE == "true") { ScoreControl += 4; };
            if (DonneeNML == "true") { ScoreControl += 2; };
            if (DonneeZDDA == "false") { ScoreControl-- ; };
            if (ScoreControl < 0) { ScoreControl = 0; };
            Score += ScoreControl;
        }
    }
}