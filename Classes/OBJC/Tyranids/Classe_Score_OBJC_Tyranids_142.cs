using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_Tyranids_142
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJC_Tyranids_142(string PC, string SG, string Fig, string Perso, string CA)
        {
            if (PC == "true") { Score += 3;};
            if (SG == "true") { Score += 3;};

            if (Fig != "") { Score += Convert.ToInt32(Fig) ;};
            if (CA == "Nephilim")
            {
                if (Perso != "") { Score += 3 * Convert.ToInt32(Perso); };
            }

            Score_ObjS = Score;
            if (Score >= 15) { Score = 15; };
            Scores_Joueur = Score;
        }        
    }
}
