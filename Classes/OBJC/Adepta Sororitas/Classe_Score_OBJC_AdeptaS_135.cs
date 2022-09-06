using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_AdeptaS_135
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJC_AdeptaS_135(string obj1, string obj2, string obj3, string obj4, string obj5, string obj_vous, string obj_Adv,string CA)
        {
            Calcul(obj1);
            Calcul(obj2);
            Calcul(obj3);
            Calcul(obj4);
            Calcul(obj5);
            if (CA == "Nachmund")
            {
                Calcul(obj_vous);
            }
            if (obj_Adv == "true"){ Score -= 3; };

            Score_ObjS = Score;
            if (Score > 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void Calcul(string donnée)
        {
            if (donnée == "true") { Score += 3; };            
        }
    }
}
