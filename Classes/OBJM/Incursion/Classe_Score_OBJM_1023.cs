using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_1023
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJM_1023(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6, String Saisie7, String Saisie8, String Saisie9, String Saisie10, String Saisie11, String Saisie12, String Saisie13, String Saisie14, String Saisie15, String Saisie16)
        {
            if (Saisie1 == "Joueur_A")
            {
                Calcul_Joueur_A(Saisie2, Saisie3, Saisie4);
                Calcul_Joueur_A(Saisie5, Saisie6, Saisie7);
                Calcul_Joueur_A(Saisie8, Saisie9, Saisie10);
                Calcul_Joueur_A(Saisie11, Saisie12, Saisie13);
                Calcul_Joueur_A(Saisie14, Saisie15, Saisie16);
            }

            if (Saisie1 == "Joueur_B")
            {
                Calcul_Joueur_B(Saisie2, Saisie3, Saisie4);
                Calcul_Joueur_B(Saisie5, Saisie6, Saisie7);
                Calcul_Joueur_B(Saisie8, Saisie9, Saisie10);
                Calcul_Joueur_B(Saisie11, Saisie12, Saisie13);
                Calcul_Joueur_B(Saisie14, Saisie15, Saisie16);
            }
            
            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void Calcul_Joueur_A (String DonneeB , String DonneeC , String DonneeD)
        {
            if (DonneeB == "true") { Score += 2; };
            if (DonneeC == "true") { Score += 3; };
            if (DonneeD == "true") { Score += 4; };
            
        }
        private void Calcul_Joueur_B(String DonneeC, String DonneeB, String DonneeA)
        {
            if (DonneeC == "true") { Score += 2; };
            if (DonneeB == "true") { Score += 3; };
            if (DonneeA == "true") { Score += 4; };
        }

    }
}
