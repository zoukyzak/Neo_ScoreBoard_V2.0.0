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

        private int Score_Tuerie = 0;
        public Classe_Score_OBJC_Tyranids_140(string Saisie1, string Saisie2, string Saisie3, string Saisie4, string Saisie5, string Saisie6, string Saisie7, string Saisie8, string Saisie9, string Saisie10, string Saisie11, string Saisie12, string Saisie13, string Saisie14, string Saisie15)
        {
            Comparatif(Saisie1, Saisie2, Saisie3);
            Comparatif(Saisie4, Saisie5, Saisie6);
            Comparatif(Saisie7, Saisie8, Saisie9);
            Comparatif(Saisie10, Saisie11, Saisie12);
            Comparatif(Saisie13, Saisie14, Saisie15);

            Score_ObjS = Score;
            if (Score >= 12) { Score = 12; };
            Scores_Joueur = Score;
        }

        private void Comparatif(string Donnée1, string Donnée2, string Donnée3)
        {
            Score_Tuerie = 0;
            if (Donnée1 != "") { Score_Tuerie += Convert.ToInt32(Donnée1); };
            if (Donnée2 != "") { Score_Tuerie += Convert.ToInt32(Donnée2) * 2 ; };
            if (Donnée3 != "") { Score_Tuerie += Convert.ToInt32(Donnée3) * 3 ; };
            if (Score_Tuerie >= 4) { Score += 3; };
        }
    }
}
