// "using System" nous donne accès aux outils de base de la console.
using System;

// L'espace de noms "namespace" permet de ranger ce code dans le sous-dossier virtuel "MonPremierProjet.Modules.Lecons".
namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Contient le code de la leçon 9 : Les Conventions de Nommage en C#.
    /// </summary>
    // "public" pour que cette classe soit accessible par notre GestionnaireLecons.
    // "class" définit notre conteneur pour la leçon.
    public class Lecon9
    {
        /// <summary>
        /// Méthode principale qui affiche le contenu de la leçon 9.
        /// </summary>
        // "public" pour être appelée de l'extérieur, "static" pour l'appeler directement sans créer d'instance, "void" car elle ne renvoie rien.
        public static void Afficher()
        {
            // On nettoie l'écran pour une lecture agréable
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 11 : LES CONVENTIONS DE NOMMAGE ---\n");
            
            // Le @ devant les guillemets permet d'écrire du texte sur plusieurs lignes très facilement (chaîne verbatim).
            Console.WriteLine(@"Le nommage, c'est la façon dont tu donnes des noms à tes variables, méthodes, classes, etc. 
En C#, il existe des règles précises pour chaque type d'élément. 
Un mauvais nom rend le code incompréhensible ; un bon nom le rend auto-documenté.

--- Les styles de casse utilisés en C# ---

1. PascalCase : Chaque mot commence par une majuscule.
   Exemple : CalculerPrix
   Utilisé pour : Classes, méthodes, propriétés, événements.

2. camelCase : Comme PascalCase mais le 1er mot est en minuscule.
   Exemple : prixTotal
   Utilisé pour : Variables locales, paramètres de méthodes.

3. _camelCase : camelCase précédé d'un underscore (tiret du bas).
   Exemple : _compteur
   Utilisé pour : Champs privés (variables cachées) d'une classe.

4. UPPER_CASE : Tout en majuscules, mots séparés par des underscores.
   Exemple : MAX_ESSAIS
   Utilisé pour : Constantes (selon les équipes, bien que Microsoft recommande PascalCase).

5. IPascalCase : PascalCase précédé d'un 'I' majuscule.
   Exemple : ICalculable
   Utilisé pour : Interfaces (des contrats que les classes doivent respecter).");

            Console.WriteLine("\nAppuyez sur une touche pour voir la syntaxe en code...");
            
            // On attend une saisie clavier pour marquer une pause dans la lecture
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- 🔤 Syntaxe Concrète ---
Voici comment ces règles s'appliquent directement dans votre code :

// PascalCase pour les classes
public class NomDeLaClasse { }

// PascalCase pour les méthodes (actions)
public void CalculerTotal() { }

// PascalCase pour les propriétés
public string NomComplet { get; set; }

// camelCase pour les variables locales
int prixUnitaire = 10;

// camelCase pour les paramètres de méthodes
public void AfficherMessage(string messageUtilisateur) { }

// _camelCase pour les champs privés (données internes à la classe)
private int _compteur;

// PascalCase avec préfixe I pour les interfaces
public interface ICalculable { }

// PascalCase pour les constantes (recommandé par Microsoft)
public const int NombreMaximumEssais = 3;");

            Console.WriteLine("\nPrenez le temps d'observer ces exemples. Un code bien nommé est la marque d'un professionnel !");
        }
    }
}
