using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_AdeptaS_134
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJC_AdeptaS_134(string ZDD1, string ZDD2, string ZDD3, string ZDD4, string ZDD5, string ZDD6, string Obj1, string Obj2, string Obj3, string Obj4, string Obj5, string Obj6)
        {
            if (Obj1 == "true") {if (ZDD1 == "true") { Score += 4; } else { Score++; } };
            if (Obj2 == "true") {if (ZDD2 == "true") { Score += 4; } else { Score++; } };
            if (Obj3 == "true") {if (ZDD3 == "true") { Score += 4; } else { Score++; } };
            if (Obj4 == "true") {if (ZDD4 == "true") { Score += 4; } else { Score++; } };
            if (Obj5 == "true") {if (ZDD5 == "true") { Score += 4; } else { Score++; } };
            if (Obj6 == "true") {if (ZDD6 == "true") { Score += 4; } else { Score++; } };
            Score_ObjS = Score;
            if (Score > 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }       
    }
}
