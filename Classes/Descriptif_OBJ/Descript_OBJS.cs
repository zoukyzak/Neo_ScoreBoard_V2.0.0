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
                    l1 = " ASSASSINAT (CA22)";
                    l2 = " Marquez 3 pts de victoire a la fin de la Bataille pour";
                    l3 = " chaque personnage ennemie qui a été detruite.";
                    l4 = "Marquez 1 pts de plus si vous tuer le seigneur de Guerre.";
                    l5 = "";
                    l6 = "";
                    l7 = "";
                    l8 = "";
                    l9 = "";
                    l10 = "";
                    break;
                default:
                    l1 = " NC";
                    l2 = " NC";
                    l3 = " NC";
                    l4 = " NC";
                    l5 = " NC";
                    l6 = " NC";
                    l7 = " NC";
                    l8 = " NC";
                    l9 = " NC";
                    l10 = "NC";
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

