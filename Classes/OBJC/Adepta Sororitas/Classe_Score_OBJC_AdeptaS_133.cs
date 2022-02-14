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

        public Classe_Score_OBJC_AdeptaS_133(string Saisie1_Bolts, string Saisie1_Flammes, string Saisie1_Fusion, string Saisie2_Bolts, string Saisie2_Flammes, string Saisie2_Fusion, string Saisie3_Bolts, string Saisie3_Flammes, string Saisie3_Fusion, string Saisie4_Bolts, string Saisie4_Flammes, string Saisie4_Fusion, string Saisie5_Bolts, string Saisie5_Flammes, string Saisie5_Fusion)
        {
            Calcul(Saisie1_Bolts, Saisie1_Flammes, Saisie1_Fusion);
            Calcul(Saisie2_Bolts, Saisie2_Flammes, Saisie2_Fusion);
            Calcul(Saisie3_Bolts, Saisie3_Flammes, Saisie3_Fusion);
            Calcul(Saisie4_Bolts, Saisie4_Flammes, Saisie4_Fusion);
            Calcul(Saisie5_Bolts, Saisie5_Flammes, Saisie5_Fusion);
            Score_ObjS = Score;
            if (Score > 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void Calcul(string bolts, string flammes, string fusion)
        {
            if (bolts == "true") { Score++; };
            if (flammes == "true") { Score++; };
            if (fusion == "true") { Score++; };
            if (bolts == "true" && flammes == "true" && fusion == "true") { Score++; };
        }
    }
}
