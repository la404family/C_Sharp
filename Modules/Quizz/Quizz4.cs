using System;
using System.Linq;

namespace MonPremierProjet.Modules.Quizz
{
    /// <summary>
    /// Module d'évaluation numéro 4. Interroge l'utilisateur sur la fin des conventions (commentaires, orga, types, flux, exceptions).
    /// </summary>
    public class Quizz4
    {
        /// <summary>
        /// Exécute le quiz 4, pose 5 questions au hasard parmi 20, et met à jour le profil de l'élève.
        /// </summary>
        public static void Executer(Profil profilActuel)
        {
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 21 : QUATRIEME QUIZ D'EVALUATION ---\n");
            Console.WriteLine("Bienvenue dans votre ultime évaluation de ce premier grand module de conventions !");
            Console.WriteLine("Cette évaluation porte sur les Leçons 12 à 17.");
            Console.WriteLine("Nous allons vous poser 5 questions, tirées au hasard parmi une banque de 20 questions.");
            Console.WriteLine("Chaque bonne réponse rapporte 4 points, pour une note maximale de 20.\n");
            Console.WriteLine("Appuyez sur Entrée pour démarrer...");
            Console.ReadLine();

            Question[] banqueQuestions = new Question[]
            {
                new Question("Que doit prioritairement expliquer un bon commentaire ?", new string[] { "Le Quoi (ce que fait l'ordinateur)", "Le Pourquoi (le contexte métier ou la décision)", "Les erreurs de compilation", "Le nom des variables" }, 2),
                new Question("À quoi servent les commentaires de documentation XML (///) ?", new string[] { "À colorer le code", "À générer des bulles d'aide interactives (IntelliSense) pour les développeurs", "À empêcher le code de s'exécuter", "À corriger les bugs" }, 2),
                new Question("Que faut-il faire avec du code dont on ne se sert plus 'pour l'instant' ?", new string[] { "Le mettre en commentaire 'au cas où'", "Le supprimer et s'en remettre à Git (historique de version)", "Le mettre tout en bas du fichier", "Le colorier en rouge" }, 2),
                new Question("Quelle est la règle d'or concernant les fichiers et les classes ?", new string[] { "On peut mettre 10 classes par fichier", "Une Classe = Un Fichier", "Le fichier doit s'appeler 'Classes.cs'", "Les classes n'ont pas besoin de fichier" }, 2),
                new Question("Dans quel ordre les membres d'une classe doivent-ils idéalement apparaître ?", new string[] { "Méthodes, Propriétés, Champs, Constructeur", "Constructeur, Méthodes, Champs", "Champs privés, Constructeur, Propriétés, Méthodes publiques", "Peu importe" }, 3),
                new Question("Que faire si une méthode possède trop de niveaux d'imbrication (if dans if dans if...) ?", new string[] { "Ajouter des espaces", "Utiliser la technique du Retour Anticipé (Early Return)", "Supprimer les accolades", "Mettre des commentaires partout" }, 2),
                new Question("Quand est-il recommandé d'utiliser le mot-clé 'var' ?", new string[] { "Tout le temps", "Jamais", "Uniquement quand le type est ÉVIDENT en lisant la ligne", "Seulement pour les nombres" }, 3),
                new Question("Pourquoi ne faut-il pas utiliser 'var x = ObtenirValeur();' ?", new string[] { "Parce que 'x' est une mauvaise lettre", "Parce qu'on ne peut pas deviner le type de retour, ce qui rend le code illisible", "Parce que 'var' est interdit", "C'est une bonne pratique en réalité" }, 2),
                new Question("Quelle est la recommandation concernant les accolades pour un bloc 'if' d'une seule ligne ?", new string[] { "Elles sont inutiles", "Il faut toujours les mettre pour éviter des bugs d'indentation", "Elles sont interdites", "Il faut les mettre sur la même ligne" }, 2),
                new Question("Qu'est-ce qu'un 'Retour Anticipé' (Early Return) ?", new string[] { "Quitter le travail plus tôt", "Une touche du clavier", "Gérer les erreurs immédiatement et sortir de la méthode avec 'return'", "Renvoyer une erreur au client" }, 3),
                new Question("Pourquoi est-il extrêmement dangereux de faire 'catch (Exception) { }' sans aucun code dedans ?", new string[] { "Ça efface le disque dur", "L'erreur grave est 'avalée' en silence, impossible à déboguer", "Ça fait planter l'ordinateur", "C'est pourtant une bonne pratique" }, 2),
                new Question("Dans un try/catch, quelle est la grave conséquence d'utiliser 'throw ex;' au lieu de 'throw;' ?", new string[] { "Cela DÉTRUIT l'historique complet de l'erreur (stack trace)", "Cela fait planter le compilateur", "Cela met le programme en pause", "Aucune, c'est la même chose" }, 1),
                new Question("À quoi sert le bloc 'finally' ?", new string[] { "À terminer le programme", "À exécuter du code de nettoyage à la toute fin, QU'IL Y AIT EU UNE ERREUR OU NON", "À arrêter une boucle", "À envoyer un email" }, 2),
                new Question("Que permet de faire le fichier '.editorconfig' ?", new string[] { "Lancer le programme", "Configurer et imposer automatiquement les règles de formatage à ton éditeur", "Traduire le code", "Générer les commentaires" }, 2),
                new Question("Que fait la commande 'dotnet format' ?", new string[] { "Elle efface tout le code", "Elle formate un disque dur", "Elle parcourt le projet pour corriger l'indentation et les espaces automatiquement", "Elle compile le code" }, 3),
                new Question("Où place-t-on les directives 'using' (importation d'outils) ?", new string[] { "Au milieu de la classe", "Dans le constructeur", "Tout en haut du fichier", "À la fin du fichier" }, 3),
                new Question("Quelle est la règle concernant le recyclage d'une variable (ex: utiliser 'total' pour un int, puis un string) ?", new string[] { "C'est recommandé pour sauver de la mémoire", "C'est strictement interdit en C# (typage fort) et très mauvaise pratique", "C'est possible avec 'var'", "C'est autorisé uniquement dans les boucles" }, 2),
                new Question("Est-il recommandé de remplacer de simples 'if' par des 'try/catch' ?", new string[] { "Oui, c'est plus moderne", "Non, les exceptions coûtent très cher en mémoire et ne doivent servir qu'aux erreurs graves", "Oui, c'est obligatoire", "Ça n'a pas d'importance" }, 2),
                new Question("Que vérifient les outils appelés 'Analyzers' (comme StyleCop) ?", new string[] { "La vitesse d'exécution", "Les erreurs de formatage et de conventions pendant que vous tapez", "Les mots de passe", "Rien du tout" }, 2),
                new Question("Un commentaire qui explique l'inverse de ce que fait le code (obsolète) est...", new string[] { "Utile", "Sans importance", "Pire que de ne pas avoir de commentaire du tout", "Normal" }, 3)
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
                        Console.WriteLine("\n✅ Excellente réponse ! (+4 points)");
                        scoreObtenu += 4;
                    }
                    else
                    {
                        Console.WriteLine($"\n❌ Mauvaise réponse. La bonne réponse était la proposition numéro {questionActuelle.BonneReponse}.");
                    }
                }
                else
                {
                    Console.WriteLine($"\n⚠️ Saisie invalide ! Vous avez perdu cette question. La bonne réponse était la {questionActuelle.BonneReponse}.");
                }

                Console.WriteLine("\nAppuyez sur Entrée pour continuer...");
                Console.ReadLine();
            }

            profilActuel.ScoreTotal += scoreObtenu;
            profilActuel.NombreQuizTermines++;
            profilActuel.ScoresQuizz.Add(scoreObtenu);

            Afficheur.NettoyerEcran();
            Console.WriteLine("=== RESULTAT DU QUIZ 4 ===");
            Console.WriteLine("Félicitations, vous avez terminé cette évaluation finale des conventions !");
            Console.WriteLine($"Score obtenu à ce quiz : {scoreObtenu} / 20");
            
            if (profilActuel.NombreQuizTermines > 1)
            {
                double moyenne = Math.Round((double)profilActuel.ScoreTotal / profilActuel.NombreQuizTermines, 2);
                Console.WriteLine($"Moyenne générale finale : {moyenne} / 20\n");
            }
            
            if (scoreObtenu == 20)
                Console.WriteLine("C'est un sans faute, vous êtes paré pour développer en entreprise !");
            else if (scoreObtenu >= 12)
                Console.WriteLine("Très bon travail ! Vos connaissances sont solides.");
            else
                Console.WriteLine("Quelques erreurs, n'hésitez pas à relire les Leçons 12 à 17 !");
                
            Console.WriteLine("\nVos points ont été ajoutés à votre Profil global de l'application.");
        }
    }
}
