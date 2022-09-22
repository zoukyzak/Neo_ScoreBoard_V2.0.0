using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using CPV9.Classes;
using CPV9;

namespace CPV9.Windows
{    
    public partial class Tv : Window
    {

        static private string _dossier_Options = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CP_v9_Options\";
        static private string _fichier_Options_Resolution_Tv = "Option_Resolution_Tv.csv";
        static private string _chemin_Options_Resolution_Tv = System.IO.Path.Combine(_dossier_Options, _fichier_Options_Resolution_Tv);


        string Table;
        string Image_P1;
        string Image_P2;
        public double[] _Resolution_Tv = new double[2];
        public bool Forcing_Height_Tv = false;
        public int[,] _Capes_Tv = new int[3,300];
        public string Text_Capes_Tv = "";
        public Tv()
        {
            InitializeComponent();
            Load_Options_Tv();
            Taille_Tv();
            Init_Capes();
        }

        private void Taille_Tv()
        {
            if (TextBox_Resolution_Tv_X.Text == null || TextBox_Resolution_Tv_Y.Text == null)
            {
                _Resolution_Tv[0] = 960;
                _Resolution_Tv[1] = 540;
            }            

            this.Width = _Resolution_Tv[0];
            this.Height = _Resolution_Tv[1];
            Save_Options_Tv();
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
            Round_Tv();
            Label_Tv_Titre.Content = Table;
            TextBlock_Nom_Player_1_Tv.Text = Pseudo_P1;
            TextBlock_Nom_Player_2_Tv.Text = Pseudo_P2;
            TextBlock_Nom_SG_1_Tv.Text = SG_P1;
            TextBlock_Nom_SG_2_Tv.Text = SG_P2;
            TextBlock_Score_Player_1_Tv.Text = Convert.ToString(Score_P1);
            TextBlock_Score_Player_2_Tv.Text = Convert.ToString(Score_P2);
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

        public void Round_Tv()
        {
            TextBlock_Round.Text = Convert.ToString(DonneesPublic._Round);
        }
        
        private void Selection_Image_Attaquant_Tv(string Image_Attaquant)
        {
            Select_Image_Player_Tv("Att", Image_Attaquant);
            Image_PL1.Visibility = Visibility.Visible;
            return;

        }
        private void Selection_Image_Defenseur_Tv(string Image_Defenseur)
        {
            Select_Image_Player_Tv("Def", Image_Defenseur);
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

        private void Window_TV_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ///Double _Taille_Ref_X = Convert.ToInt32(this.ActualWidth);
            ///Double _Resolution = _Taille_Ref_X / 960;
            ///
            _Resolution_Tv[0] = this.Width;
            _Resolution_Tv[1] = this.Height;

            double Rapport_Taille_X = _Resolution_Tv[0] / 960;
            double Rapport_Taille_Y = _Resolution_Tv[1] / 520;
            if (Rapport_Taille_X < 1) { Rapport_Taille_X = 1; };
            if (Rapport_Taille_Y < 1) { Rapport_Taille_Y = 1; };
            if (Forcing_Height_Tv == false) { this.Height = 540 * Rapport_Taille_X; };
            Forcing_Height_Tv = false;
            TextBox_Resolution_Tv_X.Text = Convert.ToString(_Resolution_Tv[0]);
            TextBox_Resolution_Tv_Y.Text = Convert.ToString(_Resolution_Tv[1]);

            Image_PL1.Width = 250 * Rapport_Taille_X;
            Image_PL2.Width = 250 * Rapport_Taille_X;
            FDE_Warhammer.Width = 250 * Rapport_Taille_X;
            FDE_Neo.Width = 250 * Rapport_Taille_X;
            Image_FDE_CA_Nachmund.Width = 125 * Rapport_Taille_X;
            Image_FDE_CA_Nephilim.Width = 125 * Rapport_Taille_X;
            StackPanel_CA_Tv.Margin = new Thickness(0, -40 * Rapport_Taille_X, 0, 0);
            Label_FDE_Alpha.Margin = new Thickness(0, -30 * Rapport_Taille_X, 0, 0);
            Label_Tv_Titre.Margin = new Thickness(0,-Rapport_Taille_X, 0, 0);
            TextBlock_Score_Player_1_Tv.FontSize = 90 * Rapport_Taille_X;
            TextBlock_Score_Player_2_Tv.FontSize = 90 * Rapport_Taille_X;
            Label_Serapare_Score.FontSize = 90 * Rapport_Taille_X;
            Label_Round.FontSize = 30 * Rapport_Taille_X;
            TextBlock_Round.FontSize = 30 * Rapport_Taille_X;
            TextBlock_Nom_Player_1_Tv.FontSize = 30 * Rapport_Taille_X;
            TextBlock_Nom_Player_2_Tv.FontSize = 30 * Rapport_Taille_X;
            TextBlock_Nom_SG_1_Tv.FontSize = 20 * Rapport_Taille_X;
            TextBlock_Nom_SG_2_Tv.FontSize = 20 * Rapport_Taille_X;
            Label_Tv_Cape_Player_Attaquant_1.FontSize = 10 * Rapport_Taille_X;
            Label_Tv_Cape_Player_Attaquant_2.FontSize = 10 * Rapport_Taille_X;
            Label_Tv_Cape_Player_Attaquant_3.FontSize = 10 * Rapport_Taille_X;
            Label_Tv_Cape_Player_Attaquant_4.FontSize = 10 * Rapport_Taille_X;
            Label_Tv_Cape_Player_Attaquant_5.FontSize = 10 * Rapport_Taille_X;
            Label_Tv_Cape_Player_Attaquant_6.FontSize = 10 * Rapport_Taille_X;
            Label_Tv_Cape_Player_Defenseur_1.FontSize = 10 * Rapport_Taille_X;
            Label_Tv_Cape_Player_Defenseur_2.FontSize = 10 * Rapport_Taille_X;
            Label_Tv_Cape_Player_Defenseur_3.FontSize = 10 * Rapport_Taille_X;
            Label_Tv_Cape_Player_Defenseur_4.FontSize = 10 * Rapport_Taille_X;
            Label_Tv_Cape_Player_Defenseur_5.FontSize = 10 * Rapport_Taille_X;
            Label_Tv_Cape_Player_Defenseur_6.FontSize = 10 * Rapport_Taille_X;
        }

        private void Button_Option_Tv_Click(object sender, RoutedEventArgs e)
        {
            StackPanel_Tv_Scores.Visibility = Visibility.Collapsed;
            StackPanel_Round.Visibility = Visibility.Collapsed;
            StackPanel_WIn_Tv_Gauche.Visibility = Visibility.Collapsed;
            StackPanel_WIn_Tv_Doite.Visibility = Visibility.Collapsed;
            Button_Option_Tv.Visibility = Visibility.Collapsed;
            StackPanel_Resolution_Tv.Visibility = Visibility.Visible;
        }
        private void Button_Option_Resolution_Tv_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Resolution_Tv_X.Text != "" && TextBox_Resolution_Tv_Y.Text != "")
            {
                _Resolution_Tv[0] = Convert.ToInt16(TextBox_Resolution_Tv_X.Text);
                _Resolution_Tv[1] = Convert.ToInt16(TextBox_Resolution_Tv_Y.Text);
                if (_Resolution_Tv[0] < 960 || _Resolution_Tv[1] < 540)
                {
                    _Resolution_Tv[0] = 960;
                    _Resolution_Tv[1] = 540;
                }                
            }
            Forcing_Height_Tv = true;
            StackPanel_Tv_Scores.Visibility = Visibility.Visible;
            StackPanel_Round.Visibility = Visibility.Visible;
            StackPanel_WIn_Tv_Gauche.Visibility = Visibility.Visible;
            StackPanel_WIn_Tv_Doite.Visibility = Visibility.Visible;
            Button_Option_Tv.Visibility = Visibility.Visible;
            StackPanel_Resolution_Tv.Visibility = Visibility.Collapsed;
            Taille_Tv();
        }

        public void Save_Options_Tv()
        {
            Classe_Sauvegarde_Options.Sauvegarder_Options_Resolution_Tv_CSV(_Resolution_Tv);
        }
        private void Load_Options_Tv()
        {
            if (File.Exists(_chemin_Options_Resolution_Tv))
            {
                using (StreamReader fichier = new StreamReader(_chemin_Options_Resolution_Tv, Encoding.UTF8))
                {
                    String ligne;
                    int i = 0;
                    while ((ligne = fichier.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(ligne))
                        {
                            string[] champs = ligne.Split(';');
                            _Resolution_Tv[i] = Convert.ToDouble(champs[0]);
                            i++;
                        }
                    }
                }
            }
        }

        #region Controle_Key

        private void Controle_Key_KeyDown(object sender, KeyEventArgs e)
        {
            controle_Nombre(e);
        }
        public void controle_Nombre(KeyEventArgs e)
        {
            Char controle_Tappe = Convert.ToChar(e.Key);


            if (Char.IsNumber(controle_Tappe))
            {
                e.Handled = true;
            }
            else if (controle_Tappe == Convert.ToChar('z'))
            {
                e.Handled = true;
            }
            else if (Char.IsLower(controle_Tappe))
            {
                e.Handled = true;
            }
            else if (Char.IsHighSurrogate(controle_Tappe))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(controle_Tappe))
            {
                e.Handled = true;
            }
            else if (Char.IsDigit(controle_Tappe))
            {
                e.Handled = true;
            }
            else if (Char.IsWhiteSpace(controle_Tappe))
            {
                e.Handled = true;
            }
            else if (Char.IsPunctuation(controle_Tappe))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(controle_Tappe))
            {
                e.Handled = true;
            }
            else if (Char.IsLowSurrogate(controle_Tappe))
            {
                e.Handled = true;
            }
            else if (Char.IsSymbol(controle_Tappe))
            {
                e.Handled = true;
            }
            else if (controle_Tappe.Equals('.'))
            {
                e.Handled = true;
            }

            else
            {
                e.Handled = false;
            }
        }

        #endregion

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true ;
            ///DonneesPublic._win = false;
            ///DonneesPublic._win_Close = true;
        }
    }
}
