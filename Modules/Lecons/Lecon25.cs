using System;

namespace MonPremierProjet.Modules.Lecons
{
    public class Lecon25
    {
        public static void Afficher()
        {
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 30 : FLEXIBILITE ET CONVERSIONS ---\n");
            
            Console.WriteLine("1. LE TYPAGE IMPLICITE ET DYNAMIQUE");
            Console.WriteLine("-----------------------------------");
            
            var age = 30; 
            var prenom = "Alice"; 
            
            dynamic valeurMagique = 10;
            valeurMagique = "Maintenant du texte";
            
            Console.WriteLine($"var (déduit)    : age={age}, prenom={prenom}");
            Console.WriteLine($"dynamic (change): {valeurMagique}");
            
            Console.WriteLine("\n2. CONVERSIONS (CASTING ET PARSING)");
            Console.WriteLine("-----------------------------------");
            
            double d = 9.7;
            int i = (int)d; 
            
            Console.WriteLine($"Cast de double (9.7) vers int : {i}");
            
            Console.Write("\nTapez un nombre entier : ");
            string saisie = Console.ReadLine() ?? "0";
            
            if (int.TryParse(saisie, out int nombreConverti))
            {
                Console.WriteLine($"Conversion réussie ! Le double de votre nombre est : {nombreConverti * 2}");
            }
            else
            {
                Console.WriteLine("Ceci n'est pas un nombre valide !");
            }
            
            Console.WriteLine("\nAppuyez sur Entrée pour continuer...");
            Console.ReadLine();
        }
    }
}
