// "using" importe les outils fondamentaux de l'environnement .NET.
using System;
// On importe l'espace "System.Threading" pour manipuler le thread d'exécution actuel (le mettre en pause avec Thread.Sleep).
using System.Threading;

// Le "namespace" déclare l'adresse virtuelle de ce fichier.
namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Leçon 19 : Personnaliser l'apparence de la Console (Couleurs et Nettoyage).
    /// </summary>
    // La classe est publique pour être visible par tout le programme.
    public class Lecon19
    {
        /// <summary>
        /// Affiche le contenu et les tests visuels de la leçon 19.
        /// </summary>
        // Déclaration de la méthode de classe (static) qui ne renvoie rien (void).
        public static void Afficher()
        {
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 19 : METTRE DE LA COULEUR ---\n");
            
            Console.WriteLine("Une console n'est pas obligée de rester triste avec son texte gris sur fond noir.");
            Console.WriteLine("C# te permet de changer les couleurs grâce à des 'Propriétés' de la classe Console.\n");
            
            Console.WriteLine("1. CHANGER LA COULEUR DU TEXTE");
            Console.WriteLine("------------------------------");
            
            // "Console.ForegroundColor" est une propriété qui gère la couleur du texte.
            // "ConsoleColor" est une énumération (une liste de choix prédéfinis de couleurs).
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Voici du texte en vert ! Parfait pour annoncer un succès.");
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Et voici du texte en rouge ! Idéal pour signaler une erreur.");
            
            Console.WriteLine("\n2. CHANGER LA COULEUR DE FOND");
            Console.WriteLine("-----------------------------");
            
            // "Console.BackgroundColor" change la couleur derrière le texte.
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Texte jaune sur fond bleu ! Ça attire l'œil !");
            
            // "Console.ResetColor()" est indispensable pour remettre les couleurs par défaut, 
            // sinon tout le reste de notre programme resterait jaune sur fond bleu !
            Console.ResetColor();
            Console.WriteLine("\n⚠️ Ouf, on a utilisé 'Console.ResetColor()' pour revenir à la normale.");
            
            Console.WriteLine("\n3. EFFACER L'ÉCRAN");
            Console.WriteLine("------------------");
            Console.WriteLine("Tu as remarqué que notre écran se nettoie à chaque nouvelle leçon ?");
            Console.WriteLine("C'est grâce à la méthode 'Console.Clear()'.");
            Console.WriteLine("Attention, l'écran va s'effacer dans 20 secondes... Observe bien !");
            
            // "Thread.Sleep(20000)" met le programme en pause pendant 20000 millisecondes (20 secondes).
            Thread.Sleep(20000);
            
            // On efface tout !
            Console.Clear();
            
            Console.WriteLine("--- ETAPE 19 : SUITE ---\n");
            Console.WriteLine("Tada ! L'écran est tout propre.");
            Console.WriteLine("Tu sais maintenant comment rendre tes applications beaucoup plus esthétiques.");
        }
    }
}
