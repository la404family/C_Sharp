// Le mot-clé "using" permet d'intégrer des fonctionnalités de base fournies par l'ordinateur.
using System;

// "namespace" permet d'encapsuler notre code pour éviter qu'il ne se mélange avec d'autres fichiers.
namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Leçon 20 : L'interactivité fluide sans la touche Entrée.
    /// </summary>
    // Le mot-clé "class" déclare ce fichier comme une entité (un objet) à part entière.
    public class Lecon20
    {
        /// <summary>
        /// Exécute et affiche la leçon 20 à l'écran.
        /// </summary>
        // "public static void" signifie que la méthode est accessible de partout, sans instanciation, et qu'elle n'a pas de valeur de retour.
        public static void Afficher()
        {
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 20 : FLUIDIFIER LES MENUS ---\n");
            
            Console.WriteLine("Jusqu'à présent, nous avons utilisé 'Console.ReadLine()'.");
            Console.WriteLine("Le problème, c'est que l'utilisateur doit toujours valider en appuyant sur [Entrée].");
            Console.WriteLine("Dans un menu de jeu vidéo, appuyer sur 'A' fait agir le personnage instantanément !");
            
            Console.WriteLine("\n1. LA MÉTHODE Console.ReadKey()");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("La méthode 'Console.ReadKey()' met le programme en pause et capte LA MOINDRE touche frappée.");
            Console.WriteLine("Dès que la touche est enfoncée, le programme continue, sans attendre [Entrée].\n");
            
            Console.WriteLine("👉 Appuie sur n'importe quelle touche de ton clavier...");
            
            // "ConsoleKeyInfo" est un type spécial (un objet) qui contient toutes les informations 
            // sur la touche qui vient d'être pressée.
            ConsoleKeyInfo touche = Console.ReadKey();
            
            Console.WriteLine($"\n\nTu as appuyé sur la touche : {touche.Key} !");
            
            Console.WriteLine("\n2. LE MODE SILENCIEUX");
            Console.WriteLine("---------------------");
            Console.WriteLine("As-tu remarqué ? La touche que tu as tapée s'est affichée à l'écran juste avant ma réponse.");
            Console.WriteLine("Pour créer des menus propres, on ne veut pas que ces touches s'affichent.");
            Console.WriteLine("On peut ajouter le paramètre 'true' : Console.ReadKey(true).\n");
            
            Console.WriteLine("👉 Appuie à nouveau sur une touche (elle ne s'affichera pas) :");
            
            // Le paramètre "true" signifie "intercepte la touche sans l'afficher dans la console".
            ConsoleKeyInfo toucheSilencieuse = Console.ReadKey(true);
            
            Console.WriteLine($"\nTu as appuyé sur la touche {toucheSilencieuse.Key}, mais je l'ai cachée !");
            Console.WriteLine("\nC'est exactement cette technique que nous utilisons depuis le début");
            Console.WriteLine("pour te permettre de naviguer entre les leçons avec la touche [R] ou [Q] !");
        }
    }
}
