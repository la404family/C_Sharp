// L'outil "using System" nous permet toujours d'utiliser la Console.
using System;

// On range cette leçon avec les autres.
namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Contient le code de la leçon 12 : Les Conventions de Commentaires en C#.
    /// </summary>
    public class Lecon12
    {
        /// <summary>
        /// Affiche le cours complet sur les commentaires du code, divisé en 4 pages interactives.
        /// </summary>
        public static void Afficher()
        {
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 15 : LES CONVENTIONS DE COMMENTAIRES ---\n");
            
            Console.WriteLine(@"Les commentaires servent à expliquer le *pourquoi* de ton code, pas le *quoi*. 
Un bon commentaire explique une décision difficile, un contexte métier ou une ruse technique. 
Un mauvais commentaire se contente de répéter en français ce que l'ordinateur fait déjà.

--- 🔤 Syntaxe de Base ---

// 1. Commentaire sur une seule ligne (le plus courant, avec deux barres obliques)
// Il est souvent placé juste au-dessus du bloc de code qu'il explique.

/* 2. Commentaire
   sur plusieurs lignes (bloc)
   Utile pour les longues explications, bien que moins utilisé aujourd'hui. */

/// <summary>
/// 3. Commentaire de documentation XML (Triple slash ///).
/// Il est placé juste au-dessus des classes et des méthodes publiques.
/// Il permet à Visual Studio d'afficher des bulles d'aide interactives (IntelliSense)
/// quand vous (ou un collègue) utilisez la méthode ailleurs dans le projet.
/// </summary>");

            Console.WriteLine("\nAppuyez sur une touche pour voir la différence entre le bon et le mauvais...");
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- 💡 Exemple Simple : Le Pourquoi vs Le Quoi ---

// ✅ BON COMMENTAIRE — Explique le 'pourquoi' de la formule (la règle métier)
// On arrondit à 2 décimales car les prix sont affichés en euros au client final.
double prixFinal = Math.Round(prixBrut * 1.20, 2);

// ------------------------------------------------------------------------

// ❌ MAUVAIS COMMENTAIRE — Répète inutilement ce que fait le code (le 'quoi')
// On multiplie prixBrut par 1.20 et on arrondit à 2
double prixFinal = Math.Round(prixBrut * 1.20, 2);


--- 💡 Le pouvoir du Commentaire XML ---

// ✅ BON — Aide directement les autres développeurs de ton équipe !
/// <summary>
/// Calcule le prix TTC (Toutes Taxes Comprises) à partir du prix HT.
/// </summary>
/// <param name=""prixHorsTaxe"">Le prix d'origine sans les taxes (en euros).</param>
/// <returns>Le prix TTC final arrondi à 2 décimales.</returns>
public double CalculerPrixTTC(double prixHorsTaxe)
{
    return Math.Round(prixHorsTaxe * 1.20, 2);
}");

            Console.WriteLine("\nAppuyez sur une touche pour découvrir l'exemple avancé...");
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- 🚀 Exemple Avancé : Le Commentaire XML Complet ---

Voici à quoi ressemble une méthode professionnelle parfaitement documentée :

/// <summary>
/// Vérifie si un utilisateur a le droit de se connecter au système.
/// </summary>
/// <param name=""identifiant"">L'identifiant unique (pseudo ou email) de l'utilisateur.</param>
/// <param name=""motDePasse"">Le mot de passe en clair (sera sécurisé pour la comparaison).</param>
/// <returns>
/// <c>true</c> si les identifiants sont valides et le compte actif ;
/// <c>false</c> sinon.
/// </returns>
/// <exception cref=""ArgumentNullException"">
/// Déclenchée si l'identifiant ou le mot de passe est null (vide).
/// </exception>
public bool VerifierConnexion(string identifiant, string motDePasse)
{
    // On valide toujours nos entrées en premier
    if (identifiant == null) throw new ArgumentNullException(nameof(identifiant));
    if (motDePasse == null) throw new ArgumentNullException(nameof(motDePasse));

    // ✅ BON COMMENTAIRE : on explique une ruse technique d'optimisation (le pourquoi !)
    // On vérifie d'abord si le compte est verrouillé avant de tester le mot de passe.
    // Cela nous évite de faire un appel très lent à la base de données (BDD) pour rien.
    if (EstCompteVerrouille(identifiant))
    {
        return false;
    }

    // ... (suite fictive du code) ...
    return true;
}");

            Console.WriteLine("\nAppuyez sur une touche pour découvrir les erreurs impardonnables...");
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- ⚠️ Erreurs Courantes à Éviter Absolument ---

- ❌ Commenter chaque ligne. 
     Cela noie l'information utile dans le bruit. Un code bien nommé se lit tout seul, comme un livre !

- ❌ Les commentaires obsolètes. 
     Un commentaire qui dit l'inverse de ce que fait le code (parce que le code a été modifié mais pas le commentaire) est PIRE que pas de commentaire du tout ! Prenez l'habitude de les mettre à jour.

- ❌ Garder du code en commentaire ('// du code...'). 
     On voit souvent des blocs entiers de code désactivés 'au cas où on en aurait besoin plus tard'. 
     C'est inutile et ça pollue ! Utilisez des logiciels comme Git (historique de versions) pour retrouver votre ancien code. Supprimez-le !

- ❌ Oublier les commentaires XML (///).
     Surtout sur vos méthodes publiques. Ce sont eux qui génèrent la documentation automatique et qui font apparaître les bulles d'aide quand vos collègues tapent votre code dans l'éditeur.");

            Console.WriteLine("\nFélicitations, vous maîtrisez maintenant l'art de documenter comme un expert !");
        }
    }
}
