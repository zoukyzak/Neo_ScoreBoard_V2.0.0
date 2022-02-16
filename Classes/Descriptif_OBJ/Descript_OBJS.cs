﻿using System;
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
                    l1 = " PAS DE PRISONNIER (ca22)";
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

