using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_Admech_131
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJC_Admech_131(String Valid1, String Valid2, String Valid3, String Valid4, String Valid5, String Valid6, String Valid7)
        {
            if (Valid7 !="")
            {
                if (Convert.ToInt32(Valid7) > 0)
                {
                    if (Valid1 == "true") { VALEUR(); };
                    if (Valid2 == "true") { VALEUR(); };
                    if (Valid3 == "true") { VALEUR(); };
                    if (Valid4 == "true") { VALEUR(); };
                    if (Valid5 == "true") { VALEUR(); };
                    if (Valid6 == "true") { Score += 5; };
                }
            }
            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void VALEUR()
        {
            Score += 2;
            return;
        }
    }
}
