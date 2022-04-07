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

            Label_Tv_Cape_Player_Defenseur_1.Visibility = Visibility.Collapsed;
            Label_Tv_Cape_Player_Defenseur_2.Visibility = Visibility.Collapsed;
            Label_Tv_Cape_Player_Defenseur_3.Visibility = Visibility.Collapsed;
            Label_Tv_Cape_Player_Defenseur_4.Visibility = Visibility.Collapsed;
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
            if (Image_Attaquant == "  Adepta Sororitas")
            {
                Image_PL1_ADEPTA_SORORITAS.Height = Taille_Image;
                Image_PL1_ADEPTA_SORORITAS.Width = Taille_Image;
                Image_PL1_ADEPTA_SORORITAS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Adeptus Custodes")
            {
                Image_PL1_ADEPTUS_CUSTODES.Height = Taille_Image;
                Image_PL1_ADEPTUS_CUSTODES.Width = Taille_Image;
                Image_PL1_ADEPTUS_CUSTODES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Adeptus Mechanicus")
            {
                Image_PL1_ADEPTUS_MECHANICUS.Height = Taille_Image;
                Image_PL1_ADEPTUS_MECHANICUS.Width = Taille_Image;
                Image_PL1_ADEPTUS_MECHANICUS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Astra Militarum")
            {
                Image_PL1_ASTRA_MILITARUM.Height = Taille_Image;
                Image_PL1_ASTRA_MILITARUM.Width = Taille_Image;
                Image_PL1_ASTRA_MILITARUM.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Chaos Daemons")
            {
                Image_PL1_CHAOS_DAEMONS.Height = Taille_Image;
                Image_PL1_CHAOS_DAEMONS.Width = Taille_Image;
                Image_PL1_CHAOS_DAEMONS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Chaos Knights")
            {
                Image_PL1_CHAOS_KNIGHTS.Height = Taille_Image;
                Image_PL1_CHAOS_KNIGHTS.Width = Taille_Image;
                Image_PL1_CHAOS_KNIGHTS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Chaos Space Marines")
            {
                Image_PL1_CHAOS_SPACE_MARINES.Height = Taille_Image;
                Image_PL1_CHAOS_SPACE_MARINES.Width = Taille_Image;
                Image_PL1_CHAOS_SPACE_MARINES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Craftworlds")
            {
                Image_PL1_CRAFTWORLDS.Height = Taille_Image;
                Image_PL1_CRAFTWORLDS.Width = Taille_Image;
                Image_PL1_CRAFTWORLDS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Death Guard")
            {
                Image_PL1_DEATH_GUARD.Height = Taille_Image;
                Image_PL1_DEATH_GUARD.Width = Taille_Image;
                Image_PL1_DEATH_GUARD.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Drukhari")
            {
                Image_PL1_DRUKHARI.Height = Taille_Image;
                Image_PL1_DRUKHARI.Width = Taille_Image;
                Image_PL1_DRUKHARI.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Genestealer Cults")
            {
                Image_PL1_GENESTEALER_CULTS.Height = Taille_Image;
                Image_PL1_GENESTEALER_CULTS.Width = Taille_Image;
                Image_PL1_GENESTEALER_CULTS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Grey Knights")
            {
                Image_PL1_GREY_KNIGHTS.Height = Taille_Image;
                Image_PL1_GREY_KNIGHTS.Width = Taille_Image;
                Image_PL1_GREY_KNIGHTS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Harlequins")
            {
                Image_PL1_HARLEQUINS.Height = Taille_Image;
                Image_PL1_HARLEQUINS.Width = Taille_Image;
                Image_PL1_HARLEQUINS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Imperial Knights")
            {
                Image_PL1_IMPERIAL_KNIGHTS.Height = Taille_Image;
                Image_PL1_IMPERIAL_KNIGHTS.Width = Taille_Image;
                Image_PL1_IMPERIAL_KNIGHTS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Necrons")
            {
                Image_PL1_NECRONS.Height = Taille_Image;
                Image_PL1_NECRONS.Width = Taille_Image;
                Image_PL1_NECRONS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Officio Assassinorum")
            {
                Image_PL1_OFFICIO_ASSASSINORUM.Height = Taille_Image;
                Image_PL1_OFFICIO_ASSASSINORUM.Width = Taille_Image;
                Image_PL1_OFFICIO_ASSASSINORUM.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Orks")
            {
                Image_PL1_ORKS.Height = Taille_Image;
                Image_PL1_ORKS.Width = Taille_Image;
                Image_PL1_ORKS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  SM_Space Marines")
            {
                Image_PL1_SPACE_MARINES.Height = Taille_Image;
                Image_PL1_SPACE_MARINES.Width = Taille_Image;
                Image_PL1_SPACE_MARINES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  SM_Dark Angels")
            {
                Image_PL1_DARK_ANGELS.Height = Taille_Image;
                Image_PL1_DARK_ANGELS.Width = Taille_Image;
                Image_PL1_DARK_ANGELS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  SM_White Scares")
            {
                Image_PL1_SM_WHITE_SCARES.Height = Taille_Image;
                Image_PL1_SM_WHITE_SCARES.Width = Taille_Image;
                Image_PL1_SM_WHITE_SCARES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  SM_Space Wolves")
            {
                Image_PL1_SPACE_WOLVES.Height = Taille_Image;
                Image_PL1_SPACE_WOLVES.Width = Taille_Image;
                Image_PL1_SPACE_WOLVES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  SM_Imperial Fists")
            {
                Image_PL1_SM_IMPERIAL_FISTS.Height = Taille_Image;
                Image_PL1_SM_IMPERIAL_FISTS.Width = Taille_Image;
                Image_PL1_SM_IMPERIAL_FISTS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  SM_Crimson Fists")
            {
                Image_PL1_SPACE_MARINES.Height = Taille_Image;
                Image_PL1_SPACE_MARINES.Width = Taille_Image;
                Image_PL1_SPACE_MARINES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  SM_Black Templars")
            {
                Image_PL1_SPACE_MARINES.Height = Taille_Image;
                Image_PL1_SPACE_MARINES.Width = Taille_Image;
                Image_PL1_SPACE_MARINES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  SM_Blood Angels")
            {
                Image_PL1_BLOOD_ANGELS.Height = Taille_Image;
                Image_PL1_BLOOD_ANGELS.Width = Taille_Image;
                Image_PL1_BLOOD_ANGELS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  SM_Flesh Tearers")
            {
                Image_PL1_SPACE_MARINES.Height = Taille_Image;
                Image_PL1_SPACE_MARINES.Width = Taille_Image;
                Image_PL1_SPACE_MARINES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  SM_Iron Hands")
            {
                Image_PL1_SM_IRON_HANDS.Height = Taille_Image;
                Image_PL1_SM_IRON_HANDS.Width = Taille_Image;
                Image_PL1_SM_IRON_HANDS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  SM_Ultramarines")
            {
                Image_PL1_SM_ULTRAMARINES.Height = Taille_Image;
                Image_PL1_SM_ULTRAMARINES.Width = Taille_Image;
                Image_PL1_SM_ULTRAMARINES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  SM_Salamandres")
            {
                Image_PL1_SM_SALAMANDRES.Height = Taille_Image;
                Image_PL1_SM_SALAMANDRES.Width = Taille_Image;
                Image_PL1_SM_SALAMANDRES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  SM_Raven Guard")
            {
                Image_PL1_SM_RAVEN_GUARD.Height = Taille_Image;
                Image_PL1_SM_RAVEN_GUARD.Width = Taille_Image;
                Image_PL1_SM_RAVEN_GUARD.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  SM_Deathwatch")
            {
                Image_PL1_DEATHWATCH.Height = Taille_Image;
                Image_PL1_DEATHWATCH.Width = Taille_Image;
                Image_PL1_DEATHWATCH.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  T AU Empire")
            {
                Image_PL1_T_AU_EMPIRE.Height = Taille_Image;
                Image_PL1_T_AU_EMPIRE.Width = Taille_Image;
                Image_PL1_T_AU_EMPIRE.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Thousand Sons")
            {
                Image_PL1_THOUSAND_SONS.Height = Taille_Image;
                Image_PL1_THOUSAND_SONS.Width = Taille_Image;
                Image_PL1_THOUSAND_SONS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Tyranid")
            {
                Image_PL1_TYRANID.Height = Taille_Image;
                Image_PL1_TYRANID.Width = Taille_Image;
                Image_PL1_TYRANID.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Attaquant == "  Ynarri")
            {
                Image_PL1_YNARRI.Height = Taille_Image;
                Image_PL1_YNARRI.Width = Taille_Image;
                Image_PL1_YNARRI.Visibility = Visibility.Visible;
                return;
            }

        }
        private void Selection_Image_Defenseur_Tv(string Image_Defenseur)
        {
            if (Image_Defenseur == "  Adepta Sororitas")
            {
                Image_PL2_ADEPTA_SORORITAS.Height = Taille_Image;
                Image_PL2_ADEPTA_SORORITAS.Width = Taille_Image;
                Image_PL2_ADEPTA_SORORITAS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Adeptus Custodes")
            {;
                Image_PL2_ADEPTUS_CUSTODES.Height = Taille_Image;
                Image_PL2_ADEPTUS_CUSTODES.Width = Taille_Image;
                Image_PL2_ADEPTUS_CUSTODES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Adeptus Mechanicus")
            {
                Image_PL2_ADEPTUS_MECHANICUS.Height = Taille_Image;
                Image_PL2_ADEPTUS_MECHANICUS.Width = Taille_Image;
                Image_PL2_ADEPTUS_MECHANICUS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Astra Militarum")
            {
                Image_PL2_ASTRA_MILITARUM.Height = Taille_Image;
                Image_PL2_ASTRA_MILITARUM.Width = Taille_Image;
                Image_PL2_ASTRA_MILITARUM.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Chaos Daemons")
            {
                Image_PL2_CHAOS_DAEMONS.Height = Taille_Image;
                Image_PL2_CHAOS_DAEMONS.Width = Taille_Image;
                Image_PL2_CHAOS_DAEMONS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Chaos Knights")
            {
                Image_PL2_CHAOS_KNIGHTS.Height = Taille_Image;
                Image_PL2_CHAOS_KNIGHTS.Width = Taille_Image;
                Image_PL2_CHAOS_KNIGHTS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Chaos Space Marines")
            {
                Image_PL2_CHAOS_SPACE_MARINES.Height = Taille_Image;
                Image_PL2_CHAOS_SPACE_MARINES.Width = Taille_Image;
                Image_PL2_CHAOS_SPACE_MARINES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Craftworlds")
            {
                Image_PL2_CRAFTWORLDS.Height = Taille_Image;
                Image_PL2_CRAFTWORLDS.Width = Taille_Image;
                Image_PL2_CRAFTWORLDS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Death Guard")
            {
                Image_PL2_DEATH_GUARD.Height = Taille_Image;
                Image_PL2_DEATH_GUARD.Width = Taille_Image;
                Image_PL2_DEATH_GUARD.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Drukhari")
            {
                Image_PL2_DRUKHARI.Height = Taille_Image;
                Image_PL2_DRUKHARI.Width = Taille_Image;
                Image_PL2_DRUKHARI.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Genestealer Cults")
            {
                Image_PL2_GENESTEALER_CULTS.Height = Taille_Image;
                Image_PL2_GENESTEALER_CULTS.Width = Taille_Image;
                Image_PL2_GENESTEALER_CULTS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Grey Knights")
            {
                Image_PL2_GREY_KNIGHTS.Height = Taille_Image;
                Image_PL2_GREY_KNIGHTS.Width = Taille_Image;
                Image_PL2_GREY_KNIGHTS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Harlequins")
            {
                Image_PL2_HARLEQUINS.Height = Taille_Image;
                Image_PL2_HARLEQUINS.Width = Taille_Image;
                Image_PL2_HARLEQUINS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Imperial Knights")
            {
                Image_PL2_IMPERIAL_KNIGHTS.Height = Taille_Image;
                Image_PL2_IMPERIAL_KNIGHTS.Width = Taille_Image;
                Image_PL2_IMPERIAL_KNIGHTS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Necrons")
            {
                Image_PL2_NECRONS.Height = Taille_Image;
                Image_PL2_NECRONS.Width = Taille_Image;
                Image_PL2_NECRONS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Officio Assassinorum")
            {
                Image_PL2_OFFICIO_ASSASSINORUM.Height = Taille_Image;
                Image_PL2_OFFICIO_ASSASSINORUM.Width = Taille_Image;
                Image_PL2_OFFICIO_ASSASSINORUM.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Orks")
            {
                Image_PL2_ORKS.Height = Taille_Image;
                Image_PL2_ORKS.Width = Taille_Image;
                Image_PL2_ORKS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  SM_Space Marines")
            {
                Image_PL2_SPACE_MARINES.Height = Taille_Image;
                Image_PL2_SPACE_MARINES.Width = Taille_Image;
                Image_PL2_SPACE_MARINES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  SM_Dark Angels")
            {
                Image_PL2_DARK_ANGELS.Height = Taille_Image;
                Image_PL2_DARK_ANGELS.Width = Taille_Image;
                Image_PL2_DARK_ANGELS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  SM_White Scares")
            {
                Image_PL2_SM_WHITE_SCARES.Height = Taille_Image;
                Image_PL2_SM_WHITE_SCARES.Width = Taille_Image;
                Image_PL2_SM_WHITE_SCARES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Space Wolves")
            {
                Image_PL2_SPACE_WOLVES.Height = Taille_Image;
                Image_PL2_SPACE_WOLVES.Width = Taille_Image;
                Image_PL2_SPACE_WOLVES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  SM_Imperial Fists")
            {
                Image_PL2_SM_IMPERIAL_FISTS.Height = Taille_Image;
                Image_PL2_SM_IMPERIAL_FISTS.Width = Taille_Image;
                Image_PL2_SM_IMPERIAL_FISTS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  SM_Crimson Fists")
            {
                Image_PL2_SPACE_MARINES.Height = Taille_Image;
                Image_PL2_SPACE_MARINES.Width = Taille_Image;
                Image_PL2_SPACE_MARINES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  SM_Black Templars")
            {
                Image_PL2_SPACE_MARINES.Height = Taille_Image;
                Image_PL2_SPACE_MARINES.Width = Taille_Image;
                Image_PL2_SPACE_MARINES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  SM_Blood Angels")
            {
                Image_PL2_BLOOD_ANGELS.Height = Taille_Image;
                Image_PL2_BLOOD_ANGELS.Width = Taille_Image;
                Image_PL2_BLOOD_ANGELS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  SM_Flesh Tearers")
            {
                Image_PL2_SPACE_MARINES.Height = Taille_Image;
                Image_PL2_SPACE_MARINES.Width = Taille_Image;
                Image_PL2_SPACE_MARINES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  SM_Iron Hands")
            {
                Image_PL2_SM_IRON_HANDS.Height = Taille_Image;
                Image_PL2_SM_IRON_HANDS.Width = Taille_Image;
                Image_PL2_SM_IRON_HANDS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  SM_Ultramarines")
            {
                Image_PL2_SM_ULTRAMARINES.Height = Taille_Image;
                Image_PL2_SM_ULTRAMARINES.Width = Taille_Image;
                Image_PL2_SM_ULTRAMARINES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  SM_Salamandres")
            {
                Image_PL2_SM_SALAMANDRES.Height = Taille_Image;
                Image_PL2_SM_SALAMANDRES.Width = Taille_Image;
                Image_PL2_SM_SALAMANDRES.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  SM_Raven Guard")
            {
                Image_PL2_SM_RAVEN_GUARD.Height = Taille_Image;
                Image_PL2_SM_RAVEN_GUARD.Width = Taille_Image;
                Image_PL2_SM_RAVEN_GUARD.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  SM_Deathwatch")
            {
                Image_PL2_DEATHWATCH.Height = Taille_Image;
                Image_PL2_DEATHWATCH.Width = Taille_Image;
                Image_PL2_DEATHWATCH.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  T AU Empire")
            {
                Image_PL2_T_AU_EMPIRE.Height = Taille_Image;
                Image_PL2_T_AU_EMPIRE.Width = Taille_Image;
                Image_PL2_T_AU_EMPIRE.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Thousand Sons")
            {
                Image_PL2_THOUSAND_SONS.Height = Taille_Image;
                Image_PL2_THOUSAND_SONS.Width = Taille_Image;
                Image_PL2_THOUSAND_SONS.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Tyranid")
            {
                Image_PL2_TYRANID.Height = Taille_Image;
                Image_PL2_TYRANID.Width = Taille_Image;
                Image_PL2_TYRANID.Visibility = Visibility.Visible;
                return;
            }
            if (Image_Defenseur == "  Ynarri")
            {
                Image_PL2_YNARRI.Height = Taille_Image;
                Image_PL2_YNARRI.Width = Taille_Image;
                Image_PL2_YNARRI.Visibility = Visibility.Visible;
                return;
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
