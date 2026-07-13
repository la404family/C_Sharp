using System;

namespace MonPremierProjet.Modules.Lecons
{
    public class Lecon27
    {
        public static void Afficher()
        {
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 33 : LE PARAMETRE DE SORTIE (out) ---\n");
            
            Console.WriteLine("Le mot-clé 'out' permet à une méthode de renvoyer PLUSIEURS résultats à la fois.");
            Console.WriteLine("Contrairement à 'ref', la variable N'A PAS BESOIN d'être initialisée avant !");
            Console.WriteLine("Mais la méthode a l'OBLIGATION d'y mettre une valeur avant de se terminer.\n");
            
            int positionX;
            int positionY;
            
            Console.WriteLine("Appel de la méthode ObtenirCoordonnees(out positionX, out positionY)...");
            ObtenirCoordonnees(out positionX, out positionY);
            
            Console.WriteLine($"Le GPS a renvoyé les coordonnées : X={positionX}, Y={positionY}");
            
            Console.WriteLine("\n--- LE CAS D'USAGE LE PLUS CONNU : TryParse ---");
            Console.WriteLine("TryParse renvoie 'true' ou 'false', mais remplit aussi une variable 'out' avec le résultat !");
            
            Console.Write("\nTapez un nombre (ou du texte pour faire échouer) : ");
            string saisie = Console.ReadLine() ?? "";
            
            bool reussite = int.TryParse(saisie, out int nombreConverti);
            
            if (reussite)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nSuccès ! La variable 'out' contient le nombre : {nombreConverti}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nÉchec ! Le texte saisi n'était pas un nombre entier.");
                Console.WriteLine($"La variable 'out' vaut 0 par défaut : {nombreConverti}");
                Console.ResetColor();
            }
            
            Console.WriteLine("\nAppuyez sur Entrée pour continuer...");
            Console.ReadLine();
        }

        private static void ObtenirCoordonnees(out int x, out int y)
        {
            x = 100;
            y = 250;
        }
    }
}
