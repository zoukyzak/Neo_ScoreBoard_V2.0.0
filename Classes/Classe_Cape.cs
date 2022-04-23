using System;

namespace CPV9.Classes
{
    class Classe_Cape
    {
        public string Cape_Selected { get; set; }
        public Classe_Cape(int ID_cape, String Text_Cape)
        {
            #region OBJ PRINCIPAL
            /**  OBJECTIF PRINCIPAL  **/
            if (ID_cape == 1000) { Cape_Selected = "Objectif Principal prendre et tenir capé"; };
            if (ID_cape == 1001) { Cape_Selected = "OBJECTIFS PRINCIPAUX capé"; };
            #endregion
            #region OBJ SECONDAIRE
            /**  ELIMINEZ L ENNEMI  **/
            if (ID_cape == 1) { Cape_Selected = "1-Assasinat capé"; };
            if (ID_cape == 2) { Cape_Selected = "2-Abbatez-le capé "; };
            if (ID_cape == 3) { Cape_Selected = "3-chasseur de Titans capé"; };

            /**  PAS DE PITIER PAS DE REPIT  **/
            if (ID_cape == 5) { Cape_Selected = "5-Pas de prisonnier capé"; };
            if (ID_cape == 6) { Cape_Selected = "6-Broyez-les capé"; };
            if (ID_cape == 7) { Cape_Selected = "7-Jusqu'au dernier capé"; };

            /**  SUPREMATIE MILITAIRE  **/
            if (ID_cape == 9) { Cape_Selected = "9-Sur tous les fronts capé"; };
            if (ID_cape == 10) { Cape_Selected = "10-Derrière les lignes ennemies capé"; };
            if (ID_cape == 11) { Cape_Selected = "11-Emprise capé"; };

            /**  OPERATION CLANDESTINE  **/
            if (ID_cape == 12) { Cape_Selected = "12-Inspecter le signal capé"; };
            if (ID_cape == 13) { Cape_Selected = "13-Balise de téléportation capé"; };
            if (ID_cape == 14) { Cape_Selected = "14-Levez hauts les étendards capé"; };
            if (ID_cape == 18) { Cape_Selected = "18-Données de Nachmund capé"; };

            /**  ART DU WARP  **/
            if (ID_cape == 15) { Cape_Selected = "15-Interrogation psychique capé"; };
            if (ID_cape == 16) { Cape_Selected = "16-Rituel du warp capé"; };
            if (ID_cape == 17) { Cape_Selected = "17-Abhorrez le sorcier capé"; };
            if (ID_cape == 19) { Cape_Selected = "19-Percer le voile capé"; };
            #endregion
            #region OBJ CODEX
            /**  NECRON  **/
            if (ID_cape == 100) { Cape_Selected = "100-Code de combat capé"; };
            if (ID_cape == 101) { Cape_Selected = "101-Eliminez la vermine capé"; };
            if (ID_cape == 102) { Cape_Selected = "102-Trésors des éons capé"; };
            if (ID_cape == 103) { Cape_Selected = "103-Machines antiques capé"; };

            /**  SPACE MARINE  **/
            if (ID_cape == 110) { Cape_Selected = "110-Guerre codex capé"; };
            if (ID_cape == 111) { Cape_Selected = "111-Tactiques de choc capé"; };
            if (ID_cape == 112) { Cape_Selected = "112-Sermnents de l'instant capé"; };

            /**  BLODD ANGELS  **/
            if (ID_cape == 113) { Cape_Selected = "113-Lame de sanguinius capé"; };
            if (ID_cape == 114) { Cape_Selected = "114-Fureur des éguarés capé"; };
            if (ID_cape == 115) { Cape_Selected = "115-La mort descend du ciel capé"; };
            if (ID_cape == 116) { Cape_Selected = "116-Assaut implacable capé"; };

            if (ID_cape == 117) { Cape_Selected = "117-La longue veille capé"; };
            if (ID_cape == 118) { Cape_Selected = "118-Ordre d'abattage capé"; };
            if (ID_cape == 119) { Cape_Selected = "119-Paraliser la place forte capé"; };
            if (ID_cape == 120) { Cape_Selected = "120-Ne tolerez pas le Xenos capé"; };
            if (ID_cape == 121) { Cape_Selected = "121-Proies glorieuses capé"; };
            if (ID_cape == 122) { Cape_Selected = "122-Défi héroïque capé"; };
            if (ID_cape == 123) { Cape_Selected = "123-Une saga magistrale capé"; };
            if (ID_cape == 124) { Cape_Selected = "124-Fierté du guerrier capé"; };

            /**  DEAD GUARD  **/
            if (ID_cape == 125) { Cape_Selected = "125-Vecteurs inconscients capé"; };
            if (ID_cape == 126) { Cape_Selected = "126-Sol corrompu capé"; };
            if (ID_cape == 127) { Cape_Selected = "127-Répandre les maladies capé"; };

            /**  ADMECH  **/
            if (ID_cape == 128) { Cape_Selected = "128-Accrétion du savoir capé"; };
            if (ID_cape == 129) { Cape_Selected = "129-Eradication de la chair capé"; };
            if (ID_cape == 130) { Cape_Selected = "130-Séquençage non répertorié capé"; };
            if (ID_cape == 131) { Cape_Selected = "131-Archéocrypte secrète capé"; };

            /**  ADEPTA SORORITAS **/
            if (ID_cape == 132) { Cape_Selected = "132-Démonstration de foi capé"; };
            if (ID_cape == 133) { Cape_Selected = "133-Tuez l'hérétique capé"; };
            if (ID_cape == 134) { Cape_Selected = "134-Sol Sacré capé"; };
            if (ID_cape == 135) { Cape_Selected = "135-Défendez le sanctuaire capé"; };

            /**  Codex Ork  **/
            if (ID_cape == 136) { Cape_Selected = "136-Krazez-les capé"; };
            if (ID_cape == 137) { Cape_Selected = "137-Les plus gros et les plus mieux capé"; };
            if (ID_cape == 138) { Cape_Selected = "138-Prenez les morceaux d'choix capé"; };
            if (ID_cape == 139) { Cape_Selected = "139-Marée verte capé"; };
            #endregion
            #region OBJ MISSION
            /**  PATROUILLE  **/
            if (ID_cape == 501) { Cape_Selected = "501-Assaut chirurgical capé"; };
            if (ID_cape == 502) { Cape_Selected = "502-Sondage capé"; };
            if (ID_cape == 503) { Cape_Selected = "503-Encercler capé"; };

            /**  INCURSION  **/
            if (ID_cape == 1011) { Cape_Selected = "1011-assaut direct capé"; };
            if (ID_cape == 1012) { Cape_Selected = "1012-Securisez les sites d'atterrissage capé"; };
            if (ID_cape == 1013) { Cape_Selected = "1013-Attaquez les lignes de ravitaillement capé"; };
            if (ID_cape == 1021) { Cape_Selected = "1021-la sagesse est le pilier de la foi capé"; };
            if (ID_cape == 1022) { Cape_Selected = "1022-ascension capé"; };
            if (ID_cape == 1023) { Cape_Selected = "1023-elan de foi capé"; };
            if (ID_cape == 1031) { Cape_Selected = "1031-Télécharger le data-spaume capé"; };
            if (ID_cape == 1032) { Cape_Selected = "1032-brisez-les corps et âme capé"; };
            if (ID_cape == 1033) { Cape_Selected = "1033-Balayage de reconnaissance capé"; };

            /**  FORCE DE FRAPPE  **/
            if (ID_cape == 2011) { Cape_Selected = "2011-brisez-les corps et âme capé"; };
            if (ID_cape == 2012) { Cape_Selected = "2012-detonation capé"; };
            if (ID_cape == 2013) { Cape_Selected = "2013-Interception de données capé"; };
            if (ID_cape == 2021) { Cape_Selected = "2021-Sécurisez le sanctuaire capé"; };
            if (ID_cape == 2022) { Cape_Selected = "2022-Sol corrompu capé"; };
            if (ID_cape == 2023) { Cape_Selected = "2023-Scan stratégique capé"; };
            if (ID_cape == 2031) { Cape_Selected = "2031-Submerger capé"; };
            if (ID_cape == 2032) { Cape_Selected = "2032-Assaut direct capé"; };
            if (ID_cape == 2033) { Cape_Selected = "2033-Artéfacts précieux capé"; };

            /**  OFFENSIVE  **/
            if (ID_cape == 3001) { Cape_Selected = "3001-Tenir le centre capé"; };
            if (ID_cape == 3002) { Cape_Selected = "3002-Encerclez-les capé"; };
            if (ID_cape == 3003) { Cape_Selected = "3003-Chercher le portail capé"; };
            #endregion
        }
    }
}
