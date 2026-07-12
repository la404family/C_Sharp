// L'outil "using System" pour interagir avec la console.
using System;

// Le sous-dossier virtuel de nos cours.
namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Contient le code de la leçon 13 : L'Organisation d'un Fichier C#.
    /// </summary>
    public class Lecon13
    {
        /// <summary>
        /// Affiche le cours complet sur l'organisation des fichiers en 4 pages.
        /// </summary>
        public static void Afficher()
        {
            // On nettoie l'écran pour une immersion parfaite
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 16 : L'ORGANISATION D'UN FICHIER ---\n");
            
            Console.WriteLine(@"Un fichier C# bien organisé suit un *ordre logique* que tous les développeurs connaissent. 
Cela permet à n'importe qui de retrouver instantanément ce qu'il cherche dans une classe de plusieurs centaines de lignes.

--- 🔤 L'Ordre Universel Recommandé ---

Voici l'anatomie parfaite d'un fichier C# :

// 1. Directives 'using' (les outils importés, tout en haut)
using System;
using System.Collections.Generic;

// 2. Déclaration du 'namespace' (le dossier virtuel)
namespace MonApplication.Models
{
    // 3. Déclaration de la classe
    public class Exemple
    {
        // 4. Constantes (les valeurs fixes qui ne changent jamais)
        public const int Capacite = 100;

        // 5. Champs privés (les données cachées internes à la classe)
        private int _valeur;

        // 6. Constructeur(s) (la méthode d'initialisation)
        public Exemple() { }

        // 7. Propriétés publiques (l'accès autorisé aux données)
        public int Valeur { get; set; }

        // 8. Méthodes publiques (les actions disponibles de l'extérieur)
        public void Afficher() { }

        // 9. Méthodes privées (les outils internes cachés de la classe)
        private void MethodeInterne() { }
    }
}");

            Console.WriteLine("\nAppuyez sur une touche pour découvrir un exemple concret dans un jeu vidéo...");
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- 💡 Exemple Simple : La classe Personnage ---

Voyons cet ordre appliqué à un cas concret et réaliste :

using System;                          // 1. Using

namespace MonJeu                       // 2. Namespace
{
    public class Personnage            // 3. Classe
    {
        // 4. Champs privés
        private string _nom;
        private int _pointsDeVie;

        // 5. Constructeur
        public Personnage(string nom)
        {
            _nom = nom;
            _pointsDeVie = 100;        // Un nouveau personnage naît avec 100 PV
        }

        // 6. Propriétés publiques
        public string Nom => _nom;
        public int PointsDeVie => _pointsDeVie;
        public bool EstVivant => _pointsDeVie > 0;

        // 7. Méthodes publiques
        public void SubirDegats(int degats)
        {
            // Math.Max choisit le plus grand nombre entre 0 et (_pointsDeVie - degats)
            // Cela empêche les PV de descendre en dessous de zéro (pas de PV négatifs !)
            _pointsDeVie = Math.Max(0, _pointsDeVie - degats);
        }
    }
}");

            Console.WriteLine("\nAppuyez sur une touche pour voir l'exemple avancé avec des séparateurs visuels...");
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- 🚀 Exemple Avancé : Les Séparateurs Visuels ---

Pour les fichiers très longs ou complexes, les professionnels utilisent des commentaires de section pour créer des 'titres'.

using System;
using System.Collections.Generic;
using System.Linq; // Pour utiliser des outils de liste magiques (comme Any)

namespace MonApplication.Services
{
    /// <summary>
    /// Service de gestion de l'inventaire d'un magasin.
    /// </summary>
    public class ServiceInventaire
    {
        // ── Constantes ──────────────────────────────────────
        private const int StockMinimumAlerte = 5;

        // ── Champs privés ───────────────────────────────────
        private readonly List<Produit> _produits;

        // ── Constructeur ────────────────────────────────────
        public ServiceInventaire()
        {
            _produits = new List<Produit>(); // On initialise la liste vide
        }

        // ── Propriétés publiques ────────────────────────────
        public int NombreProduits => _produits.Count;

        // 'Any' vérifie si au moins UN produit respecte la condition
        public bool ADesAlertesStock => _produits.Any(p => p.Quantite < StockMinimumAlerte);

        // ── Méthodes publiques ──────────────────────────────
        public void AjouterProduit(Produit produit)
        {
            if (produit == null) throw new ArgumentNullException(nameof(produit));
            _produits.Add(produit);
        }

        // ── Méthodes privées ────────────────────────────────
        private bool ProduitExiste(string nomProduit)
        {
            // Outil interne utilisé par les autres méthodes de la classe
            return _produits.Any(p => p.Nom == nomProduit);
        }
    }
}");

            Console.WriteLine("\nAppuyez sur une touche pour découvrir les erreurs à fuir comme la peste...");
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- ⚠️ Erreurs Courantes à Éviter Absolument ---

- ❌ Mettre plusieurs classes dans un seul fichier. 
     Règle d'or absolue : UNE CLASSE = UN FICHIER. Si tu as une classe 'Joueur', elle doit être seule dans 'Joueur.cs'.

- ❌ Mélanger l'ordre des éléments. 
     Mettre des champs privés tout en bas, puis un constructeur au milieu, puis des propriétés... C'est un enfer à relire. Suis toujours l'ordre universel.

- ❌ Conserver des 'using' inutilisés. 
     Ça encombre le haut du fichier pour rien. Visual Studio te les affiche en gris clair pour te dire de les supprimer (Astuce : raccourci Ctrl + .).

- ❌ Imbriquer trop de niveaux (les fameux 'if' dans des 'if' dans des 'if'). 
     Si ton code part trop vers la droite (plus de 3 niveaux d'indentation), c'est qu'il faut le découper !


--- ✅ Les Bonnes Pratiques du Pro ---

1. Nomme ton fichier EXACTEMENT comme ta classe.
2. Utilise des commentaires de section (// ── Section ──) dans les classes massives.
3. Trie toujours par niveau d'accès : le 'public' (accessible) en haut, le 'private' (les petits outils internes cachés) en bas.
4. Garde tes fichiers courts : si un fichier dépasse les 200 à 300 lignes, c'est souvent le signe qu'il fait trop de choses à la fois et qu'il faut le diviser en deux classes distinctes.");

            Console.WriteLine("\nFélicitations, vous savez maintenant structurer un fichier comme un véritable architecte logiciel !");
        }
    }
}
