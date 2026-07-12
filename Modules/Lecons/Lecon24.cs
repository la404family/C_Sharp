using System;

namespace MonPremierProjet.Modules.Lecons
{
    public class Lecon24
    {
        private static int champDeClasseStatique = 100;
        private int champDInstance = 50;

        public static void Afficher()
        {
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 29 : LA PORTEE (SCOPE) ---\n");
            
            Console.WriteLine("1. VARIABLE LOCALE VS GLOBALE");
            Console.WriteLine("-----------------------------");
            
            int variableLocale = 10;
            Console.WriteLine($"Variable locale : {variableLocale}");
            Console.WriteLine($"Champ statique global : {champDeClasseStatique}");
            
            Console.WriteLine("\n2. PORTEE DE BLOC (BLOCK SCOPE)");
            Console.WriteLine("-------------------------------");
            
            if (variableLocale == 10)
            {
                int variableDeBloc = 5;
                Console.WriteLine($"Dans le if, variableDeBloc existe et vaut : {variableDeBloc}");
            }
            
            Console.WriteLine("En dehors du if, variableDeBloc n'existe plus en mémoire.");
            
            Console.WriteLine("\nAppuyez sur Entrée pour continuer...");
            Console.ReadLine();
        }
    }
}
