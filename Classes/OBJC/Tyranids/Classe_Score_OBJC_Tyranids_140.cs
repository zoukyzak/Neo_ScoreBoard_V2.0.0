using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_Tyranids_140
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;
        public Classe_Score_OBJC_Tyranids_140(string Saisie1, string Saisie2, string Saisie3, string Saisie4, string Saisie5)
        {
            Comparatif(Saisie1);
            Comparatif(Saisie2);
            Comparatif(Saisie3);
            Comparatif(Saisie4);
            Comparatif(Saisie5);

            Score_ObjS = Score;
            if (Score >= 12) { Score = 12; };
            Scores_Joueur = Score;
        }

        private void Comparatif(string Donnée1)
        {
            if (Donnée1 != "")
            {
                if (Convert.ToInt32(Donnée1) >= 4) { Score += 3; };
            }
        }
    }
}
