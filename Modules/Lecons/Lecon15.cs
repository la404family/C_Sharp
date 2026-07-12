using System;

namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Contient le code de la leçon 15 : Les Accolades et le Flux de contrôle.
    /// </summary>
    public class Lecon15
    {
        public static void Afficher()
        {
            Afficheur.NettoyerEcran();
            Console.WriteLine("--- ETAPE 18 : LE FLUX DE CONTRÔLE ET LES ACCOLADES ---\n");
            Console.WriteLine(@"En C#, les accolades { } délimitent les blocs de code. Même quand le compilateur les rend optionnelles (pour un 'if' d'une seule ligne par exemple), les conventions recommandent de *toujours* les mettre.

--- 🔤 Syntaxe de Base ---

// ✅ RECOMMANDÉ — Toujours mettre les accolades
if (estMajeur)
{
    Entrer();
}

// ❌ DÉCONSEILLÉ — Accolades manquantes (risque énorme de bug)
if (estMajeur)
    Entrer();");
            
            Console.WriteLine("\nAppuyez sur une touche pour comprendre le danger de cet oubli...");
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- 💡 Pourquoi l'oubli d'accolades est-il si dangereux ? ---

Voici le fameux bug de la ligne manquante qui a causé des failles de sécurité monumentales dans l'industrie :

// ❌ DANGEREUX — L'indentation est trompeuse pour l'oeil humain
if (estConnecte)
    Console.WriteLine(""Bienvenue"");
    ChargerProfil();   // ⚠️ PIÈGE ! Cette ligne s'exécutera TOUJOURS, 
                       // même si estConnecte est 'false'.
                       // L'ordinateur considère que le 'if' ne couvre que la première ligne !

// ✅ SÉCURISÉ — Avec les accolades, aucune ambiguïté possible
if (estConnecte)
{
    Console.WriteLine(""Bienvenue"");
    ChargerProfil();   // Ne s'exécute QUE si estConnecte est 'true'
}");
            
            Console.WriteLine("\nAppuyez sur une touche pour découvrir la technique du 'Retour Anticipé'...");
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- 🚀 Technique Pro : L'Early Return (Retour Anticipé) ---

Un code propre ne doit pas avoir trop de niveaux d'indentation (les 'if' dans des 'if' dans des 'if').
On utilise des 'retours anticipés' pour régler les cas d'erreur immédiatement et sortir de la méthode.

// ❌ MAUVAIS — L'effet 'Flèche' ou 'Arrow anti-pattern' (trop imbriqué)
if (commande != null)
{
    if (commande.EstPayee)
    {
        return ""Validé"";
    }
}

// ✅ BON — Retour anticipé (le code reste plat et lisible)
if (commande == null)
{
    return ""Introuvable""; // On gère l'erreur tout de suite et on sort !
}

if (!commande.EstPayee)
{
    return ""Non payé"";    // On gère l'autre erreur et on sort !
}

return ""Validé"";           // Le cas idéal se place à la fin, sans aucune imbrication.");
            
            Console.WriteLine("\nFélicitations, vous venez de faire un pas de géant vers un code fluide !");
        }
    }
}
