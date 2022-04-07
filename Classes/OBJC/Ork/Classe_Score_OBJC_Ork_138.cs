using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_Ork_138
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;
        public Classe_Score_OBJC_Ork_138(String Saisie1, String Saisie2, String Saisie3, String Saisie4)
        {
            Calcul(Saisie1);
            Calcul(Saisie2);
            Calcul(Saisie3);
            Calcul(Saisie4);

            Score_ObjS = Score;
            if (Score >= 15) { Score = 15; };
            Scores_Joueur = Score;
        }
       
        private void Calcul(String D)
        {
            if (D != "") { if (Convert.ToInt32(D) > 0) { Score += 3 * Convert.ToInt32(D); }; };            
        }
    }
}
