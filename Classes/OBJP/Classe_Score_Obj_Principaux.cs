using System;

namespace CPV9.Classes
{
    public class Classe_Score_Obj_Principaux
    {

        public int Scores_Joueur = 0;
        public int Score_ObjP { get; set; }

        private int Score = 0;
        private int seuil_Bas = 0;
        private int seuil_Haut = 0;

        public Classe_Score_Obj_Principaux(int Formatbis, string Saisie1, string Saisie2, string Saisie3, string Saisie4, string Saisie5, string Saisie6, string Saisie7, string Saisie8)
        {
            if (Formatbis == 1)/// Formatbis , identification du scoring a partir de 2 objectifs pris
            {
                seuil_Bas = 2;
                seuil_Haut = 3;
            }
            else
            {
                seuil_Bas = 1;
                seuil_Haut = 2;
            }

            Control(Saisie1, Saisie2);
            Control(Saisie3, Saisie4);
            Control(Saisie5, Saisie6);
            Control(Saisie7, Saisie8);

            Score_ObjP = Score;
            if (Score >= 45)
            {
                Score = 45;
            }
            Scores_Joueur = Score;
        }

        private void Control(string C1, string C2)
        {
            if (C1 != "" && C2 != "")
            {
                if (Convert.ToInt32(C1) >= seuil_Bas) { Calcul(); };
                if (Convert.ToInt32(C1) >= seuil_Haut) { Calcul(); };
                if (Convert.ToInt32(C1) > Convert.ToInt32(C2)) { Calcul(); };
            }
        }
        private void Calcul()
        {
            Score = Score + 4;
        }
    }
}
