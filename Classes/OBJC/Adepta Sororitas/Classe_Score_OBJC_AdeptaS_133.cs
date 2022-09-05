using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_AdeptaS_133
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJC_AdeptaS_133(string Saisie1_Bolts, string Saisie1_Flammes, string Saisie1_Fusion, string Saisie2_Bolts, string Saisie2_Flammes, string Saisie2_Fusion, string Saisie3_Bolts, string Saisie3_Flammes, string Saisie3_Fusion, string Saisie4_Bolts, string Saisie4_Flammes, string Saisie4_Fusion, string Saisie5_Bolts, string Saisie5_Flammes, string Saisie5_Fusion, string CA)
        {
            Calcul(Saisie1_Bolts, Saisie1_Flammes, Saisie1_Fusion, CA);
            Calcul(Saisie2_Bolts, Saisie2_Flammes, Saisie2_Fusion, CA);
            Calcul(Saisie3_Bolts, Saisie3_Flammes, Saisie3_Fusion, CA);
            Calcul(Saisie4_Bolts, Saisie4_Flammes, Saisie4_Fusion, CA);
            Calcul(Saisie5_Bolts, Saisie5_Flammes, Saisie5_Fusion, CA);
            Score_ObjS = Score;
            if (Score > 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void Calcul(string bolts, string flammes, string fusion,string CA)
        {
            if (CA == "Nachmund")
            {
                if (bolts == "true") { Score++; };
                if (flammes == "true") { Score++; };
                if (fusion == "true") { Score++; };
                if (bolts == "true" && flammes == "true" && fusion == "true") { Score++; };
            }
            if (CA == "Nephilim")
            {
                if (bolts != "" && Convert.ToInt32(bolts) >= 1)
                {
                    Score += Convert.ToInt32(bolts);
                }
                if (flammes != "" && Convert.ToInt32(flammes) >= 1)
                {
                    Score += Convert.ToInt32(flammes);
                }
                if (fusion != "" && Convert.ToInt32(fusion) >= 1)
                {
                    Score += Convert.ToInt32(fusion);
                }
            }
        }
    }
}
