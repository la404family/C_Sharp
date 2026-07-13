using System;

namespace MonPremierProjet.Modules.Lecons
{
    public class Lecon26
    {
        public static void Afficher()
        {
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 32 : LE PASSAGE PAR REFERENCE (ref) ---\n");
            
            Console.WriteLine("Par défaut, quand on donne une variable à une méthode, C# en fait une COPIE.");
            Console.WriteLine("Si la méthode modifie cette copie, l'original reste intact.");
            Console.WriteLine("\nMais avec le mot-clé 'ref', on donne l'ACCES DIRECT à la vraie variable !");
            
            int monScore = 5;
            Console.WriteLine($"\nScore initial du joueur : {monScore}");
            
            Console.WriteLine("Appel de la méthode AjouterDix(ref monScore)...");
            AjouterDix(ref monScore);
            
            Console.WriteLine($"Score après la méthode : {monScore}");
            Console.WriteLine("\nLe score a bien été modifié définitivement !");
            
            Console.WriteLine("\n--- EXEMPLE : ECHANGER DEUX PRENOMS ---");
            string joueurA = "Alice";
            string joueurB = "Bob";
            
            Console.WriteLine($"Avant échange : Joueur A = {joueurA}, Joueur B = {joueurB}");
            
            EchangerPrenoms(ref joueurA, ref joueurB);
            
            Console.WriteLine($"Après échange : Joueur A = {joueurA}, Joueur B = {joueurB}");
            
            Console.WriteLine("\nAttention : Une variable doit OBLIGATOIREMENT être initialisée avant d'utiliser 'ref'.");
            
            Console.WriteLine("\nAppuyez sur Entrée pour continuer...");
            Console.ReadLine();
        }

        private static void AjouterDix(ref int scoreInterne)
        {
            scoreInterne = scoreInterne + 10;
        }

        private static void EchangerPrenoms(ref string p1, ref string p2)
        {
            string memoire = p1;
            p1 = p2;
            p2 = memoire;
        }
    }
}
