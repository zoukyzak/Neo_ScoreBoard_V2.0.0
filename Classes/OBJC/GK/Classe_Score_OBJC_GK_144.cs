using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_GK_144
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;
        public Classe_Score_OBJC_GK_144(string Saisie1, string Saisie2, string Saisie3, string Saisie4, string Saisie5,string CA)
        {
            Comparatif(Saisie1, CA);
            Comparatif(Saisie2, CA);
            Comparatif(Saisie3, CA);
            Comparatif(Saisie4, CA);
            Comparatif(Saisie5, CA);
            Score_ObjS = Score;
            if (Score >= 15) { Score = 15; };
            Scores_Joueur = Score;
        }

        private void Comparatif(string Donnée,string CA)
        {
            if (Donnée == "true" && CA == "Nachmund") { Score += 3; };
            if (Donnée == "true" && CA == "Nephilim") { Score += 4; };
        }
    }
}
