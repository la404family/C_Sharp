using System;

namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Contient le code de la leçon 14 : Les Types et Variables (var vs Explicite).
    /// </summary>
    public class Lecon14
    {
        public static void Afficher()
        {
            Afficheur.NettoyerEcran();
            Console.WriteLine("--- ETAPE 17 : LES TYPES ET VARIABLES ---\n");
            Console.WriteLine(@"En C#, tu peux déclarer les types de deux façons : en écrivant le type *explicitement* ou en utilisant le mot-clé 'var' qui laisse l'ordinateur deviner le type.

--- 🔤 Syntaxe de Base ---

// 1. Type explicite — Tu écris le type toi-même
string nom = ""Alice"";
int age = 25;

// 2. Mot-clé 'var' — Le compilateur déduit le type automatiquement
var prenom = ""Bob"";                     // Le compilateur sait que c'est un 'string'
var compteur = 0;                       // Le compilateur sait que c'est un 'int'");
            
            Console.WriteLine("\nAppuyez sur une touche pour découvrir les règles de décision...");
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- 💡 Le Grand Débat : Quand utiliser 'var' ? ---

La règle d'or est la suivante : utilise 'var' uniquement quand le type est ÉVIDENT en lisant la ligne de code.

// ✅ BON — Utilise var quand le type est évident à droite du signe égal
var message = ""Bonjour"";               
var joueurs = new List<Joueur>();       // On lit clairement 'List<Joueur>', donc 'var' allège la ligne

// ✅ BON — Utilise le type explicite quand le type n'est PAS évident
int resultat = CalculerScore();        // Sans 'int', on ne saurait pas ce que retourne la méthode
FileStream fichier = ObtenirFichier(); // Clarifie l'intention immédiatement

// ❌ MAUVAIS — Impossible de deviner le type
var x = GetData();                     // Qu'est-ce que 'GetData' renvoie ? Un int ? Une liste ? Mystère !");
            
            Console.WriteLine("\nAppuyez sur une touche pour voir les bonnes pratiques...");
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- ✅ Bonnes Pratiques sur les Variables ---

- ✅ Déclare les variables au plus proche de leur première utilisation (ne les déclare pas toutes en haut de ton fichier pour rien).
- ✅ Une variable a UN SEUL rôle. Ne recycle pas une variable 'total' pour y stocker du texte plus tard. Le C# est un langage fortement typé.
- ✅ Utilise des noms qui se suffisent à eux-mêmes (évite 'x' ou 'y', sauf dans les boucles courtes).

--- ⚠️ Erreurs Courantes ---

- ❌ Utiliser 'var' partout sans réfléchir (rend le code très difficile à relire).
- ❌ Ne jamais utiliser 'var' (rend le code lourd, exemple : 'Dictionary<string, int> dico = new Dictionary<string, int>();').");
            
            Console.WriteLine("\nFélicitations, vous savez maintenant typer comme un pro !");
        }
    }
}
