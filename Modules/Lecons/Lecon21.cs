// "using" charge le module système principal.
using System;
// Importation du module gérant les processus et le temps d'exécution (Thread).
using System.Threading;

// Déclaration de notre "dossier virtuel" (namespace).
namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Leçon 21 : Transformer la console en canevas de dessin et ajouter du son.
    /// </summary>
    // Déclaration de la classe pour la leçon 21.
    public class Lecon21
    {
        /// <summary>
        /// Affiche le contenu et les effets visuels de la leçon 21.
        /// </summary>
        // Signature de la méthode d'affichage principale.
        public static void Afficher()
        {
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 21 : LE MODE DESSIN ET LE SON ---\n");
            
            Console.WriteLine("1. DÉPLACER LE CURSEUR");
            Console.WriteLine("----------------------");
            Console.WriteLine("Habituellement, l'ordinateur écrit de haut en bas, ligne par ligne.");
            Console.WriteLine("Mais avec 'Console.SetCursorPosition(colonne, ligne)', tu peux forcer l'ordinateur");
            Console.WriteLine("à écrire n'importe où ! Comme un peintre sur sa toile.\n");
            
            Console.WriteLine("Regarde bien en bas à droite de ton écran dans 2 secondes...");
            Thread.Sleep(2000); // Petite pause pour le suspense
            
            // On sauvegarde la position actuelle pour pouvoir y revenir après notre dessin.
            // "Console.CursorLeft" est la colonne actuelle, "Console.CursorTop" est la ligne actuelle.
            int ancienneColonne = Console.CursorLeft;
            int ancienneLigne = Console.CursorTop;
            
            // "Console.WindowWidth" nous donne la largeur totale de la fenêtre.
            // On déplace le curseur tout à droite (largeur - 15 caractères) et sur la ligne 1.
            Console.SetCursorPosition(Console.WindowWidth - 15, 1);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("⭐ COUCOU ! ⭐");
            Console.ResetColor();
            
            // On replace le curseur là où il était avant notre dessin pour continuer normalement !
            Console.SetCursorPosition(ancienneColonne, ancienneLigne);
            
            Console.WriteLine("Génial non ? Cela permet de créer des barres de vie ou d'afficher un score constant dans un coin.");
            
            Console.WriteLine("\n2. AJOUTER DU SON");
            Console.WriteLine("-----------------");
            Console.WriteLine("Notre application est très silencieuse. Mettons-y de la vie avec 'Console.Beep()'.");
            Console.WriteLine("Attention les oreilles, voici 3 bips rapides !");
            
            // Une petite boucle pour jouer 3 sons d'affilée.
            for (int i = 0; i < 3; i++)
            {
                // Console.Beep(fréquence en Hertz, durée en millisecondes). 
                // Note: Les paramètres spécifiques (freq, durée) ne fonctionnent que sous Windows.
                try 
                {
                    Console.Beep(800, 150); 
                } 
                catch (PlatformNotSupportedException) 
                {
                    // Sécurité au cas où l'utilisateur ne serait pas sous Windows.
                    Console.Beep(); 
                }
                Thread.Sleep(100);
            }
            
            Console.WriteLine("\nTe voilà devenu un véritable maître de la Console !");
        }
    }
}
