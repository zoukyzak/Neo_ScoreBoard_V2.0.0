using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJM_1033
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;
        private int Compte_OBJ_Cocher = 0;
        public Classe_Score_OBJM_1033(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6, String Saisie7, String Saisie8, String Saisie9, String Saisie10, String Saisie11, String Saisie12, String Saisie13, String Saisie14, String Saisie15, String Saisie16, String Saisie17, String Saisie18, String Saisie19, String Saisie20)
        {
            Compte_OBJ_Cocher = 0;
            Controle_Cocher(Saisie1);
            Controle_Cocher(Saisie2);
            Controle_Cocher(Saisie3);
            Controle_Cocher(Saisie4);
            Controle_Cocher(Saisie5);
            Controle_Cocher(Saisie6);
            Controle_Cocher(Saisie7);
            Controle_Cocher(Saisie8);
            Controle_Cocher(Saisie9);
            Controle_Cocher(Saisie10);
            Controle_Cocher(Saisie11);
            Controle_Cocher(Saisie12);
            Controle_Cocher(Saisie13);
            Controle_Cocher(Saisie14);
            Controle_Cocher(Saisie15);
            Controle_Cocher(Saisie16);
            Controle_Cocher(Saisie17);
            Controle_Cocher(Saisie18);
            Controle_Cocher(Saisie19);
            Controle_Cocher(Saisie20);
            if (Compte_OBJ_Cocher == 1) { Score =  3 ; };
            if (Compte_OBJ_Cocher == 2) { Score =  6 ; };
            if (Compte_OBJ_Cocher == 3) { Score =  10 ; };
            if (Compte_OBJ_Cocher == 4) { Score =  15 ; };
            
            Score_ObjS = Score;
            Scores_Joueur = Score;
        }

        private void Controle_Cocher(string Coche)
        {
            if (Coche == "true") { Compte_OBJ_Cocher++; };
        }
    }
}
