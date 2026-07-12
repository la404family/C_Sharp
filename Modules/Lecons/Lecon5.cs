// Accès aux fonctionnalités de base de l'ordinateur, comme l'affichage dans la console.
using System;

// Définition de l'espace de noms pour regrouper les leçons.
namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Leçon 5 : Introduction au C# et à l'écosystème .NET.
    /// </summary>
    // Classe encapsulant le contenu de la leçon 5.
    public class Lecon5
    {
        /// <summary>
        /// Affiche le cours théorique sur l'écosystème .NET.
        /// </summary>
        // Méthode exécutant l'action d'affichage pour cette leçon.
        public static void Afficher()
        {
            // Nettoyage absolu de l'écran et de son historique.
            Afficheur.NettoyerEcran();
            
            // Affichage du titre principal.
            Console.WriteLine("--- ETAPE 5 : QU'EST-CE QUE LE C# ET L'ECOSYSTEME .NET ? ---\n");

            // Utilisation d'une chaîne Verbatim (précédée de '@') pour afficher un bloc de texte multi-lignes sans effort.
            // Note : Dans une chaîne Verbatim, on doit doubler les guillemets ("") pour en afficher un seul.
            Console.WriteLine(@"=== Vue d'ensemble ===
| Terme          | Description                                                     |
|----------------|-----------------------------------------------------------------|
| C#             | Le langage de programmation orienté objet créé par Microsoft    |
| .NET           | La plateforme d'exécution (runtime) qui fait tourner le code C# |
| ASP.NET Core   | Le framework pour créer des applications web                    |

=== C# - Le langage ===
C# (prononcé ""Ci-Sharp"") est un langage de programmation moderne, orienté objet, créé par Microsoft en 2000. 
Il combine la puissance du C++ avec la simplicité de langages comme Java.

Caractéristiques principales :
- Typage fort et statique (détection d'erreurs à la compilation)
- Gestion automatique de la mémoire (Garbage Collector)
- Syntaxe claire et lisible
- Support de la programmation orientée objet, fonctionnelle et asynchrone

=== .NET - La plateforme ===
.NET est l'environnement d'exécution qui permet de faire tourner les applications C#. 
Il fournit les bibliothèques de base, le compilateur et le runtime.

Historique simplifié :
| Version            | Période   | Caractéristique                         |
|--------------------|-----------|-----------------------------------------|
| .NET Framework     | 2002-2019 | Windows uniquement (legacy)             |
| .NET Core          | 2016-2020 | Multiplateforme, open-source            |
| .NET 5/6/7/8+      | 2020+     | Unification, version moderne à utiliser |

> Astuce : Aujourd'hui, utilisez simplement .NET X (la dernière version LTS). 
Les termes ""Core"" et ""Framework"" sont historiques.

=== Ce que vous pouvez créer avec C# et .NET ===
- Applications Console          : Scripts, outils CLI, automatisation
- Applications Desktop          : WPF, WinForms, MAUI
- Sites Web                     : ASP.NET Core MVC, Razor Pages
- API REST                      : ASP.NET Core Web API
- Applications Web interactives : Blazor
- Jeux vidéo                    : Unity
- Applications mobiles          : .NET MAUI, Xamarin
- Microservices                 : ASP.NET Core, gRPC
- Cloud & Serverless            : Azure Functions
- IoT & Embedded                : .NET nanoFramework
");
        }
    }
}
