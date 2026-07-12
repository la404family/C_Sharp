// Le mot-clé "using System" permet d'utiliser les outils de base fournis par Microsoft, comme "Console" pour écrire à l'écran.
using System;

// "namespace" permet de ranger notre code dans un "dossier virtuel". 
// Ici, on le range dans "MonPremierProjet.Modules" pour dire que ça fait partie de nos modules complémentaires.
namespace MonPremierProjet.Modules
{
    /// <summary>
    /// La classe Afficheur est un module dont l'unique rôle est de gérer l'affichage de messages à l'écran.
    /// Pensez à une classe comme un plan de construction ou une boîte à outils spécifique.
    /// </summary>
    // "public" signifie que cette classe est utilisable partout dans notre projet.
    // "class" déclare que nous créons une nouvelle boîte à outils (une classe).
    public class Afficheur
    {
        /// <summary>
        /// Cette méthode affiche le message demandé dans la console.
        /// </summary>
        // "public" permet à notre fichier principal (Program.cs) d'utiliser cette action.
        // "static" signifie que l'on peut utiliser l'action directement depuis la boîte à outils, sans avoir à en construire une nouvelle version.
        // "void" indique que cette action fait quelque chose (afficher un message) mais ne renvoie aucun résultat à analyser ensuite (elle fait juste le travail).
        public static void AfficherMessage()
        {
            // "Console" est l'outil fourni par C# pour interagir avec la fenêtre noire (la console).
            // "WriteLine" est une action (méthode) de cet outil qui écrit une ligne de texte avec un retour à la ligne automatique.
            // Le texte doit toujours être encadré par des guillemets doubles "".
            Console.WriteLine("Hello World !");
        }

        /// <summary>
        /// Efface complètement l'écran et son historique (scrollback) pour un rendu parfait.
        /// </summary>
        // "public" et "static" pour pouvoir l'appeler facilement de n'importe où.
        public static void NettoyerEcran()
        {
            // On utilise la commande classique pour vider la zone visible.
            Console.Clear();
            
            // On envoie le code ANSI "3J" secret qui demande au terminal moderne 
            // de supprimer totalement l'historique de défilement (le scroll) !
            // "\x1b" est le caractère d'échappement (Échap) qui prévient la console qu'un ordre arrive.
            Console.Write("\x1b[3J");
        }
    }
}
