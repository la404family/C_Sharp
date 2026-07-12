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
                // Si aucune leçon n'est trouvée (le chiffre de l'étape dépasse 6), c'est que le cursus est terminé !
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
                    }
                    else
                    {
                        Console.WriteLine("Bravo, vous avez terminé la partie théorique du cursus sans faire de quiz !");
                    }
                    
                    Console.WriteLine("\nAppuyez sur n'importe quelle touche pour fermer l'application.");
                    Console.ReadKey();
                    return false;
            }

            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("[Entrée] Etape suivante | [R] Retour en arrière | [S] Sauvegarder");
            
            return true;
        }
    }
}
