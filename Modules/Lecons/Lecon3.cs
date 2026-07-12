// Accès aux outils de base.
using System;

// Dossier virtuel du projet.
namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Affiche l'arborescence complète et détaillée du projet C#.
    /// </summary>
    // Classe dédiée à l'étape 3.
    public class Lecon3
    {
        /// <summary>
        /// Dessine l'arbre ASCII de l'architecture du projet.
        /// </summary>
        // Action principale de la classe.
        public static void Afficher()
        {
            // Nettoyage absolu de l'écran (historique inclus).
            Afficheur.NettoyerEcran();
            
            // Affichage du titre.
            Console.WriteLine("--- ETAPE 3 : ARCHITECTURE COMPLETE DU PROJET ---\n");
            
            // Explication théorique sur la Console et la Modularité avec une chaîne Verbatim.
            Console.WriteLine(@"=== Qu'est-ce qu'un projet Console ? ===
Un projet Console est la forme la plus pure d'un programme informatique.
Il n'y a pas d'interface graphique compliquée, ni de fenêtres, ni de boutons. 
L'ordinateur lit simplement ce que vous tapez, et écrit ses réponses en texte brut. 
C'est l'environnement d'apprentissage idéal pour se concentrer à 100% sur la logique !

=== Pourquoi faire du code Modulaire ? ===
Imaginez si l'intégralité de ce cursus, de la sauvegarde et des quiz était 
écrite dans un seul et unique fichier... Il ferait des dizaines de milliers de lignes !
Le code deviendrait très vite illisible et dangereux à modifier.

Séparer la logique consiste à découper son programme en petites ""briques"" (les Modules).
Chaque fichier ne s'occupe que d'une seule tâche précise (ce qu'on appelle la Responsabilité Unique).
Par exemple : 
- ""Sauvegarde.cs"" ne gère que la sauvegarde, il ne dessine rien à l'écran.
- Chaque Leçon possède son propre fichier, sans interférer avec les autres.

C'est la Règle d'Or du développeur pour construire un projet propre et professionnel !
");
            
            // Le "\n" à la fin d'une chaîne de caractères provoque un retour à la ligne supplémentaire (un saut de ligne).
            Console.WriteLine("Voici comment nos fichiers sont organisés :\n");
            
            // Le symbole '@' placé juste avant les guillemets permet d'écrire une chaîne de caractères "Verbatim".
            // Cela signifie que l'on peut faire des retours à la ligne directement dans le code sans provoquer d'erreur.
            // C'est très pratique pour dessiner de l'ASCII art !
            Console.WriteLine(@"|_ MonProjet/
   |_ Program.cs
   |_ MonPremierProjet.csproj
   |_ LancerProjet.bat
   |_ README.md
   |_ progression.txt
   |_ Modules/
      |_ Afficheur.cs
      |_ GestionnaireLecons.cs
      |_ Sauvegarde.cs
      |_ Lecons/
         |_ Lecon1.cs
         |_ Lecon2.cs
         |_ Lecon3.cs
         |_ Lecon4.cs
         |_ LeconXXX.cs
      |_ Quizz/
         |_ Quizz1.cs
         |_ Quizzxxx.cs
   ");
         
            // Le texte informatif de fin.
            Console.WriteLine("\nNous allons expliquer ces fichiers dans la prochaine leçon !");
        }
    }
}
