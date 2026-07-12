// "using System" donne accès aux outils de base de l'ordinateur, comme la console.
using System;

// "namespace" permet de ranger ce code dans le sous-dossier virtuel "MonPremierProjet.Modules.Lecons".
namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Contient le code de la leçon 8 : Résumé détaillé de la CLI, du CLR et du flux d'exécution.
    /// </summary>
    // "public" pour que cette classe soit accessible par notre GestionnaireLecons depuis n'importe où.
    // "class" définit un modèle qui contient nos méthodes (actions).
    public class Lecon8
    {
        /// <summary>
        /// Méthode principale qui affiche le contenu de la leçon 8.
        /// </summary>
        // "public" pour être appelée de l'extérieur, "static" pour l'appeler sans créer d'instance (objet), "void" car elle ne renvoie aucune valeur.
        public static void Afficher()
        {
            // Nettoyage de l'écran pour une lecture claire
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 8 : LE GRAND RESUME (CLI, CLR, ROSLYN) ---\n");
            
            // On utilise une chaîne verbatim (@) pour faciliter l'affichage
            Console.WriteLine(@"Voici un résumé complet de ce que vous avez appris sur le fonctionnement interne !

--- Comment ils travaillent ensemble (Le Flux) ---

Voici ce qui se passe quand vous appuyez sur ""Play"" dans Visual Studio :

1. ✍️ Écriture : Vous écrivez du code C#.
2. ⚙️ Compilation (Roslyn) : Le compilateur C# vérifie votre code. S'il est bon, il le transforme 
   non pas en code machine, mais en fichier .dll ou .exe contenant du Code IL (le code standardisé par la CLI).
3. 🚀 Exécution (CLR) :
   - Vous lancez le programme.
   - Le CLR démarre.
   - Il lit le Code IL.
   - Son compilateur JIT traduit ce Code IL en instructions machines spécifiques à votre ordinateur (Windows, Mac, Linux).
   - Le processeur exécute les instructions.");

            Console.WriteLine("\nAppuyez sur une touche pour voir les tableaux récapitulatifs...");
            
            // Pause pour la lecture
            Console.ReadKey();
            
            // On nettoie l'écran pour éviter que le texte ne devienne illisible
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- En résumé ---

| Acronyme | Nom complet | Rôle | Analogie |
|----------|-------------|------|----------|
| CLI      | Common Language Infrastructure | Les Règles. La norme du code. | Le Code de la route (le livre). |
| CLR      | Common Language Runtime | L'Exécutant. Le moteur. | La Voiture et le Conducteur. |

--- Ce qu'il faut retenir (Points clés) ---

- CLI : Une norme (ECMA-335). Définit les règles communes à tous les langages .NET.
- CLR : Un logiciel (runtime). Exécute le code, gère la mémoire, compile en JIT.
- Roslyn : Le compilateur C#. Transforme ton code C# en code IL.
- CIL / IL : Code intermédiaire. Le ""langage universel"" entre ton code C# et le processeur.
- JIT : Compilation Just-In-Time. Traduit le code IL en code machine au moment de l'exécution.");

            Console.WriteLine("\nAppuyez sur une touche pour la FAQ et les erreurs courantes...");
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- ❓ Questions fréquentes ---

Q : Le CLR est-il le compilateur ?
❌ Non ! Le CLR est le runtime. Il contient un compilateur JIT qui traduit le code IL en code machine, mais ce n'est pas lui qui compile ton code C#.

Q : Roslyn est-il le compilateur ?
✅ Oui ! Roslyn est le compilateur officiel de C#. Il analyse ton code, détecte les erreurs et le transforme en code IL.

Q : Quelle est la différence entre compilation et exécution ?
- La compilation (Roslyn) vérifie ton code et le transforme en IL -> tu obtiens un fichier .dll ou .exe.
- L'exécution (CLR) prend ce fichier IL et le fait tourner sur ta machine grâce au JIT.

--- ⚠️ Erreurs courantes des débutants ---

❌ Confondre CLI (Common Language Infrastructure) avec CLI (Command Line Interface - terminal).
❌ Penser que le CLR est un compilateur classique. En réalité, il fait de la compilation JIT (au moment de l'exécution).
❌ Croire que le code C# s'exécute directement par le processeur. C'est en fait : C# -> IL (Roslyn) -> Code machine (CLR/JIT).");

            Console.WriteLine("\nAppuyez sur une touche pour la conclusion...");
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- ✅ Bonnes pratiques ---
- Utilise toujours la dernière version LTS de .NET.
- Retiens le flux : Code C# -> Roslyn -> IL -> CLR/JIT -> Code machine.
- Quand on te parle de CLI en contexte .NET, pense infrastructure, pas terminal.

--- 🧠 L'analogie pour tout retenir (La recette de cuisine) ---
📖 CLI = Le livre de recettes standardisé (les règles)
👨‍🍳 Roslyn = Le chef qui lit ta recette (C#) et la traduit en instructions universelles (IL)
🍳 CLR = La cuisine équipée qui exécute les instructions
🔥 JIT = L'adaptation en temps réel selon le four disponible (ton processeur)

--- 🎯 Si on te demande : ---
- ""Qui est le compilateur C# ?"" -> Roslyn
- ""Qui exécute le code ?"" -> Le CLR
- ""Qu'est-ce que le code IL ?"" -> Le code intermédiaire
- ""CLI et PEP 8, c'est pareil ?"" -> Non ! CLI = fondation technique, PEP 8 = guide de style.");

            Console.WriteLine("\nFélicitations, l'architecture .NET n'a plus de secrets pour vous !");
        }
    }
}
