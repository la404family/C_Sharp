using System;
using System.IO;

namespace MonPremierProjet.Modules
{
    /// <summary>
    /// Ce module gère la sauvegarde et le chargement du profil complet de l'utilisateur.
    /// </summary>
    public class Sauvegarde
    {
        // Nom du fichier contenant notre sauvegarde.
        private const string FichierSauvegarde = "progression.txt";

        /// <summary>
        /// Sauvegarde le profil de l'utilisateur ligne par ligne.
        /// </summary>
        // La méthode prend maintenant notre "boîte" entière (Profil) en paramètre !
        public static void SauvegarderProfil(Profil monProfil)
        {
            // Nous créons un "Tableau" (Array) de chaînes de caractères (string[]).
            // Un tableau est une liste structurée. Ici, chaque élément de la liste représentera une ligne dans notre fichier.
            string[] lignes = new string[3];
            
            // On remplit la case numéro 0 du tableau (en informatique, on commence toujours à compter à 0 !).
            lignes[0] = monProfil.EtapeActuelle.ToString();
            // Case numéro 1 : le score total.
            lignes[1] = monProfil.ScoreTotal.ToString();
            // Case numéro 2 : le nombre de quiz.
            lignes[2] = monProfil.NombreQuizTermines.ToString();

            // "WriteAllLines" écrit toutes les lignes de notre tableau dans le fichier.
            File.WriteAllLines(FichierSauvegarde, lignes);
            
            Console.WriteLine(">>> Profil sauvegardé avec succès ! Appuyez sur Entrée pour continuer.");
            Console.ReadLine(); 
        }

        /// <summary>
        /// Charge le profil sauvegardé ou crée un nouveau profil vide si le fichier n'existe pas.
        /// </summary>
        public static Profil ChargerProfil()
        {
            // On crée un nouveau profil par défaut (étape 1, 0 point, 0 quiz) avec le mot-clé "new".
            Profil profilCharge = new Profil();

            // Si le fichier de sauvegarde existe sur le disque dur...
            if (File.Exists(FichierSauvegarde))
            {
                // "ReadAllLines" lit le fichier et range chaque ligne dans les cases d'un tableau de texte.
                string[] lignes = File.ReadAllLines(FichierSauvegarde);
                
                // On récupère les valeurs depuis les cases du tableau et on les traduit en nombres (Parse).
                profilCharge.EtapeActuelle = int.Parse(lignes[0]);
                profilCharge.ScoreTotal = int.Parse(lignes[1]);
                profilCharge.NombreQuizTermines = int.Parse(lignes[2]);
            }
            
            // On renvoie la "boîte" Profil toute prête avec ses données !
            return profilCharge;
        }
    }
}
