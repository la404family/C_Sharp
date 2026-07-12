// "using System" donne accès aux outils de base de l'ordinateur, comme la console.
using System;

// "namespace" permet de ranger ce code dans le sous-dossier virtuel "MonPremierProjet.Modules.Lecons".
namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Contient le code de la leçon 7 expliquant le Common Language Runtime (CLR) et le flux d'exécution.
    /// </summary>
    // "public" pour que cette classe soit accessible par notre GestionnaireLecons depuis n'importe où.
    // "class" définit un modèle qui contient nos méthodes (actions).
    public class Lecon7
    {
        /// <summary>
        /// Méthode principale qui affiche le contenu de la leçon 7.
        /// </summary>
        // "public" pour être appelée de l'extérieur, "static" pour l'appeler sans créer d'instance (objet), "void" car elle ne renvoie aucune valeur.
        public static void Afficher()
        {
            // Nettoyage de l'écran pour une lecture claire
            Afficheur.NettoyerEcran();
            
            // Utilisation de Console.WriteLine() pour afficher du texte et passer à la ligne.
            Console.WriteLine("--- ETAPE 7 : LE CLR ET LE FLUX D'EXECUTION ---\n");
            
            // On utilise une chaîne verbatim (@) pour afficher un bloc de texte multi-lignes sans utiliser \n.
            // On double les guillemets ("") à l'intérieur d'une chaîne verbatim pour échapper les guillemets.
            Console.WriteLine(@"Dans la leçon précédente, nous avons vu que la CLI est un grand livre de règles. 
Mais un règlement ne sert à rien s'il n'y a personne pour l'appliquer !

C'est là qu'entre en scène le CLR.

--- Qu'est-ce que le CLR ? (La Pratique) ---

CLR signifie Common Language Runtime.
Si la CLI est le plan de construction, le CLR est l'ouvrier sur le chantier ! 
C'est le moteur bien réel (une ""machine virtuelle"") installé sur votre ordinateur. 
Son rôle ? Prendre votre code, le comprendre, et le faire tourner pour de vrai.

Les responsabilités du CLR (Le travail du Chef) :
Le CLR prend votre code intermédiaire (celui défini par la CLI) et le fait tourner. 
Il gère des tâches très lourdes pour vous :

⚡ Compilation JIT (Just-In-Time) : Le CLR traduit le code intermédiaire en code machine natif 
(celui que votre processeur comprend : 010110) au dernier moment, juste avant l'exécution.

🧹 Gestion de la mémoire (Garbage Collector) : C'est le rôle le plus connu du CLR. 
Il nettoie automatiquement la mémoire de votre ordinateur en supprimant les objets que votre programme n'utilise plus, pour éviter les fuites de mémoire.

🛡️ Gestion des exceptions : Il gère les erreurs (les ""plantages"") de manière structurée.

🔒 Sécurité : Il vérifie que le code a le droit de s'exécuter.");

            Console.WriteLine("\nAppuyez sur une touche pour découvrir comment tout cela travaille ensemble...");
            
            // On met en pause pour que l'utilisateur prenne le temps de lire
            Console.ReadKey();
            
            // Petit espace visuel
            Console.WriteLine("\n--- Comment ils travaillent ensemble (Le Flux) ---\n");
            
            Console.WriteLine(@"Voici ce qui se passe quand vous appuyez sur ""Play"" dans Visual Studio :

1. ✍️ Écriture : Vous écrivez du code C#.
2. ⚙️ Compilation (Roslyn) : Le compilateur C# (Roslyn) vérifie votre code. S'il est bon, il le transforme 
   non pas en code machine, mais en fichier .dll ou .exe contenant du Code IL (le code standardisé par la CLI).
3. 🚀 Exécution (CLR) :
   - Vous lancez le programme.
   - Le CLR démarre.
   - Il lit le Code IL.
   - Son compilateur JIT traduit ce Code IL en instructions machines spécifiques à votre ordinateur (Windows, Mac, Linux).
   - Le processeur exécute les instructions !");

            Console.WriteLine("\nFélicitations, vous maîtrisez maintenant le cycle de vie complet d'un programme .NET !");
        }
    }
}
