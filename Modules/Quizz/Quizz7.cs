using System;
using System.Linq;

namespace MonPremierProjet.Modules.Quizz
{
    public class Quizz7
    {
        public static void Executer(Profil profilActuel)
        {
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 34 : SEPTIEME QUIZ D'EVALUATION ---\n");
            Console.WriteLine("Bienvenue dans votre septième évaluation interactive !");
            Console.WriteLine("Cette évaluation porte sur le module Ref et Out (Leçons 26 et 27).");
            Console.WriteLine("Nous allons vous poser 5 questions tirées au hasard.");
            Console.WriteLine("Chaque bonne réponse rapporte 4 points, pour une note maximale de 20.\n");
            Console.WriteLine("Appuyez sur Entrée pour démarrer...");
            Console.ReadLine();

            Question[] banqueQuestions = new Question[]
            {
                new Question("Que signifie le passage par 'valeur' (comportement par défaut en C#) ?", new string[] { "Un lien direct vers la variable est envoyé", "Une copie de la variable est envoyée à la méthode", "La variable est supprimée après la méthode", "La variable devient constante" }, 2),
                new Question("Que permet de faire le mot-clé 'ref' ?", new string[] { "Renvoyer plusieurs résultats", "Passer une variable par référence, donnant un accès direct à l'original", "Rafraîchir l'écran", "Effacer la mémoire" }, 2),
                new Question("Quelle est la condition absolue pour passer une variable avec 'ref' ?", new string[] { "Elle doit être nulle", "Elle ne doit contenir que des chiffres", "Elle doit obligatoirement être initialisée avant l'appel", "Elle doit être statique" }, 3),
                new Question("Où doit-on écrire le mot-clé 'ref' dans le code ?", new string[] { "Uniquement dans la déclaration de la méthode", "Uniquement lors de l'appel", "Dans la déclaration de la méthode ET lors de son appel", "Au début du fichier" }, 3),
                new Question("Que se passe-t-il si la méthode modifie une variable passée avec 'ref' ?", new string[] { "La variable d'origine est définitivement modifiée", "Seule la copie locale est modifiée", "Le programme plante", "La modification est annulée à la fin" }, 1),
                new Question("Dans quel but principal utilise-t-on le mot-clé 'out' ?", new string[] { "Pour quitter le programme", "Pour afficher du texte", "Pour renvoyer plusieurs résultats depuis une seule méthode", "Pour optimiser la mémoire" }, 3),
                new Question("Quelle est la différence majeure de 'out' par rapport à 'ref' concernant l'initialisation ?", new string[] { "Avec 'out', la variable n'a pas besoin d'être initialisée avant", "Avec 'out', la variable doit être à zéro", "Il n'y a aucune différence", "'out' nécessite une constante" }, 1),
                new Question("Quelle est l'obligation absolue d'une méthode recevant un paramètre 'out' ?", new string[] { "Elle doit renvoyer true", "Elle doit obligatoirement lui assigner une valeur avant de se terminer", "Elle ne doit pas modifier la variable", "Elle doit s'exécuter en moins d'une seconde" }, 2),
                new Question("Que renvoie la méthode 'int.TryParse' comme résultat principal (le 'return') ?", new string[] { "Le texte converti", "Un booléen indiquant le succès ou l'échec de la conversion", "Un code d'erreur", "Rien (void)" }, 2),
                new Question("Où se trouve le résultat numérique converti lors de l'utilisation de 'int.TryParse' ?", new string[] { "Dans la console", "Dans le return", "Dans la variable passée avec le mot-clé 'out'", "Dans un fichier texte" }, 3),
                new Question("Que se passe-t-il si on oublie de mettre 'ref' lors de l'appel d'une méthode l'exigeant ?", new string[] { "Le compilateur génère une erreur", "Le code s'exécute mais la variable n'est pas modifiée", "Le C# ajoute le 'ref' automatiquement", "Le programme se ferme" }, 1),
                new Question("Comment appelle-t-on le fait de déclarer la variable directement dans l'appel (ex: out int nombre) ?", new string[] { "L'affectation encastrée (Inline)", "Le casting", "Le parsing", "L'encapsulation" }, 1),
                new Question("Est-il recommandé d'utiliser 'ref' partout pour modifier des variables ?", new string[] { "Oui, c'est plus propre", "Non, cela rend l'architecture imprévisible et difficile à déboguer", "Oui, c'est beaucoup plus rapide", "C'est obligatoire en C#" }, 2),
                new Question("Que se passe-t-il si 'int.TryParse' échoue à convertir le texte \"Salut\" ?", new string[] { "Le jeu plante (Crash)", "Il renvoie false et met 0 dans la variable 'out'", "Il renvoie true et met null", "Il ferme la console" }, 2),
                new Question("Peut-on utiliser 'out' pour passer une variable qui contient déjà une donnée importante à conserver ?", new string[] { "Oui, la donnée sera protégée", "Oui, la méthode ajoutera à la suite", "Non, car la méthode écrasera obligatoirement cette valeur avec son propre résultat", "Seulement si c'est un texte" }, 3),
                new Question("Quelle fonctionnalité moderne du C# remplace souvent l'usage abusif de 'out' pour renvoyer plusieurs valeurs ?", new string[] { "Les listes", "Les Tuples", "Les boucles foreach", "Les pointeurs" }, 2),
                new Question("Pourquoi le C# oblige-t-il à réécrire 'ref' lors de l'appel de la méthode ?", new string[] { "Pour avertir visuellement le développeur que sa variable risque d'être modifiée", "Parce que le compilateur est bête", "Pour ralentir l'exécution", "C'est une erreur de conception du langage" }, 1),
                new Question("Quel type de méthode est l'exemple le plus courant et quotidien de l'utilisation de 'out' ?", new string[] { "L'affichage de texte", "Les méthodes de parsing sécurisé comme 'TryParse'", "Le calcul de l'âge", "La sauvegarde de fichier" }, 2),
                new Question("Si on passe une variable SANS le mot-clé 'ref', la méthode peut-elle la modifier de façon globale ?", new string[] { "Oui, toujours", "Oui, si c'est un int", "Non, elle ne modifiera que sa copie locale", "Seulement sur Windows" }, 3),
                new Question("Peut-on passer plusieurs paramètres 'ref' ou 'out' à la même méthode ?", new string[] { "Non, c'est limité à un seul", "Seulement deux maximum", "Oui, on peut tout à fait en combiner plusieurs", "Oui, mais uniquement des 'out'" }, 3)
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
            Console.WriteLine("=== RESULTAT DU QUIZ 7 ===");
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
                Console.WriteLine("C'est un sans faute, vous maîtrisez l'adressage mémoire !");
            else if (scoreObtenu >= 12)
                Console.WriteLine("Très bon travail ! Les concepts de ref et out sont bien assimilés.");
            else
                Console.WriteLine("Quelques erreurs, n'hésitez pas à relire la fiche sur Ref et Out !");
                
            Console.WriteLine("\nVos points ont été ajoutés à votre Profil global de l'application.");
        }
    }
}
