using CPV9.Classes;
using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;



void init_affichage()
{

    FDE.Visibility = Visibility.Collapsed;
    CDV9_droit.Visibility = Visibility.Collapsed;
    CDV9_gauche.Visibility = Visibility.Collapsed;
    Button_info.Visibility = Visibility.Collapsed;
    StackPanel_Tables.Visibility = Visibility.Collapsed;
    Button_Table_Mars_Reprendre.Visibility = Visibility.Hidden;
    Button_Table_Highlands_Reprendre.Visibility = Visibility.Hidden;
    Button_Table_Quarantaine_Reprendre.Visibility = Visibility.Hidden;
    StackPanel_Bouton_Format.Visibility = Visibility.Collapsed;
    StackPanel_Rassembler_Les_Armees.Visibility = Visibility.Collapsed;
    Button_depart.Visibility = Visibility.Collapsed;

    Label_Saisie_Attaquant.Visibility = Visibility.Collapsed;
    Label_Nom_Attaquant.Visibility = Visibility.Collapsed;
    TextBox_Nom_Attaquant.Visibility = Visibility.Collapsed;
    Label_Nom_Attaquant_SG.Visibility = Visibility.Collapsed;
    TextBox_Nom_Attaquant_SG.Visibility = Visibility.Collapsed;
    Button_Saisie_Attaquant_Valider.Visibility = Visibility.Collapsed;

    Label_Saisie_Defenseur.Visibility = Visibility.Collapsed;
    Label_Nom_Defenseur.Visibility = Visibility.Collapsed;
    TextBox_Nom_Defenseur.Visibility = Visibility.Collapsed;
    Label_Nom_Defenseur_SG.Visibility = Visibility.Collapsed;
    TextBox_Nom_Defenseur_SG.Visibility = Visibility.Collapsed;
    Button_Saisie_Defenseur_Valider.Visibility = Visibility.Collapsed;

    StackPanel_ComboBox_Choix_Armee.Visibility = Visibility.Collapsed;

    StackPanel_MAPS.Visibility = Visibility.Collapsed;
    Label_Maps_1D6.Visibility = Visibility.Collapsed;
    Label_Maps_2D6.Visibility = Visibility.Collapsed;
    TextBox_Map_A.Visibility = Visibility.Collapsed;
    TextBox_Map_B.Visibility = Visibility.Collapsed;


    Button_Valid_Affichage_Map.Visibility = Visibility.Collapsed;
    StackPanel_Saisie_Att_Def.Visibility = Visibility.Collapsed;
    StackPanel_Bouton_Pages.Visibility = Visibility.Collapsed;
    StackPanel_PTS_Defenseur.Visibility = Visibility.Collapsed;
    StackPanel_PTS_Attaquant.Visibility = Visibility.Collapsed;

    Button_Option.Visibility = Visibility.Collapsed;
    Button_Caché_Obj_Peint_Att.Visibility = Visibility.Collapsed;
    Button_Visible_Obj_Peint_Att.Visibility = Visibility.Collapsed;
    Button_501_Affichage_Map.Visibility = Visibility.Collapsed;
    Button_502_Affichage_Map.Visibility = Visibility.Collapsed;
    Button_503_Affichage_Map.Visibility = Visibility.Collapsed;
    Button_3001_Affichage_Map.Visibility = Visibility.Collapsed;
    Button_3002_Affichage_Map.Visibility = Visibility.Collapsed;
    Button_3003_Affichage_Map.Visibility = Visibility.Collapsed;
    Button_501_Affichage_Description.Visibility = Visibility.Collapsed;
    Button_502_Affichage_Description.Visibility = Visibility.Collapsed;
    Button_503_Affichage_Description.Visibility = Visibility.Collapsed;
    Button_3001_Affichage_Description.Visibility = Visibility.Collapsed;
    Button_3002_Affichage_Description.Visibility = Visibility.Collapsed;
    Button_3003_Affichage_Description.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_Necron_100_Att_1.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_Necron_100_Def_1.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_Necron_101_Att_1.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_Necron_101_Def_1.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_Necron_102_Att_1.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_Necron_102_Def_1.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_Necron_103_Att_1.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_Necron_103_Def_1.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_SM_110_Att.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_SM_110_Def.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_SM_111_Att.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_SM_111_Def.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_SM_112_Att.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_SM_112_Def.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_BA_113_Att.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_BA_113_Def.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_BA_114_Att.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_BA_114_Def.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_BA_115_Att.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_BA_115_Def.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_BA_116_Att.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_BA_116_Def.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_Deathwatch_117_Att.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_Deathwatch_117_Def.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_Deathwatch_118_Att.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_Deathwatch_118_Def.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_Deathwatch_119_Att.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_Deathwatch_119_Def.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_Deathwatch_120_Att.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_Deathwatch_120_Def.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_SW_121_Att.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_SW_121_Def.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_SW_122_Att.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_SW_122_Def.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_SW_123_Att.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_SW_123_Def.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_SW_124_Att.Visibility = Visibility.Collapsed;
    Button_Obj_Codex_SW_124_Def.Visibility = Visibility.Collapsed;


    Label_Objectif_Principal_Att_message.Visibility = Visibility.Collapsed;
    Label_Objectif_Principal_Def_message.Visibility = Visibility.Collapsed;
    TextBlock_Nom_Player_1.Visibility = Visibility.Collapsed;
    TextBlock_Nom_Player_2.Visibility = Visibility.Collapsed;
    TextBlock_Nom_SG_1.Visibility = Visibility.Collapsed;
    TextBlock_Nom_SG_2.Visibility = Visibility.Collapsed;
    TextBlock_Score_Player_1.Visibility = Visibility.Collapsed;
    TextBlock_Score_Player_2.Visibility = Visibility.Collapsed;
    StackPanel_OBJSec_Att.Visibility = Visibility.Collapsed;
    StackPanel_OBJSec_Def.Visibility = Visibility.Collapsed;
    StackPanel_Cape_Player_1.Visibility = Visibility.Collapsed;
    StackPanel_Cape_Player_2.Visibility = Visibility.Collapsed;
    StackPanel_Valid_Choix_ObjS_Att.Visibility = Visibility.Collapsed;
    StackPanel_Valid_Choix_ObjS_Def.Visibility = Visibility.Collapsed;
    Label_Score_ObjP_Cape_Player_1.Visibility = Visibility.Collapsed;
    Label_Score_ObjP_Cape_Player_2.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_1_Cape_Player_1.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_1_Cape_Player_2.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_2_Cape_Player_1.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_2_Cape_Player_2.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_3_Cape_Player_1.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_3_Cape_Player_2.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_4_Cape_Player_1.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_4_Cape_Player_2.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_5_Cape_Player_1.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_5_Cape_Player_2.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_6_Cape_Player_1.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_6_Cape_Player_2.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_7_Cape_Player_1.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_7_Cape_Player_2.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_8_Cape_Player_1.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_8_Cape_Player_2.Visibility = Visibility.Collapsed;
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
    Label_Score_ObjS_3002_Cape_Player_1.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_3002_Cape_Player_2.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_3003_Cape_Player_1.Visibility = Visibility.Collapsed;
    Label_Score_ObjS_3003_Cape_Player_2.Visibility = Visibility.Collapsed;

    StackPanel_Obj_FIG_Att.Visibility = Visibility.Collapsed;
    StackPanel_Obj_FIG_Def.Visibility = Visibility.Collapsed;

    Image_PL1_ADEPTA_SORORITAS.Visibility = Visibility.Collapsed;
    Image_PL2_ADEPTA_SORORITAS.Visibility = Visibility.Collapsed;

    Image_PL1_ADEPTUS_CUSTODES.Visibility = Visibility.Collapsed;
    Image_PL2_ADEPTUS_CUSTODES.Visibility = Visibility.Collapsed;

    Image_PL1_ADEPTUS_MECHANICUS.Visibility = Visibility.Collapsed;
    Image_PL2_ADEPTUS_MECHANICUS.Visibility = Visibility.Collapsed;

    Image_PL1_ASTRA_MILITARUM.Visibility = Visibility.Collapsed;
    Image_PL2_ASTRA_MILITARUM.Visibility = Visibility.Collapsed;

    Image_PL1_BLOOD_ANGELS.Visibility = Visibility.Collapsed;
    Image_PL2_BLOOD_ANGELS.Visibility = Visibility.Collapsed;

    Image_PL1_CHAOS_DAEMONS.Visibility = Visibility.Collapsed;
    Image_PL2_CHAOS_DAEMONS.Visibility = Visibility.Collapsed;

    Image_PL1_CHAOS_KNIGHTS.Visibility = Visibility.Collapsed;
    Image_PL2_CHAOS_KNIGHTS.Visibility = Visibility.Collapsed;

    Image_PL1_CHAOS_SPACE_MARINES.Visibility = Visibility.Collapsed;
    Image_PL2_CHAOS_SPACE_MARINES.Visibility = Visibility.Collapsed;

    Image_PL1_CRAFTWORLDS.Visibility = Visibility.Collapsed;
    Image_PL2_CRAFTWORLDS.Visibility = Visibility.Collapsed;

    Image_PL1_DARK_ANGELS.Visibility = Visibility.Collapsed;
    Image_PL2_DARK_ANGELS.Visibility = Visibility.Collapsed;

    Image_PL1_DEATH_GUARD.Visibility = Visibility.Collapsed;
    Image_PL2_DEATH_GUARD.Visibility = Visibility.Collapsed;

    Image_PL1_DEATHWATCH.Visibility = Visibility.Collapsed;
    Image_PL2_DEATHWATCH.Visibility = Visibility.Collapsed;

    Image_PL1_DRUKHARI.Visibility = Visibility.Collapsed;
    Image_PL2_DRUKHARI.Visibility = Visibility.Collapsed;

    Image_PL1_GENESTEALER_CULTS.Visibility = Visibility.Collapsed;
    Image_PL2_GENESTEALER_CULTS.Visibility = Visibility.Collapsed;

    Image_PL1_GREY_KNIGHTS.Visibility = Visibility.Collapsed;
    Image_PL2_GREY_KNIGHTS.Visibility = Visibility.Collapsed;

    Image_PL1_HARLEQUINS.Visibility = Visibility.Collapsed;
    Image_PL2_HARLEQUINS.Visibility = Visibility.Collapsed;

    Image_PL1_IMPERIAL_KNIGHTS.Visibility = Visibility.Collapsed;
    Image_PL2_IMPERIAL_KNIGHTS.Visibility = Visibility.Collapsed;

    Image_PL1_NECRONS.Visibility = Visibility.Collapsed;
    Image_PL2_NECRONS.Visibility = Visibility.Collapsed;

    Image_PL1_OFFICIO_ASSASSINORUM.Visibility = Visibility.Collapsed;
    Image_PL2_OFFICIO_ASSASSINORUM.Visibility = Visibility.Collapsed;

    Image_PL1_ORKS.Visibility = Visibility.Collapsed;
    Image_PL2_ORKS.Visibility = Visibility.Collapsed;

    Image_PL1_SM_IMPERIAL_FISTS.Visibility = Visibility.Collapsed;
    Image_PL2_SM_IMPERIAL_FISTS.Visibility = Visibility.Collapsed;

    Image_PL1_SM_IRON_HANDS.Visibility = Visibility.Collapsed;
    Image_PL2_SM_IRON_HANDS.Visibility = Visibility.Collapsed;

    Image_PL1_SM_RAVEN_GUARD.Visibility = Visibility.Collapsed;
    Image_PL2_SM_RAVEN_GUARD.Visibility = Visibility.Collapsed;

    Image_PL1_SM_SALAMANDRES.Visibility = Visibility.Collapsed;
    Image_PL2_SM_SALAMANDRES.Visibility = Visibility.Collapsed;

    Image_PL1_SM_ULTRAMARINES.Visibility = Visibility.Collapsed;
    Image_PL2_SM_ULTRAMARINES.Visibility = Visibility.Collapsed;

    Image_PL1_SM_WHITE_SCARES.Visibility = Visibility.Collapsed;
    Image_PL2_SM_WHITE_SCARES.Visibility = Visibility.Collapsed;

    Image_PL1_SPACE_MARINES.Visibility = Visibility.Collapsed;
    Image_PL2_SPACE_MARINES.Visibility = Visibility.Collapsed;

    Image_PL1_SPACE_WOLVES.Visibility = Visibility.Collapsed;
    Image_PL2_SPACE_WOLVES.Visibility = Visibility.Collapsed;

    Image_PL1_T_AU_EMPIRE.Visibility = Visibility.Collapsed;
    Image_PL2_T_AU_EMPIRE.Visibility = Visibility.Collapsed;

    Image_PL1_THOUSAND_SONS.Visibility = Visibility.Collapsed;
    Image_PL2_THOUSAND_SONS.Visibility = Visibility.Collapsed;

    Image_PL1_TYRANID.Visibility = Visibility.Collapsed;
    Image_PL2_TYRANID.Visibility = Visibility.Collapsed;

    Image_PL1_YNARRI.Visibility = Visibility.Collapsed;
    Image_PL2_YNARRI.Visibility = Visibility.Collapsed;

    Image_501_Map.Visibility = Visibility.Collapsed;
    Image_501_Descriptif.Visibility = Visibility.Collapsed;
    Image_502_Map.Visibility = Visibility.Collapsed;
    Image_502_Descriptif.Visibility = Visibility.Collapsed;
    Image_503_Map.Visibility = Visibility.Collapsed;
    Image_503_Descriptif.Visibility = Visibility.Collapsed;
    Image_1011.Visibility = Visibility.Collapsed;
    Image_1012.Visibility = Visibility.Collapsed;
    Image_1013.Visibility = Visibility.Collapsed;
    Image_1021.Visibility = Visibility.Collapsed;
    Image_1022.Visibility = Visibility.Collapsed;
    Image_1023.Visibility = Visibility.Collapsed;
    Image_1031.Visibility = Visibility.Collapsed;
    Image_1032.Visibility = Visibility.Collapsed;
    Image_1033.Visibility = Visibility.Collapsed;
    Image_2011.Visibility = Visibility.Collapsed;
    Image_2012.Visibility = Visibility.Collapsed;
    Image_2013.Visibility = Visibility.Collapsed;
    Image_2021.Visibility = Visibility.Collapsed;
    Image_2022.Visibility = Visibility.Collapsed;
    Image_2023.Visibility = Visibility.Collapsed;
    Image_2031.Visibility = Visibility.Collapsed;
    Image_2032.Visibility = Visibility.Collapsed;
    Image_2033.Visibility = Visibility.Collapsed;
    Image_3001_Map.Visibility = Visibility.Collapsed;
    Image_3001_Descriptif.Visibility = Visibility.Collapsed;
    Image_3002_Map.Visibility = Visibility.Collapsed;
    Image_3002_Descriptif.Visibility = Visibility.Collapsed;
    Image_3003_Map.Visibility = Visibility.Collapsed;
    Image_3003_Descriptif.Visibility = Visibility.Collapsed;

}