using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_Necrons_103
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;
        public int y;

        public Classe_Score_OBJC_Necrons_103(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String CA)
        {
            if (Saisie1 != "") { calcul(Convert.ToInt32(Saisie1), CA); };
            if (Saisie2 != "") { calcul(Convert.ToInt32(Saisie2), CA); };
            if (Saisie3 != "") { calcul(Convert.ToInt32(Saisie3), CA); };
            if (Saisie4 != "") { calcul(Convert.ToInt32(Saisie4), CA); };
            Score_ObjS = Score;
            if (Score >= 15) { Score = 15; };
            Scores_Joueur = Score;
        }

        private void calcul(int Donne1, String CA)
        {
            if (CA == "Nachmund") { y = 3; };
            if (CA == "Nephilim") { y = 4; };
            if (Donne1 >= 1)
            {
                Score += y * Donne1;
                return;
            }
            else
            {
                return;
            }
        }
    }
}
