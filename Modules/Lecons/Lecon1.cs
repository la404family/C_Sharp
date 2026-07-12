// "using System" donne accès aux outils de base de l'ordinateur, comme la console.
using System;

// "namespace" permet de ranger ce code dans le sous-dossier virtuel "MonPremierProjet.Modules.Lecons".
namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Contient le code de la toute première leçon (Hello World).
    /// </summary>
    // "public" permet à cette classe d'être utilisée par notre GestionnaireLecons.
    // "class" déclare notre boîte à outils dédiée à la leçon 1.
    public class Lecon1
    {
        /// <summary>
        /// Méthode principale qui affiche le contenu de la leçon 1.
        /// </summary>
        // "public" pour être appelée de l'extérieur, "static" pour l'appeler sans créer d'instance, "void" car elle ne renvoie rien.
        public static void Afficher()
        {
            // "Afficheur.NettoyerEcran()" est notre action maison pour effacer tout l'historique (scrollback inclus).
            Afficheur.NettoyerEcran();
            
            // On affiche le titre de la leçon.
            Console.WriteLine("--- ETAPE 1 : LE TRADITIONNEL HELLO WORLD ---\n");
            
            // On appelle notre module d'affichage externe créé précédemment.
            Afficheur.AfficherMessage();
            
            // On ajoute l'explication historique demandée avec une chaîne Verbatim (@) pour gérer les sauts de ligne.
            Console.WriteLine("\n=== Mais au fait, pourquoi \"Hello World\" ? ===");
            Console.WriteLine(@"Cette tradition remonte à 1978 ! C'est Brian Kernighan qui l'a popularisée 
dans son célèbre livre d'apprentissage du langage C (""The C Programming Language"").

À l'époque, c'était simplement un tout petit exemple pour montrer à l'étudiant 
comment compiler et lancer un programme basique. 

Depuis, c'est devenu un rite de passage mondial : le tout premier programme que 
l'on écrit lorsqu'on apprend un nouveau langage est TOUJOURS un ""Hello World"". 
C'est une façon simple de vérifier que notre environnement de développement 
est bien installé et que l'ordinateur nous écoute !");
        }
    }
}
