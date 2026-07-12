// On utilise System pour les fonctionnalités de base (Console, Random).
using System;
// On utilise System.Linq pour avoir accès à des outils avancés de manipulation de tableaux (comme OrderBy).
using System.Linq;

// L'espace de noms regroupe ce code avec les autres modules de quiz.
namespace MonPremierProjet.Modules.Quizz
{
    /// <summary>
    /// Module d'évaluation numéro 1. Il interroge l'utilisateur sur les 5 premières leçons.
    /// </summary>
    public class Quizz1
    {
        /// <summary>
        /// Exécute le quiz, pose 5 questions au hasard, et met à jour le profil de l'élève.
        /// </summary>
        // La méthode "Executer" reçoit la boîte "profilActuel" pour pouvoir modifier ses scores à la fin.
        public static void Executer(Profil profilActuel)
        {
            // On s'assure que la console est parfaitement propre.
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 6 : PREMIER QUIZ D'EVALUATION ---\n");
            Console.WriteLine("Bienvenue dans votre première évaluation interactive !");
            Console.WriteLine("Nous allons vous poser 5 questions, tirées au hasard parmi une banque de 20 questions.");
            Console.WriteLine("Chaque bonne réponse rapporte 4 points, pour une note maximale de 20.\n");
            Console.WriteLine("Appuyez sur Entrée pour démarrer...");
            Console.ReadLine();

            // Création de la banque de 20 questions.
            // On utilise un Tableau de type "Question" (notre classe Conteneur créée spécifiquement).
            Question[] banqueQuestions = new Question[]
            {
                new Question("Qui a popularisé la tradition du 'Hello World' ?", new string[] { "Bill Gates", "Brian Kernighan", "Steve Jobs", "Linus Torvalds" }, 2),
                new Question("En quelle année la tradition du 'Hello World' a-t-elle commencé ?", new string[] { "1978", "1990", "2000", "1965" }, 1),
                new Question("Quel langage était concerné par le premier 'Hello World' ?", new string[] { "Le C#", "Le Java", "Le langage C", "Le Python" }, 3),
                new Question("Que signifie 'IDE' dans le monde du développement ?", new string[] { "Interface De l'Ecran", "Integrated Development Environment", "Internal Data Execution", "Internet Developer Engine" }, 2),
                new Question("Quel est l'IDE le plus populaire créé par Microsoft pour C# ?", new string[] { "Eclipse", "Visual Studio", "IntelliJ", "Notepad++" }, 2),
                new Question("Quelle extension est fortement recommandée si l'on code en C# sur VS Code ?", new string[] { "Python", "C# Dev Kit", "Java Extension", "Prettier" }, 2),
                new Question("Qu'est-ce qu'un projet de type 'Console' ?", new string[] { "Un jeu vidéo pour console de salon", "Un programme pur texte, sans fenêtres graphiques", "Une application mobile", "Un site web interactif" }, 2),
                new Question("Pourquoi est-il crucial d'avoir un code dit 'Modulaire' ?", new string[] { "Pour rendre le code plus lent", "Pour séparer les responsabilités et garder un code lisible", "Pour utiliser moins de mémoire vive", "Pour complexifier le travail" }, 2),
                new Question("A quoi sert le fichier Program.cs ?", new string[] { "A sauvegarder les données utilisateur", "A compiler le projet automatiquement", "C'est le point d'entrée principal (le chef d'orchestre)", "A générer la documentation" }, 3),
                new Question("Quel fichier contient la configuration de compilation pour .NET ?", new string[] { "README.md", "MonPremierProjet.csproj", "LancerProjet.bat", "progression.txt" }, 2),
                new Question("A quoi nous sert le fichier LancerProjet.bat ?", new string[] { "A automatiser la compilation et l'exécution d'un double-clic", "A dessiner des fenêtres animées", "A stocker la progression", "A nettoyer le disque dur" }, 1),
                new Question("Quel est le but d'un fichier README.md ?", new string[] { "Compiler le code source", "Stocker des mots de passe", "Servir de manuel d'accueil et de vitrine au projet", "Faire des calculs mathématiques" }, 3),
                new Question("En quelle année le langage C# a-t-il été créé ?", new string[] { "1978", "1995", "2000", "2010" }, 3),
                new Question("Parmi ces propositions, quelle est une caractéristique clé du C# ?", new string[] { "Typage faible et dynamique", "Gestion manuelle de la mémoire (pas de Garbage Collector)", "Typage fort et statique", "C'est un langage exclusivement fonctionnel" }, 3),
                new Question("Qu'est-ce que la plateforme .NET ?", new string[] { "Un vieux langage de programmation", "L'environnement d'exécution (runtime) qui fait tourner C#", "Un navigateur web moderne", "Un composant matériel de l'ordinateur" }, 2),
                new Question("Quelle technologie de l'écosystème permet de créer des jeux vidéo (2D/3D) ?", new string[] { "Blazor", "ASP.NET Core", ".NET MAUI", "Unity" }, 4),
                new Question("Que permet de faire Blazor ?", new string[] { "Créer des scripts d'administration", "Faire de la modélisation 3D", "Créer des applications web interactives sans JavaScript", "Créer des bases de données SQL" }, 3),
                new Question("Lequel de ces termes est aujourd'hui considéré comme obsolète (legacy) ?", new string[] { ".NET Framework", "ASP.NET Core", ".NET 8+", "C#" }, 1),
                new Question("Quelle instruction C# permet de nettoyer l'écran visible du terminal ?", new string[] { "Console.Clear()", "Console.Write()", "System.Clean()", "Afficheur.Delete()" }, 1),
                new Question("Dans l'architecture de ce projet, quel dossier contient la documentation détaillée ?", new string[] { "Modules/", "INFOS/Architecture/", "Lecons/", "Quizz/" }, 2)
            };

            // On utilise la classe "Random" pour générer du hasard.
            Random generateur = new Random();
            
            // La technique (LINQ) "OrderBy" trie le tableau selon un critère aléatoire, puis "Take(5)" garde les 5 premiers éléments.
            // On convertit le résultat en tableau avec "ToArray()". C'est une façon très élégante de mélanger !
            Question[] questionsChoisies = banqueQuestions.OrderBy(x => generateur.Next()).Take(5).ToArray();

            // Variable pour garder en mémoire les points gagnés durant cette session.
            int scoreObtenu = 0;

            // La boucle "for" va répéter le code entre les accolades exactement pour la taille du tableau (5 fois).
            for (int i = 0; i < questionsChoisies.Length; i++)
            {
                Afficheur.NettoyerEcran();
                
                // On extrait la question en cours d'évaluation.
                Question questionActuelle = questionsChoisies[i];

                // On affiche le compteur (i commence à 0, donc on affiche i + 1).
                Console.WriteLine($"--- QUESTION {i + 1} / 5 ---\n");
                Console.WriteLine(questionActuelle.TexteQuestion);
                Console.WriteLine("--------------------------------------------------");
                
                // Une sous-boucle "for" pour afficher toutes les propositions liées à cette question.
                for (int j = 0; j < questionActuelle.Propositions.Length; j++)
                {
                    // "j + 1" sert à afficher un chiffre de 1 à 4 pour l'utilisateur, au lieu de l'index interne de 0 à 3.
                    Console.WriteLine($"{j + 1}. {questionActuelle.Propositions[j]}");
                }
                
                Console.WriteLine("--------------------------------------------------");
                Console.Write("\nVotre réponse (tapez 1, 2, 3 ou 4) : ");

                // On récupère la saisie clavier.
                string saisieUtilisateur = Console.ReadLine() ?? "";
                
                // "int.TryParse" tente de convertir le texte tapé en nombre entier (int).
                // L'immense avantage est que si l'utilisateur tape des lettres par erreur, cela ne fait pas planter (crash) le programme !
                if (int.TryParse(saisieUtilisateur, out int reponseChiffre))
                {
                    // On vérifie si la réponse numérique correspond à la bonne réponse stockée dans notre objet.
                    if (reponseChiffre == questionActuelle.BonneReponse)
                    {
                        Console.WriteLine("\n✅ Excellente réponse ! (+4 points)");
                        scoreObtenu += 4; // Ajout des points
                    }
                    else
                    {
                        Console.WriteLine($"\n❌ Mauvaise réponse. La bonne réponse était la proposition numéro {questionActuelle.BonneReponse}.");
                    }
                }
                else
                {
                    // Cas où la conversion en nombre a échoué.
                    Console.WriteLine($"\n⚠️ Saisie invalide ! Vous avez perdu cette question. La bonne réponse était la {questionActuelle.BonneReponse}.");
                }

                Console.WriteLine("\nAppuyez sur Entrée pour continuer...");
                Console.ReadLine();
            }

            // --- Fin du quiz, on met à jour les données du joueur ---
            profilActuel.ScoreTotal += scoreObtenu;
            profilActuel.NombreQuizTermines++;

            // Affichage de la page de résultat du quiz.
            Afficheur.NettoyerEcran();
            Console.WriteLine("=== RESULTAT DU QUIZ ===");
            Console.WriteLine("Félicitations, vous avez terminé cette évaluation !");
            Console.WriteLine($"Score obtenu à ce quiz : {scoreObtenu} / 20\n");
            
            // "if / else if / else" permet d'afficher un message personnalisé selon le score.
            if (scoreObtenu == 20)
                Console.WriteLine("C'est un sans faute, vous maîtrisez parfaitement le sujet !");
            else if (scoreObtenu >= 12)
                Console.WriteLine("Très bon travail ! Vos connaissances sont solides.");
            else
                Console.WriteLine("Il y a quelques lacunes, n'hésitez pas à relire les leçons précédentes.");
                
            Console.WriteLine("\nVos points ont été ajoutés à votre Profil global de l'application.");
        }
    }
}
