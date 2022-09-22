using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPV9.Classes
{
    static class Classe_Sauvegarde_Options
    {
        static private string _dossier_Options = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CP_v9_Options\";

        static private string _fichier_Options_Fond = "Option_Fond.csv";
        static private string _fichier_Options_Opacity = "Option_Opacity.csv";
        static private string _fichier_Options_Resolution_Tv = "Option_Resolution_Tv.csv";

        static private string _chemin_Options_Fond = System.IO.Path.Combine(_dossier_Options, _fichier_Options_Fond);
        static private string _chemin_Options_Opacity = System.IO.Path.Combine(_dossier_Options, _fichier_Options_Opacity);
        static private string _chemin_Options_Resolution_Tv = System.IO.Path.Combine(_dossier_Options, _fichier_Options_Resolution_Tv);


        public static void Sauvegarder_Option_Fond_CSV(String Fond)
        {
            if (!Directory.Exists(_dossier_Options))
            {
                Directory.CreateDirectory(_dossier_Options);
            }

            StringBuilder ligne = new StringBuilder();
            using (StreamWriter fichier = new StreamWriter(_chemin_Options_Fond, false, Encoding.UTF8, 1024))
            {
                ligne.Append(Fond + ";");
                fichier.WriteLine(ligne.ToString());
                ligne.Clear();
            }
        }
        public static void Sauvegarder_Option_Opacity_CSV(int Opacit)
        {
            if (!Directory.Exists(_dossier_Options))
            {
                Directory.CreateDirectory(_dossier_Options);
            }

            StringBuilder ligne = new StringBuilder();
            using (StreamWriter fichier = new StreamWriter(_chemin_Options_Opacity, false, Encoding.UTF8, 1024))
            {
                ligne.Append(Opacit + ";");
                fichier.WriteLine(ligne.ToString());
                ligne.Clear();
            }
        }

        public static void Sauvegarder_Options_Resolution_Tv_CSV(double[] Resolution_Tv)
        {
            if (!Directory.Exists(_dossier_Options))
            {
                Directory.CreateDirectory(_dossier_Options);
            }

            StringBuilder ligne = new StringBuilder();
            using (StreamWriter fichier = new StreamWriter(_chemin_Options_Resolution_Tv, false, Encoding.UTF8, 1024))
            {
                for (int i = 0; i < 2; i++)
                {
                    ligne.Append(Resolution_Tv[i] + ";");
                    fichier.WriteLine(ligne.ToString());
                    ligne.Clear();
                }
            }
        }
    }
}
