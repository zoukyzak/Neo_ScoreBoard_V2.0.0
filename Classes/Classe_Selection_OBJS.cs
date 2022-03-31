namespace CPV9.Classes
{
    class Classe_Selection_OBJS
    {
        public string Nom_Objectif_Selected { get; set; }

        public Classe_Selection_OBJS(int Choix_ObjS, string text_Objectif)
        {
            /**  ELIMINEZ L ENNEMI  **/
            if (Choix_ObjS == 1)
            {
                text_Objectif = "1-Assasinat , ";
            }
            if (Choix_ObjS == 2)
            {
                text_Objectif = "2-Abbatez-le , ";
            }
            if (Choix_ObjS == 3)
            {
                text_Objectif = "3-chasseur de Titans , ";
            }
            /**  PAS DE PITIER PAS DE REPIT  **/
            if (Choix_ObjS == 5)
            {
                text_Objectif = "5-Pas de prisonnier , ";
            }
            if (Choix_ObjS == 6)
            {
                text_Objectif = "6-Broyez-les , ";
            }
            if (Choix_ObjS == 7)
            {
                text_Objectif = "7-Jusqu'au dernier , ";
            }
            /**  SUPREMATIE MILITAIRE  **/
            if (Choix_ObjS == 9)
            {
                text_Objectif = "9-Sur tous les fronts , ";
            }
            if (Choix_ObjS == 10)
            {
                text_Objectif = "10-Derrière les lignes ennemies , ";
            }
            if (Choix_ObjS == 11)
            {
                text_Objectif = "11-Emprise , ";
            }
            /**  OPERATION CLANDESTINE  **/
            if (Choix_ObjS == 12)
            {
                text_Objectif = "12-Inspecter le signal , ";
            }
            if (Choix_ObjS == 13)
            {
                text_Objectif = "13-Balise de téléportation , ";
            }
            if (Choix_ObjS == 14)
            {
                text_Objectif = "14-Levez hauts les étendards , ";
            }
            if (Choix_ObjS == 18)
            {
                text_Objectif = "18-Données de Nachmund , ";
            }
            /**  ART DU WARP  **/
            if (Choix_ObjS == 15)
            {
                text_Objectif = "15-Interrogation psychique ,";
            }
            if (Choix_ObjS == 16)
            {
                text_Objectif = "16-Rituel du warp , ";
            }
            if (Choix_ObjS == 17)
            {
                text_Objectif = "17-Abhorrez le sorcier , ";
            }            
            if (Choix_ObjS == 19)
            {
                text_Objectif = "19-Percer le voile , ";
            }

            /**  NECRON  **/
            if (Choix_ObjS == 100)
            {
                text_Objectif = "100-Code de combat , ";
            }
            if (Choix_ObjS == 101)
            {
                text_Objectif = "101-Eliminez la vermine , ";
            }
            if (Choix_ObjS == 102)
            {
                text_Objectif = "102-Trésors des éons , ";
            }
            if (Choix_ObjS == 103)
            {
                text_Objectif = "103-Machines antiques , ";
            }

            /**  SPACE MARINE  **/
            if (Choix_ObjS == 110)
            {
                text_Objectif = "110-Guerre codex , ";
            }
            if (Choix_ObjS == 111)
            {
                text_Objectif = "111-Tactiques de choc , ";
            }
            if (Choix_ObjS == 112)
            {
                text_Objectif = "112-Sermnents de l'instant , ";
            }

            /**  BLODD ANGELS  **/
            if (Choix_ObjS == 113)
            {
                text_Objectif = "113-Lame de sanguinius , ";
            }
            if (Choix_ObjS == 114)
            {
                text_Objectif = "114-Fureur des éguarés , ";
            }
            if (Choix_ObjS == 115)
            {
                text_Objectif = "115-La mort descend du ciel , ";
            }
            if (Choix_ObjS == 116)
            {
                text_Objectif = "116-Assaut implacable , ";
            }
           
            if (Choix_ObjS == 117)
            {
                text_Objectif = "117-La longue veille , ";
            }
            if (Choix_ObjS == 118)
            {
                text_Objectif = "118-Ordre d'abattage , ";
            }
            if (Choix_ObjS == 119)
            {
                text_Objectif = "119-Paraliser la place forte , ";
            }
            if (Choix_ObjS == 120)
            {
                text_Objectif = "120-Ne tolerez pas le Xenos , ";
            }
            if (Choix_ObjS == 121)
            {
                text_Objectif = "121-Proies glorieuses, ";
            }
            if (Choix_ObjS == 122)
            {
                text_Objectif = "122-Défi héroïque , ";
            }
            if (Choix_ObjS == 123)
            {
                text_Objectif = "123-Une saga magistrale , ";
            }
            if (Choix_ObjS == 124)
            {
                text_Objectif = "124-Fierté du guerrier , ";
            }

            /**  DEAD GUARD  **/
            if (Choix_ObjS == 125)
            {
                text_Objectif = "125-Vecteurs inconscients , ";
            }
            if (Choix_ObjS == 126)
            {
                text_Objectif = "126-Sol corrompu , ";
            }
            if (Choix_ObjS == 127)
            {
                text_Objectif = "127-Répandre les maladies , ";
            }

            /**  ADMECH  **/
            if (Choix_ObjS == 128)
            {
                text_Objectif = "128-Accrétion du savoir , ";
            }
            if (Choix_ObjS == 129)
            {
                text_Objectif = "129-Eradication de la chair , ";
            }
            if (Choix_ObjS == 130)
            {
                text_Objectif = "130-Séquençage non répertorié , ";
            }
            if (Choix_ObjS == 131)
            {
                text_Objectif = "131-Archéocrypte secrète , ";
            }

            /**  ADEPTA SORORITAS **/
            if (Choix_ObjS == 132)
            {
                text_Objectif = "132-Démonstration de foi , ";
            }
            if (Choix_ObjS == 133)
            {
                text_Objectif = "133-Tuez l'hérétique , ";
            }
            if (Choix_ObjS == 134)
            {
                text_Objectif = "134-Sol Sacré , ";
            }
            if (Choix_ObjS == 135)
            {
                text_Objectif = "135-Défendez le sanctuaire , ";
            }

            /**  Ork **/
            if (Choix_ObjS == 136) { text_Objectif = "136-Krazez-les , "; };
            if (Choix_ObjS == 137) { text_Objectif = "137-Les plus gros ... , "; };
            if (Choix_ObjS == 138) { text_Objectif = "138-Prenez les morçeaux d'choix , "; };
            if (Choix_ObjS == 139) { text_Objectif = "139-Marée verte , "; };

            /**  PATROUILLE  **/
            if (Choix_ObjS == 501)
            {
                text_Objectif = "501-Assaut chirurgical , ";
            }
            if (Choix_ObjS == 502)
            {
                text_Objectif = "502-Sondage , ";
            }
            if (Choix_ObjS == 503)
            {
                text_Objectif = "503-Encercler , ";
            }

            /**  INCURSION  **/
            if (Choix_ObjS == 1011)
            {
                text_Objectif = "1011-assaut direct , ";
            }
            if (Choix_ObjS == 1012)
            {
                text_Objectif = "1012-Securisez les sites d'atterrissage , ";
            }
            if (Choix_ObjS == 1013)
            {
                text_Objectif = "1013-Attaquez les lignes de ravitaillement , ";
            }
            if (Choix_ObjS == 1021)
            {
                text_Objectif = "1021-la sagesse est le pilier de la foi  , ";
            }
            if (Choix_ObjS == 1022)
            {
                text_Objectif = "1022-ascension  , ";
            }
            if (Choix_ObjS == 1023)
            {
                text_Objectif = "1023-elan de foi  , ";
            }
            if (Choix_ObjS == 1031)
            {
                text_Objectif = "1031-Télécharger le data-spaume  , ";
            }
            if (Choix_ObjS == 1032)
            {
                text_Objectif = "1032-brisez-les corps et âme  , ";
            }
            if (Choix_ObjS == 1033)
            {
                text_Objectif = "1033-Balayage de reconnaissance  , ";
            }

            /**  FORCE DE FRAPPE  **/
            if (Choix_ObjS == 2011)
            {
                text_Objectif = "2011-brisez-les corps et âme , ";
            }
            if (Choix_ObjS == 2012)
            {
                text_Objectif = "2012-detonation  , ";
            }
            if (Choix_ObjS == 2013)
            {
                text_Objectif = "2013-Interception de données  , ";
            }
            if (Choix_ObjS == 2021)
            {
                text_Objectif = "2021-Sécurisez le sanctuaire  , ";
            }
            if (Choix_ObjS == 2022)
            {
                text_Objectif = "2022-Sol corrompu  , ";
            }
            if (Choix_ObjS == 2023)
            {
                text_Objectif = "2023-Scan stratégique  , ";
            }
            if (Choix_ObjS == 2031)
            {
                text_Objectif = "2031-Submerger  , ";
            }
            if (Choix_ObjS == 2032)
            {
                text_Objectif = "2032-Assaut direct  , ";
            }
            if (Choix_ObjS == 2033)
            {
                text_Objectif = "2033-Artéfacts précieux , ";
            }

            /**  OFFENSIVE  **/
            if (Choix_ObjS == 3001)
            {
                text_Objectif = "3001-Tenir le centre , ";
            }
            if (Choix_ObjS == 3002)
            {
                text_Objectif = "3002-Encerclez-les , ";
            }
            if (Choix_ObjS == 3003)
            {
                text_Objectif = "3003-Chercher le portail , ";
            }

            Nom_Objectif_Selected = text_Objectif;
            return;
        }
    }
}
