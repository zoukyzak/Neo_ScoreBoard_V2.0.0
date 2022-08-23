using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CPV9.Classes;

namespace CPV9.Windows
{
    
    public partial class Tv : Window
    {
        string Table;
        Double _Taille = 1;
        Double _Taille_Ref = 1;
        Double Resolution;
        int Taille_Image_Ref = 150;
        Double Taille_Image;
        string Image_P1;
        string Image_P2;
        bool style_Tv = false;

        public int[,] _Capes_Tv = new int[3,300];
        public string Text_Capes_Tv = "";
        public Tv()
        {
            InitializeComponent();
            Init_Capes();
            _Taille_Ref = Convert.ToInt32(this.MinHeight) + Convert.ToInt32(this.MinWidth);
        }
        private void Init_Capes()
        {
            Label_Tv_Cape_Player_Attaquant_1.Visibility = Visibility.Collapsed;
            Label_Tv_Cape_Player_Attaquant_2.Visibility = Visibility.Collapsed;
            Label_Tv_Cape_Player_Attaquant_3.Visibility = Visibility.Collapsed;
            Label_Tv_Cape_Player_Attaquant_4.Visibility = Visibility.Collapsed;
            Label_Tv_Cape_Player_Attaquant_5.Visibility = Visibility.Collapsed;
            Label_Tv_Cape_Player_Attaquant_6.Visibility = Visibility.Collapsed;

            Label_Tv_Cape_Player_Defenseur_1.Visibility = Visibility.Collapsed;
            Label_Tv_Cape_Player_Defenseur_2.Visibility = Visibility.Collapsed;
            Label_Tv_Cape_Player_Defenseur_3.Visibility = Visibility.Collapsed;
            Label_Tv_Cape_Player_Defenseur_4.Visibility = Visibility.Collapsed;
            Label_Tv_Cape_Player_Defenseur_5.Visibility = Visibility.Collapsed;
            Label_Tv_Cape_Player_Defenseur_6.Visibility = Visibility.Collapsed;
        }
        public void Collect_Cape_Tv(string Player, int ID_Cape_Tv, string text_Cape_Tv)
         {
            if (Player == "Att")
            {
                if (ID_Cape_Tv == 1)
                {
                    Label_Tv_Cape_Player_Attaquant_1.Content = text_Cape_Tv;
                    if (text_Cape_Tv == "")
                    {
                        Label_Tv_Cape_Player_Attaquant_1.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Label_Tv_Cape_Player_Attaquant_1.Visibility = Visibility.Visible;
                    }
                }
                if (ID_Cape_Tv == 2)
                {
                    Label_Tv_Cape_Player_Attaquant_2.Content = text_Cape_Tv;
                    if (text_Cape_Tv == "")
                    {
                        Label_Tv_Cape_Player_Attaquant_2.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Label_Tv_Cape_Player_Attaquant_2.Visibility = Visibility.Visible;
                    }
                }                
                if (ID_Cape_Tv == 3)
                {
                    Label_Tv_Cape_Player_Attaquant_3.Content = text_Cape_Tv;
                    if (text_Cape_Tv == "")
                    {
                        Label_Tv_Cape_Player_Attaquant_3.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Label_Tv_Cape_Player_Attaquant_3.Visibility = Visibility.Visible;
                    }
                }
                if (ID_Cape_Tv == 4)
                {
                    Label_Tv_Cape_Player_Attaquant_4.Content = text_Cape_Tv;
                    if (text_Cape_Tv == "")
                    {
                        Label_Tv_Cape_Player_Attaquant_4.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Label_Tv_Cape_Player_Attaquant_4.Visibility = Visibility.Visible;
                    }
                }
                if (ID_Cape_Tv == 5)
                {
                    Label_Tv_Cape_Player_Attaquant_5.Content = text_Cape_Tv;
                    if (text_Cape_Tv == "")
                    {
                        Label_Tv_Cape_Player_Attaquant_5.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Label_Tv_Cape_Player_Attaquant_5.Visibility = Visibility.Visible;
                    }
                }
                if (ID_Cape_Tv == 6)
                {
                    Label_Tv_Cape_Player_Attaquant_6.Content = text_Cape_Tv;
                    if (text_Cape_Tv == "")
                    {
                        Label_Tv_Cape_Player_Attaquant_6.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Label_Tv_Cape_Player_Attaquant_6.Visibility = Visibility.Visible;
                    }
                }
            }
            if (Player == "Def")
            {
                if (ID_Cape_Tv == 1)
                {                    
                    Label_Tv_Cape_Player_Defenseur_1.Content = text_Cape_Tv;
                    if (text_Cape_Tv == "")
                    {
                        Label_Tv_Cape_Player_Defenseur_1.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Label_Tv_Cape_Player_Defenseur_1.Visibility = Visibility.Visible;
                    }
                }
                if (ID_Cape_Tv == 2)
                {
                    Label_Tv_Cape_Player_Defenseur_2.Content = text_Cape_Tv;
                    if (text_Cape_Tv == "")
                    {
                        Label_Tv_Cape_Player_Defenseur_2.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Label_Tv_Cape_Player_Defenseur_2.Visibility = Visibility.Visible;
                    }
                }
                if (ID_Cape_Tv == 3)
                {
                    Label_Tv_Cape_Player_Defenseur_3.Content = text_Cape_Tv;
                    if (text_Cape_Tv == "")
                    {
                        Label_Tv_Cape_Player_Defenseur_3.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Label_Tv_Cape_Player_Defenseur_3.Visibility = Visibility.Visible;
                    }
                }
                if (ID_Cape_Tv == 4)
                {
                    Label_Tv_Cape_Player_Defenseur_4.Content = text_Cape_Tv;
                    if (text_Cape_Tv == "")
                    {
                        Label_Tv_Cape_Player_Defenseur_4.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Label_Tv_Cape_Player_Defenseur_4.Visibility = Visibility.Visible;
                    }
                }
                if (ID_Cape_Tv == 5)
                {
                    Label_Tv_Cape_Player_Defenseur_5.Content = text_Cape_Tv;
                    if (text_Cape_Tv == "")
                    {
                        Label_Tv_Cape_Player_Defenseur_5.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Label_Tv_Cape_Player_Defenseur_5.Visibility = Visibility.Visible;
                    }
                }
                if (ID_Cape_Tv == 6)
                {
                    Label_Tv_Cape_Player_Defenseur_6.Content = text_Cape_Tv;
                    if (text_Cape_Tv == "")
                    {
                        Label_Tv_Cape_Player_Defenseur_6.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Label_Tv_Cape_Player_Defenseur_6.Visibility = Visibility.Visible;
                    }
                }
            }
        }
        public void Actu_Tv(int Table_Tv, String Image_Pl1, String Image_Pl2, String Pseudo_P1, string Pseudo_P2, String SG_P1, string SG_P2, int Score_P1, int Score_P2)
        {
            _Tables(Table_Tv);
            Label_Tv_Titre.Content = Table;
            TextBlock_Nom_Player_1_Tv.Text = Pseudo_P1;
            TextBlock_Nom_Player_2_Tv.Text = Pseudo_P2;
            TextBlock_Nom_SG_1_Tv.Text = SG_P1;
            TextBlock_Nom_SG_2_Tv.Text = SG_P2;
            TextBlock_Score_Player_1_Tv.Text = Convert.ToString(Score_P1);
            TextBlock_Score_Player_2_Tv.Text = Convert.ToString(Score_P2);
            Taille(Resolution, _Taille_Ref);
            Image_P1 = Image_Pl1;
            Image_P2 = Image_Pl2;
            Selection_Image_Attaquant_Tv(Image_Pl1);
            Selection_Image_Defenseur_Tv(Image_Pl2);
        }
        
        private void _Tables(int Table_Tv)
        {
            if (Table_Tv == 1) { Table = "Mars"; };
            if (Table_Tv == 2) { Table = "Highlands"; };
            if (Table_Tv == 3) { Table = "Quarantaine"; };
        }

        public void Round_Tv(int _Round)
        {
            TextBlock_Round.Text = Convert.ToString(_Round);
        }
        private void Taille(Double Resolution, Double _Taille_ref)
        {
            _Taille = Resolution / _Taille_Ref;
            Taille_Image = Taille_Image_Ref * _Taille;
            if (_Taille <= 0) { _Taille = 1; };
            Label_Tv_Titre.FontSize = 25 * _Taille;
            CDV9_droit_Neo.FontSize = 30 * _Taille;
            CDV9_gauche_Neo.FontSize = 30 * _Taille;
            CDV9_droit_ScoreBoard.FontSize = 10 * _Taille;
            CDV9_gauche_ScoreBoard.FontSize = 10 * _Taille;
            TextBlock_Nom_Player_1_Tv.FontSize = 20 * _Taille;
            TextBlock_Nom_Player_2_Tv.FontSize = 20 * _Taille;
            TextBlock_Nom_SG_1_Tv.FontSize = 20 * _Taille;
            TextBlock_Nom_SG_2_Tv.FontSize = 20 * _Taille;
            TextBlock_Score_Player_1_Tv.FontSize = 35 * _Taille;
            Label_Serapare_Score.FontSize = 60 * _Taille;
            Label_Round.FontSize = 20 * _Taille;
            TextBlock_Round.FontSize = 20 * _Taille;
            TextBlock_Score_Player_2_Tv.FontSize = 35 * _Taille;
            Selection_Image_Attaquant_Tv(Image_P1);
            Selection_Image_Defenseur_Tv(Image_P2);
            StackPanel_Cape_Player_1_Tv.Margin = new Thickness (5, 150 * _Taille, 0, 0);
            StackPanel_Cape_Player_2_Tv.Margin = new Thickness (0, 170 * _Taille, 5, 0);

            Label_Tv_Cape_Player_Attaquant_1.FontSize= 8 * _Taille;
            Label_Tv_Cape_Player_Attaquant_2.FontSize= 8 * _Taille;
            Label_Tv_Cape_Player_Attaquant_3.FontSize= 8 * _Taille;
            Label_Tv_Cape_Player_Attaquant_4.FontSize= 8 * _Taille;
            Label_Tv_Cape_Player_Defenseur_1.FontSize = 8 * _Taille;
            Label_Tv_Cape_Player_Defenseur_2.FontSize = 8 * _Taille;
            Label_Tv_Cape_Player_Defenseur_3.FontSize = 8 * _Taille;
            Label_Tv_Cape_Player_Defenseur_4.FontSize = 8 * _Taille;
        }

        private void Window_Tv_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Double _Resolution_X = Convert.ToInt32(this.ActualWidth);
            Double _Resolution_Y = Convert.ToInt32(this.ActualHeight);
            
            Resolution = _Resolution_X + _Resolution_Y;
            Taille(Resolution, _Taille_Ref);
        }

        private void Selection_Image_Attaquant_Tv(string Image_Attaquant)
        {
            Select_Image_Player_Tv("Att", Image_Attaquant);
            Image_PL1.Height = Taille_Image;
            Image_PL1.Width = Taille_Image;
            Image_PL1.Visibility = Visibility.Visible;
            return;

        }
        private void Selection_Image_Defenseur_Tv(string Image_Defenseur)
        {
            Select_Image_Player_Tv("Def", Image_Defenseur);
            Image_PL2.Height = Taille_Image;
            Image_PL2.Width = Taille_Image;
            Image_PL2.Visibility = Visibility.Visible;
            return;
        }

        private void Select_Image_Player_Tv(String Player, String Choix)
        {

            if (Player == "Att")
            {
                BitmapImage Chemin_Image_Pl1 = new BitmapImage();
                Chemin_Image_Pl1.BeginInit();
                Classe_Images_Players chemin_Image;
                chemin_Image = new Classe_Images_Players(Choix);
                Chemin_Image_Pl1.UriSource = new Uri(chemin_Image.Chemin_Image_Player, UriKind.Relative);
                Chemin_Image_Pl1.EndInit();
                Image_PL1.Source = Chemin_Image_Pl1;
            }
            if (Player == "Def")
            {
                BitmapImage Chemin_Image_Pl2 = new BitmapImage();
                Chemin_Image_Pl2.BeginInit();
                Classe_Images_Players chemin_Image;
                chemin_Image = new Classe_Images_Players(Choix);
                Chemin_Image_Pl2.UriSource = new Uri(chemin_Image.Chemin_Image_Player, UriKind.Relative);
                Chemin_Image_Pl2.EndInit();
                Image_PL2.Source = Chemin_Image_Pl2;
            }
        }
        private void Button_Option_Tv_Click(object sender, RoutedEventArgs e)
        {
            if (style_Tv == false)
            {
                this.WindowStyle = WindowStyle.SingleBorderWindow;
                style_Tv = true;
                return;
            }
            if (style_Tv == true)
            {
                this.WindowStyle = WindowStyle.None;
                style_Tv = false;
                return;
            }
        }
    }
}
