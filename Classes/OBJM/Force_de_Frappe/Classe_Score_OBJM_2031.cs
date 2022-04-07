using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_2031
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_2031(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6)
        {
            Submerged(Saisie1);
            Submerged(Saisie2);
            Submerged(Saisie3);
            Submerged(Saisie4);
            if (Saisie5 != "") { Submerged_in(Convert.ToInt32(Saisie5)); };
            Submerged_Fin(Saisie6);
            Score_ObjS = Score;
            if (Score >= 8) { Score = 8; };
            Scores_Joueur = Score;
        }

        private void Submerged(String Donne)
        {
            if (Donne == "true") { Score += 2; };            
        }
        private void Submerged_in(int Donne)
        {
            if (Donne >= 0) { Score += (2 * Donne); };
        }
        private void Submerged_Fin(string Donne)
        {
            if (Donne == "true") { Score += 4; };
        }
    }
}
