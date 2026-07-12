using System;

namespace MonPremierProjet.Modules.Lecons
{
    public class Lecon23
    {
        public static void Afficher()
        {
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 28 : CONSTANTES ET PRECISION ---\n");
            
            Console.WriteLine("1. LES CONSTANTES");
            Console.WriteLine("-----------------");
            
            const double PI = 3.14159;
            const string MESSAGE = "Bienvenue !";
            
            Console.WriteLine("Valeur de PI : " + PI);
            Console.WriteLine("Message fixe : " + MESSAGE);
            
            Console.WriteLine("\n2. LES TYPES SPECIFIQUES");
            Console.WriteLine("------------------------");
            
            float positionX = 1.5f;
            decimal prixExact = 19.99m;
            char lettre = 'A';
            
            Console.WriteLine("Type float   (f) : " + positionX);
            Console.WriteLine("Type decimal (m) : " + prixExact);
            Console.WriteLine("Type char        : " + lettre);
            
            Console.WriteLine("\nAppuyez sur Entrée pour continuer...");
            Console.ReadLine();
        }
    }
}
