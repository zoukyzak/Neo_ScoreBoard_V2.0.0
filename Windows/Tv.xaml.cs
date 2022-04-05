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
        public Tv()
        {
            InitializeComponent();
            Init_Capes();
            _Taille_Ref = Convert.ToInt32(this.MinHeight) + Convert.ToInt32(this.MinWidth);
        }
        private void Init_Capes()
        {
            Label_Score_ObjP_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjP_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_3_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_3_Cape_Player_2.Visibility = Visibility.Collapsed;

            Label_Score_ObjS_5_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_5_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_6_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_6_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_7_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_7_Cape_Player_2.Visibility = Visibility.Collapsed;

            Label_Score_ObjS_9_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_9_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_10_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_10_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_11_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_11_Cape_Player_2.Visibility = Visibility.Collapsed;

            Label_Score_ObjS_12_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_12_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_13_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_13_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_14_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_14_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_15_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_15_Cape_Player_2.Visibility = Visibility.Collapsed;

            Label_Score_ObjS_16_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_16_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_17_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_17_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_18_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_18_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_19_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_19_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_501_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_501_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_502_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_502_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_503_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_503_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1011_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1011_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1012_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1012_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1013_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1013_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1021_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1021_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1022_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1022_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1023_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1023_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1031_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1031_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1032_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1032_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1033_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_1033_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2011_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2011_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2012_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2012_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2013_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2013_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2021_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2021_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2022_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2022_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2023_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2023_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2031_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2031_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2032_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2032_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2033_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjS_2033_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Necron_100_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Necron_100_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Necron_101_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Necron_101_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Necron_102_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Necron_102_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Necron_103_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Necron_103_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_SM_110_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_SM_110_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_SM_111_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_SM_111_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_SM_112_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_SM_112_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_BA_113_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_BA_113_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_BA_114_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_BA_114_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_BA_115_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_BA_115_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_BA_116_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_BA_116_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Deathwatch_117_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Deathwatch_117_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Deathwatch_118_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Deathwatch_118_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Deathwatch_119_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Deathwatch_119_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Deathwatch_120_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Deathwatch_120_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_SW_121_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_SW_121_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_SW_122_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_SW_122_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_SW_123_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_SW_123_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_SW_124_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_SW_124_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_DG_125_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_DG_125_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_DG_126_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_DG_126_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_DG_127_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_DG_127_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Admech_128_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Admech_128_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Admech_129_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Admech_129_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Admech_130_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Admech_130_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Admech_131_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_Admech_131_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_AdeptaS_132_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_AdeptaS_132_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_AdeptaS_133_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_AdeptaS_133_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_AdeptaS_134_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_AdeptaS_134_Cape_Player_2.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_AdeptaS_135_Cape_Player_1.Visibility = Visibility.Collapsed;
            Label_Score_ObjC_AdeptaS_135_Cape_Player_2.Visibility = Visibility.Collapsed;
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
        public void Capes_Tv()
        {
            Init_Capes();
            int n = 0;
            if (_Capes_Tv[1,n] == 1){Label_Score_ObjP_Cape_Player_1.Visibility = Visibility.Visible;};///0 OBJECTIF PRIMAIRE
            if (_Capes_Tv[2,n] == 1){Label_Score_ObjP_Cape_Player_2.Visibility = Visibility.Visible;};n++;

            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_1_Cape_Player_1.Visibility = Visibility.Visible; };///1 OBJECTIF SECONDAIRE
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_1_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_2_Cape_Player_1.Visibility = Visibility.Visible; };///2
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_2_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_3_Cape_Player_1.Visibility = Visibility.Visible; };///3
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_3_Cape_Player_2.Visibility = Visibility.Visible; }; n = 5;

            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_5_Cape_Player_1.Visibility = Visibility.Visible; };///5
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_5_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_6_Cape_Player_1.Visibility = Visibility.Visible; };///6
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_6_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_7_Cape_Player_1.Visibility = Visibility.Visible; };///7
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_7_Cape_Player_2.Visibility = Visibility.Visible; }; n = 9;

            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_9_Cape_Player_1.Visibility = Visibility.Visible; };///9
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_9_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_10_Cape_Player_1.Visibility = Visibility.Visible; };///10
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_10_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_11_Cape_Player_1.Visibility = Visibility.Visible; };///11
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_11_Cape_Player_2.Visibility = Visibility.Visible; }; n++;

            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_12_Cape_Player_1.Visibility = Visibility.Visible; };///12
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_12_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_13_Cape_Player_1.Visibility = Visibility.Visible; };///13
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_13_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_14_Cape_Player_1.Visibility = Visibility.Visible; };///14
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_14_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_15_Cape_Player_1.Visibility = Visibility.Visible; };///15
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_15_Cape_Player_2.Visibility = Visibility.Visible; }; n++;

            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_16_Cape_Player_1.Visibility = Visibility.Visible; };///16
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_16_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_17_Cape_Player_1.Visibility = Visibility.Visible; };///17
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_17_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_18_Cape_Player_1.Visibility = Visibility.Visible; };///18
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_18_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_19_Cape_Player_1.Visibility = Visibility.Visible; };///19
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_19_Cape_Player_2.Visibility = Visibility.Visible; }; n = 21;

            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_501_Cape_Player_1.Visibility = Visibility.Visible; };///21 OBJECTIF DE MISSION PATROUILLE
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_501_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_502_Cape_Player_1.Visibility = Visibility.Visible; };///22
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_502_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_503_Cape_Player_1.Visibility = Visibility.Visible; };///23
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_503_Cape_Player_2.Visibility = Visibility.Visible; }; n++;

            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_1011_Cape_Player_1.Visibility = Visibility.Visible; };///24 OBJECTIF DE MISSION INCURSION
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_1011_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_1012_Cape_Player_1.Visibility = Visibility.Visible; };///25
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_1012_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_1013_Cape_Player_1.Visibility = Visibility.Visible; };///26
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_1013_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_1021_Cape_Player_1.Visibility = Visibility.Visible; };///27
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_1021_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_1022_Cape_Player_1.Visibility = Visibility.Visible; };///28
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_1022_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_1023_Cape_Player_1.Visibility = Visibility.Visible; };///29
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_1023_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_1031_Cape_Player_1.Visibility = Visibility.Visible; };///30
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_1031_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_1032_Cape_Player_1.Visibility = Visibility.Visible; };///31
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_1032_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_1033_Cape_Player_1.Visibility = Visibility.Visible; };///32
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_1033_Cape_Player_2.Visibility = Visibility.Visible; }; n++;

            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_2011_Cape_Player_1.Visibility = Visibility.Visible; };///33 OBJECTIF DE MISSION FORCE DE FRAPPE
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_2011_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_2012_Cape_Player_1.Visibility = Visibility.Visible; };///34
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_2012_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_2013_Cape_Player_1.Visibility = Visibility.Visible; };///35
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_2013_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_2021_Cape_Player_1.Visibility = Visibility.Visible; };///36
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_2021_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_2022_Cape_Player_1.Visibility = Visibility.Visible; };///37
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_2022_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_2023_Cape_Player_1.Visibility = Visibility.Visible; };///38
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_2023_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_2031_Cape_Player_1.Visibility = Visibility.Visible; };///39
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_2031_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_2032_Cape_Player_1.Visibility = Visibility.Visible; };///40
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_2032_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_2033_Cape_Player_1.Visibility = Visibility.Visible; };///41
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_2033_Cape_Player_2.Visibility = Visibility.Visible; }; n++;

            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_2011_Cape_Player_1.Visibility = Visibility.Visible; };///42 OBJECTIF DE MISSION APPOCALYPSE
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_2011_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_2012_Cape_Player_1.Visibility = Visibility.Visible; };///43
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjS_2012_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_2013_Cape_Player_1.Visibility = Visibility.Visible; };///44
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjS_2013_Cape_Player_2.Visibility = Visibility.Visible; };n++;

            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Necron_100_Cape_Player_1.Visibility = Visibility.Visible; };///45 OBJECTIF DE CODEX NECRONS
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Necron_100_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Necron_101_Cape_Player_1.Visibility = Visibility.Visible; };///46
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Necron_101_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Necron_102_Cape_Player_1.Visibility = Visibility.Visible; };///47
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Necron_102_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Necron_103_Cape_Player_1.Visibility = Visibility.Visible; };///48
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Necron_103_Cape_Player_2.Visibility = Visibility.Visible; }; n++;

            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_SM_110_Cape_Player_1.Visibility = Visibility.Visible; };///49 OBJECTIF DE CODEX SPACE MARINE
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_SM_110_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_SM_111_Cape_Player_1.Visibility = Visibility.Visible; };///50
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_SM_111_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_SM_112_Cape_Player_1.Visibility = Visibility.Visible; };///51
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_SM_112_Cape_Player_2.Visibility = Visibility.Visible; }; n++;

            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Necron_100_Cape_Player_1.Visibility = Visibility.Visible; };///52 OBJECTIF DE CODEX BLOOD ANGEL
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Necron_100_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Necron_101_Cape_Player_1.Visibility = Visibility.Visible; };///53
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Necron_101_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Necron_102_Cape_Player_1.Visibility = Visibility.Visible; };///54
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Necron_102_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Necron_103_Cape_Player_1.Visibility = Visibility.Visible; };///55
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Necron_103_Cape_Player_2.Visibility = Visibility.Visible; }; n++;

            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Deathwatch_117_Cape_Player_1.Visibility = Visibility.Visible; };///56 OBJECTIF DE CODEX DEATHWATCH
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Deathwatch_117_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Deathwatch_118_Cape_Player_1.Visibility = Visibility.Visible; };///57
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Deathwatch_118_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Deathwatch_119_Cape_Player_1.Visibility = Visibility.Visible; };///58
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Deathwatch_119_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Deathwatch_120_Cape_Player_1.Visibility = Visibility.Visible; };///59
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Deathwatch_120_Cape_Player_2.Visibility = Visibility.Visible; }; n++;

            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_SW_121_Cape_Player_1.Visibility = Visibility.Visible; };///60 OBJECTIF DE CODEX SPACE WOLVES
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_SW_121_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_SW_122_Cape_Player_1.Visibility = Visibility.Visible; };///61
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_SW_122_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_SW_123_Cape_Player_1.Visibility = Visibility.Visible; };///62
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_SW_123_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_SW_124_Cape_Player_1.Visibility = Visibility.Visible; };///63
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_SW_124_Cape_Player_2.Visibility = Visibility.Visible; }; n++;

            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_DG_125_Cape_Player_1.Visibility = Visibility.Visible; };///64 OBJECTIF DE CODEX DEATH GUARD
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_DG_125_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_DG_126_Cape_Player_1.Visibility = Visibility.Visible; };///65
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_DG_126_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_DG_127_Cape_Player_1.Visibility = Visibility.Visible; };///66
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_DG_127_Cape_Player_2.Visibility = Visibility.Visible; }; n++;

            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Admech_128_Cape_Player_1.Visibility = Visibility.Visible; };///67 OBJECTIF DE CODEX ADEPTUS MECHANICUS
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Admech_128_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Admech_129_Cape_Player_1.Visibility = Visibility.Visible; };///68
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Admech_129_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Admech_130_Cape_Player_1.Visibility = Visibility.Visible; };///69
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Admech_130_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Admech_131_Cape_Player_1.Visibility = Visibility.Visible; };///70
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Admech_131_Cape_Player_2.Visibility = Visibility.Visible; }; n++;

            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_AdeptaS_132_Cape_Player_1.Visibility = Visibility.Visible; };///71 OBJECTIF DE CODEX ADEPTA SORORITAS
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_AdeptaS_132_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_AdeptaS_133_Cape_Player_1.Visibility = Visibility.Visible; };///72
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_AdeptaS_133_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_AdeptaS_134_Cape_Player_1.Visibility = Visibility.Visible; };///73
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_AdeptaS_134_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_AdeptaS_135_Cape_Player_1.Visibility = Visibility.Visible; };///74
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_AdeptaS_135_Cape_Player_2.Visibility = Visibility.Visible; }; n++;

            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Ork_136_Cape_Player_1.Visibility = Visibility.Visible; };///75 OBJECTIF DE CODEX ORK
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Ork_136_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Ork_137_Cape_Player_1.Visibility = Visibility.Visible; };///76
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Ork_137_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Ork_138_Cape_Player_1.Visibility = Visibility.Visible; };///77
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Ork_138_Cape_Player_2.Visibility = Visibility.Visible; }; n++;
            if (_Capes_Tv[1, n] == 1) { Label_Score_ObjC_Ork_139_Cape_Player_1.Visibility = Visibility.Visible; };///78
            if (_Capes_Tv[2, n] == 1) { Label_Score_ObjC_Ork_139_Cape_Player_2.Visibility = Visibility.Visible; }; n++;           
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

            Label_Score_ObjP_Cape_Player_1.FontSize= 8 * _Taille;
            Label_Score_ObjP_Cape_Player_2.FontSize= 8 * _Taille;
            Label_Score_ObjS_1_Cape_Player_1.FontSize= 8 * _Taille;
            Label_Score_ObjS_1_Cape_Player_2.FontSize= 8 * _Taille;
            Label_Score_ObjS_2_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_2_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_3_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_3_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_5_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_5_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_6_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_6_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_7_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_7_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_9_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_9_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_10_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_10_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_11_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_11_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_12_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_12_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_13_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_13_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_14_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_14_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_15_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_15_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_16_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_16_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_17_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_17_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_18_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_18_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_19_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_19_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_501_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_501_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_502_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_502_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_503_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_503_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_1011_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_1011_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_1012_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_1012_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_1013_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_1013_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_1021_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_1021_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_1022_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_1022_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_1023_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_1023_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_1031_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_1031_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_1032_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_1032_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_1033_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_1033_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_2011_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_2011_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_2012_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_2012_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_2013_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_2013_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_2021_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_2021_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_2022_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_2022_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_2023_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_2023_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_2031_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_2031_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_2032_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_2032_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjS_2033_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjS_2033_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_Necron_100_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_Necron_100_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_Necron_101_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_Necron_101_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_Necron_102_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_Necron_102_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_Necron_103_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_Necron_103_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_SM_110_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_SM_110_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_SM_111_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_SM_111_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_SM_112_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_SM_112_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_BA_113_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_BA_113_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_BA_114_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_BA_114_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_BA_115_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_BA_115_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_BA_116_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_BA_116_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_Deathwatch_117_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_Deathwatch_117_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_Deathwatch_118_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_Deathwatch_118_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_Deathwatch_119_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_Deathwatch_119_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_Deathwatch_120_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_Deathwatch_120_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_SW_121_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_SW_121_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_SW_122_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_SW_122_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_SW_123_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_SW_123_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_SW_124_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_SW_124_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_DG_125_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_DG_125_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_DG_126_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_DG_126_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_DG_127_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_DG_127_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_Admech_128_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_Admech_128_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_Admech_129_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_Admech_129_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_Admech_130_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_Admech_130_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_Admech_131_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_Admech_131_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_AdeptaS_132_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_AdeptaS_132_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_AdeptaS_133_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_AdeptaS_133_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_AdeptaS_134_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_AdeptaS_134_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_AdeptaS_135_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_AdeptaS_135_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_Ork_136_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_Ork_136_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_Ork_137_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_Ork_137_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_Ork_138_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_Ork_138_Cape_Player_2.FontSize = 8 * _Taille;
            Label_Score_ObjC_Ork_139_Cape_Player_1.FontSize = 8 * _Taille;
            Label_Score_ObjC_Ork_139_Cape_Player_2.FontSize = 8 * _Taille;
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
