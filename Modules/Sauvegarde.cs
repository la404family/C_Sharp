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
        /// <param name="monProfil">Le profil contenant toutes les données (étape, score) à sauvegarder.</param>
        /// <param name="silencieux">Paramètre optionnel. Si vrai, n'affiche pas de message de confirmation à l'écran.</param>
        // La méthode prend notre "boîte" entière (Profil) en paramètre.
        // On ajoute un paramètre optionnel "silencieux" qui vaut "false" par défaut si non précisé lors de l'appel.
        public static void SauvegarderProfil(Profil monProfil, bool silencieux = false)
        {
            // Nous créons un "Tableau" (Array) de 5 cases pour stocker nos 5 informations.
            string[] lignes = new string[5];
            
            // On remplit le tableau ligne par ligne.
            lignes[0] = monProfil.EtapeActuelle.ToString();
            lignes[1] = monProfil.ScoreTotal.ToString();
            lignes[2] = monProfil.NombreQuizTermines.ToString();
            lignes[3] = monProfil.NomUtilisateur;
            // "string.Join" permet de coller tous les éléments d'une liste ensemble, séparés par une virgule (ex: "16,20,12").
            lignes[4] = string.Join(",", monProfil.ScoresQuizz);

            // "WriteAllLines" écrit toutes les lignes de notre tableau dans le fichier.
            File.WriteAllLines(FichierSauvegarde, lignes);
            
            // Si le mode n'est PAS silencieux (le point d'exclamation "!" signifie "NON").
            if (!silencieux)
            {
                Console.WriteLine(">>> Profil sauvegardé avec succès ! Appuyez sur Entrée pour continuer.");
                Console.ReadLine(); 
            }
        }

        /// <summary>
        /// Charge le profil sauvegardé ou crée un nouveau profil vide si le fichier n'existe pas.
        /// </summary>
        public static Profil ChargerProfil()
        {
            // On crée un nouveau profil par défaut avec le mot-clé "new".
            Profil profilCharge = new Profil();

            // Si le fichier de sauvegarde existe sur le disque dur...
            if (File.Exists(FichierSauvegarde))
            {
                // "ReadAllLines" lit le fichier et range chaque ligne dans les cases d'un tableau de texte.
                string[] lignes = File.ReadAllLines(FichierSauvegarde);
                
                // On récupère les 3 premières valeurs.
                profilCharge.EtapeActuelle = int.Parse(lignes[0]);
                profilCharge.ScoreTotal = int.Parse(lignes[1]);
                profilCharge.NombreQuizTermines = int.Parse(lignes[2]);

                // On s'assure que le fichier sauvegardé contient bien le nom (rétrocompatibilité avec les vieilles sauvegardes).
                if (lignes.Length > 3)
                {
                    profilCharge.NomUtilisateur = lignes[3];
                }

                // On s'assure qu'il y a bien une ligne pour les scores et qu'elle n'est pas vide.
                if (lignes.Length > 4 && !string.IsNullOrEmpty(lignes[4]))
                {
                    // "Split" fait l'inverse de Join : il coupe le texte à chaque virgule pour recréer un tableau.
                    string[] scoresTexte = lignes[4].Split(',');
                    // Une boucle "foreach" (pour chaque) parcourt tous les éléments de notre tableau découpé.
                    foreach (string score in scoresTexte)
                    {
                        // On ajoute chaque score dans notre Liste.
                        profilCharge.ScoresQuizz.Add(int.Parse(score));
                    }
                }
            }
            
            // On renvoie la "boîte" Profil toute prête avec ses données !
            return profilCharge;
        }

        /// <summary>
        /// Supprime la sauvegarde existante pour repartir de zéro.
        /// </summary>
        public static void ReinitialiserProfil()
        {
            // On vérifie si le fichier existe avant d'essayer de le détruire
            if (File.Exists(FichierSauvegarde))
            {
                // "File.Delete" supprime physiquement le fichier du disque dur.
                File.Delete(FichierSauvegarde);
            }
        }
    }
}
