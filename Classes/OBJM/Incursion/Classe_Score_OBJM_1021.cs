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

        public Classe_Score_OBJM_1021(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6, String Saisie7, String Saisie8, String Saisie9, String Saisie10, String Saisie11, String Saisie12, String Saisie13, String Saisie14, String Saisie15)
        {
            Calcul_Score(Saisie1, Saisie2, Saisie3);   
            Calcul_Score(Saisie4, Saisie5, Saisie6);   
            Calcul_Score(Saisie7, Saisie8, Saisie9);   
            Calcul_Score(Saisie10, Saisie11, Saisie12);   
            Calcul_Score(Saisie13, Saisie14, Saisie15);   

            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void Calcul_Score(String OBJ1, String OBJ2, String OBJ3)
        {
            int Score2 = 0;
            if (OBJ1 == "true") { Score2 += 2;};
            if (OBJ2 == "false") { Score2--;};
            if (OBJ3 != "")
                {
                if (Convert.ToInt32 (OBJ3) >= 1 && Convert.ToInt32(OBJ3) <=2) { Score2 = Score2 + Convert.ToInt32(OBJ3); };
                }
            if (Score2 < 0) { Score2 = 0;};
            Score = Score + Score2;
        }
    }
    

}
