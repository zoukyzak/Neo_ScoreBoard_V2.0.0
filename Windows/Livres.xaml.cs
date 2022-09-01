using System;
using System.Windows;

namespace CPV9.Windows
{
    public partial class Livres : Window
    {
        public Livres()
        {
            InitializeComponent();
            
        }
        public void Affich_Lives(int Objectif, string CA)
        {
            CPV9.Classes.Descript_OBJS CetObjectif = new CPV9.Classes.Descript_OBJS(Objectif, CA);

            Label_OBJ_Livres_1.Content = CetObjectif.L1;
            Label_OBJ_Livres_2.Content = CetObjectif.L2;
            Label_OBJ_Livres_3.Content = CetObjectif.L3;
            Label_OBJ_Livres_4.Content = CetObjectif.L4;
            Label_OBJ_Livres_5.Content = CetObjectif.L5;
            Label_OBJ_Livres_6.Content = CetObjectif.L6;
            Label_OBJ_Livres_7.Content = CetObjectif.L7;
            Label_OBJ_Livres_8.Content = CetObjectif.L8;
            Label_OBJ_Livres_9.Content = CetObjectif.L9;
            Label_OBJ_Livres_10.Content = CetObjectif.L10;
            Label_OBJ_Livres_11.Content = CetObjectif.L11;
            Label_OBJ_Livres_12.Content = CetObjectif.L12;
            Label_OBJ_Livres_13.Content = CetObjectif.L13;
            Label_OBJ_Livres_14.Content = CetObjectif.L14;

            double Rapport_Taille = (this.ActualHeight * this.ActualWidth * 10) / (800 * 600);
            Label_OBJ_Livres_1.FontSize = 1.2 * Rapport_Taille;
            Label_OBJ_Livres_2.FontSize  = Rapport_Taille;
            Label_OBJ_Livres_3.FontSize  = Rapport_Taille;
            Label_OBJ_Livres_4.FontSize  = Rapport_Taille;
            Label_OBJ_Livres_5.FontSize  = Rapport_Taille;
            Label_OBJ_Livres_6.FontSize  = Rapport_Taille;
            Label_OBJ_Livres_7.FontSize  = Rapport_Taille;
            Label_OBJ_Livres_8.FontSize  = Rapport_Taille;
            Label_OBJ_Livres_9.FontSize  = Rapport_Taille;
            Label_OBJ_Livres_10.FontSize = Rapport_Taille;
            Label_OBJ_Livres_11.FontSize = Rapport_Taille;
            Label_OBJ_Livres_12.FontSize = Rapport_Taille;
            Label_OBJ_Livres_13.FontSize = Rapport_Taille;
            Label_OBJ_Livres_14.FontSize = Rapport_Taille;
        }
    }
}
