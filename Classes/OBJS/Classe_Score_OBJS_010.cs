using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_010
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJS_010(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5)
        {
            if (Saisie1 != "") { calcul(Saisie1);};
            if (Saisie2 != "") { calcul(Saisie2);};
            if (Saisie3 != "") { calcul(Saisie3);};
            if (Saisie4 != "") { calcul(Saisie4);};
            if (Saisie5 != "") { calcul(Saisie5);};

            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void calcul(string _Donnee)
        {
            if (Convert.ToInt16(_Donnee) == 1) { Score = Score + 2;};
            if (Convert.ToInt16(_Donnee) >= 2) { Score = Score + 4;};
        }
    }
}
