using System;

namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Contient le code de la leçon 17 : Les Outils pour Appliquer les Conventions.
    /// </summary>
    public class Lecon17
    {
        public static void Afficher()
        {
            Afficheur.NettoyerEcran();
            Console.WriteLine("--- ETAPE 20 : LES OUTILS D'AUTOMATISATION ---\n");
            Console.WriteLine(@"Tu n'as pas besoin de retenir toutes ces conventions par cœur ! 
Les développeurs professionnels utilisent des outils pour que l'ordinateur vérifie et corrige le code à leur place.

--- 🛠️ Les Outils Incontournables ---

1. Le fichier '.editorconfig'
   Placé à la racine de ton projet, ce petit fichier dicte les règles à ton éditeur (Visual Studio, VSCode). 
   Il configure automatiquement l'indentation à 4 espaces, exige que les champs privés commencent par un underscore (_), etc.

2. Les 'Analyzers' (StyleCop / Roslyn)
   Ce sont des extensions que tu ajoutes à ton projet. 
   Pendant que tu tapes du code, si tu oublies une accolade ou nommes mal une variable, ils soulignent ton code en jaune (Warning) pour t'avertir.

3. La commande 'dotnet format'
   Tu ouvres ton terminal, tu tapes 'dotnet format', et l'ordinateur parcourt tous tes fichiers pour corriger automatiquement l'indentation, les espaces et les accolades mal placées !");
            
            Console.WriteLine("\nAppuyez sur une touche pour la grande conclusion...");
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- 🧠 Ce qu'il faut retenir globalement ---

Les conventions ne sont pas des règles rigides pour embêter les développeurs. Elles sont notre *langage commun* !

- Nommage : PascalCase pour le public, camelCase pour le local, _camelCase pour le privé.
- Formatage : Style Allman (nouvelle ligne), 4 espaces, aéré.
- Commentaires : Explique le POURQUOI, utilise le XML (///) pour les classes publiques.
- Architecture : 1 Fichier = 1 Classe.
- Variables : 'var' quand c'est évident, sinon Type explicite.
- Flux : Toujours des accolades, privilégier le retour anticipé (Early Return).

En appliquant tout cela, n'importe quel développeur dans le monde pourra ouvrir ton code et le lire comme s'il s'agissait du sien.

La grande partie théorique sur les fondations professionnelles de C# est désormais terminée !");
            
        }
    }
}
