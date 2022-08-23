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
        public Classe_Score_OBJC_GK_145(string Saisie1)
        {
            if (Saisie1 !="") { compar (Convert.ToInt32(Saisie1));   };

            Score_ObjS = Score;
            if (Score >= 6) { Score = 6; };
            Scores_Joueur = Score;
        }
        private void compar(int donnee)
        {
            if (donnee == 1) { Score = 1; };
            if (donnee == 2) { Score = 2; };
            if (donnee == 3) { Score = 4; };
            if (donnee >= 4) { Score = 6; };
        }
    }
}
