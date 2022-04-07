using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_006
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJS_006(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6, String Saisie7, String Saisie8, String Saisie9, String Saisie10)
        {
            Compare(Saisie1, Saisie2);
            Compare(Saisie3, Saisie4);
            Compare(Saisie5, Saisie6);
            Compare(Saisie7, Saisie8);
            Compare(Saisie9, Saisie10);
            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

         void Compare(string Donnée1, string donnée2)
        {
            if (Donnée1 != "" & donnée2 != "")
            {
                if (Convert.ToInt32(Donnée1) > Convert.ToInt32(donnée2))
                {
                    Score = Score + 3;
                }
            }            
        }

    }


    
}
