using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_011
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJS_011(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6, String Saisie7, String Saisie8, String Saisie9, String Saisie10)
        {

            Compare(Saisie1, Saisie6);
            Compare(Saisie2, Saisie7);
            Compare(Saisie3, Saisie8);
            Compare(Saisie4, Saisie9);
            Compare(Saisie5, Saisie10);
           
            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void Compare(string Donnee1, string Donnee2)
        {
            if (Donnee1 != "" && Donnee2 != "")
            {
                if ((Convert.ToInt16(Donnee1) > Convert.ToInt16(Donnee2)) && (Convert.ToInt16(Donnee1) >= 3))
                {
                    Score += 3;
                }
            }
        }
    }
}
 