using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_GK_143
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;
        public Classe_Score_OBJC_GK_143(string Saisie1, string Saisie2, string Saisie3, string Saisie4,String Saisie5, string CA)
        {
            if (Saisie1 !="") { Score += (5 * Convert.ToInt32(Saisie1)); };
            if (Saisie2 !="") { Score += (3 * Convert.ToInt32(Saisie2)); };
            if (Saisie3 !="") { Score += (3 * Convert.ToInt32(Saisie3)); };
            if (Saisie4 !="") { Score += (1 * Convert.ToInt32(Saisie4)); };
            if (CA == "Nephilim" && Saisie5 !="")
            {
                Score -= Convert.ToInt32(Saisie5);
            }

            Score_ObjS = Score;
            if (Score >= 15) { Score = 15; };
            if (Score <= 0) { Score = 0; };
            Scores_Joueur = Score;
        }        
    }
}
