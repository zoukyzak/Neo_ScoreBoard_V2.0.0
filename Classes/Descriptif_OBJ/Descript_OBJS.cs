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
                case 1:
                    l1 = " ASSASSINAT (ca22)";
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
                    l1 = " ABBATEZ-LE (ca22)";
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
                    l1 = " TUEUR DE TITANS (ca22)";
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
                    l1 = " BROYEZ-LES (ca22)";
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
                    l1 = " PAS DE PRISONNIER (ca22)";
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
                    l1 = " J'USQU'AU DERNIER (ca22)";
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
                    l1 = " SUR TOUS LES FRONT (ca22)";
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
                    l1 = " DERRIERE LES LIGNES ENNEMIES (ca22)";
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

                default:
                    l1 = "default";
                    l2 = "default";
                    l3 = "default";
                    l4 = "default";
                    l5 = "default";
                    l6 = "default";
                    l7 = "default";
                    l8 = "default";
                    l9 = "default";
                    l10 = "default";
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

