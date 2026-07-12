// "using System" donne accès aux outils de base de la console.
using System;

// On classe ce fichier dans le sous-dossier virtuel des Leçons.
namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Contient le code de la leçon 10 : Exemple Avancé sur les Conventions de Nommage.
    /// </summary>
    public class Lecon10
    {
        /// <summary>
        /// Affiche l'exemple avancé décortiqué étape par étape.
        /// </summary>
        // "public static" permet d'appeler cette méthode directement depuis le Gestionnaire.
        public static void Afficher()
        {
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 12 : EXEMPLE AVANCE DE NOMMAGE ---\n");
            
            // Le @ permet d'écrire sur plusieurs lignes.
            Console.WriteLine(@"Pour bien consolider la leçon précédente, nous allons analyser un exemple de code complet.
Cet exemple regroupe toutes les conventions de nommage dans un scénario réaliste de développement.

Avant de lire le code, voici quelques définitions de concepts techniques que vous allez croiser :

- Interface : C'est un ""contrat"" qui oblige une classe à posséder certaines propriétés ou méthodes.
- Propriété : C'est une donnée publique exposée par un objet (ex: lire la Marque).
- Champ privé : C'est une variable cachée, utilisée en interne par la classe pour fonctionner sans qu'on puisse la modifier de l'extérieur.
- Constructeur : C'est la méthode spéciale appelée au moment où l'on crée un nouvel objet en mémoire.
- Variable locale : C'est une variable temporaire, qui n'existe que le temps qu'une méthode s'exécute.");

            Console.WriteLine("\nAppuyez sur une touche pour découvrir le code commenté...");
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- 💻 Le Code en Action ---

// L'Interface (contrat) : commence par un 'I' majuscule + PascalCase
public interface IVehicule             
{
    // Une Propriété (PascalCase) exigée par le contrat
    string Marque { get; }             
    
    // Une Méthode (PascalCase) exigée par le contrat
    void Demarrer();                   
}

// La Classe (PascalCase) qui respecte le contrat de l'interface
public class Voiture : IVehicule       
{
    // Constante (PascalCase, recommandation de Microsoft)
    // Une donnée qui ne changera jamais dans toute la vie du programme.
    public const int NombreRoues = 4;

    // Champs privés (_camelCase)
    // Ce sont les données internes de la voiture, inaccessibles de l'extérieur.
    private readonly string _marque;
    private bool _estDemarree;

    // Propriété publique (PascalCase)
    // Elle permet à l'extérieur de LIRE la valeur du champ privé _marque, sans pouvoir l'écraser.
    public string Marque => _marque;

    // Constructeur (PascalCase, porte obligatoirement le nom de la classe)
    // Le paramètre entrant, lui, est en camelCase.
    public Voiture(string marqueVehicule)
    {
        // On assigne la valeur du paramètre entrant au champ privé interne
        _marque = marqueVehicule;      
        _estDemarree = false;          
    }

    // Méthode publique (PascalCase)
    public void Demarrer()
    {
        // Variable locale (camelCase)
        // Elle est temporaire et sert juste pour le calcul de cette méthode.
        bool peutDemarrer = !_estDemarree;

        if (peutDemarrer)
        {
            _estDemarree = true; // On met à jour l'état interne
            Console.WriteLine($""La {_marque} démarre !"");
        }
    }
}");
            Console.WriteLine("\nPrenez votre temps pour analyser comment chaque élément se distingue visuellement grâce à son nom.");
        }
    }
}
