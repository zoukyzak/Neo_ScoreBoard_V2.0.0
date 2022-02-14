using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_Admech_129
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJC_Admech_129(String Admech1, String Infanterie1, String Vehicule1, String Admech2, String Infanterie2, String Vehicule2, String Admech3, String Infanterie3, String Vehicule3, String Admech4, String Infanterie4, String Vehicule4, String Admech5, String Infanterie5, String Vehicule5)
        {
            if (Admech1 == "true" && Infanterie1 != "" && Vehicule1 != "") { VALEUR(Convert.ToInt32(Infanterie1), Convert.ToInt32(Vehicule1)); };
            if (Admech2 == "true" && Infanterie2 != "" && Vehicule2 != "") { VALEUR(Convert.ToInt32(Infanterie2), Convert.ToInt32(Vehicule2)); };
            if (Admech3 == "true" && Infanterie3 != "" && Vehicule3 != "") { VALEUR(Convert.ToInt32(Infanterie3), Convert.ToInt32(Vehicule3)); };
            if (Admech4 == "true" && Infanterie4 != "" && Vehicule4 != "") { VALEUR(Convert.ToInt32(Infanterie4), Convert.ToInt32(Vehicule4)); };
            if (Admech5 == "true" && Infanterie5 != "" && Vehicule5 != "") { VALEUR(Convert.ToInt32(Infanterie5), Convert.ToInt32(Vehicule5)); };

            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void VALEUR(int Infanterie, int Vehicule)
        {
            if (Vehicule < Infanterie)
            {
                Score += 3;
                return;
            }
            else
            {
                return;
            }
        }
    }
}
