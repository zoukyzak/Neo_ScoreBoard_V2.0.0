using System;
using System.IO;
using System.Text;

namespace CPV9.Classes
{
    static class Classe_Resolution
    {
        static private string _dossier_Resolution = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CP_v9_Resolution\";
        static private string _fichier_Resolution = "Resolution.csv";

        static private string _chemin_Resolution = Path.Combine(_dossier_Resolution, _fichier_Resolution);

        public static void Sauvegarder_Resolution_CSV(int[] Resolution)
        {
            if (!Directory.Exists(_dossier_Resolution))
            {
                Directory.CreateDirectory(_dossier_Resolution);
            }

            StringBuilder ligne = new StringBuilder();
            using (StreamWriter fichier = new StreamWriter(_chemin_Resolution, false, Encoding.UTF8, 1024))
            {
                for (int i = 0; i < 2; i++)
                {
                    ligne.Append(Resolution[i] + ";");
                    fichier.WriteLine(ligne.ToString());
                    ligne.Clear();
                }
            }
        }

    }

}
