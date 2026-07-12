// On utilise System pour les fonctionnalités de base (Console, Random).
using System;
// On utilise System.Linq pour manipuler nos tableaux facilement.
using System.Linq;

// L'espace de noms regroupe ce code avec les autres modules de quiz.
namespace MonPremierProjet.Modules.Quizz
{
    /// <summary>
    /// Module d'évaluation numéro 3. Interroge l'utilisateur sur les conventions de nommage et de formatage.
    /// </summary>
    public class Quizz3
    {
        /// <summary>
        /// Exécute le quiz 3, pose 5 questions au hasard parmi 20, et met à jour le profil de l'élève.
        /// </summary>
        // La méthode "Executer" reçoit la boîte "profilActuel" pour pouvoir modifier ses scores à la fin.
        public static void Executer(Profil profilActuel)
        {
            // On s'assure que la console est parfaitement propre.
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 14 : TROISIEME QUIZ D'EVALUATION ---\n");
            Console.WriteLine("Bienvenue dans votre troisième évaluation interactive !");
            Console.WriteLine("Cette évaluation porte sur les Conventions de Nommage et de Formatage (Leçons 9, 10, 11).");
            Console.WriteLine("Nous allons vous poser 5 questions, tirées au hasard parmi une banque de 20 questions.");
            Console.WriteLine("Chaque bonne réponse rapporte 4 points, pour une note maximale de 20.\n");
            Console.WriteLine("Appuyez sur Entrée pour démarrer...");
            Console.ReadLine();

            // Création de la banque de 20 questions.
            // On utilise le même modèle que pour les quiz précédents.
            Question[] banqueQuestions = new Question[]
            {
                new Question("Quel style de casse commence par une majuscule à chaque mot (ex: CalculerPrix) ?", new string[] { "camelCase", "PascalCase", "snake_case", "UPPER_CASE" }, 2),
                new Question("Pour quels éléments utilise-t-on le PascalCase en C# ?", new string[] { "Variables locales et paramètres", "Champs privés", "Classes, méthodes et propriétés", "Uniquement les interfaces" }, 3),
                new Question("Quel style est utilisé pour les variables locales et les paramètres de méthodes ?", new string[] { "camelCase", "PascalCase", "_camelCase", "UPPER_CASE" }, 1),
                new Question("Quelle est la convention pour un champ privé au sein d'une classe ?", new string[] { "PascalCase", "camelCase", "_camelCase", "UPPER_CASE" }, 3),
                new Question("Quel préfixe est obligatoire devant le nom d'une Interface ?", new string[] { "La lettre A", "Le mot Base", "La lettre I majuscule", "Un underscore (_)" }, 3),
                new Question("Parmi ces propositions, laquelle est bien nommée pour une classe ?", new string[] { "gestionnaireClient", "GestionnaireClient", "_gestionnaireClient", "GESTIONNAIRE_CLIENT" }, 2),
                new Question("Quelle est la recommandation officielle de Microsoft pour le nommage des Constantes ?", new string[] { "PascalCase", "UPPER_CASE", "camelCase", "minuscules" }, 1),
                new Question("Comment doit-on placer l'accolade d'ouverture '{' en C# (Style Allman) ?", new string[] { "A la fin de la ligne courante", "Sur une nouvelle ligne, toute seule", "Où l'on veut", "Indulgent tant qu'il y a un espace" }, 2),
                new Question("Combien d'espaces utilise-t-on traditionnellement pour une indentation en C# ?", new string[] { "2 espaces", "8 espaces", "4 espaces (ou 1 tabulation)", "Aucun espace" }, 3),
                new Question("Quelle est la bonne pratique concernant les opérateurs mathématiques (ex: +) ?", new string[] { "Coller les valeurs (5+3)", "Mettre un espace autour (5 + 3)", "Aller à la ligne après (5 +\n3)", "Mettre entre parenthèses ((5)+(3))" }, 2),
                new Question("Quelle est la bonne syntaxe pour appeler une méthode ?", new string[] { "Console.WriteLine(\"Test\")", "Console.WriteLine (\"Test\")", "Console.WriteLine_(\"Test\")", "Console.WriteLine. \"Test\"" }, 1),
                new Question("Combien de lignes vides faut-il idéalement laisser entre deux méthodes ?", new string[] { "Aucune", "Exactement 1 ligne vide", "Au moins 3 lignes vides", "Peu importe" }, 2),
                new Question("Quel est l'ordre recommandé pour ranger les éléments dans une classe ?", new string[] { "Méthodes, Constructeur, Champs", "Champs privés, Constructeur, Propriétés, Méthodes", "Propriétés, Méthodes privées, Champs", "Constructeur, Méthodes, Champs" }, 2),
                new Question("Dans l'organisation d'un fichier, où place-t-on les instructions 'using' ?", new string[] { "A la toute fin du fichier", "Dans le constructeur", "Tout en haut du fichier, triées par ordre alphabétique", "Juste avant les méthodes" }, 3),
                new Question("Qu'est-ce qu'une Interface en programmation ?", new string[] { "Un menu avec des boutons", "Un 'contrat' qui oblige une classe à posséder certains éléments", "Une variable temporaire", "Un outil de compilation" }, 2),
                new Question("Qu'est-ce qu'un Constructeur ?", new string[] { "Le compilateur Roslyn", "La personne qui a créé C#", "La méthode spéciale appelée au moment de la création d'un objet", "Un champ privé" }, 3),
                new Question("A quoi sert le mot-clé 'throw' croisé dans l'exemple avancé ?", new string[] { "A lancer une boucle", "A supprimer une variable", "A déclencher (lever) une erreur logicielle personnalisée", "A formater le texte" }, 3),
                new Question("Quelle est la longueur maximale recommandée pour une ligne de code ?", new string[] { "50 caractères", "80 caractères", "120 caractères", "Pas de limite" }, 3),
                new Question("Qu'est-ce qu'une propriété publique ?", new string[] { "Une donnée interne cachée", "Une variable temporaire dans une méthode", "Une donnée publique exposée par un objet", "Une constante" }, 3),
                new Question("Qu'est-ce qu'une variable locale ?", new string[] { "Une variable partagée par tout le programme", "Une variable temporaire qui n'existe que le temps qu'une méthode s'exécute", "Une constante globale", "Un champ privé de la classe" }, 2)
            };

            // On utilise la classe "Random" pour générer du hasard.
            Random generateur = new Random();
            
            // On mélange aléatoirement les questions et on en garde 5.
            Question[] questionsChoisies = banqueQuestions.OrderBy(x => generateur.Next()).Take(5).ToArray();

            int scoreObtenu = 0;

            // La boucle "for" va répéter le code pour poser les 5 questions.
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

            // --- Fin du quiz, on met à jour les données du joueur ---
            profilActuel.ScoreTotal += scoreObtenu;
            profilActuel.NombreQuizTermines++;
            // On enregistre également la note spécifique de ce quiz dans notre Liste pour le récapitulatif final.
            profilActuel.ScoresQuizz.Add(scoreObtenu);

            Afficheur.NettoyerEcran();
            Console.WriteLine("=== RESULTAT DU QUIZ 3 ===");
            Console.WriteLine("Félicitations, vous avez terminé cette évaluation !");
            Console.WriteLine($"Score obtenu à ce quiz : {scoreObtenu} / 20");
            
            // Si l'élève a terminé plus d'un quiz, on calcule et affiche sa moyenne globale.
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
                Console.WriteLine("C'est un sans faute, vous codez déjà de manière parfaitement lisible !");
            else if (scoreObtenu >= 12)
                Console.WriteLine("Très bon travail ! Vos connaissances sur les conventions sont solides.");
            else
                Console.WriteLine("Quelques erreurs, n'hésitez pas à relire les Leçons 9, 10 et 11 !");
                
            Console.WriteLine("\nVos points ont été ajoutés à votre Profil global de l'application.");
        }
    }
}
