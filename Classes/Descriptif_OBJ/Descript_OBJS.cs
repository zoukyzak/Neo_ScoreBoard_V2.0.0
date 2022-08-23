namespace CPV9.Classes
{
    class Descript_OBJS
    {
        public Descript_OBJS(int OBJ)
        {
            l1 = l2 = l3 = l4 = l5 = l6 = l7 = l8 = l9 = l10 = l11 = l12 = l13 = l14 = "";
            switch (OBJ)
            {
                #region OBJP
                /**  ELIMINEZ L ENNEMI  **/
                case 1:
                    l1 = " ASSASSINAT";
                    l4 = "Score 3 points de victoire à la fin de la bataille";
                    l5 = "pour chaque figurine personnage ennemi qui aura été detruite.";
                    l9 = "Si , le Seigneur de Guerre ennemi est detruit durant la bataille,";
                    l10 = "gagner 1 point de victoire supplementaire.";
                    break;

                case 2:
                    l1 = " ABBATEZ-LE";
                    l3 = "Score 1 points de victoire à la fin de la bataille pour chaque figurine ennemi,";
                    l4 = "véhicule ou monstre avec une charactéristique de PV de 9 ou moins qui est détruite.";
                    l6 = "Score 2 points de victoire à la fin de la bataille pour chaque figurine ennemi";
                    l7 = "véhicule ou monstre avec une charactéristique de PV entre 10 et 14 qui est détruite.";
                    l9 = "et 3 points de victoire à la fin de la bataille pour chaque figurine ennemi, ";
                    l10 = "véhicule ou monstre avec une charactéristique de PV de 15 et plus qui est détruite.";
                    break;

                case 3:
                    l1 = " CHASSEUR DE TITANS";
                    l3 = "Score 4 points de victoire à la fin de la bataille si,";
                    l4 = "une figurine Titanesque ennemi est détruite.";
                    l6 = "Score 9 points de victoire à la fin de la bataille si,";
                    l7 = "deux figurines Titanesques ennemi sont détruitent.";
                    l9 = "Score 15 points de victoire à la fin de la bataille si,";
                    l10 = "trois figurines Titanesques ennemi sont détruitent.";
                    break;
                /**  PAS DE PITIER PAS DE REPIT  **/
                case 5:
                    l1 = " PAS DE PRISONNIER";
                    l2 = "Si vous choisissez cet objectif, tenez un compte de points de pertes infigées. Chaque fois qu'une figurine ennemie";
                    l3 = "est détruite, à moins q'il sagise d'une unité Véhicule, Monstre ou Personnage, ajoutez à ce compte autant de points que la charactéristique";
                    l4 = "de points de vie de la figurine détruite.";
                    l6 = "Une figurine peut, si elle est ressuscitée  pour n'importe quelle raison, potentiellement octroyer plusieurs points à ce compte";
                    l8 = "A la fin de la bataille, divisez par 10 votre compte de points de pertes infligées en arrondissant à l'entier inférieur; le résultat est le nombre de points";
                    l9 = "de victoire marqués. De plus , si votre compte de points de pertes infligées est entre 50 et 99, vous marquez 1 points de victoire supplémentaire, et";
                    l10 = "si votre comptre de points de pertes infligées est de 100 ou plus, vous marquez 2 point de victoire supplemenaire";
                    break;

                case 6:
                    l1 = " BROYEZ-LES";
                    l4 = "Marquez 3 pts de victoire a la fin du round de bataille";
                    l5 = "si d'avantage d'unités ennemies que d'unités amis ";
                    l6 = "ont été détruites à ce round de bataille.";
                    break;

                case 7:
                    l1 = " J'USQU'AU DERNIER";
                    l3 = "Identifié avant la bataille vos trois unités qui ont leurs coups en points les plus élévés.";
                    l4 = " les unitée avec le rôle tactique fortification exclues ";
                    l6 = "Score 5 points de victoire pour chaque unité encore en vie à la fin de la bataille";
                    l8 = "Si une unité se scinde en deux et qu'une partie est détruite et l'autre est resté en vie à la fin de la bataille,";
                    l9 = "Score 3 points de victoire pour cette unité au lieu de 5 points";
                    break;
                /**  SUPREMATIE MILITAIRE  **/
                case 9:
                    l1 = " SUR TOUS LES FRONT";
                    l3 = "Marquez 2 points de victoire à la fin de votre tour si vous avez une unité éligible ou plus";
                    l4 = "de votre armée entiérement dans les 3/4 de tables différents et a plus de 6 pouces du centre.";
                    l6 = "Marquez 3 points de victoire à la fin de votre tour si vous avez une unité éligible ou plus";
                    l7 = "de votre armée entiérement dans chaque quart de tables différents et a plus de 6 pouces du centre.";
                    l9 = "Pour être éligible , l'unité dois contenir 3 figurines ou plus , oubien contenir un véhicule ou monstre ou plus.";
                    break;

                case 10:
                    l1 = " DERRIERE LES LIGNES ENNEMIES";
                    l4 = "Marquez 2 points de victoire à la fin de votre tour si 1 unité de votre armée (hors Aérodyne)";
                    l5 = "est entièrement dans la zone de déploiement adverse.";
                    l7 = "Marquez 4 points de victoire à la place à la fin de votre tour , si 2 unités ou plus (hors Aérodyne)";
                    l8 = "sont entièrement dans la zone de déploiement adverse.";
                    break;

                case 11:
                    l1 = " EMPRISE";
                    l5 = "Marquez 3 points de victoire à la fin de votre tour si vous contrôlez 3 objectifs";
                    l6 = "ou plus et que vous en contrôliez plus que votre adversaire.";
                    break;
                /**  OPERATION CLANDESTINE  **/
                case 12:
                    l1 = " INSPECTER LE SIGNAL";
                    l3 = "Marquez 3 points de victoire chaque fois qu'une unité de votre armée accomplit l'action suivante :";
                    l5 = "Inspecter le signal (action) :";
                    l8 = "1 unité d'INFANTERIE de votre armée qui contient 3 figurines ou plus peut";
                    l9 = "entreprendre cette action à la fin de votre phase de mouvement si elle est entièrement à 6 pouces";
                    l10 = "du centre du champs de bataille.Cette action est accomplit à la fin de votre tour à condition que";
                    l11 = "l'unité qui l'entreprenait soit toujours entièrement a 6 pouces du centre du champs de bataille";
                    l12 = "et qu'il n'y ai pas d'unité ennemie entièrement à 6 pouces du centre.(hors Aérodyne)";
                    break;

                case 13:
                    l1 = " DEPLOYEZ LES BALISES DE TELEPORTATION";
                    l2 = "Si vous choisissez cette objectif , alors les unités de votre armée peuvent accomplir l'action suivante:";
                    l3 = "DEPLOYEZ UNE BALISE DE TELEPORTATION (action) :";
                    l5 = "1 unité d'infanterie ou motard peut commencer cette action à la fin de votre phase de mouvement si elle est";
                    l6 = "entièrement à 12 pouces de la zone de déploiement adverse.";
                    l8 = "Si l'unité a le rôle tactique Troupes,l'action est accomplie à la fin de votre phase de mouvement ,";
                    l9 = "sinon l'action n'est accomplie qu'à la fin de la prochaine phase de commandement et si l'unité est";
                    l10 = "toujours entièrement à 12 pouces de la zone de déploiement adverse.";
                    l12 = "Chaque fois qu'une unité accomplit cette action, vous marquerez 2 points de victoire.";
                    l13 = "4 points de victoire à la place si l'unité est entièrement dans la zone de déploiement adverse.";
                    break;

                case 14:
                    l1 = " LEVEZ HAUT LES ETENDARDS (action)";
                    l2 = "1 unité INFANTERIE ou plus de votre armée peut commencer cette action à la fin de votre phase de mouvement.";
                    l3 = "Chaque unité de votre armée qui commence cette action doit être à portée d'un pion objectif";
                    l4 = "différent sur lequel aucun de vos étendards n'a été levé.";
                    l6 = "Une unité ne peut pas commencer cette action s'il y a la moindre unité ennemie (hors Aérodyne) à portée du même pion objectif.";
                    l7 = "L'action est accomplie à la fin de votre phase de mouvement.";
                    l8 = "si cette action est accomplie, on dit qu'un étendard de votre armée est levé sur ce pion objectif.";
                    l10 = "L'étendard est retiré si votre adversaire contrôle le pion objectif au début de n'importe quelle phase.";
                    l12 = "Vous marquez 1 point de victoire à la fin de chacune de vos phase de commandement et 1 point de victoire à la fin de la bataille,";
                    l13 = "pour chaque pion objectif du champs de bataille sur lequel un de vos étendards a été levé";
                    break;

                case 18:
                    l1 = " RECUPEREZ LES DONNEES DE NACHMUND (action)";
                    l2 = "1 unité INFANTERIE ou motard de votre armée peut entreprendre cette action à la fin de votre phase de mouvement";
                    l3 = "si elle est entièrement dans un quart de table sans servocrâne récupéré par votre armée (voir ci-dessous)";
                    l4 = "et à plus de 6 pouces de tout autre quart de table.";
                    l6 = "Cette action est accomplie à la fin de votre tour, tant que l'unité qui tente de le faire est toujours dans le même quart de table.";
                    l8 = "Si cette action est accomplie, jetez un D6, en soustrayant 1 au résultat si l'unité qui as accompli l'action";
                    l9 = "a le rôle tactique TROUPES :  si le résultat est inférieur ou égal au nombres de figurines actuel,";
                    l10 = "votre armée a retrouvé un servocrâne dans ce quart de table et vous ajoutez 1 à votre compte de Données récupérées.";
                    l12 = "A la fin de la bataille, marquez 4 points de victoire si votre compte de Données Récupérées est de 2, marquez 8 points";
                    l13 = "de victoire s'il est de 3, ou 12 points de victoire s'il est de 4";
                    break;
                /**  ART DU WARP  **/
                case 15:
                    l1 = " INTERROGATION PSYCHIQUE (action)";
                    l3 = "Marquez 3 points de victoire chaque fois que vous accomplissez avec succès l'action psychique suivante:";
                    l5 = "INTERROGATION PSYCHIQUE (Action Psychique charge Warp 4):";
                    l7 = "1 unité PERSONNAGE PSYKER de votre armée peut tenter d'accomplir cette action psychique à votre phase psychique";
                    l8 = "si elle est à 24 pouces d'une ou plusieurs figurines PERSONNAGES ennemies.";
                    break;

                case 16:
                    l1 = " RITUEL DU WARP (action)";
                    l2 = "Si vous choississez cet objectif , tenez un compte de rituel;";
                    l3 = "ajouter 1 a ce compte chaque fois qu'une unité de votre armée accomplit avec succès l'action psychique suivante:";
                    l5 = "RITUEL DU WARP (Action Psychique charge Warp 3):";
                    l7 = "1 unité PERSONNAGE PSYKER de votre armée peut tenter d'accomplir cette action psychique à votre phase psychique";
                    l8 = "si elle est à 6 pouces du centre du champ de bataille.";
                    l11 = "A la fin de la bataille, marquez 3 points de victoire si votre compte est de 1, marquez 7 points de victoire s'il est de 2,";
                    l12 = "ou marquez 12 points de victoire s'il est de 3 ou plus";
                    break;

                case 17:
                    l1 = " ABHORREZ LE SORCIER";
                    l4 = "Vous ne pouvez pas choisir cet objectif secondaire si votre armée inclut la moindre unité Psyker.";
                    l7 = "Marquez 3 points de victoire à la fin de la bataille pour chaque unité PERSONNAGE PSYKER ennemie";
                    l8 = "qui a été détruit, et 2 points de victoire pour chaque autre unité Psyker ennemie qui a été détruite.";
                    break;

                case 19:
                    l1 = " PERCER LE VOILE";
                    l4 = "Marquez 8 points de victoire à la fin de la bataille si une ou plusieurs unités de votre armée ont accompli avec succès";
                    l5 = "l'action psychique suivante 2 fois ou plus lors de la bataille, ou 15 points de victoire à la fin de la bataille";
                    l7 = "si une ou plusieurs unités de votre armée ont accompli avec succès l'action psychique suivante 4 fois lors de la bataille.";
                    l8 = "Vous ne pouvez accomplir cet objectif qu'une fois par tour.";
                    l10 = "PERCER LE VOILE (action psychique - charge warp 4)";
                    l12 = "1 unité PERSONNAGE PSYKER de votre armée peu tenter d'accomplir cette action psychique durant votre phase psychique";
                    l13 = "s'il est à 6 pouces du bord de table de votre adversaire et a plus de 6 pouces de toute figurine ennemie.";
                    break;
                #endregion
                #region OBJC_Necron
                case 100:
                    l1 = " CODE DE COMBAT";
                    l5 = "Marquez 3 points de victoire à la fin de la bataille pour chaque unité énnemie détruite";
                    l6 = "par une unité NOBLE Nécron de votre armée.";
                    break;

                case 101:
                    l1 = " ELEMINEZ LA VERMINE";
                    l4 = "Marquez 2 points de victoire à la fin de votre tour pour chaque quart de table";
                    l5 = "qui n'as aucune unité énnemie ( hors aérodynes) entièement à l'intérieur.";
                    l6 = "cette objectif ne peut pas être marqué au premier tour.";
                    break;

                case 102:
                    l1 = " TRESORS DES EONS";
                    l3 = "Si vous choisissez cette objectif secondaire, une fois les deux camps déployés,";
                    l4 = "votre adversaire choisit 3 pions objectifs sur le champs de bataille.";
                    l5 = "Marquez un nombre de points de victoire à la fin de votre tour si vous contrôlez";
                    l6 = "un ou plusieurs de ces pions objectif";
                    l8 = "Nombres de pions objectifs contrôler :";
                    l10 = "1 = 2 points de victoire";
                    l11 = "2 = 3 points de victoire";
                    l12 = "3 = 5 points de victoire";
                    break;

                case 103:
                    l1 = " MACHINES ANTIQUES";
                    l2 = "Une fois les deux camps déployés, en commençant par votre adversaire, les joueurs altérne pour choissir les pions objectif";
                    l3 = " qui ne sont dans aucune zone de dépoiement pour être des pions objectifs de Machine Antique, jusqu'a ce que 3 pions objectifs aient été choisis";
                    l4 = " (s'il n'y a qu'un pion répondant à ces critères, seul ce pion objectif est un pion objectif de machine antique)";
                    l5 = ".Les unités BASE Nécron ou CANOPTEKS peuvent tenter l'action suivante : Eveillez une machine antique (Action)";
                    l7 = "A la fin de votre phase de mouvement ,";
                    l8 = "une ou plusieurs unités BASE ou CANOPTECKS Nécrons de votre armée peuvent commencer à accomplir cette action. ";
                    l10 = "Chaque unité de votre armée qui commence à accomplir cette action dois être à porté d'un pion objectif Machine de guerre Antique distinct.";
                    l11 = "Une unité ne peut pas commencer à accomplir cette action tant qu'il y a une unité ennemi à portée du même pion objectif.";
                    l12 = "L'action est achevé à la fin de votre prochaine phase de commandement, tant que l'unité est encore à porté du pion";
                    l13 = "de machine quantique en question.Marquez 3 points chaque fois qu'une unité achève l'action Eveiller une machine quantite.";
                    break;
                #endregion
                #region OBJC_SM
                case 110:
                    l1 = "GUERRE CODEX";
                    l4 = "Marquez 1 pts, par unité detruite pendant les doctrines suivante et en utilisant les armes selectionné";
                    l5 = "dans un maximun de 5 pts par doctrine (Utiliser les unités ADEPTUS ASTARTES uniquement)";
                    l7 = "Doctrine Devastator ( armes Lourdes et Grenades)";
                    l8 = "Doctrine Tactique ( armes Assaut et Tir rapide)";
                    l9 = "Doctrine Assaut ( armes Mêlé et Pistolet)";
                    break;

                case 111:
                    l1 = "TACTIQUES DE CHOC";
                    l4 = "Marquez 3 pts par round si vous contrôlez , a la fin du round ,";
                    l5 = " au moins un objectif que l adversaire possédait au début de ce même round.";
                    l6 = "Une unité ADEPTUS ASTARTES dois être presente sur cette objectif";
                    break;

                case 112:
                    l1 = "SERMENTS DE L'INSTANT";
                    l4 = "Marquez des points a chaque round , pour chaque serment respecté.";
                    l6 = "serment de VALEUR ( 1 pts/round) pour avoir détruit au moins un personnage,véhicule ou montre a laide d'une unité ADEPTUS ASTARTES";
                    l7 = "serment d'HONNEUR ( 1 pts/round) pour n'avoir ni battu en retraite , ni avoir raté un test de morale";
                    l8 = "serment du DEVOIR ( 2 pts/round) pour avoir une unité ADEPTUS ASTARTES entierement dans les 6 pouces au centre du champs de bataille";
                    break;
                #endregion
                #region OBJC_BA
                case 113:
                    l1 = "LAME SANGUINIUS";
                    l3 = "Au début de votre première phase de commandement, vous devez choisir une figurines PERSONNAGE Blood Angels de votre armée";
                    l4 = "pour lancer un défi et votre adversaire dois choisir une figurine PERSONNAGE de son armée pour le relever.";
                    l5 = "Si un joueur ou l'autre n'as pas de figurine personnage, il doit à la place choisir son seigneur de guerre.";
                    l7 = "Marquez 5 points de victoire à la fin de la bataille pour chacune des conditions suivantes qui as été rempli:";
                    l8 = "La figurine qui as relevé le défi a été détruite.";
                    l9 = "La figurine qui as relevé le défi a été détruite par une attaque de mélée.";
                    l10 = "La figurine qui as relevé le défi a été détruite par une attaque de mélée de la figurine qui as lancé le défi.";
                    break;

                case 114:
                    l1 = "FUREUR DES EGARES";
                    l4 = "Marquez 3 points de victoire à la fin de votre tour si une ou plusieurs unités ennemies";
                    l5 = "ont été détruites par une unitée COMPAGNIE DE LA MORT de votre armée à ce tour .";
                    break;

                case 115:
                    l1 = "LA MORT DESCEND DU CIEL";
                    l4 = "Marquez 2 points de victoire à la fin de votre tour si une ou plusieurs unités ennemie ont été détruites";
                    l5 = "par une unitée Blood Angels de votre armée qui as té placé sur le champs de bataille ";
                    l6 = "à l'étapes de renforts d'une de vos phase de mouvement.";
                    l8 = "Si une de ces unités ennemies étaient une unité Personnage,";
                    l9 = "Marquez 3 points de victoire à la place.";
                    break;

                case 116:
                    l1 = "ASSAUT IMPLACABLE";
                    l4 = "Marquez 2 points de victoire à la fin de votre tour s'il y a plus d'unités Bood Angels";
                    l5 = "de votre armée dans la zone de déploiement ennemie qu'il y as d'unités ennemies";
                    l6 = "dans votre zone de déploiement.";
                    break;

                #endregion
                #region OBJC_Dead Guard
                case 125:
                    l1 = "VECTEURS INCONSCIENTS";
                    l4 = "Marquez 3 points de victoire à la fin du round de bataille si au moins une unitée ennemie";
                    l5 = "a raté un test de moral à ce round, et qu'au cours de celui-ci";
                    l6 = "au moins une de ses figurines ai été détruite par des attaques d'une arme de la peste ";
                    break;

                case 126:
                    l1 = "SOL CORROMPU";
                    l2 = "Marquez 4 points de victoire à la fin de la bataille si vous avez au moins une unitée BUBONICUS ASTARTES entièrement";
                    l3 = "dans la zone de déploiement adverse et au moins une unité BUBONICUS ASTARTES entièrement dans votre zone de déploiement.";
                    l4 = "Marquez 4 points de victoire à la fin de la bataille si vous avez au moins une unitée BUBONICUS ASTARTES entièrement";
                    l5 = "sur 3 quarts de table différents, et ue ces unités sont toutes à plus de 6 pouces du centre du champs de bataille.";
                    l6 = "Marquez 6 points de victoire à la place si vous avez au moins une unité BUBONICUS ASTARTES entièrement sur chaque";
                    l7 = "quarts de table et que ces unités sont toutes à plus de 6 pouces du centre du champs de bataille. ";
                    l9 = "Marquez 4 points de victoire à la fin de la bataille si vous contrôlez plus de la moitier du nombre total de pions objectifs";
                    l10 = "sur le champs de bataille et qu'il y a des unités BUBONICUS ASTARTES de votre armée à 3 pouces de ces pions objectifs.";
                    l12 = "Marquez 4 points de victoire à la fin de la bataille si chaque pion objectif sur le champs de bataille";
                    l13 = " est à portée de contagion d'une aptitude de contagion des unitées de votre armée.";
                    break;

                case 127:
                    l1 = "REPANDRE LES MALADIES";
                    l2 = "Si vous choisissez cet objectif , les unités Infanterie de la Death Guard de votre armée peuvent effectuer l'action suivante:";
                    l4 = "Répandre les maladies (Action):";
                    l5 = "Une unité de votre armée peut commencer à effectuer cette action à la fin de votre phase de mouvement si elle est à 3 pouces";
                    l6 = "d'un pion objectif qui n'as pas été contaminé. ";
                    l8 = "Une unité ne peut pas commencer cette action si il y a une unité ennemie ( hors aérodynes) à 3 pouces du même pion objectif.";
                    l10 = "L'action est terminé à la fin de votre tour. Quand cette action est terminée, choisissez un des effets suivants:";
                    l11 = "Jetez un D6 : sur 4+ ce pion objectif est contaminé oubien , ";
                    l12 = "L'unité qui effectue cette action subit D3 BM et ce pion objectif est contaminé";
                    l13 = "Marquez 3 points de victoire à la fin de la bataille pour chaque pion objectif Contaminé par une unité de votre armée.";
                    break;
                #endregion
                #region OBJC_Admech
                case 128:
                    l1 = "ACCRETION DU SAVOIR";
                    l4 = "Marquez 3 points de victoire à la fin de la bataille pour chaque figurine ennemie détruite";
                    l5 = "qui remplit un ou plusieurs des critères suivants";
                    l7 = "- La figurine a un Trait de Seigneur de Guerre.";
                    l8 = "- La figurine a une Relique.";
                    l9 = "-La figurine a le mot-clé Véhicule et une charactèristique de PV de 14 ou plus.";
                    break;

                case 129:
                    l1 = "ERADICATION DE LA CHAIR";
                    l4 = "Marquez 3 points de victoire à la fin du round de bataille s'il y a au moins une unité Véhicule ADEPTUS MECHANICUS";
                    l5 = "de votre armée sur le champs de bataille,";
                    l6 = "et si à ce round de bataille, les unités ADEPTUS MECHANICUS de votre armée ont détruit plus d'unités d'Infanterie";
                    l7 = "que les unités ennemie n'ont détruit d'unités Vehicule amies.";
                    break;

                case 130:
                    l1 = "SEQUENCAGE NON REPERTORIE";
                    l3 = "Avant le déploiement ,";
                    l4 = "Assignez un seul pion objectif à chaque round de bataille et inscrivez le. ";
                    l6 = "Un pion objectif ne peut pas être assigné à plus d'un round de bataille.";
                    l8 = "Marquez 3 points de victoire à la fin du round de bataille, si vous contrôlez ";
                    l9 = "le pion objectif assigné au round de bataille concerné.";
                    break;

                case 131:
                    l1 = "ARCHEOCRYPTE SECRETE";
                    l4 = "Aprés le déploiement,votre adversaire choisit un seul pion objectif sur le champs de bataille";
                    l5 = "( En dehors des pions objectif dans sa propre zon de déploiement) ";
                    l8 = "- Marquez 2 points de victoire à la fin du round de bataille si vous contrôlez le pion objectif concerné.";
                    l10 = "- Marquez 5 points de victoire à la fin du round de bataille si vous contrôlez le pion objectif concerné.";
                    break;

                #endregion
                #region OBJC_Adepta S
                case 132:
                    l1 = "DEMONSTRATION DE FOI";
                    l3 = "A la fin de chaque tour , si 2 actes de foi ont été accomplis à ce tour par des unités Adepta Sororitas de votre armée,";
                    l4 = "marquez 1 points de victoire si c'est votre tour, ou 2 points de victoire si c'est le tour adverse.";
                    l6 = "Si au moins 3 actes de foi ont été accomplis à ce tour par des unités Adepta Sororitas de votre armée, marquez 1 point de victoire additionnel.";
                    l8 = "Notez que les actes de foi accomplis grâce à des dés de Chérubin accordés par des chérubins à encensoire ne compte pas pour cet objectif secondaire.";
                    l10 = "Vous ne pouvez pas marquer plus de 12 points de victoire grâce à cet objectif secondaire pendant la mission.";
                    break;

                case 133:
                    l1 = "TUEZ L'HERETIQUE";
                    l3 = "A la fin de chacune de vos phase de tir, marquez 1 points de victoire pour chacune des conditions suivantes qui as été rempli:";
                    l5 = "- Une ou plusieurs unités ennemies ont été détruites par une attaque éffectué avec une arme a BOLTS par une unité MINISTORUM de votre armée.";
                    l7 = "- Une ou plusieurs unités ennemies ont été détruites par une attaque éffectué avec une arme a FLAMMES par une unité MINISTORUM de votre armée.";
                    l9 = "- Une ou plusieurs unités ennemies ont été détruites par une attaque éffectué avec une arme a FUSION par une unité MINISTORUM de votre armée.";
                    l12 = "Si ces trois conditions ont été remplis à la fin de votre phase de tir , marquez 1 point de victoire additionnel";
                    l13 = "( pour un maximum de 4 points de victoire )";
                    break;

                case 134:
                    l1 = "SOL SACRE";
                    l2 = "Les unités Infanterie ADEPTA SORORITAS et PRETRES MINISTRUM de votre armée pevent tenter l'action suivante :";
                    l4 = "Sol sacré (atcion) :";
                    l6 = "Une unité infanterie Adepta Sororitas ou prêtre Culte Impérialis de votre armée peuvent commencer à accomplir cette action";
                    l7 = "à la fin de votre phase de mouvement si elle est à porté d'un pion objectif que votre armée n'a pas déjà consacré.";
                    l8 = "Une unitée ne peut pas commencer à accomplir cette action tant qu'il y a une unitée ennemie à porte du pion objectif. (hors aérodynes).";
                    l9 = "L'action est achevé à la fin de votre prochaine phase de commandement ou à la fin de la bataille, selon qui surviens en premier,";
                    l10 = "tant que l'unité qui l'accomplit est encore à portée du pion objectif.Si elle est achevée, le pion objectif est consacré par votre armée,";
                    l11 = "et jusqu'a la fin de la bataille , il gagne le trait Terrain Exaltant comme s'il sagissait d'un élément de terrain";
                    l12 = "Chaque fois qu'une unité achève l'action Sol Sacré,si le pion objectif consacré par l'action était entièrement dans votre zone de déploiement";
                    l13 = "marquez 1 point de victoire ; sinon marquez 4 points de victoire.";
                    break;

                case 135:
                    l1 = "DEFENDEZ LE SANCTUAIRE";
                    l3 = "Si vous choisissez cet objecif secondaire, après que les deux camps ont fini de se déployer, votre adversaire doit choisir un pion objectif";
                    l4 = "sur le champs de bataille hors de sa zone de déploiement qui sera le pion objectif du sanctuaire";
                    l5 = "(Si le seul pion objectif du champ de bataille est dans la zone de déploiement ennemie, ce sera le pion objectif du sanctuaire)";
                    l7 = "- A la fin de votre tour, marquez 3 points de victoire, si vous contrôlez le pion objectif de sanctuaire. ";
                    l9 = "- A la fin de la bataille, marquez 3 points de victoire additionnel, si vous contrôlez le pion objectif de sanctuaire. ";
                    l11 = "- A la fin de la bataille, réduisez le nombre de point de victoire que vous a rapporté cet objectif secondaire de 3 ";
                    l12 = "jusqu'a un minimun de 0, si votre adversaire contrôle le pion de santuaire.";
                    break;

                #endregion
                #region OBJC Orks
                case 136:
                    l1 = "KRAZEZ-LES";
                    l3 = "Marquez 3 points de victoire à la fin de chaque round de bataille";
                    l4 = "si le nombre d'unité ennemie détruites par des attaques de mêlée d'unités Orks de votre armée";
                    l5 = "est supérieur au nombre d'unités non-Gretchins amies détruites par des attaques de mêlée";
                    l6 = "pendant ce round de bataille.";
                    l10 = "Marquez 1 point de victoire supplémentaire à la fin de chaque round de bataille";
                    l11 = "si le nombre d'unités ennemies détruites par les attaques de mélée d'unités Orks de votre armée";
                    l12 = "est au moins 2 et le double du nombre d'unités non-Gretchins amies détruites par des attaques de mêlée";
                    l13 = "pendant ce round de bataille.";
                    break;

                case 137:
                    l1 = "LES PLUS GROS ET LES PLUS MIEUX";
                    l3 = "Si vous avez choisi cet objectif secondaire,";
                    l4 = "vous marquez 3 points de victoire à la fin de chaque round de bataille";
                    l5 = "pour chacune des conditions suivantes remplies par votre Seigneur de Guerre Orks ,";
                    l6 = "jusqu'à un maximum de 5 points de victoire :";
                    l9 = "Une unité Monstre ou Véhicule ennemie est détruite suite à une attaque de mêlée de ce Seigneur de Guerre.";
                    l11 = "Un Personnage ennemie est détruit suite à une attaque de mêlée de ce Seigneur de Guerre.";
                    l13 = "5 figurines ennemies ou plus ont été détruites suite à des attaques de ce Seigneur de Guerre.";
                    break;

                case 138:
                    l1 = "PRENEZ LES MORCEAUX D'CHOIX";
                    l2 = "Si vous avez choisi cet objectif secondaire, après le déploiement des deux camps, ";
                    l3 = "les joueurs choisissent à tour de rôle les pions objectifs qui ne sont dans la zone de déploiement d'aucun joueur";
                    l4 = "pour être des pions objectif de Morceaux d'Choix, jusqu'à ce que 3 pions objectif aient été choisis";
                    l5 = "(s'il n'y a qu'un pion objectif de cette sorte, seul celui-ci est un pion objectif de Morceaux d'Choix).";
                    l7 = "Les unités Base Orks de votre armée peuvent tenter l'action suivante:";
                    l8 = "Prenez les Morceaux d'Choix (Action):";
                    l9 = "A la fin de votre phase de Mouvement, une ou plusieurs unités Base Orks de votre armée peuvent commencer à accomplir cette action.";
                    l10 = "Chaque unité qui commence cette action doit être à portée d'un pion objectif de Morceaux d'Choix différent.";
                    l11 = "Une unité ennemie (hormis Aérodyne) à portée du même pion.";
                    l12 = "L'action est accomplie à la fin de votre prochaine phase de Commandement, tant que l'unité tentant l'action";
                    l13 = "est toujours à portée du même pion objectif de Morceaux d'Choix.";
                    l14 = "Marquez 3 points de victoire chaque fois qu'une unité de votre armée accomplit l'action Prenez les Morceaux d'Choix.";
                    break;

                case 139:
                    l1 = "MAREE VERTE";
                    l5 = "Au début de la bataille, divisez le champ de bataille en quarts égaux.";
                    l7 = "Marquez 3 points de victoire à la fin du round de bataille si deux quarts de champ de bataille";
                    l8 = "ou plus ont une unité Orks de votre armée contenant 11 figurines ou plus entièrement à l'intérieur";
                    l9 = "de chacun d'eux.";
                    l11 = "Marquez à la place 5 points de victoire à la fin du round de bataille si les quatre quarts ont une unité";
                    l12 = "Orks de votre armée contenant 11 figurines ou plus entièrement à l'intérieur de chacun d'eux.";
                    break;

                #endregion
                #region OBJC Tyranids
                case 140:
                    l1 = "PERSPICACITE SYNAPTIQUE";
                    l2 = "Si vous choississez cette objectif , tenez un compte Tuerie Synaptique. Ramenez ce compte a 0 au debut de chaque round.";
                    l3 = "Chaque fois qu'une figurine ennemie ( hors figurine de transport assigné ) est détruite par une figurine synapse de votre armée:";
                    l5 = "- Si la figurine ennemie avait une characteristique de PV entre 3 et 5 , ajoutez 1 à votre compte de tuerie synaptique.";
                    l7 = "- Si la figurine ennemie avait une characteristique de PV entre 6 et 9 , ajoutez 2 à votre compte de tuerie synaptique.";
                    l9 = "- Si la figurine ennemie avait une characteristique de PV de 10 ou plus , ajoutez 3 à votre compte de tuerie synaptique.";
                    l11 = "Marquez 3 points de victoire à la fin du round , si votre compte est de 4 ou plus";
                    l13 = "Vous ne pouvez pas marquer plus de 12 points de victoire avec cet objectif.";
                    break;

                case 141:
                    l1 = "NODULES DE SPORES";
                    l3 = "Marquez 4 points de victoire chaque fois qu'une unité de votre armée accomplit l'action suivante : ";
                    l5 = "SEMER DES NODULES DE SPORES ( Action ) :";
                    l6 = "1 unité de troupes de votre armée peut entreprendre cette action à la fin de votre phase de mouvement à partir du deuxieme round de bataille";
                    l7 = "si elle est à 6 pouces de la zone de déploiement adverse et à plus de 6 pouces de tout pions objectif de nodules de spores.";
                    l8 = "L'action est accomplit à la fin de votre tour.";
                    l9 = "Si cette action est accomplit , placer un pion objectif n'importe ou entièrement dans la zone de déploiement adverse";
                    l10 = " et à 1 pouce de l'unitée qui a accomplit cette action .";
                    l12 = "Ce pion objectif représente unnodules de spores , mais ne compte pas comme un pion objectif en termes de régles autres ";
                    l11 = "qu'au regard de cette objectif secondaire .";
                    break;

                case 142:
                    l1 = "FESTIN CRANIEN";
                    l3 = "Chaque fois qu'une figurine PERSONNAGE ennmie ou champion d'unité ennemi ,";
                    l4 = "est détruite par ne attaque de mélée d'une figurine VRILLE DE RUCHE de votre armée , jeter un D6 ,";
                    l5 = "en ajoutant 2 au jet si la figurine Vrille de Ruche a le mot-clé Vrilles Sensitives,";
                    l6 = "et en ajoutant 2 au jet si la figurine détruite & le mot-clé Personnage : ";
                    l8 = "Sur un 6+ , vous gagnez un point de commandement ( jusqu'à un maximum de 1 pts de commanementt par round ).";
                    l10 = "A la fin de la bataille : ";
                    l11 = "- Marquez 3 points de victoire si vous avez gagné 1 PC ou plus durant la bataille grâce à cet objectif.";
                    l12 = "- Marquez 1 point de victoire pour chaque figurine Personnage ennemi et chaque Champion  d'unité ennemie";
                    l13 = "qui as été détruite par une attaque de mêlée d'une figurine Vrille de ruche   de votre armée.";
                    l14 = "- Marquez 3 points de victoire si le Seigneur de Guerre ennemi à été détruit par une attaque de mêlée d'une figurine Vrille de ruche de votre armée..";
                    break;

                #endregion
                #region OBJC GK
                case 143:
                    l1 = "DETRUISEZ LE DEMON";
                    l3 = "Si vous choississez cette objectif secondaire,";
                    l4 = "Vous marquez des points de victoire pour chaque unité détruite lors de la bataille par une unité Grey Knights de votre armé";
                    l5 = "comme suit : ";
                    l7 = "- Unité Primarque démon : marquez 5 points de victoire .";
                    l8 = "- Unité Monstre démon   : marquez 3 points de victoire .";
                    l9 = "- Unité Véhicule démon  : marquez 3 points de victoire .";
                    l10 = "- Unité autre démon    : marquez 1 points de victoire .";
                    break;

                case 144:
                    l1 = "ASSAUT TELEPORTE";
                    l3 = "Marquez 3 points de victoire à la fin de la bataille";
                    l4 = "si une ou plusieurs unités ennemies ont été détruites par une figurine Grey Knights de votre armée";
                    l5 = "qui fut placé sur le champs de bataille à l' aide: de l'aptitude Frappe par téléportation,";
                    l7 = "de l'aptitude          -Frappe par téléportation,";
                    l8 = "du stratagème          -Poussé de téléportation";
                    l9 = "du pouvoir psychique   -Portail d'infinité";
                    l11 = "lors de ce round de bataille .";
                    break;

                case 145:
                    l1 = "RITUEL PURIFICATEUR";
                    l2 = "Marquez à la fin du round de bataille , le nombre de points de victoire indiquer dans le tableau ci-dessous";
                    l3 = "ce nombre étant fonction du nombre d'unités de votre armée qui ont accompli avec succès l'action psychique suivante à ce round de bataille : ";                    
                    l4 = "Rituel Purificateur (Action PSy - Charge Warp 5)";
                    l6 = "A votre phase Psychique , cette action peut-être accomplie par n'importe quel nombre d'unités de votre armée.";
                    l7 = "A votre phase Psychique , si une unité Psyker Grey Knights de votre armée est a 3 pouces d'n pion objectif,elle peut tenté de Purifier";
                    l8 = "en accompissant cette action psychique.";
                    l9 = "Chaque pion objetif ne pas être Purifié plus d'une fois au cours du même round.";
                    l10 = "Nbre d'objectif purifié              points de victoire marqués";
                    l11 = "         1                                       1 pts";
                    l12 = "         2                                       2 pts";
                    l13 = "         3                                       4 pts";
                    l14 = "         4+                                      6 pts";
                    break;

                #endregion
                #region OBJM patrouille
                case 501:
                    l1 = "ASSAUT CHIRURGICAL";
                    l6 = "Marquez 5 points de victoire si vous contrôlez le pion objectif";
                    l7 = "dans la zone de déploiement adverse à la fin de votre tour.";
                    break;

                case 502:
                    l1 = "SONDAGE";
                    l5 = "Marquez 5 points de victoire si vous contrôlez les 2 pions objectifs qui ne sont dans aucune";
                    l6 = "des zones de déploiement des joueurs a la fin de votre phase de commandement.";
                    l8 = "Cette objectif secondaire ne peut pas être marqué au premier round de bataille";
                    break;

                case 503:
                    l1 = "ENCERCER";
                    l4 = "MArquez 3 points de victoire si vous au moins une unité de votre armée ( hors Aérodynes ) entièrement à 6 pouces";
                    l5 = "de votre bord de champ de bataille et au moins une unité de votre armée (hors Aérodynes ) entièrement à 6 pouces";
                    l6 = "du bord du champ de bataille adverse à la fin de votre tour.";
                    l8 = "Marquez 5 points de victoire à la place si une de ces unités est de surcroît entièrement dans la zone de déploiement adverse.";
                    break;
                #endregion
                #region OBJM Incursion                
                case 1011:
                    l1 = "ASSAUT DIRECT";
                    l4 = "A la fin du tour de chaque joueur,  le joueur dont c'est le tour marque 2 points de victoire s'il remplit une des conditions suivante,";
                    l5 = "ou 3 points de victoire s'il remplit les deux conditions suivantes :";
                    l7 = "1- Il contrôle chaque pion objectif du champ de bataille ou il contrôle au moins 1 pion objectif qu'il ne contrôlait pas au début du tour.";
                    l9 = "2- Il a détruit au moins 1 unité ennemie qui était à portée d'un pion objectif au début de son tour. ";
                    break;

                case 1012:
                    l1 = "SECURISER LES SITES D'ATTERRISSAGE";
                    l3 = "A la fin du tour de chaque joueur, le joueur dont c'est le tour marque des points de victoire pour chaque pion objectif";
                    l4 = "dans le No Man's Land qu'il contrôle comme indiqué ci-dessous ";
                    l5 = "( Notez que le nombres de point de victoire marqué changent selon le round de bataille )";
                    l7 = "Round 3: 2 points de victoire par pion objectif dans le No Man's Land contrôlé";
                    l8 = "Round 4: 3 points de victoire par pion objectif dans le No Man's Land contrôlé";
                    l9 = "Round 5: 4 points de victoire par pion objectif dans le No Man's Land contrôlé";
                    l11 = "cet objectif principal ne peut pas être marqué au premier ou au deuxième rounds de bataille";
                    break;

                case 1013:
                    l1 = "ATTAQUEZ LES LIGNES DE RAVITAILLEMENT";
                    l6 = "A la fin du tour de chaque joueur, le joueur dont c'est le tour, marque 3 points de victoire ";
                    l7 = "s'il contrôle au moins 1 des pions objectif qui se trouve dans la zone de déploiement de son adversaire.";
                    break;

                case 1021:
                    l1 = "LA SAGESSE EST LE PILIER DE LA FOI";
                    l3 = "A la fin du tour du joueur A, ce joueur : ";
                    l4 = "- Marque 2 points de victoire s'il contrôle le pion objectif B";
                    l5 = "- Perd 1 point de victoire s'il ne contrôle pas le pion objectif A";
                    l6 = "- Marque 1 point de victoire pour chaque autre pion objectid qu'il contrôle";
                    l8 = "A la fin du tour du joueur B, ce joueur : ";
                    l9 = "- Marque 2 points de victoire s'il contrôle le pion objectif A";
                    l10 = "- Perd 1 point de victoire s'il ne contrôle pas le pion objectif B";
                    l11 = "- Marque 1 point de victoire pour chaque autre pion objectid qu'il contrôle";
                    l13 = "Le score de points de victoire d'un joueur ne peut pas tomber en dessous de 0.";
                    break;

                case 1022:
                    l1 = "ASCENSION";
                    l3 = "A la fin du tour de chaque joueur, le joueur dont c'est le tour marque 2 points de victoire s'il remplit au moins une des conditions suivantes:";
                    l5 = "Il contrôle le pion objectif au centre du champ de bataille.";
                    l6 = "Il a détruit au moins 1 unité ennemie qui était à 6 pouces du centre du champ de bataille au début de son tour.";
                    l8 = "A la fin de la bataille, chaque joueur marque 3 points de victoire pour chacune des conditions suivantes qu'il remplit:";
                    l9 = "(jusqu'à un maximum de 6 points par joueur)";
                    l11 = "- Son seigner de Guerre est à porté du pion objectif au centre du champ de bataille.";
                    l12 = "- Le seigneur de Guerre de son adversaire est détruit.";
                    break;

                case 1023:
                    l1 = "ELAN DE FOI";
                    l3 = "Elan de Foi ( Action):";
                    l4 = "1 unité de votre armée peut enteprendre cette action au début de votre phase de mouvement si elle est à portée d'un pion objectif qui ne se trouve pas";
                    l5 = " dans votre zone de déploiement.Les unités ayant l'aptitude OBjectif Sécurisé ou une règle similaire peuvent entreprendre cette action à la fin";
                    l6 = " de votre phase de mouvement à la place.Une unité ne peut pas entreprendre cette action tant qu'une ou plusieurs unités ennemies ( hors aérodines) sont";
                    l7 = "à portée du même pion objectif.L'action est accomplieà la fin de votre tour, à condition que l'unité qui l'entreprend soit toujours à portée du même pion";
                    l8 = "chaque fois qu'une unité de votre armée accomplit avec succès l'action de Foi,";
                    l9 = "vous marquez des points de victoire selon le pion objectif sur lequel cette action a été entreprise,comme suit:";
                    l10 = "Pion objectif A -->      pts de victoire Joueur A: N/A     pts de victoire joueur B: 4";
                    l11 = "Pion objectif B -->      pts de victoire Joueur A: 2       pts de victoire joueur B: 3";
                    l12 = "Pion objectif C -->      pts de victoire Joueur A: 3       pts de victoire joueur B: 2";
                    l13 = "Pion objectif D -->      pts de victoire Joueur A: 4       pts de victoire joueur B N/A";
                    break;

                case 1031:
                    l1 = "TELECHARGER LE DATA-PSAUME";
                    l2 = "A la fin du tour de chaque joueur , si une ou plusieurs unités de l'armée de ce joueur ont accompli avec succès l'action Télécharger le Data-psaume à ce tour,";
                    l3 = "le joueur concerné marque 1 point de victoire pour chaque pion objectif qu'il contrôle à ce moment (jusqu'à un maximum de 3 points de victoire par joueur et par tour)";
                    l5 = "TELECHARHER LE DATA-PSAUME (Action):";
                    l7 = "une ou plusieurs unités de votre armée peuvent entreprendre cette action à la fin de votre phase de mouvement.";
                    l8 = "Chaque unité qui entreprend cette action doit êtreà portée d'un pion objectif différent.";
                    l9 = " Une unité ne peut pas commencer cette action tant que n'importe quel nombre d'unités ennemies sont à portée du même pion objectif (Aérodynes exclus). ";
                    l11 = "Cette action est accompit à la fin de votre phase de commandement suivante , à condition que l'unité qui l'a entreprise soit toujours à portée du même pion objectif.";
                    l12 = "Si une unité ayant la règleObjectif Sécurisé ou une règle similaire accomplit cette action avec succès, le pion objectif concerné demeure sous le contrôle de ce joueur,";
                    l13 = "à moins que son adversaire le contrôle à la fin de n'importe quelle phase ultérieure, même s'il n'y a pas de figurine à portée.";
                    break;

                case 1032:
                    l1 = "BRISEZ-LES CORPS ET AME";
                    l4 = "A la fin de chaque round de bataille, ";
                    l5 = "chaque joueur marque 1 point de victoire pour chaque unité ennemie qui a été détruite lors du round de bataille concerné.";
                    l7 = " (jusqu'a un maximum de 3 points de victoire par joueur et par round)";
                    l9 = "Une unité peut, ";
                    l10 = "si elle est ressuscitée pour n'importe quelle raison, compter potentiellement comme ayant été détruite plusieurs fois pour cet objectif principal";
                    l12 = "( en supposant qu'elle a été détruite à nouveau au cours du même round de bataille )";
                    break;

                case 1033:
                    l1 = "BALAYAGE DE RECONNAISSANCE";
                    l2 = "A a fin de la bataille, chaque joueur marque des points de victoire pour le nombre total de pions objectif du champ de bataille";
                    l3 = " qui ont été balayés par son armée, comme indiqué ci-dessous";
                    l4 = "1 Pion OBjectif balayé = 3 points de victoire  ; 2 Pion OBjectif balayé = 6 points de victoire ;";
                    l5 = "3 Pion OBjectif balayé = 10 points de victoire ; 4 Pion OBjectif balayé = 15 points de victoire ;";
                    l7 = "BALAYAGE DE RECONNAISSANCE ( Action:)";
                    l8 = "Une unitée de votre armée peu entrependre cette action à la fin de votre phase de mouvement si elle est à portée d'un pion objectif qui nas pas été balayé";
                    l9 = "par une unité de votre armée. Une unité ne peut pas commencer cette action tant que n'importe quelle nombres d'unités ennemies sont à portée du même pion objectif.(hors Aérodynes)";
                    l10 = "Si l'unité qui entreprend l'action a le rôle tactique Attaque rapide, ou si elle a l'aptitude Objectif Sécurisé ou une règle similaire, l'action est accomplie";
                    l11 = "à la fin de votre tour à condition que l'unité soit toujours à portée du même pion objectif; sinon , l'action est accomplie au début de votre prochaine phase de commandement,";
                    l12 = "ou à la fin de la bataille ( selon ce qui arrive en premier), à condition que l'unité qui entreprend l'action soit toujours à portée du même pion objectif.";
                    l13 = "Si l'action est accompie avec succès, on dit du pion objectif concerné qu'il a été balayé par votre armée.";
                    break;
                #endregion
                #region OBJM Force De Frappe
                case 2011:
                    l1 = "BRISEZ-LES CORPS ET AME";
                    l4 = "A la fin de chaque round de bataille, ";
                    l5 = "chaque joueur marque 1 point de victoire pour chaque unité ennemie qui a été détruite lors du round de bataille concerné.";
                    l7 = " (jusqu'a un maximum de 3 points de victoire par joueur et par round)";
                    l9 = "Une unité peut, ";
                    l10 = "si elle est ressuscitée pour n'importe quelle raison, compter potentiellement comme ayant été détruite plusieurs fois pour cet objectif principal";
                    l12 = "( en supposant qu'elle a été détruite à nouveau au cours du même round de bataille )";
                    break;

                case 2012:
                    l1 = "DETONATION";
                    l2 = "A la fin de la bataille, chaque joueur marque 4 point de victoire pour chaque pion objectif d'Explosifs Amorcés qui est dans le territoire de l'adversaire.";
                    l3 = "(Jusqu'à un maximum de 15 points de victoire par joueur)";
                    l4 = "AMORCER LES EXPLOSIFS (Action):";
                    l5 = "1 unité de votre armée peut entreprendre cette action à la fin de votre phase de Mouvement si elle est entièrement dans le territoire adverse et ";
                    l6 = "si elle est à 9 pouces d'un ou plusieurs pions objectif d'explosifs Amorcés.Si l'unité qui entreprend l'action a l'aptitude Objectif Sécurisé ou une règle similaire,";
                    l7 = " l'action est accomplie à la fin de votre tour; sinon , l'action est accomplie a la fin de votre prochaine phase de commandement. Si cette action est accomplie,";
                    l8 = "placer 1 pion objectif d'explosifs Amorcés sur le champ de bataille, entièrement dans le territoire adverse et entièrement à 3 pouces de l'unité qui accompli cette action:";
                    l9 = "ceci représente une cache d'Explosifs Amorcés, mais ne compte pas comme un pion objectif en termes de règles, sauf pour les besoins de l'action Désamorcer les Explosifs et";
                    l10 = "l'objectif principal Détonation";
                    l11 = "DESAMORCER LES EXPLOSIFS (Action)";
                    l12 = "1 unité de votre armée peut entreprendre cette action à la fin de votre phase de Mouvement si elle st à portée d'un pion objectif d'Explosifs Amorcés dans votre territoire et si";
                    l13 = "aucune unité ennemie ( hors Aérodynes ) n'est à portée du même pion objectif d'Explosifs Amorcés. Si cette action accomplie, jetez un D6  et ajoutez 3 au résultat si l'unité";
                    l14 = "accompli l'action a 'aptitude Objectif Sécurisé ou une règles similaire: sur 4+, retirez le pion objectif d'Explosis Amorcés du champ de bataille.";
                    break;

                case 2013:
                    l1 = "INTERCEPTION DE DONNEES";
                    l2 = "Chaque fois qu'une unité de votre armée accomplit l'action Interception de Données,";
                    l3 = " vous marquez autant de points de victoire que le nombre de pions objectif situés";
                    l4 = "dans le no Man's Land que vous contrôlez actuellement, jusqu'à un maximum de 3 points de victoire par action.";
                    l5 = "INTERCEPTION DE DONNEES (Action):";
                    l6 = "1 unité de votre armée peut entreprendre cette action à la fin de votre phase de Mouvement si";
                    l7 = " elle est à portée du pion objectif dans sa zone de déploiement et";
                    l8 = "si aucune unité ennemie ( hormis les Aérodynes ) n'est à portée du pion objectif";
                    l9 = "Cette action est accomplie à la fin de votre tour, à condition que l'unité qui l'entreprend soit toujours à portée du pion objectif.";
                    l10 = "TERMINAUX DE DONNEES";
                    l11 = "Dans cette mission, si un joueur contrôle un pion objectif qui est dans le no Man's Land à la fin de sa phase de Commandement et";
                    l12 = " si une ou plusieurs des ses unités qui sont à portée de celui-ci ont l'aptitude Objectif Sécurisé ou une règle similaire,";
                    l13 = " il reste sous le contrôle du joueur même s'il n'y a pas de figurines à portée,";
                    l14 = "à moins que son adversaire en prenne le contrôle à la fin d'une phase ultérieure.";
                    break;

                case 2021:
                    l1 = "SECURISER LES SANCTUAIRES";
                    l3 = "A la fin du tour de chaque joueur, le joueur dont c'est le tour marque 2 points de victoire s'il remplit au moins une des conditions suivantes:";
                    l4 = "-Il contrôle le pion objectif au centre du champs de bataille.";
                    l5 = "-Il a détruit au moins une unité ennemie qui était à 6' du centre du champ de bataille au début du tour.";
                    l7 = "A la fin de la bataille, le joueur qui contrôle le pion objectif au centre du champ de bataille marque 5 points de victoire";
                    l10 = "NO MAN'S LAND:";
                    l12 = "Si une unité a une règle de prébataille qui lui permet d'être placé n'importe où sur le champ de bataille, elle ne peut pas être placée dans le man's land.";
                    l13 = "Si une unité a une règle qui lui permet de faire un mouvement avant le début du premier tour, elle ne peut pas le terminer dans le no man's land.";
                    l14 = "Si une règle est utilisée pour redéployer une unité, elle ne peut pas servir à placer l'unité dans le no man's land.";
                    break;

                case 2022:
                    l1 = "SOL CORROMPU";
                    l2 = "A la fin du tour de chaque joueur, le joueur dont c'est le tour:";
                    l3 = "Marque 4 points de victoire s'il contrôle le pion objectif de la zone de déploiement adverse.";
                    l4 = "Marque 2 points de victoire s'il contrôle au moins un pion objectif qui est dans le no man's land.";
                    l5 = "Perd 1 points de victoire s'il ne contrôle pas le pion objectif dans sa zone de déploiement.";
                    l6 = "Le score de points de victoires d'un joueur ne peut jamais descendre en dessous de 0.";
                    l8 = "DIRIGER EN PREMIERE LIGNE";
                    l10 = "Dans cette mission, un joueur reçoit le bonus de PC Réglementaire au ";
                    l11 = "début de la phase de commandement seulement si son Seigneur de Guerre est sur le champ de bataille, ";
                    l13 = "ou s'il est embarqué dans une figurine de Transport qui est sur le champ de bataille.";
                    break;

                case 2023:
                    l1 = "SCAN STRATEGIQUE";
                    l3 = "A la fin de la bataille, chaque joueur marque 3 points de victoire pour chaque pion objectif sur le champ de bataille";
                    l4 = "qui a été scanné par son armée";
                    l6 = "SCAN D'AUSPEX";
                    l8 = "1 unité de votre armée peut entreprendre cette action à la fin de votre phase de Mouvement";
                    l9 = "si elle est à portée d'un pion objectif qui n'a pas été scanné par une unité de votre armée.";
                    l10 = "Une unité ne peut pas entreprendre cette action tant qu'il y a une ou plusieurs unités ennemies (hormis Aérodynes) à portée du pion objectif.";
                    l11 = "Cette action est accomplie au début de votre prochaine phase de Commandement, ou à la fin de bataille,";
                    l13 = "à condition que l'unité qui l'entreprend soit toujours à portée du pion objectif.";
                    l14 = "Si cette action est accomplie, le pion objectif à été scanné par votre armée";
                    break;

                case 2031:
                    l1 = "SUBMERGER";
                    l2 = "A la fin des premier, deuxième, troisième et quatrième tours de chaque joueur, le joueur dont ";
                    l3 = "c'est le tour marque 2 points de victoire s'il contrôle au moins un pion objectif dans le territoire adverse";
                    l4 = "A la fin de la bataille, chaque joueur marque 4 points de victoire s'il contrôle le pion objectif";
                    l5 = "dans la zone de déploiement adverse, et 2 points de victoire pour chaque autre pion objectif du territoire adverse qu'il contrôle";
                    l6 = "(pour un maximum de 8 points de victoire par joueur).";
                    l8 = "LIGNES DE RAVITAILLEMENT";
                    l11 = "Dans cette mission, un joueur reçoit le bonus de PC Réglementaire au début de sa phase de Commandement";
                    l13 = "seulement s'il contrôle le pion objectif de sa zone de déploiement.";
                    break;

                case 2032:
                    l1 = "ASSAUT DIRECT";
                    l2 = "A la fin du tour de chaque joueur, le joueur dont c'est le tour marque 2 points de victoire";
                    l3 = "s'il remplit une de ces conditions suivantes, ou 3 points de victoire s'il remplit les deux:";
                    l4 = "-Il contrôle tous les pions objectif du champ de bataille ou il contrôle au moins un pion objectif";
                    l5 = "qu'il ne contrôlait pas au début de son tour";
                    l7 = "-Il a détruit au moins une unité ennemie qui était à portée d'un pion objectif au début de son tour";
                    l9 = "OBJECTIF PURGE";
                    l11 = "Dans cette mission, si un joueur contrôle un pion objectif à la fin de sa phase de Commandement";
                    l12 = "et si une ou plusieurs de ses unités qui sont à portée de celui-ci ont l'aptitude Objectif Sécurisé";
                    l13 = "ou une règle similaire, il reste sous le contrôle du joueur même s'il n'y a pas de figurine à portée,";
                    l14 = "à moins que son adversaire en prenne le contrôle à la fin d'une phase ultérieure.";
                    break;

                case 2033:
                    l1 = "ARTEFACTS PRECIEUX";
                    l2 = "A la fin du tour de chaque joueur, le joueur dont c'est le tour marque 3 points de victoire";
                    l3 = "s'il contrôle le pion objectif Prioritaire qui est dans son territoire.";
                    l4 = "OBJECTIFS PRECIEUX";
                    l5 = "-D'abord, l'Attaquant repositionne 1 pion objectif noté A ou 1 pion objectif noté B.";
                    l6 = "-Ensuite, le Défenseur repositionne 1 pion objectif noté A et 1 pion objectif noté B";
                    l7 = "(un pion objectif ne peut pas être repositionné plusieurs fois)";
                    l8 = "-Enfin, l'Attaquant repositionne le dernier pion objectif noté A ou B qui doit encore être repositionné.";
                    l9 = "Dans tous les cas, quand un pion objectif est repositionné, placez-le entièrement à 6' horizontalement";
                    l10 = "de sa position initiale, et pas sur ou dans un Obstacle ni sur un Terrain Défendable.";
                    l11 = "Après que tous les pions objectif ont été repositionnés, chaque joueur note en secret un des pion";
                    l12 = "objectif Prioritaire (ce ne peut pas être le pion objectif au centre du champ de bataille).";
                    l13 = "Après que les deux joueurs ont déployé leurs armées, ils révèlent leur choix à l'adversaire.";
                    break;

                #endregion
                #region OBJM Offensive
                case 3001:
                    l1 = "TENIR LE CENTRE";
                    l6 = "Marquez 5 points de victoire à la fin de votre phase de Commandement, ";
                    l7 = "si vous contrôlez plus de pions objectif marquez B que votre adversaire n'en contrôle";
                    l8 = "et que vous avez plus de figurines entièrement à 12 pouces du centre du champ de bataille que votre adversaire.";
                    l10 = "Cet objectif secondaire ne peut pas être marqué au premier round de bataille.";
                    break;

                case 3002:
                    l1 = "ENCERCLEZ-LES";
                    l5 = "Marquez 4 points de victoire à la fin de votre phase de Commandement et à la fin de la bataille";
                    l6 = "si vous contrôlez les pions objectifs dans votre zone de déploiement";
                    l7 = " et un pion objectif ou plus dans la zone de déploiement adverse.";
                    l9 = "Marquez 8 points de victoire à la place si vous contrôlez les quatre pions objectif qui sont dans es zones de déploiement";
                    break;

                case 3003:
                    l1 = "CHERCHER LE PORTAIL";
                    l3 = "Chaque fois qu'une unité de votre armée accomplit l'Action Chercher le Portail , vous marquez 1 point de victoire,";
                    l4 = "et 1 point de victoire supplémentaire pour chaque pion objectif marqué A actuellement sous votre contrôle";
                    l5 = "( pour un maximum de 5 points de victoire )";
                    l7 = "Chercher le Portail ( Action) :";
                    l9 = "1 unité INFANTERIE de votre armée ( PERSONNAGES EXCLUS) peut commencer à effectuer cette action à la fin de votre phase de mouvement";
                    l10 = "si elle est entièrement dans la zone de fouille figurée sur la carte de déploiement.";
                    l11 = "L'action est accompie à la fin de votre prochaine phase de Commandement tant que l'unité qui l'effectue";
                    l12 = " est toujours entièrement dans la zone de Fouille.";
                    break;
                #endregion

                #region OBJC_vide
                case 1130:
                    l1 = "";
                    l2 = "";
                    l3 = "";
                    l4 = "";
                    l5 = "";
                    l6 = "";
                    l7 = "";
                    l8 = "";
                    l9 = "";
                    l10 = "";
                    l11 = "";
                    l12 = "";
                    l13 = "";
                    l14 = "";
                    break;

                case 1140:
                    l1 = "";
                    l2 = "";
                    l3 = "";
                    l4 = "";
                    l5 = "";
                    l6 = "";
                    l7 = "";
                    l8 = "";
                    l9 = "";
                    l10 = "";
                    l11 = "";
                    l12 = "";
                    l13 = "";
                    break;

                case 1150:
                    l1 = "";
                    l2 = "";
                    l3 = "";
                    l4 = "";
                    l5 = "";
                    l6 = "";
                    l7 = "";
                    l8 = "";
                    l9 = "";
                    l10 = "";
                    l11 = "";
                    l12 = "";
                    l13 = "";
                    break;

                case 1160:
                    l1 = "";
                    l2 = "";
                    l3 = "";
                    l4 = "";
                    l5 = "";
                    l6 = "";
                    l7 = "";
                    l8 = "";
                    l9 = "";
                    l10 = "";
                    l11 = "";
                    l12 = "";
                    l13 = "";
                    break;

                #endregion

                default:
                    l1 = "";
                    l2 = "";
                    l3 = "";
                    l4 = "";
                    l5 = "PAS DE DESCRIPTION DISPONNIBLE !";
                    l6 = "";
                    l7 = "";
                    l8 = "";
                    l9 = "";
                    l10 = "";
                    l11 = "";
                    l12 = "";
                    l13 = "";
                    l14 = "";
                    break;
            }
        }

        private string l1;
        private string l2;
        private string l3;
        private string l4;
        private string l5;
        private string l6;
        private string l7;
        private string l8;
        private string l9;
        private string l10;
        private string l11;
        private string l12;
        private string l13;
        private string l14;

        public string L1 { get { return l1; } }
        public string L2 { get { return l2; } }
        public string L3 { get { return l3; } }
        public string L4 { get { return l4; } }
        public string L5 { get { return l5; } }
        public string L6 { get { return l6; } }
        public string L7 { get { return l7; } }
        public string L8 { get { return l8; } }
        public string L9 { get { return l9; } }
        public string L10 { get { return l10; } }
        public string L11 { get { return l11; } }
        public string L12 { get { return l12; } }
        public string L13 { get { return l13; } }
        public string L14 { get { return l14; } }
    }
}

