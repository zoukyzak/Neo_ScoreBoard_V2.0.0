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
        public Classe_Score_OBJC_GK_143(string Saisie1, string Saisie2, string Saisie3, string Saisie4)
        {
            if (Saisie1 == "true") { Score += 5;};
            if (Saisie2 == "true") { Score += 3;};
            if (Saisie3 == "true") { Score += 3;};
            if (Saisie4 == "true") { Score += 1;};

            Score_ObjS = Score;
            if (Score >= 12) { Score = 12; };
            Scores_Joueur = Score;
        }        
    }
}
