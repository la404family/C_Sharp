// "using" permet d'importer des outils externes. Ici, on importe l'espace de noms "System" qui contient la classe Console.
using System;

// "namespace" organise notre code dans un espace de travail virtuel.
namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Leçon 18 : Dialoguer avec l'utilisateur via la Console (Entrées et Sorties).
    /// </summary>
    // "public" permet à cette classe d'être utilisée par le GestionnaireLecons.
    // "class" déclare notre fichier comme un conteneur de code structuré.
    public class Lecon18
    {
        /// <summary>
        /// Méthode principale appelée par le Gestionnaire pour afficher la leçon 18.
        /// </summary>
        // "public" pour être accessible, "static" pour être appelée sans instance d'objet, "void" car elle ne retourne aucune valeur.
        public static void Afficher()
        {
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 18 : DIALOGUER AVEC L'UTILISATEUR ---\n");
            
            Console.WriteLine("Jusqu'à présent, notre programme parlait tout seul.");
            Console.WriteLine("Aujourd'hui, nous allons apprendre à écouter l'utilisateur !");
            Console.WriteLine("La classe 'Console' possède plusieurs outils (méthodes) pour cela.\n");
            
            // Explication de WriteLine vs Write
            Console.WriteLine("1. AFFICHER DU TEXTE (LES SORTIES)");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Tu connais déjà 'Console.WriteLine()'. Cette méthode affiche du texte puis passe à la ligne suivante.");
            
            // Console.Write() affiche du texte sans passer à la ligne.
            Console.Write("Mais il existe aussi 'Console.Write()'. ");
            Console.Write("Ce texte s'affiche ");
            Console.Write("sur la même ligne !");
            Console.WriteLine("\n\nC'est très pratique quand on veut poser une question et que l'utilisateur réponde juste à côté.");
            
            Console.WriteLine("\n2. LIRE DU TEXTE (LES ENTRÉES)");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Pour écouter ce que tape l'utilisateur, on utilise 'Console.ReadLine()'.");
            Console.WriteLine("Cette méthode met le programme en pause, attend que l'utilisateur tape quelque chose et appuie sur [Entrée].");
            Console.WriteLine("Elle renvoie alors le texte tapé sous forme de variable 'string' (chaîne de caractères).\n");
            
            // Démonstration interactive
            Console.Write("👉 Faisons un test. Quel est ton plat préféré ? ");
            
            // "string" déclare une variable de type texte.
            // On y stocke le résultat renvoyé par "Console.ReadLine()".
            string platPrefere = Console.ReadLine();
            
            // On utilise l'interpolation de chaîne ($"...") pour injecter notre variable dans la phrase.
            Console.WriteLine($"\nMiam ! J'adore aussi le/la {platPrefere}.");
            Console.WriteLine("Tu viens de réaliser ton premier dialogue interactif personnalisé !");
            
            Console.WriteLine("\n📖 Pour plus de détails, n'hésite pas à consulter la fiche [INFO_LaConsole.md] dans le dossier INFOS/Architecture/.");
        }
    }
}
