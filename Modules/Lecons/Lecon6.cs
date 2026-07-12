// "using System" donne accès aux outils de base de l'ordinateur, comme la console.
using System;

// "namespace" permet de ranger ce code dans le sous-dossier virtuel "MonPremierProjet.Modules.Lecons".
namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Contient le code de la leçon 6 expliquant la Common Language Infrastructure (CLI) et le fonctionnement interne de .NET.
    /// </summary>
    // "public" pour que cette classe soit accessible par notre GestionnaireLecons depuis n'importe où.
    // "class" définit un modèle qui contient nos méthodes (actions).
    public class Lecon6
    {
        /// <summary>
        /// Méthode principale qui affiche le contenu de la leçon 6.
        /// </summary>
        // "public" pour être appelée de l'extérieur, "static" pour l'appeler sans créer d'instance (objet), "void" car elle ne renvoie aucune valeur.
        public static void Afficher()
        {
            // Nettoyage de l'écran pour une lecture claire
            Afficheur.NettoyerEcran();
            
            // Utilisation de Console.WriteLine() pour afficher du texte et passer à la ligne.
            Console.WriteLine("--- ETAPE 6 : LA FONDATION TECHNIQUE DE .NET (LA CLI) ---\n");
            
            // Le '@' (Verbatim string) avant les guillemets permet de créer une chaîne multi-lignes très facilement.
            // Cela nous évite d'utiliser le caractère "\n" à chaque retour à la ligne.
            Console.WriteLine(@"Jusqu'à présent, vous avez écrit du code C# et l'ordinateur 
l'a compris ""comme par magie"". Mais que se passe-t-il vraiment en coulisses ? 
Comment un texte écrit par un humain se transforme-t-il en un programme exécutable ?

C'est ici qu'intervient la fondation de .NET !

--- Qu'est-ce que la CLI ? (La Théorie) ---

La CLI (Common Language Infrastructure) est le point de départ. 
Imaginez-la comme un grand livre de règles (une norme technique internationale).
Ce n'est pas un logiciel que l'on installe, mais une spécification stricte créée par Microsoft.
Elle dicte très précisément comment tous les langages de l'univers .NET (C#, VB.NET, F#) doivent se comporter.

À quoi ça sert concrètement ?
C'est le secret de la compatibilité ! Grâce à ce règlement commun, différents langages 
peuvent fonctionner ensemble main dans la main. Vous pouvez ainsi écrire un outil en C# 
et un autre développeur pourra l'utiliser sans problème dans son projet en F# !");

            Console.WriteLine("\nAppuyez sur une touche pour découvrir ce que la CLI définit...");
            
            // Console.ReadKey() met le programme en pause jusqu'à ce que l'utilisateur appuie sur une touche de son clavier.
            Console.ReadKey();
            
            // Un petit retour à la ligne pour aérer l'affichage ("\n")
            Console.WriteLine("\n--- Ce que la CLI définit concrètement : ---\n");

            // On utilise à nouveau le @ pour un gros bloc de texte avec des emojis !
            Console.WriteLine(@"🔢 Le CTS (Common Type System) : 
Il garantit que tous les langages s'entendent sur les types de données (ex: ce qu'est un 'int' ou une 'string', leur taille et leur comportement).

⚙️ Le CIL (Common Intermediate Language) : 
Quand vous compilez votre code C#, il ne devient pas tout de suite du code ""machine"" (0 et 1 pour le processeur). 
Il devient d'abord un code ""intermédiaire"" universel (IL). La CLI définit à quoi ressemble ce code.

📋 Les Metadata : 
Ce sont les informations qui décrivent la structure de votre code compilé, un peu comme les coulisses de votre application.

🖥️ Le VES (Virtual Execution System) : 
C'est le système qui charge et exécute votre code compilé. Chez Microsoft, cette machine s'appelle le CLR (Common Language Runtime).");

            Console.WriteLine("\nBravo ! Vous savez maintenant ce qui se cache sous le capot de .NET.");
        }
    }
}
