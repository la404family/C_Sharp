using System;

namespace MonPremierProjet.Modules.Lecons
{
    /// <summary>
    /// Contient le code de la leçon 16 : La Gestion des Exceptions.
    /// </summary>
    public class Lecon16
    {
        public static void Afficher()
        {
            Afficheur.NettoyerEcran();
            Console.WriteLine("--- ETAPE 19 : LA GESTION DES EXCEPTIONS ---\n");
            Console.WriteLine(@"Les *exceptions* sont des erreurs graves qui surviennent pendant l'exécution (ex: lire un fichier qui a été supprimé du disque dur). 
Les conventions de l'industrie dictent très clairement *comment* les attraper sans casser le programme.

--- 🔤 Syntaxe de Base ---

try
{
    // Le code dangereux à tenter (ex: lecture de fichier)
}
catch (FileNotFoundException ex)   // 1. On attrape d'abord les erreurs très précises
{
    // Traitement spécifique (On prévient que le fichier est introuvable)
}
catch (Exception ex)               // 2. On attrape les autres erreurs génériques en dernier
{
    // Traitement généralisé
}
finally
{
    // 3. Code qui s'exécute TOUJOURS à la fin (avec ou sans erreur)
    // Souvent utilisé pour fermer proprement les accès fichiers
}");
            
            Console.WriteLine("\nAppuyez sur une touche pour voir les erreurs à ne pas commettre...");
            Console.ReadKey();
            Afficheur.NettoyerEcran();

            Console.WriteLine(@"--- ⚠️ Erreurs Courantes (Et Dévastatrices) ---

- ❌ Le catch 'silencieux' (Avaler l'erreur).
  catch (Exception) { } 
  Pire pratique possible : une erreur grave se produit, mais le bloc est vide, le programme l'ignore et continue comme si de rien n'était. C'est impossible à déboguer par la suite.

- ❌ Remplacer les 'if' par des 'try/catch'.
  N'utilise pas try/catch pour tester si une variable est vide ou si un nombre est trop grand. Utilise un simple 'if'. Les exceptions coûtent très cher en mémoire à l'ordinateur.

- ❌ Détruire l'historique de l'erreur avec 'throw ex;'
  catch (Exception ex) 
  { 
      throw ex; // DÉTRUIT l'historique complet de l'erreur (la stack trace) !
  }
  
  // ✅ LA BONNE MÉTHODE
  catch (Exception)
  {
      throw; // Relance l'erreur d'origine vers le haut en gardant tout son contexte intact.
  }");
            
            Console.WriteLine("\nFélicitations, la gestion professionnelle des erreurs n'a plus de secret pour vous !");
        }
    }
}
