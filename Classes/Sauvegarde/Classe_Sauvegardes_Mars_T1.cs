using System;
using System.IO;
using System.Text;

namespace CPV9.Classes
{
    static class Classe_Sauvegardes_Mars_T1
    {

        static private string _dossier_Mars = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CP_v9_Mars\";
        static private string _fichier_Pages_Mars = "Pages.csv";
        static private string _fichier_Format_Mars = "Format.csv";
        static private string _fichier_FormatBis_Mars = "FormatBis.csv";
        static private string _fichier_Map_Mars = "Map.csv";
        static private string _fichier_Codex_Mars = "Codex.csv";
        static private string _fichier_Players_Attaquant_Mars = "Players_Attaquant.csv";
        static private string _fichier_Players_Defenseur_Mars = "Players_Defenseur.csv";
        static private string _fichier_Scores_Attaquant_Mars = "Scores_Attaquant.csv";
        static private string _fichier_Scores_Defenseur_Mars = "Scores_Defenseur.csv";
        static private string _fichier_Choix_ObjS_Attaquant_Mars = "Choix_ObjS_Attaquant.csv";
        static private string _fichier_Choix_ObjS_Defenseur_Mars = "Choix_ObjS_Defenseur.csv";
        static private string _fichier_Mem_Saisie_Attaquant_Mars = "Mem_Saisie_Attaquant.csv";
        static private string _fichier_Mem_Saisie_Defenseur_Mars = "Mem_Saisie_Defenseur.csv";


        static private string _chemin_Pages_Mars = Path.Combine(_dossier_Mars, _fichier_Pages_Mars);
        static private string _chemin_Format_Mars = Path.Combine(_dossier_Mars, _fichier_Format_Mars);
        static private string _chemin_FormatBis_Mars = Path.Combine(_dossier_Mars, _fichier_FormatBis_Mars);
        static private string _chemin_Map_Mars = Path.Combine(_dossier_Mars, _fichier_Map_Mars);
        static private string _chemin_Codex_Mars = Path.Combine(_dossier_Mars, _fichier_Codex_Mars);
        static private string _chemin_Players_Attaquant_Mars = Path.Combine(_dossier_Mars, _fichier_Players_Attaquant_Mars);
        static private string _chemin_Players_Defenseur_Mars = Path.Combine(_dossier_Mars, _fichier_Players_Defenseur_Mars);
        static private string _chemin_Scores_Attaquant_Mars = Path.Combine(_dossier_Mars, _fichier_Scores_Attaquant_Mars);
        static private string _chemin_Scores_Defenseur_Mars = Path.Combine(_dossier_Mars, _fichier_Scores_Defenseur_Mars);
        static private string _chemin_Choix_ObjS_Attaquant_Mars = Path.Combine(_dossier_Mars, _fichier_Choix_ObjS_Attaquant_Mars);
        static private string _chemin_Choix_ObjS_Defenseur_Mars = Path.Combine(_dossier_Mars, _fichier_Choix_ObjS_Defenseur_Mars);
        static private string _chemin_Mem_Saisie_Attaquant_Mars = Path.Combine(_dossier_Mars, _fichier_Mem_Saisie_Attaquant_Mars);
        static private string _chemin_Mem_Saisie_Defenseur_Mars = Path.Combine(_dossier_Mars, _fichier_Mem_Saisie_Defenseur_Mars);

        public static void Sauvegarder_Pages_CSV(int Pages)
        {
            if (!Directory.Exists(_dossier_Mars))
            {
                Directory.CreateDirectory(_dossier_Mars);
            }

            StringBuilder ligne = new StringBuilder();
            using (StreamWriter fichier = new StreamWriter(_chemin_Pages_Mars, false, Encoding.UTF8, 1024))
            {
                ligne.Append(Pages + ";");
                fichier.WriteLine(ligne.ToString());
                ligne.Clear();
            }
        }
        public static void Sauvegarder_Format_CSV(int format)
        {
            if (!Directory.Exists(_dossier_Mars))
            {
                Directory.CreateDirectory(_dossier_Mars);
            }

            StringBuilder ligne = new StringBuilder();
            using (StreamWriter fichier = new StreamWriter(_chemin_Format_Mars, false, Encoding.UTF8, 1024))
            {
                ligne.Append(format + ";");
                fichier.WriteLine(ligne.ToString());
                ligne.Clear();
            }
        }
        public static void Sauvegarder_FormatBis_CSV(int formatBis)
        {
            if (!Directory.Exists(_dossier_Mars))
            {
                Directory.CreateDirectory(_dossier_Mars);
            }

            StringBuilder ligne = new StringBuilder();
            using (StreamWriter fichier = new StreamWriter(_chemin_FormatBis_Mars, false, Encoding.UTF8, 1024))
            {
                ligne.Append(formatBis + ";");
                fichier.WriteLine(ligne.ToString());
                ligne.Clear();
            }
        }
        public static void Sauvegarder_Map_CSV(int map)
        {
            if (!Directory.Exists(_dossier_Mars))
            {
                Directory.CreateDirectory(_dossier_Mars);
            }

            StringBuilder ligne = new StringBuilder();
            using (StreamWriter fichier = new StreamWriter(_chemin_Map_Mars, false, Encoding.UTF8, 1024))
            {
                ligne.Append(map + ";");
                fichier.WriteLine(ligne.ToString());
                ligne.Clear();
            }
        }
        public static void Sauvegarder_Codex_CSV(bool codex)
        {
            if (!Directory.Exists(_dossier_Mars))
            {
                Directory.CreateDirectory(_dossier_Mars);
            }

            StringBuilder ligne = new StringBuilder();
            using (StreamWriter fichier = new StreamWriter(_chemin_Codex_Mars, false, Encoding.UTF8, 1024))
            {
                ligne.Append(codex + ";");
                fichier.WriteLine(ligne.ToString());
                ligne.Clear();
            }
        }
        public static void Sauvegarder_Players_Attaquant_CSV(String[] Players_Attaquant)
        {
            if (!Directory.Exists(_dossier_Mars))
            {
                Directory.CreateDirectory(_dossier_Mars);
            }

            StringBuilder ligne = new StringBuilder();
            using (StreamWriter fichier = new StreamWriter(_chemin_Players_Attaquant_Mars, false, Encoding.UTF8, 1024))
            {
                for (int i = 0; i < 3; i++)
                {
                    ligne.Append(Players_Attaquant[i] + ";");
                    fichier.WriteLine(ligne.ToString());
                    ligne.Clear();
                }
            }
        }
        public static void Sauvegarder_Players_Defenseur_CSV(String[] Players_Defenseur)
        {
            if (!Directory.Exists(_dossier_Mars))
            {
                Directory.CreateDirectory(_dossier_Mars);
            }

            StringBuilder ligne = new StringBuilder();
            using (StreamWriter fichier = new StreamWriter(_chemin_Players_Defenseur_Mars, false, Encoding.UTF8, 1024))
            {
                for (int i = 0; i < 3; i++)
                {
                    ligne.Append(Players_Defenseur[i] + ";");
                    fichier.WriteLine(ligne.ToString());
                    ligne.Clear();
                }
            }
        }
        public static void Sauvegarder_Scores_Attaquant_CSV(int[] Scores_Attaquant)
        {
            if (!Directory.Exists(_dossier_Mars))
            {
                Directory.CreateDirectory(_dossier_Mars);
            }

            StringBuilder ligne = new StringBuilder();
            using (StreamWriter fichier = new StreamWriter(_chemin_Scores_Attaquant_Mars, false, Encoding.UTF8, 1024))
            {
                for (int i = 0; i < 3; i++)
                {
                    ligne.Append(Scores_Attaquant[i] + ";");
                    fichier.WriteLine(ligne.ToString());
                    ligne.Clear();
                }
            }
        }
        public static void Sauvegarder_Scores_Defenseur_CSV(int[] Scores_Defenseur)
        {
            if (!Directory.Exists(_dossier_Mars))
            {
                Directory.CreateDirectory(_dossier_Mars);
            }

            StringBuilder ligne = new StringBuilder();
            using (StreamWriter fichier = new StreamWriter(_chemin_Scores_Defenseur_Mars, false, Encoding.UTF8, 1024))
            {
                for (int i = 0; i < 3; i++)
                {
                    ligne.Append(Scores_Defenseur[i] + ";");
                    fichier.WriteLine(ligne.ToString());
                    ligne.Clear();
                }
            }
        }
        public static void Sauvegarder_Choix_ObjS_Attaquant_CSV(int[] Choix_ObjS_Attaquant)
        {
            if (!Directory.Exists(_dossier_Mars))
            {
                Directory.CreateDirectory(_dossier_Mars);
            }

            StringBuilder ligne = new StringBuilder();
            using (StreamWriter fichier = new StreamWriter(_chemin_Choix_ObjS_Attaquant_Mars, false, Encoding.UTF8, 1024))
            {
                for (int i = 0; i < 3; i++)
                {
                    ligne.Append(Choix_ObjS_Attaquant[i] + ";");
                    fichier.WriteLine(ligne.ToString());
                    ligne.Clear();
                }
            }
        }
        public static void Sauvegarder_Choix_ObjS_Defenseur_CSV(int[] Choix_ObjS_Defenseur)
        {
            if (!Directory.Exists(_dossier_Mars))
            {
                Directory.CreateDirectory(_dossier_Mars);
            }

            StringBuilder ligne = new StringBuilder();
            using (StreamWriter fichier = new StreamWriter(_chemin_Choix_ObjS_Defenseur_Mars, false, Encoding.UTF8, 1024))
            {
                for (int i = 0; i < 3; i++)
                {
                    ligne.Append(Choix_ObjS_Defenseur[i] + ";");
                    fichier.WriteLine(ligne.ToString());
                    ligne.Clear();
                }
            }
        }
        public static void Sauvegarder_Mem_Saisie_Attaquant_CSV(string[,] Mem_Saisie_Attaquant)
        {
            if (!Directory.Exists(_dossier_Mars))
            {
                Directory.CreateDirectory(_dossier_Mars);
            }

            StringBuilder ligne = new StringBuilder();
            using (StreamWriter fichier = new StreamWriter(_chemin_Mem_Saisie_Attaquant_Mars, false, Encoding.UTF8, 1024))
            {
                for (int t = 0; t < 20; t++)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        ligne.Append(Mem_Saisie_Attaquant[t, i] + ";");
                        fichier.WriteLine(ligne.ToString());
                        ligne.Clear();
                    }
                }
            }
        }
        public static void Sauvegarder_Mem_Saisie_Defenseur_CSV(string[,] Mem_Saisie_Defenseur)
        {
            if (!Directory.Exists(_dossier_Mars))
            {
                Directory.CreateDirectory(_dossier_Mars);
            }

            StringBuilder ligne = new StringBuilder();
            using (StreamWriter fichier = new StreamWriter(_chemin_Mem_Saisie_Defenseur_Mars, false, Encoding.UTF8, 1024))
            {
                for (int t = 0; t < 20; t++)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        ligne.Append(Mem_Saisie_Defenseur[t, i] + ";");
                        fichier.WriteLine(ligne.ToString());
                        ligne.Clear();
                    }
                }
            }
        }

    }
}
