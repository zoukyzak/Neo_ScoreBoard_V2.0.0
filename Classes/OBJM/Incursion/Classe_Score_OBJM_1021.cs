using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_1021
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_1021(String Saisie1, String Saisie2, String Saisie3, String Saisie4)
        {
            if (Saisie1 == "true") { Score += 3; };
            if (Saisie2 == "true") { Score += 3; };
            if (Saisie3 == "true") { Score += 3; };
            if (Saisie4 == "true") { Score += 3; };
            

            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }
    }
}
