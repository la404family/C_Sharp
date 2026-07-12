using System;
using System.Linq;

namespace MonPremierProjet.Modules.Quizz
{
    public class Quizz6
    {
        public static void Executer(Profil profilActuel)
        {
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 31 : SIXIEME QUIZ D'EVALUATION ---\n");
            Console.WriteLine("Bienvenue dans votre sixième évaluation interactive !");
            Console.WriteLine("Cette évaluation porte sur le module des Variables (Leçons 22 à 25).");
            Console.WriteLine("Nous allons vous poser 5 questions tirées au hasard.");
            Console.WriteLine("Chaque bonne réponse rapporte 4 points, pour une note maximale de 20.\n");
            Console.WriteLine("Appuyez sur Entrée pour démarrer...");
            Console.ReadLine();

            Question[] banqueQuestions = new Question[]
            {
                new Question("Quel type de variable permet de stocker du texte ?", new string[] { "int", "char", "string", "bool" }, 3),
                new Question("Quel type de variable utiliseriez-vous pour stocker l'âge d'une personne ?", new string[] { "double", "int", "string", "var" }, 2),
                new Question("Quelle valeur peut contenir une variable de type 'bool' ?", new string[] { "true ou false", "0 ou 1", "Oui ou Non", "N'importe quel texte" }, 1),
                new Question("Quel suffixe est obligatoire lors de l'initialisation d'un type 'decimal' ?", new string[] { "f", "d", "c", "m" }, 4),
                new Question("Quel suffixe est utilisé pour initialiser un 'float' (simple précision) ?", new string[] { "f", "l", "m", "Aucun" }, 1),
                new Question("À quoi sert le mot-clé 'const' ?", new string[] { "À créer une constante immuable qui ne changera jamais", "À définir un constructeur", "À empêcher la compilation", "À définir une variable de classe" }, 1),
                new Question("Quel caractère spécial utilise-t-on pour l'interpolation de chaîne ?", new string[] { "&", "$", "#", "@" }, 2),
                new Question("Qu'est-ce qu'une variable 'locale' ?", new string[] { "Une variable partagée sur le réseau", "Une variable déclarée dans une classe", "Une variable déclarée dans une méthode, accessible uniquement dans celle-ci", "Une variable globale" }, 3),
                new Question("Qu'est-ce qu'un champ de classe (ou variable d'instance) ?", new string[] { "Une variable déclarée en dehors des méthodes, accessible dans toute la classe", "Une variable temporaire", "Une constante", "Une variable détruite à la fin du bloc" }, 1),
                new Question("Quelle est la valeur par défaut d'un champ de classe de type 'int' s'il n'est pas initialisé ?", new string[] { "null", "0", "-1", "Une erreur de compilation" }, 2),
                new Question("Quelle est la valeur par défaut d'un champ de classe de type 'bool' s'il n'est pas initialisé ?", new string[] { "true", "null", "false", "0" }, 3),
                new Question("Que se passe-t-il si vous tentez d'utiliser une variable locale sans l'avoir initialisée ?", new string[] { "Elle vaut 0 par défaut", "Elle vaut null", "Le compilateur génère une erreur", "Le programme plante à l'exécution" }, 3),
                new Question("Que fait le mot-clé 'var' en C# ?", new string[] { "Il crée une variable sans type", "Il demande au compilateur de déduire le type lors de la compilation", "Il crée une variable dynamique", "Il est interdit en C#" }, 2),
                new Question("Quelle est la principale caractéristique de 'dynamic' par rapport à 'var' ?", new string[] { "Aucune, c'est la même chose", "Le type est résolu à l'exécution et peut changer, contrairement à var", "dynamic est plus rapide", "var est utilisé pour le web, dynamic pour la console" }, 2),
                new Question("Comment appelle-t-on la conversion forcée d'un type vers un autre avec des parenthèses, ex: (int)d ?", new string[] { "Le Casting explicite", "Le Parsing", "L'Inférence", "Le Boxage" }, 1),
                new Question("Que se passe-t-il lors du casting explicite d'un 'double' vers un 'int' ?", new string[] { "Le nombre est arrondi à l'entier le plus proche", "La partie décimale est purement et simplement supprimée (tronquée)", "Une erreur se produit", "Le type reste double" }, 2),
                new Question("Quelle méthode utiliseriez-vous pour convertir de force la chaîne \"123\" en entier ?", new string[] { "int.Convert(\"123\")", "(int)\"123\"", "int.Parse(\"123\")", "\"123\".ToInt()" }, 3),
                new Question("Quel est l'énorme avantage de int.TryParse() par rapport à int.Parse() ?", new string[] { "Il est plus rapide", "Il ne fait pas planter le programme (crash) si le texte n'est pas un nombre valide", "Il convertit aussi les lettres", "Il renvoie un double" }, 2),
                new Question("Quelle est la portée d'une variable déclarée à l'intérieur d'un bloc 'if' ?", new string[] { "Toute la classe", "Toute la méthode", "Uniquement à l'intérieur de ce bloc if", "Partout dans le programme" }, 3),
                new Question("Qu'est-ce qu'une variable 'statique' (static) ?", new string[] { "Une variable qui ne bouge pas (constante)", "Une variable partagée par TOUTES les instances de la classe", "Une variable propre à chaque objet", "Une variable stockée sur le disque dur" }, 2)
            };

            Random generateur = new Random();
            
            Question[] questionsChoisies = banqueQuestions.OrderBy(x => generateur.Next()).Take(5).ToArray();

            int scoreObtenu = 0;

            for (int i = 0; i < questionsChoisies.Length; i++)
            {
                Afficheur.NettoyerEcran();
                
                Question questionActuelle = questionsChoisies[i];

                Console.WriteLine($"--- QUESTION {i + 1} / 5 ---\n");
                Console.WriteLine(questionActuelle.TexteQuestion);
                Console.WriteLine("--------------------------------------------------");
                
                for (int j = 0; j < questionActuelle.Propositions.Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {questionActuelle.Propositions[j]}");
                }
                
                Console.WriteLine("--------------------------------------------------");
                Console.Write("\nVotre réponse (tapez 1, 2, 3 ou 4) : ");

                string saisieUtilisateur = Console.ReadLine() ?? "";
                
                if (int.TryParse(saisieUtilisateur, out int reponseChiffre))
                {
                    if (reponseChiffre == questionActuelle.BonneReponse)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n✅ Excellente réponse ! (+4 points)");
                        Console.ResetColor();
                        scoreObtenu += 4;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n❌ Mauvaise réponse. La bonne réponse était la proposition numéro {questionActuelle.BonneReponse}.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n⚠️ Saisie invalide ! Vous avez perdu cette question. La bonne réponse était la {questionActuelle.BonneReponse}.");
                    Console.ResetColor();
                }

                Console.WriteLine("\nAppuyez sur Entrée pour continuer...");
                Console.ReadLine();
            }

            profilActuel.ScoreTotal += scoreObtenu;
            profilActuel.NombreQuizTermines++;
            profilActuel.ScoresQuizz.Add(scoreObtenu);

            Afficheur.NettoyerEcran();
            Console.WriteLine("=== RESULTAT DU QUIZ 6 ===");
            Console.WriteLine("Félicitations, vous avez terminé cette évaluation !");
            Console.WriteLine($"Score obtenu à ce quiz : {scoreObtenu} / 20");
            
            if (profilActuel.NombreQuizTermines > 1)
            {
                double moyenne = Math.Round((double)profilActuel.ScoreTotal / profilActuel.NombreQuizTermines, 2);
                Console.WriteLine($"Moyenne générale actuelle : {moyenne} / 20\n");
            }
            else
            {
                Console.WriteLine();
            }
            
            if (scoreObtenu == 20)
                Console.WriteLine("C'est un sans faute, les variables n'ont plus de secret pour vous !");
            else if (scoreObtenu >= 12)
                Console.WriteLine("Très bon travail ! Vous maîtrisez bien les bases des données.");
            else
                Console.WriteLine("Quelques erreurs, n'hésitez pas à relire la fiche sur les Variables !");
                
            Console.WriteLine("\nVos points ont été ajoutés à votre Profil global de l'application.");
        }
    }
}
