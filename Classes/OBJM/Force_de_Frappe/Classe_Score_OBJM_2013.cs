using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_2013
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_2013(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5)
        {
            if (Saisie1 != "") { Control(Convert.ToInt16(Saisie1)); };
            if (Saisie2 != "") { Control(Convert.ToInt16(Saisie2)); };
            if (Saisie3 != "") { Control(Convert.ToInt16(Saisie3)); };
            if (Saisie4 != "") { Control(Convert.ToInt16(Saisie4)); };
            if (Saisie5 != "") { Control(Convert.ToInt16(Saisie5)); };            

            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }
        private void Control (int Donnee)
        {
            if (Donnee >= 1 && Donnee <= 3) { Score += Donnee; };
            if (Donnee >= 4) { Score += 3; } ;            
        }
    }
}
