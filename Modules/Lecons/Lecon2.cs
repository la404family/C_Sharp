// Importation des outils de base de C#.
using System;

// Rangement du code dans l'espace de noms correspondant au dossier.
namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Contient le code de l'explication globale du projet et l'installation de l'environnement.
    /// </summary>
    // Classe dédiée exclusivement à l'étape 2.
    public class Lecon2
    {
        /// <summary>
        /// Affiche le message de bienvenue, les objectifs et l'installation.
        /// </summary>
        // Méthode exécutant l'action d'affichage.
        public static void Afficher()
        {
            // Effacement total de la console et de son historique pour une lecture parfaite.
            Afficheur.NettoyerEcran();
            
            // "Console.WriteLine" écrit le texte entre guillemets et passe automatiquement à la ligne suivante.
            Console.WriteLine("--- ETAPE 2 : EXPLICATION DU PROJET ---\n");
            Console.WriteLine("Bienvenue ! Dans ce projet, vous allez apprendre les bases de C#.");
            Console.WriteLine("Nous allons créer ensemble un programme interactif pas à pas.\n");

            // Utilisation d'une chaîne Verbatim (@) pour afficher un long texte formaté avec des sauts de ligne.
            // On double les guillemets ("") à l'intérieur pour les afficher correctement.
            Console.WriteLine(@"=== Les bases de la programmation en C-Sharp ===

--- Installation de l'environnement de développement ---
Pour commencer à programmer en C-Sharp, vous devez installer un environnement de développement intégré (IDE). 
Le plus populaire pour C-Sharp est Visual Studio. Vous pouvez le télécharger depuis le site officiel de Microsoft.
Vous pouvez également utiliser Visual Studio Code (VScode) avec l'extension C# si vous préférez un éditeur plus léger.

1) Utilisation de Visual Studio :
   - Rendez-vous sur le site de Visual Studio (https://visualstudio.microsoft.com/).
   - Téléchargez la version Community (gratuite).
   - Suivez les instructions d'installation et assurez-vous de sélectionner le workload 
     "".NET desktop development"" lors de l'installation.

2) Utilisation de VScode :
   - Téléchargez et installez Visual Studio Code (https://code.visualstudio.com/).
   - Ouvrez Visual Studio Code et allez dans l'onglet Extensions.
   - Recherchez et installez l'extension ""C#"".
   - Assurez-vous d'avoir le SDK .NET installé sur votre machine. Vous pouvez le télécharger 
     depuis le site officiel de .NET (https://dotnet.microsoft.com/download).

   Extensions recommandées pour VScode :
   - C# Dev Kit
   - C# Extensions");
        }
    }
}
