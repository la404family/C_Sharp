// Outils de base.
using System;

// Espace de noms du projet.
namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Explique les fichiers de base du projet et présente les quiz.
    /// </summary>
    // Classe de l'étape 4.
    public class Lecon4
    {
        /// <summary>
        /// Affiche l'explication des fichiers et l'information sur les quiz.
        /// </summary>
        // Méthode de la classe.
        public static void Afficher()
        {
            // Nettoyage absolu de l'écran.
            Afficheur.NettoyerEcran();
            
            // Affichage du titre.
            Console.WriteLine("--- ETAPE 4 : EXPLICATION DES FICHIERS & LES QUIZ ---\n");
            
            // On rappelle la structure visuelle pour que l'élève puisse suivre l'explication.
            Console.WriteLine(@"Rappel de notre architecture :
|_ MonProjet/
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
            
            // Explication des fichiers de base transférée depuis l'étape 3.
            Console.WriteLine(@"=== À quoi servent ces fichiers principaux ? ===
- Program.cs              : Le point d'entrée de l'application, notre ""chef d'orchestre"".
                            Il contient la boucle principale (le moteur du programme).
- MonPremierProjet.csproj : Le fichier de configuration du projet C#. Il indique à
                            l'ordinateur avec quels paramètres compiler notre code.
- LancerProjet.bat        : Notre script pour compiler et démarrer l'application d'un double-clic.
- README.md               : Le manuel d'accueil du développeur (la vitrine du projet).
- progression.txt         : Le fichier généré automatiquement par notre code pour sauvegarder !
- Modules/                : Le dossier où l'on range toutes nos briques de code séparées.");

            // Affichage de l'information sur les quiz.
            Console.WriteLine("\n=== Évaluations (QCM) ===");
            Console.WriteLine("Le projet contient des modules d'évaluation (QCM).");
            Console.WriteLine("Il est nécessaire de saisir la bonne réponse pour avancer et gagner des points.");
            
            // Le texte informatif de fin.
            Console.WriteLine("\nEst ce bien clair ? !");
        }
    }
}
