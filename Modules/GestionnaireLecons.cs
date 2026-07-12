using System;
using MonPremierProjet.Modules.Lecons;
// On a besoin d'accéder aux quiz aussi !
using MonPremierProjet.Modules.Quizz;

namespace MonPremierProjet.Modules
{
    /// <summary>
    /// Ce module sert d'aiguillage (Routeur). 
    /// </summary>
    public class GestionnaireLecons
    {
        // La méthode reçoit maintenant l'objet "Profil" complet contenant les scores.
        public static bool AfficherEtape(Profil profilActuel)
        {
            // On regarde uniquement le numéro de l'étape pour notre aiguillage.
            switch (profilActuel.EtapeActuelle)
            {
                case 1:
                    Lecon1.Afficher();
                    break;
                case 2:
                    Lecon2.Afficher();
                    break;
                case 3:
                    Lecon3.Afficher();
                    break;
                case 4:
                    Lecon4.Afficher();
                    break;
                case 5:
                    Lecon5.Afficher();
                    break;
                case 6:
                    Quizz1.Executer(profilActuel);
                    break;
                case 7:
                    Lecon6.Afficher();
                    break;
                case 8:
                    Lecon7.Afficher();
                    break;
                case 9:
                    Lecon8.Afficher();
                    break;
                case 10:
                    Quizz2.Executer(profilActuel);
                    break;
                case 11:
                    Lecon9.Afficher();
                    break;
                case 12:
                    Lecon10.Afficher();
                    break;
                case 13:
                    Lecon11.Afficher();
                    break;
                case 14:
                    Quizz3.Executer(profilActuel);
                    break;
                case 15:
                    Lecon12.Afficher();
                    break;
                case 16:
                    Lecon13.Afficher();
                    break;
                case 17:
                    Lecon14.Afficher();
                    break;
                case 18:
                    Lecon15.Afficher();
                    break;
                case 19:
                    Lecon16.Afficher();
                    break;
                case 20:
                    Lecon17.Afficher();
                    break;
                case 21:
                    Quizz4.Executer(profilActuel);
                    break;
                case 22:
                    Lecon18.Afficher();
                    break;
                case 23:
                    Lecon19.Afficher();
                    break;
                case 24:
                    Lecon20.Afficher();
                    break;
                case 25:
                    Lecon21.Afficher();
                    break;
                case 26:
                    Quizz5.Executer(profilActuel);
                    break;
                case 27:
                    Lecon22.Afficher();
                    break;
                case 28:
                    Lecon23.Afficher();
                    break;
                case 29:
                    Lecon24.Afficher();
                    break;
                case 30:
                    Lecon25.Afficher();
                    break;
                case 31:
                    Quizz6.Executer(profilActuel);
                    break;
                // Si aucune leçon n'est trouvée (le chiffre de l'étape dépasse 31), c'est que le cursus est terminé !
                // Grâce à ce fonctionnement dynamique, cette boucle s'adapte automatiquement à l'ajout de futures étapes.
                default:
                    Afficheur.NettoyerEcran();
                    Console.WriteLine("================ FIN DU CURSUS ================\n");
                    
                    // On vérifie qu'il a bien fait au moins un quiz pour éviter de diviser par zéro (ce qui provoque un crash mathématique).
                    if (profilActuel.NombreQuizTermines > 0)
                    {
                        // On calcule la moyenne. 
                        // Le "(double)" est une ruse pour forcer l'ordinateur à faire une division à virgule et non une division entière (arrondie).
                        double moyenne = (double)profilActuel.ScoreTotal / profilActuel.NombreQuizTermines;
                        
                        // "Math.Round" permet d'arrondir le résultat à 2 chiffres après la virgule (ex: 15.66).
                        moyenne = Math.Round(moyenne, 2);
                        
                        Console.WriteLine($"Vous avez terminé votre cursus avec un résultat moyen de {moyenne} / 20 !");
                        Console.WriteLine($"Total des points cumulés : {profilActuel.ScoreTotal}");
                        Console.WriteLine($"Nombre de quiz effectués : {profilActuel.NombreQuizTermines}");

                        // -- Génération du fichier texte de résultats --
                        
                        // On crée un tableau pour stocker les lignes du fichier.
                        // La taille est dynamique : nombre de quiz + 4 lignes (titre, sauts de ligne, moyenne).
                        string[] lignesResultat = new string[profilActuel.ScoresQuizz.Count + 4];
                        
                        // "ToUpper()" met le nom tout en majuscules.
                        lignesResultat[0] = $"--- RESULTATS DU CURSUS DE {profilActuel.NomUtilisateur.ToUpper()} ---";
                        lignesResultat[1] = ""; // Ligne vide
                        
                        // Une boucle pour lister les notes individuelles.
                        for (int i = 0; i < profilActuel.ScoresQuizz.Count; i++)
                        {
                            // "i + 2" car les lignes 0 et 1 sont déjà occupées.
                            lignesResultat[i + 2] = $"Quizz {i + 1} : {profilActuel.ScoresQuizz[i]} / 20";
                        }
                        
                        lignesResultat[lignesResultat.Length - 2] = ""; // Ligne vide
                        lignesResultat[lignesResultat.Length - 1] = $"Moyenne Globale : {moyenne} / 20";

                        // On choisit un nom de fichier personnalisé.
                        string nomFichier = $"Resultats_{profilActuel.NomUtilisateur}.txt";
                        
                        // On écrit le fichier sur le disque dur.
                        System.IO.File.WriteAllLines(nomFichier, lignesResultat);
                        
                        Console.WriteLine($"\n✅ Un fichier récapitulatif '{nomFichier}' a été généré dans le dossier de l'application !");
                    }
                    else
                    {
                        Console.WriteLine("Bravo, vous avez terminé la partie théorique du cursus sans faire de quiz !");
                    }
                    
                    Console.WriteLine("\n------------------------------------------------");
                    Console.WriteLine("[R] Retour à la dernière leçon | [Q] Quitter");
                    Console.WriteLine("Astuce: [Ctrl + R] Réinitialiser la progression et repartir de zéro.");
                    
                    // On retourne "true" pour laisser Program.cs gérer les touches au lieu de forcer la fermeture.
                    return true;
            }

            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("[Entrée] Etape suivante | [R] Retour en arrière | [Q] Quitter");
            Console.WriteLine("Astuce: [Ctrl + R] Réinitialiser la progression et repartir de zéro.");
            
            return true;
        }
    }
}
