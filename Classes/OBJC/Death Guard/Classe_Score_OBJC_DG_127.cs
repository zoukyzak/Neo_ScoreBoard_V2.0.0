﻿using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJC_DG_127
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;

        public Classe_Score_OBJC_DG_127(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5, String Saisie6)
        {
            VALEUR(Saisie1);
            VALEUR(Saisie2);
            VALEUR(Saisie3);
            VALEUR(Saisie4);
            VALEUR(Saisie5);
            VALEUR(Saisie6);

            Score_ObjS = Score;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        private void VALEUR(string Donne1)
        {
            if (Donne1 == "true")
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
