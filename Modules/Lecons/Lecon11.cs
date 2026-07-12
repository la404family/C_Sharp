// "using System" donne accès aux outils de base de la console.
using System;

// L'espace de noms pour ranger ce fichier dans le sous-dossier virtuel des leçons.
namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Contient le code de la leçon 11 : Les Conventions de Formatage en C#.
    /// </summary>
    public class Lecon11
    {
        /// <summary>
        /// Affiche le cours complet sur le formatage du code, divisé en 4 pages interactives.
        /// </summary>
        public static void Afficher()
        {
            // On nettoie l'écran pour une lecture claire
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 13 : LES CONVENTIONS DE FORMATAGE ---\n");
            
            // Le @ permet d'écrire sur plusieurs lignes.
            Console.WriteLine(@"Le formatage, c'est la façon dont tu organises visuellement ton code : l'indentation, 
les espaces, les retours à la ligne, et surtout les accolades { }. 

Un code bien formaté est facile à lire et à comprendre d'un seul coup d'œil. 
C'est comme la ponctuation dans un livre !

--- 🔤 Règles de Syntaxe de Base ---

// Règle 1 : Accolades TOUJOURS sur leur propre ligne (ce qu'on appelle le style 'Allman')
public class MaClasse
{                                      // ← Accolade ouvrante SEULE sur sa ligne
    public void MaMethode()
    {                                  // ← Idem ici
        // Code...
    }                                  // ← Accolade fermante SEULE sur sa ligne
}

// Règle 2 : Indentation avec 4 espaces (ou 1 tabulation)
// L'indentation est le décalage du texte vers la droite pour montrer qu'un code est 'à l'intérieur' d'un autre.
public void Exemple()
{
    if (true)
    {
        Console.WriteLine(""Indenté de 4 espaces supplémentaires"");
    }
}

// Règle 3 : Un espace autour des opérateurs mathématiques ou logiques
int resultat = 5 + 3;                 // ✅ Bien, aéré
int resultat2 = 5+3;                  // ❌ Mal, étouffé, pas d'espace

// Règle 4 : Pas d'espace avant les parenthèses d'un appel de méthode
Console.WriteLine(""Bonjour"");         // ✅ Bien
Console.WriteLine (""Bonjour"");        // ❌ Mal, un espace en trop");

            Console.WriteLine("\nAppuyez sur une touche pour voir la différence de lisibilité...");
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- 💡 Exemple Simple : Bon vs Mauvais ---

Voici pourquoi le formatage est si important en programmation :

// ✅ BON FORMATAGE — Clair, aéré, facile à lire pour un humain
public class Calculatrice
{
    public int Additionner(int a, int b)
    {
        int resultat = a + b;
        return resultat;
    }

    public int Soustraire(int a, int b)
    {
        int resultat = a - b;
        return resultat;
    }
}

// ------------------------------------------------------------------------

// ❌ MAUVAIS FORMATAGE — Compact, lourd, fatiguant pour les yeux
// L'ordinateur le comprend très bien, mais tes collègues développeurs vont te détester !
public class Calculatrice{
    public int Additionner(int a,int b){
        int resultat=a+b;return resultat;}
    public int Soustraire(int a,int b){int resultat=a-b;return resultat;}}");

            Console.WriteLine("\nAppuyez sur une touche pour découvrir l'organisation d'une classe complète...");
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- 🚀 Exemple Avancé : L'Organisation d'un Fichier ---

En plus des espaces, il faut ranger les éléments dans un ordre précis à l'intérieur d'une classe :

using System;                          // Les 'using' (importation d'outils) tout en haut
using System.Collections.Generic;      // Et on les trie par ordre alphabétique !

namespace MonApplication.Services       
{
    public class ServiceUtilisateur
    {
        // 1. D'abord les CHAMPS PRIVÉS (les données internes cachées)
        private readonly List<string> _utilisateurs;
        private int _compteur;

        // 2. Ensuite le CONSTRUCTEUR (l'initialisation de l'objet)
        public ServiceUtilisateur()
        {
            _utilisateurs = new List<string>();
            _compteur = 0;
        }

        // 3. Puis les PROPRIÉTÉS PUBLIQUES (les données accessibles de l'extérieur)
        public int NombreUtilisateurs => _utilisateurs.Count;

        // 4. Ensuite les MÉTHODES PUBLIQUES (les actions principales)
        public void AjouterUtilisateur(string nom)
        {
            // Étape A : Validation en premier
            if (string.IsNullOrWhiteSpace(nom))
            {
                // 'throw' permet de déclencher (lever) une erreur logicielle personnalisée (Exception).
                throw new ArgumentException(""Le nom ne peut pas être vide."");
            }

            // Étape B : Logique métier (le coeur de l'action) ensuite
            _utilisateurs.Add(nom);
            _compteur++;

            // Étape C : Affichage à la fin
            Console.WriteLine($""Utilisateur ajouté avec succès."");
        }

        // 5. Enfin les MÉTHODES PRIVÉES en dernier (les petits outils internes de la classe)
        private bool UtilisateurExiste(string nom)
        {
            return _utilisateurs.Contains(nom);
        }
    }
}");

            Console.WriteLine("\nAppuyez sur une touche pour découvrir les erreurs à éviter absolument...");
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- ⚠️ Erreurs Courantes à Éviter Absolument ---

- ❌ Les accolades à la 'K&R' (style Java, JavaScript, C++) : 
     public void Methode() {
     En C#, c'est totalement interdit par les conventions ! L'accolade d'ouverture va TOUJOURS sur une nouvelle ligne.

- ❌ Mélanger des tabulations et des espaces pour l'indentation. 
     Choisis l'un ou l'autre (généralement on paramètre son éditeur sur 4 espaces) et sois constant dans tout ton fichier.

- ❌ Les lignes de code trop longues. 
     Si ta ligne de code dépasse 120 caractères et sort de ton écran, découpe-la pour améliorer la lisibilité.

- ❌ Ne mettre aucune ligne vide entre les méthodes. 
     Il faut TOUJOURS ajouter une seule ligne vide pour 'aérer' le code et séparer deux blocs logiques.

- ❌ Mettre trop de lignes vides. 
     Laisser 3, 4 ou 5 lignes vides d'affilée ne sert strictement à rien. Une seule ligne vide suffit pour délimiter les blocs.");

            Console.WriteLine("\nFélicitations, votre code sera désormais lisible et digne d'un vrai professionnel !");
        }
    }
}
