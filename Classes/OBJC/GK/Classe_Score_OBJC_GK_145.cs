using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_GK_145
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;
        public Classe_Score_OBJC_GK_145(string Saisie1, string Saisie2, string Saisie3, string Saisie4, string Saisie5, string CA)
        {
            if (Saisie1 !="") { compar (Convert.ToInt32(Saisie1), CA); };
            if (Saisie2 !="") { compar (Convert.ToInt32(Saisie2), CA); };
            if (Saisie3 !="") { compar (Convert.ToInt32(Saisie3), CA); };
            if (Saisie4 !="") { compar (Convert.ToInt32(Saisie4), CA); };
            if (Saisie5 !="") { compar (Convert.ToInt32(Saisie5), CA); };

            Score_ObjS = Score;
            if (Score >= 15) { Score = 15; };
            Scores_Joueur = Score;
        }
        private void compar(int donnee, string CA)
        {
            if (donnee == 1) { Score += 1; };
            if (donnee == 2) { Score += 2; };
            if (donnee == 3) { Score += 4; };
            if (CA == "Nachmund") { if (donnee >= 4) { Score += 6; }; };
            if (CA == "Nephilim") { if (donnee >= 4) { Score += 5; }; };
        }
    }
}
