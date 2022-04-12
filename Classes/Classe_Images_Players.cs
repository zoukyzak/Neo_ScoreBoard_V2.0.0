using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPV9.Classes
{
    class Classe_Images_Players
    {
        public string Chemin_Image_Player { get; set; }
        public Classe_Images_Players(string Select_Image_Player)
        {            
            switch (Select_Image_Player)
            {                
                case "  Adepta Sororitas":
                    Chemin_Image_Player = "/Images/ADEPTA SORORITAS.png " ;
                break;

                case "  Adeptus Custodes":
                    Chemin_Image_Player = "/Images/ADEPTUS CUSTODES.png ";                    
                break;

                case "  Adeptus Mechanicus":
                    Chemin_Image_Player = "/Images/ADEPTUS MECHANICUS.png ";
                    break;

                case "  Astra Militarum":
                    Chemin_Image_Player = "/Images/ASTRA MILITARUM.png ";
                    break;

                case "  Chaos Daemons":
                    Chemin_Image_Player = "/Images/CHAOS DAEMONS.png ";
                    break;

                case "  Chaos Knights":
                    Chemin_Image_Player = "/Images/CHAOS KNIGHTS.png ";
                    break;

                case "  Chaos Space Marines":
                    Chemin_Image_Player = "/Images/CHAOS SPACE MARINES.png ";
                    break;

                case "  Craftworlds":
                    Chemin_Image_Player = "/Images/CRAFTWORLDS.png ";
                    break;

                case "  Death Guard":
                    Chemin_Image_Player = "/Images/DEATH GUARD.png ";
                    break;

                case "  Drukhari":
                    Chemin_Image_Player = "/Images/DRUKHARI.png ";
                    break;

                case "  Genestealer Cults":
                    Chemin_Image_Player = "/Images/GENESTEALERCULTS.png ";
                    break;

                case "  Grey Knights":
                    Chemin_Image_Player = "/Images/GREY KNIGHTS.png ";
                    break;

                case "  Harlequins":
                    Chemin_Image_Player = "/Images/HARLEQUINS.png ";
                    break;

                case "  Imperial Knights":
                    Chemin_Image_Player = "/Images/IMPERIAL KNIGHTS.png ";
                    break;

                case "  Necrons":
                    Chemin_Image_Player = "/Images/NECRONS.png ";
                    break;

                case "  Officio Assassinorum":
                    Chemin_Image_Player = "/Images/OFFICIO ASSASSINORUM.png ";
                    break;

                case "  Orks":
                    Chemin_Image_Player = "/Images/ORKS.png ";
                    break;

                case "  SM_Space Marines":
                    Chemin_Image_Player = "/Images/SPACE MARINES.png ";
                    break;

                case "  SM_Dark Angels":
                    Chemin_Image_Player = "/Images/DARK ANGELS.png ";
                    break;

                case "  SM_White Scares":
                    Chemin_Image_Player = "/Images/SM_WHITE SCARES.png ";
                    break;

                case "  SM_Space Wolves":
                    Chemin_Image_Player = "/Images/SPACE WOLVES.png ";
                    break;

                case "  SM_Imperial Fists":
                    Chemin_Image_Player = "/Images/SM_IMPERIAL FISTS.png ";
                    break;

                case "  SM_Crimson Fists":
                    Chemin_Image_Player = "/Images/SM_IMPERIAL FISTS.png ";
                    break;

                case "  SM_Black Templars":
                    Chemin_Image_Player = "/Images/SPACE MARINES.png ";
                    break;

                case "  SM_Blood Angels":
                    Chemin_Image_Player = "/Images/BLOOD ANGELS.png ";
                    break;

                case "  SM_Flesh Tearers":
                    Chemin_Image_Player = "/Images/SPACE MARINES.png ";
                    break;

                case "  SM_Iron Hands":
                    Chemin_Image_Player = "/Images/SM_IRON HANDS.png ";
                    break;

                case "  SM_Ultramarines":
                    Chemin_Image_Player = "/Images/SM_ULTRAMARINES.png ";
                    break;

                case "  SM_Salamandres":
                    Chemin_Image_Player = "/Images/SM_SALAMANDRES.png ";
                    break;

                case "  SM_Raven Guard":
                    Chemin_Image_Player = "/Images/SM_RAVEN GUARD.png ";
                    break;

                case "  SM_Deathwatch":
                    Chemin_Image_Player = "/Images/DEATHWATCH.png ";
                    break;

                case "  T AU Empire":
                    Chemin_Image_Player = "/Images/T AU EMPIRE.png ";
                    break;

                case "  Thousand Sons":
                    Chemin_Image_Player = "/Images/THOUSAND SONS.png ";
                    break;

                case "  Tyranid":
                    Chemin_Image_Player = "/Images/TYRANID.png ";
                    break;

                case "  Ynarri":
                    Chemin_Image_Player = "/Images/YNARRI.png ";
                    break;

                default:
                    Chemin_Image_Player = "/Images/DEATH GUARD.png ";
                    break;
            }            
        }         
    }
}



