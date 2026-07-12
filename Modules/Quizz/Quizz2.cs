// On utilise System pour les fonctionnalités de base (Console, Random).
using System;
// On utilise System.Linq pour avoir accès à des outils avancés de manipulation de tableaux (comme OrderBy).
using System.Linq;

// L'espace de noms regroupe ce code avec les autres modules de quiz.
namespace MonPremierProjet.Modules.Quizz
{
    /// <summary>
    /// Module d'évaluation numéro 2. Il interroge l'utilisateur sur les leçons 6 à 8 (CLI, CLR, etc.).
    /// </summary>
    public class Quizz2
    {
        /// <summary>
        /// Exécute le quiz, pose 5 questions au hasard parmi 20, et met à jour le profil de l'élève.
        /// </summary>
        // La méthode "Executer" reçoit la boîte "profilActuel" pour pouvoir modifier ses scores à la fin.
        public static void Executer(Profil profilActuel)
        {
            // On s'assure que la console est parfaitement propre.
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 10 : DEUXIEME QUIZ D'EVALUATION ---\n");
            Console.WriteLine("Bienvenue dans votre deuxième évaluation interactive !");
            Console.WriteLine("Cette évaluation porte sur la machinerie interne de .NET (CLI, CLR, etc.).");
            Console.WriteLine("Nous allons vous poser 5 questions, tirées au hasard parmi une banque de 20 questions.");
            Console.WriteLine("Chaque bonne réponse rapporte 4 points, pour une note maximale de 20.\n");
            Console.WriteLine("Appuyez sur Entrée pour démarrer...");
            Console.ReadLine();

            // Création de la banque de 20 questions sur la CLI et le CLR.
            // On utilise le même modèle que pour le Quizz1.
            Question[] banqueQuestions = new Question[]
            {
                new Question("Que signifie l'acronyme CLI ?", new string[] { "Common Language Infrastructure", "Command Line Interface", "C# Language Integration", "Computer Logical Interface" }, 1),
                new Question("Quelle est la nature de la CLI ?", new string[] { "Un logiciel antivirus", "Une norme (un livre de règles)", "Un compilateur très rapide", "Un système d'exploitation" }, 2),
                new Question("Quelle organisation a standardisé la CLI (norme 335) ?", new string[] { "L'ONU", "Le W3C", "L'ECMA", "L'ISO" }, 3),
                new Question("Quel est le rôle principal du CTS (Common Type System) ?", new string[] { "Faire des calculs", "Garantir que tous les langages s'entendent sur les types de données (int, string...)", "Créer des interfaces graphiques", "Gérer les connexions réseau" }, 2),
                new Question("Que signifie l'acronyme CLR ?", new string[] { "Common Language Runtime", "C# Language Rules", "Computer Local Registry", "Core Logical Router" }, 1),
                new Question("Lequel de ces éléments est l'Ouvrier (le moteur) qui exécute réellement le code ?", new string[] { "La CLI", "Visual Studio", "Le CLR", "Le CTS" }, 3),
                new Question("Quel compilateur traduit le code C# en Code Intermédiaire (IL) ?", new string[] { "JIT", "Roslyn", "GCC", "Le CLR" }, 2),
                new Question("En quoi Roslyn transforme-t-il votre code source C# ?", new string[] { "Directement en Code Machine (0101)", "En fichier HTML", "En fichier .dll ou .exe contenant du Code IL", "En fichier texte lisible" }, 3),
                new Question("Que signifie JIT ?", new string[] { "Jump In Time", "Just-In-Time (Juste à temps)", "Java Internal Translator", "Joint Integration Test" }, 2),
                new Question("Qui possède le compilateur JIT et s'en sert ?", new string[] { "Le système Windows", "Le compilateur Roslyn", "Le CLR", "Le développeur manuellement" }, 3),
                new Question("Quand le compilateur JIT intervient-il ?", new string[] { "Lorsqu'on écrit le code", "Au moment de l'exécution, juste avant que le processeur n'en ait besoin", "Pendant l'installation de Visual Studio", "Lorsqu'on sauvegarde le fichier" }, 2),
                new Question("Que signifie IL ou CIL ?", new string[] { "Internal Logic", "Common Intermediate Language", "Internet Link", "Interface Local" }, 2),
                new Question("Qui est responsable du nettoyage de la mémoire dans .NET ?", new string[] { "Le Garbage Collector", "Le développeur avec la commande delete", "Le système d'exploitation", "Le compilateur Roslyn" }, 1),
                new Question("A quel composant appartient le Garbage Collector ?", new string[] { "Au CLR", "A la CLI", "A Roslyn", "Au système Windows" }, 1),
                new Question("Parmi ces propositions, laquelle est une erreur courante ?", new string[] { "Penser que Roslyn compile le C# en IL", "Croire que le CLR est un compilateur classique au lieu d'un runtime", "Penser que le JIT compile juste avant l'exécution", "Savoir que le CLR gère la sécurité" }, 2),
                new Question("Que sont les Metadata dans la CLI ?", new string[] { "Les mots de passe du projet", "Des informations (les coulisses) décrivant la structure du code compilé", "Des images utilisées par le programme", "Le manuel utilisateur" }, 2),
                new Question("Dans l'analogie de la cuisine, qui est le Chef qui lit la recette (C#) ?", new string[] { "Le CLR", "Le JIT", "Roslyn", "La CLI" }, 3),
                new Question("Dans l'analogie de la cuisine, qui représente la CLI ?", new string[] { "Le Chef", "La cuisine équipée", "L'adaptation au four", "Le livre de recettes standardisé" }, 4),
                new Question("Qu'est-ce que le VES (Virtual Execution System) ?", new string[] { "Un casque de réalité virtuelle", "Le système qui charge et exécute le code (implémenté par le CLR)", "Un serveur web", "Une base de données" }, 2),
                new Question("Quel est le bon flux de compilation et d'exécution ?", new string[] { "C# -> CLR -> IL -> Roslyn -> Code machine", "C# -> JIT -> Code machine", "C# -> Roslyn -> IL -> CLR/JIT -> Code machine", "IL -> C# -> Code Machine" }, 3)
            };

            // On utilise la classe "Random" pour générer du hasard.
            Random generateur = new Random();
            
            // La technique (LINQ) "OrderBy" trie le tableau selon un critère aléatoire, puis "Take(5)" garde les 5 premiers éléments.
            // On convertit le résultat en tableau avec "ToArray()". C'est une façon très élégante de mélanger !
            Question[] questionsChoisies = banqueQuestions.OrderBy(x => generateur.Next()).Take(5).ToArray();

            // Variable pour garder en mémoire les points gagnés durant cette session.
            int scoreObtenu = 0;

            // La boucle "for" va répéter le code entre les accolades 5 fois.
            for (int i = 0; i < questionsChoisies.Length; i++)
            {
                Afficheur.NettoyerEcran();
                
                // On extrait la question en cours d'évaluation.
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
            Console.WriteLine("=== RESULTAT DU QUIZ 2 ===");
            Console.WriteLine("Félicitations, vous avez terminé cette évaluation !");
            Console.WriteLine($"Score obtenu à ce quiz : {scoreObtenu} / 20");
            
            // Si l'élève a terminé plus d'un quiz, on calcule et affiche sa moyenne globale.
            if (profilActuel.NombreQuizTermines > 1)
            {
                // "(double)" force une division à virgule. "Math.Round" arrondit à 2 chiffres après la virgule.
                double moyenne = Math.Round((double)profilActuel.ScoreTotal / profilActuel.NombreQuizTermines, 2);
                Console.WriteLine($"Moyenne générale actuelle : {moyenne} / 20\n");
            }
            else
            {
                // Sinon, on passe simplement une ligne pour l'esthétique.
                Console.WriteLine();
            }
            
            if (scoreObtenu == 20)
                Console.WriteLine("C'est un sans faute, vous maîtrisez la théorie .NET sur le bout des doigts !");
            else if (scoreObtenu >= 12)
                Console.WriteLine("Très bon travail ! Vous avez bien compris la différence entre CLI et CLR.");
            else
                Console.WriteLine("Cette partie était très théorique, n'hésitez pas à relire la Leçon 8.");
                
            Console.WriteLine("\nVos points ont été ajoutés à votre Profil global de l'application.");
        }
    }
}
