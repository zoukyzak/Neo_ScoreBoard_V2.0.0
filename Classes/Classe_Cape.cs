using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPV9.Classes
{
    class Classe_Cape
    {
        public string Cape_Selected { get; set; }
        public Classe_Cape(int ID_cape , String Text_Cape)
        {
            /**  OBJECTIF PRINCIPAL  **/
            if (ID_cape == 1000) { Cape_Selected = "Objectif Principal capé"; };

            /**  ELIMINEZ L ENNEMI  **/
            if (ID_cape == 1) { Cape_Selected = "1-Assasinat capé"; };
            if (ID_cape == 2) { Cape_Selected = "2-Abbatez-le capé "; };
            if (ID_cape == 3) { Cape_Selected = "3-chasseur de Titans capé"; };

            /**  Codex Ork  **/
            if (ID_cape == 136) { Cape_Selected = "136-Krazez-les capé"; };
        }

    }
}
