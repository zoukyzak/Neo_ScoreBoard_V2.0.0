using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPV9.Classes
{
    class Descript_OBJS
    {
        public Descript_OBJS(int OBJ)
        {
            switch (OBJ)
            {
                #region OBJP
                case 1:
                    l1 = " ASSASSINAT";
                    l2 = "";
                    l3 = "";
                    l4 = "Score 3 points de victoire à la fin de la bataille";
                    l5 = "pour chaque figurine personnage ennemi qui aura été detruite.";
                    l6 = "Si , le Seigneur de Guerre ennemi est detruit durant la bataille,";
                    l7 = "gagner 1 point de victoire supplementaire.";
                    l8 = "";
                    l9 = "";
                    l10 = "";
                    break;

                case 2:
                    l1 = " ABBATEZ-LE";
                    l2 = "";
                    l3 = "Score 1 points de victoire à la fin de la bataille pour chaque figurine ennemi,";
                    l4 = "véhicule ou monstre avec une charactéristique de PV de 9 ou moins qui est détruite.";
                    l5 = "";
                    l6 = "Score 2 points de victoire à la fin de la bataille pour chaque figurine ennemi";
                    l7 = "véhicule ou monstre avec une charactéristique de PV entre 10 et 14 qui est détruite.";
                    l8 = "";
                    l9 = "et 3 points de victoire à la fin de la bataille pour chaque figurine ennemi, ";
                    l10 = "véhicule ou monstre avec une charactéristique de PV de 15 et plus qui est détruite.";
                    break;

                case 3:
                    l1 = " TUEUR DE TITANS";
                    l2 = "";
                    l3 = "Score 4 points de victoire à la fin de la bataille si,";
                    l4 = "une figurine Titanesque ennemi est détruite.";
                    l5 = "";
                    l6 = "Score 9 points de victoire à la fin de la bataille si,";
                    l7 = "deux figurines Titanesques ennemi sont détruitent.";
                    l8 = "";
                    l9 = "Score 15 points de victoire à la fin de la bataille si,";
                    l10 = "trois figurines Titanesques ennemi sont détruitent.";
                    break;

                case 5:
                    l1 = " BROYEZ-LES";
                    l2 = "Additionnez le nombres de points de vie des figurines ennemi détruite durant la bataille.";
                    l3 = "Une unitée réssuscité et de nouveau détruite , sera comptabilisé une seconde fois";
                    l4 = "";
                    l5 = "A la fin de la bataille,score 1 point par tranche de 10 points de vie perdu par l' ennemi";
                    l6 = "";
                    l7 = "de plus ,";
                    l8 = "si vous avez cumulez entre 50 et 99 points de vie , ajouter 1 point de victoire supplemenaire";
                    l9 = "si vous avez cumulez 100 points de vie et plus, ajouter 2 point de victoire supplemenaire";
                    l10 = "";
                    break;

                case 6:
                    l1 = " PAS DE PRISONNIER";
                    l2 = "";
                    l3 = "";
                    l4 = "Marquez 3 pts de victoire a la fin du round de bataille";
                    l5 = "si d'avantage d'unités ennemies que d'unités amis ";
                    l6 = "ont été détruites à ce round de bataille.";
                    l7 = "";
                    l8 = "";
                    l9 = "";
                    l10 = "";
                    break;

                case 7:
                    l1 = " J'USQU'AU DERNIER";
                    l2 = "";
                    l3 = "Identifié avant la bataille vos trois unités qui ont leurs coups en points les plus élévés.";
                    l4 = " les unitée avec le rôle tactique fortification exclues ";
                    l5 = "";
                    l6 = "Score 5 points de victoire pour chaque unité encore en vie à la fin de la bataille";
                    l7 = "";
                    l8 = "Si une unité se scinde en deux et qu'une partie est détruite et l'autre est resté en vie à la fin de la bataille,";
                    l9 = "Score 3 points de victoire pour cette unité au lieu de 5 points";
                    l10 = "";
                    break;

                case 9:
                    l1 = " SUR TOUS LES FRONT";
                    l2 = "";
                    l3 = "Marquez 2 points de victoire à la fin de votre tour si vous avez une unité éligible ou plus";
                    l4 = "de votre armée entiérement dans les 3/4 de tables différents et a plus de 6 pouces du centre.";
                    l5 = "";
                    l6 = "Marquez 3 points de victoire à la fin de votre tour si vous avez une unité éligible ou plus";
                    l7 = "de votre armée entiérement dans chaque quart de tables différents et a plus de 6 pouces du centre.";
                    l8 = "";
                    l9 = "Pour être éligible , l'unité dois contenir 3 figurines ou plus , oubien contenir un véhicule ou monstre ou plus.";
                    l10 = "";
                    break;

                case 10:
                    l1 = " DERRIERE LES LIGNES ENNEMIES";
                    l2 = "";
                    l3 = "";
                    l4 = "Marquez 2 points de victoire à la fin de votre tour si 1 unité de votre armée (hors Aérodyne)";
                    l5 = "est entièrement dans la zone de déploiement adverse.";
                    l6 = "";
                    l7 = "Marquez 4 points de victoire à la place à la fin de votre tour , si 2 unités ou plus (hors Aérodyne)";
                    l8 = "sont entièrement dans la zone de déploiement adverse.";
                    l9 = "";
                    l10 = "";
                    break;

                case 11:
                    l1 = " EMPRISE";
                    l2 = "";
                    l3 = "";
                    l4 = "";
                    l5 = "Marquez 3 points de victoire à la fin de votre tour si vous contrôlez 3 objectifs";
                    l6 = "ou plus et que vous en contrôliez plus que votre adversaire.";
                    l7 = "";
                    l8 = "";
                    l9 = "";
                    l10 = "";
                    break;

                case 12:
                    l1 = " INSPECTER LE SIGNAL";
                    l2 = "";
                    l3 = "Marquez 3 points de victoire chaque fois qu'une unité de votre armée accomplit l'action suivante :";
                    l4 = "";
                    l5 = "Inspecter le signal (action) :";
                    l6 = "1 unité d'INFANTERIE de votre armée qui contient 3 figurines ou plus peut";
                    l7 = "entreprendre cette action à la fin de votre phase de mouvement si elle est entièrement à 6 pouces";
                    l8 = "du centre du champs de bataille.Cette action est accomplit à la fin de votre tour à condition que";
                    l9 = "l'unité qui l'entreprenait soit toujours entièrement a 6 pouces du centre du champs de bataille";
                    l10 = "et qu'il n'y ai pas d'unité ennemie entièrement à 6 pouces du centre.(hors Aérodyne)";
                    break;

                case 13:
                    l1 = " DEPLOYEZ LES BALISES DE TELEPORTATION";
                    l2 = "Si vous choisissez cette objectif , alors les unités de votre armée peuvent accomplir l'action suivante:";
                    l3 = "DEPLOYEZ UNE BALISE DE TELEPORTATION (action) :";
                    l4 = "1 unité d'infanterie ou motard peut commencer cette action à la fin de votre phase de mouvement si elle est";
                    l5 = "entièrement à 12 pouces de la zone de déploiement adverse.";
                    l6 = "Si l'unité a le rôle tactique Troupes,l'action est accomplie à la fin de votre phase de mouvement ;";
                    l7 = "sinon l'action n'est accomplie qu'à la fin de la prochaine phase de commandement et si l'unité est";
                    l8 = "toujours entièrement à 12 pouces de la zone de déploiement adverse.";
                    l9 = "Chaque fois qu'une unité accomplit cette action, vous marquerez 2 points de victoire.";
                    l10 = "4 points de victoire à la place si l'unité est entièrement dans la zone de déploiement adverse.";
                    break;

                case 14:
                    l1 = " LEVEZ HAUT LES ETENDARDS (action)";
                    l2 = "1 unité INFANTERIE ou plus de votre armée peut commencer cette action à la fin de votre phase de mouvement.";
                    l3 = "Chaque unité de votre armée qui commence cette action doit être à portée d'un pion objectif";
                    l4 = "différent sur lequel aucun de vos étendards n'a été levé.";
                    l5 = "Une unité ne peut pas commencer cette action s'il y a la moindre unité ennemie (hors Aérodyne) à portée du même pion objectif.";
                    l6 = "L'action est accomplie à la fin de votre phase de mouvement.";
                    l7 = "si cette action est accomplie, on dit qu'un étendard de votre armée est levé sur ce pion objectif.";
                    l8 = "L'étendard est retiré si votre adversaire contrôle le pion objectif au début de n'importe quelle phase.";
                    l9 = "Vous marquez 1 point de victoire à la fin de chacune de vos phase de commandement et 1 point de victoire à la fin de la bataille,";
                    l10 = "pour chaque pion objectif du champs de bataille sur lequel un de vos étendards a été levé";
                    break;

                case 15:
                    l1 = " INTERROGATION PSYCHIQUE (action)";
                    l2 = "";
                    l3 = "Marquez 3 points de victoire chaque fois que vous accomplissez avec succès l'action psychique suivante:";
                    l4 = "";
                    l5 = "INTERROGATION PSYCHIQUE (Action Psychique charge Warp 4):";
                    l6 = "";
                    l7 = "1 unité PERSONNAGE PSYKER de votre armée peut tenter d'accomplir cette action psychique à votre phase psychique";
                    l8 = "si elle est à 24 pouces d'une ou plusieurs figurines PERSONNAGES ennemies.";
                    l9 = "";
                    l10 = "";
                    break;

                case 16:
                    l1 = " RITUEL DU WARP (action)";
                    l2 = "Si vous choississez cet objectif , tenez un compte de rituel;";
                    l3 = "ajouter 1 a ce compte chaque fois qu'une unité de votre armée accomplit avec succès l'action psychique suivante:";
                    l4 = "";
                    l5 = "RITUEL DU WARP (Action Psychique charge Warp 3):";
                    l6 = "";
                    l7 = "1 unité PERSONNAGE PSYKER de votre armée peut tenter d'accomplir cette action psychique à votre phase psychique";
                    l8 = "si elle est à 6 pouces du centre du champ de bataille.";
                    l9 = "A la fin de la bataille, marquez 3 points de victoire si votre compte est de 1, marquez 7 points de victoire s'il est de 2,";
                    l10 = "ou marquez 12 points de victoire s'il est de 3 ou plus";
                    break;

                case 17:
                    l1 = " ABHORREZ LE SORCIER";
                    l2 = "";
                    l3 = "";
                    l4 = "Vous ne pouvez pas choisir cet objectif secondaire si votre armée inclut la moindre unité Psyker.";
                    l5 = "";
                    l6 = "";
                    l7 = "Marquez 3 points de victoire à la fin de la bataille pour chaque unité PERSONNAGE PSYKER ennemie";
                    l8 = "qui a été détruit, et 2 points de victoire pour chaque autre unité Psyker ennemie qui a été détruite.";
                    l9 = "";
                    l10 = "";
                    break;


                case 18:
                    l1 = " RECUPEREZ LES DONNEES DE NACHMUND (action)";
                    l2 = "1 unité INFANTERIE ou motard de votre armée peut entreprendre cette action à la fin de votre phase de mouvement";
                    l3 = "si elle est entièrement dans un quart de table sans servocrâne récupéré par votre armée (voir ci-dessous)";
                    l4 = "et à plus de 6 pouces de tout autre quart de table.";
                    l5 = "Cette action est accomplie à la fin de votre tour, tant que l'unité qui tente de le faire est toujours dans le même ";
                    l6 = "quart de table. Si cette action est accomplie, jetez un D6, en soustrayant 1 au résultat si l'unité qui as accompli l'action";
                    l7 = "a le rôle tactique TROUPES :  si le résultat est inférieur ou égal au nombres de figurines actuel,";
                    l8 = "votre armée a retrouvé un servocrâne dans ce quart de table et vous ajoutez 1 à votre compte de Données récupérées.";
                    l9 = "A la fin de la bataille, marquez 4 points de victoire si votre compte de Données Récupérées est de 2, marquez 8 points";
                    l10 = "de victoire s'il est de 3, ou 12 points de victoire s'il est de 4";
                    break;

                case 19:
                    l1 = " PERCER LE VOILE";
                    l2 = "Marquez 8 points de victoire à la fin de la bataille si une ou plusieurs unités de votre armée ont accompli avec succès";
                    l3 = "l'action psychique suivante 2 fois ou plus lors de la bataille, ou 15 points de victoire à la fin de la bataille";
                    l4 = "si une ou plusieurs unités de votre armée ont accompli avec succès l'action psychique suivante 4 fois lors de la bataille.";
                    l5 = "";
                    l6 = "Vous ne pouvez accomplir cet objectif qu'une fois par tour.";
                    l7 = "";
                    l8 = "PERCER LE VOILE (action psychique - charge warp 4)";
                    l9 = "1 unité PERSONNAGE PSYKER de votre armée peu tenter d'accomplir cette action psychique durant votre phase psychique";
                    l10 = "s'il est à 6 pouces du bord de table de votre adversaire et a plus de 6 pouces de toute figurine ennemie.";
                    break;
                #endregion
                #region OBJC_Necron
                case 100:
                    l1 = " CODE DE COMBAT";
                    l2 = "";
                    l3 = "";
                    l4 = "";
                    l5 = "Marquez 3 points de victoire à la fin de la bataille pour chaque unité énnemie détruite";
                    l6 = "par une unité NOBLE Nécron de votre armée.";
                    l7 = "";
                    l8 = "";
                    l9 = "";
                    l10 = "";
                    break;

                case 101:
                    l1 = " ELEMINEZ LA VERMINE";
                    l2 = "";
                    l3 = "";
                    l4 = "Marquez 2 points de victoire à la fin de votre tour pour chaque quart de table";
                    l5 = "qui n'as aucune unité énnemie ( hors aérodynes) entièement à l'intérieur.";
                    l6 = "cette objectif ne peut pas être marqué au premier tour.";
                    l7 = "";
                    l8 = "";
                    l9 = "";
                    l10 = "";
                    break;

                case 102:
                    l1 = " TRESORS DES EONS";
                    l2 = "";
                    l3 = "Si vous choisissez cette objectif secondaire, une fois les deux camps déployés,";
                    l4 = "votre adversaire choisit 3 pions objectifs sur le champs de bataille.";
                    l5 = "Marquez un nombre de points de victoire à la fin de votre tour si vous contrôlez";
                    l6 = "un ou plusieurs de ces pions objectif";
                    l7 = "Nombres de pions objectifs contrôler :";
                    l8 = "1 = 2 points de victoire";
                    l9 = "2 = 3 points de victoire";
                    l10 = "3 = 5 points de victoire";
                    break;

                case 103:
                    l1 = " MACHINES ANTIQUES";
                    l2 = "Une fois les deux camps déployés, en commençant par votre adversaire, les joueurs altérne pour choissir les pions objectif";
                    l3 = " qui ne sont dans aucune zone de dépoiement pour être des pions objectifs de Machine Antique, jusqu'a ce que 3 pions objectifs aient été choisis";
                    l4 = " (s'il n'y a qu'un pion répondant à ces critères, seul ce pion objectif est un pion objectif de machine antique)";
                    l5 = ".Les unités BASE Nécron ou CANOPTEKS peuvent tenter l'action suivante : Eveillez une machine antique (Action)";
                    l6 = "A la fin de votre phase de mouvement , une ou plusieurs unités BASE ou CANOPTECKS Nécrons de votre armée peuvent commencer";
                    l7 = "à accomplir cette action. Chaque unité de votre armée qui commence à accomplir cette action dois être à porté d'un pion objectif";
                    l8 = "Machine de guerre Antique distinct.Une unité ne peut pas commencer à accomplir cette action tant qu'il y a une unité ennemi à portée";
                    l9 = "du même pion objectif.L'action est achevé à la fin de votre prochaine phase de commandement,tant que l'unité est encore à porté du pion";
                    l10 = "de machine quantique en question.Marquez 3 points chaque fois qu'une unité achève l'action Eveiller une machine quantite.";
                    break;
                #endregion
                #region OBJC_SM
                case 110:
                    l1 = "GUERRE CODEX";
                    l2 = "";
                    l3 = "";
                    l4 = "Marquez 1 pts, par unité detruite pendant les doctrines suivante et en utilisant les armes selectionné";
                    l5 = "dans un maximun de 5 pts par doctrine (Utiliser les unités ADEPTUS ASTARTES uniquement)";
                    l6 = "";
                    l7 = "Doctrine Devastator ( armes Lourdes et Grenades)";
                    l8 = "Doctrine Tactique ( armes Assaut et Tir rapide)";
                    l9 = "Doctrine Assaut ( armes Mêlé et Pistolet)";
                    l10 = "";
                    break;

                case 111:
                    l1 = "TACTIQUES DE CHOC";
                    l2 = "";
                    l3 = "";
                    l4 = "Marquez 3 pts par round si vous contrôlez , a la fin du round ,";
                    l5 = " au moins un objectif que l adversaire possédait au début de ce même round.";
                    l6 = "Une unité ADEPTUS ASTARTES dois être presente sur cette objectif";
                    l7 = "";
                    l8 = "";
                    l9 = "";
                    l10 = "";
                    break;

                case 112:
                    l1 = "SERMENTS DE L'INSTANT";
                    l2 = "";
                    l3 = "";
                    l4 = "Marquez des points a chaque round , pour chaque serment respecté.";
                    l5 = "";
                    l6 = "serment de VALEUR ( 1 pts/round) pour avoir détruit au moins un personnage,véhicule ou montre a laide d'une unité ADEPTUS ASTARTES";
                    l7 = "serment d'HONNEUR ( 1 pts/round) pour n'avoir ni battu en retraite , ni avoir raté un test de morale";
                    l8 = "serment du DEVOIR ( 2 pts/round) pour avoir une unité ADEPTUS ASTARTES entierement dans les 6 pouces au centre du champs de bataille";
                    l9 = "";
                    l10 = "";
                    break;
                #endregion
                #region OBJC_BA
                case 113:
                    l1 = "LAME SANGUINIUS";
                    l2 = "";
                    l3 = "Au début de votre première phase de commandement, vous devez choisir une figurines PERSONNAGE Blood Angels de votre armée";
                    l4 = "pour lancer un défi et votre adversaire dois choisir une figurine PERSONNAGE de son armée pour le relever.";
                    l5 = "Si un joueur ou l'autre n'as pas de figurine personnage, il doit à la place choisir son seigneur de guerre.";
                    l6 = "";
                    l7 = "Marquez 5 points de victoire à la fin de la bataille pour chacune des conditions suivantes qui as été rempli:";
                    l8 = "La figurine qui as relevé le défi a été détruite.";
                    l9 = "La figurine qui as relevé le défi a été détruite par une attaque de mélée.";
                    l10 = "La figurine qui as relevé le défi a été détruite par une attaque de mélée de la figurine qui as lancé le défi.";
                    break;

                case 114:
                    l1 = "FUREUR DES EGARES";
                    l2 = "";
                    l3 = "";
                    l4 = "Marquez 3 points de victoire à la fin de votre tour si une ou plusieurs unités ennemies";
                    l5 = "ont été détruites par une unitée COMPAGNIE DE LA MORT de votre armée à ce tour .";
                    l6 = "";
                    l7 = "";
                    l8 = "";
                    l9 = "";
                    l10 = "";
                    break;

                case 115:
                    l1 = "LA MORT DESCEND DU CIEL";
                    l2 = "";
                    l3 = "";
                    l4 = "Marquez 2 points de victoire à la fin de votre tour si une ou plusieurs unités ennemie ont été détruites";
                    l5 = "par une unitée Blood Angels de votre armée qui as té placé sur le champs de bataille ";
                    l6 = "à l'étapes de renforts d'une de vos phase de mouvement.";
                    l7 = "";
                    l8 = "Si une de ces unités ennemies étaient une unité Personnage,";
                    l9 = "Marquez 3 points de victoire à la place.";
                    l10 = "";
                    break;

                case 116:
                    l1 = "ASSAUT IMPLACABLE";
                    l2 = "";
                    l3 = "";
                    l4 = "Marquez 2 points de victoire à la fin de votre tour s'il y a plus d'unités Bood Angels";
                    l5 = "de votre armée dans la zone de déploiement ennemie qu'il y as d'unités ennemies";
                    l6 = "dans votre zone de déploiement.";
                    l7 = "";
                    l8 = "";
                    l9 = "";
                    l10 = "";
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
        }
    }

