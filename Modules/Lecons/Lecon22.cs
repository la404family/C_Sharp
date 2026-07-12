using System;

namespace MonPremierProjet.Modules.Lecons
{
    public class Lecon22
    {
        public static void Afficher()
        {
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 27 : LES VARIABLES FONDAMENTALES ---\n");
            
            Console.WriteLine("1. DECLARATION ET INITIALISATION");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("En C#, une variable doit toujours avoir un type défini.");
            
            int age = 30;
            string prenom = "Jean";
            double prix = 19.99;
            bool estActif = true;
            
            Console.WriteLine("Type int    : " + age);
            Console.WriteLine("Type string : " + prenom);
            Console.WriteLine("Type double : " + prix);
            Console.WriteLine("Type bool   : " + estActif);
            
            Console.WriteLine("\n2. CONCATENATION VS INTERPOLATION");
            Console.WriteLine("---------------------------------");
            
            string nomCompletConcat = prenom + " Dupont";
            Console.WriteLine("Concaténation (+) : " + nomCompletConcat);
            
            string phraseInterpolation = $"Bonjour {prenom}, vous avez {age} ans.";
            Console.WriteLine("Interpolation ($) : " + phraseInterpolation);
            
            Console.WriteLine("\nAppuyez sur Entrée pour continuer...");
            Console.ReadLine();
        }
    }
}
