// "using" permet d'importer les fonctionnalités de base, comme la classe Console ou Random.
using System;
// "System.Linq" nous permet de mélanger nos questions facilement (OrderBy).
using System.Linq;

// On déclare l'espace de noms pour lier ce module avec le reste du projet.
namespace MonPremierProjet.Modules.Quizz
{
    /// <summary>
    /// Module d'évaluation numéro 5. Interroge l'utilisateur sur la gestion de la Console.
    /// </summary>
    // Déclaration publique de la classe du Quizz 5.
    public class Quizz5
    {
        /// <summary>
        /// Exécute le quiz 5, pose 5 questions au hasard, et met à jour le profil de l'élève.
        /// </summary>
        // "public static void" signifie que la méthode est accessible partout sans créer d'objet, et ne renvoie rien.
        public static void Executer(Profil profilActuel)
        {
            // On s'assure que la console est parfaitement propre avant de commencer.
            Afficheur.NettoyerEcran();
            
            Console.WriteLine("--- ETAPE 26 : CINQUIEME QUIZ D'EVALUATION ---\n");
            Console.WriteLine("Bienvenue dans votre cinquième évaluation interactive !");
            Console.WriteLine("Cette évaluation porte sur l'utilisation avancée de System.Console (Leçons 18 à 21).");
            Console.WriteLine("Nous allons vous poser 5 questions tirées au hasard.");
            Console.WriteLine("Chaque bonne réponse rapporte 4 points, pour une note maximale de 20.\n");
            Console.WriteLine("Appuyez sur Entrée pour démarrer...");
            Console.ReadLine();

            // Création de la banque de questions (20 questions sur les leçons 18, 19, 20 et 21).
            Question[] banqueQuestions = new Question[]
            {
                new Question("Quelle méthode affiche du texte ET passe à la ligne suivante ?", new string[] { "Console.ReadLine()", "Console.Write()", "Console.WriteLine()", "Console.Print()" }, 3),
                new Question("Que renvoie la méthode Console.ReadLine() ?", new string[] { "Un entier (int)", "Une chaîne de caractères (string)", "Un booléen (vrai/faux)", "Rien (void)" }, 2),
                new Question("Quelle propriété modifie la couleur du texte affiché ?", new string[] { "Console.TextColor", "Console.Color", "Console.ForegroundColor", "Console.BackgroundColor" }, 3),
                new Question("Comment remettre les couleurs par défaut de la console ?", new string[] { "Console.Clear()", "Console.DefaultColor()", "Console.ResetColor()", "Console.BackgroundColor = Black" }, 3),
                new Question("Que fait la méthode Console.Clear() ?", new string[] { "Elle ferme la console", "Elle efface tout le contenu affiché à l'écran", "Elle supprime les variables", "Elle remet les couleurs à zéro" }, 2),
                new Question("A quoi sert la méthode Console.ReadKey() ?", new string[] { "A fermer le programme", "A lire une phrase complète", "A intercepter la frappe d'une seule touche", "A lire un fichier texte" }, 3),
                new Question("Pourquoi utiliser Console.ReadKey(true) avec le paramètre 'true' ?", new string[] { "Pour rendre la touche majuscule obligatoire", "Pour que la touche frappée ne s'affiche pas à l'écran", "Pour que le programme s'arrête", "Pour valider automatiquement" }, 2),
                new Question("Dans Console.SetCursorPosition(colonne, ligne), par quel chiffre commence-t-on à compter ?", new string[] { "Par 0", "Par 1", "Par 10", "Par -1" }, 1),
                new Question("Comment jouer un signal sonore avec la console ?", new string[] { "Console.PlaySound()", "Console.Music()", "Console.Beep()", "Console.Audio()" }, 3),
                new Question("Quelle propriété donne la largeur totale de la fenêtre de la console ?", new string[] { "Console.Width", "Console.WindowWidth", "Console.BufferWidth", "Console.SizeX" }, 2),
                new Question("Quel est le type d'objet renvoyé par Console.ReadKey() ?", new string[] { "string", "char", "ConsoleKeyInfo", "int" }, 3),
                new Question("Si je veux écrire 'Nom :' et laisser l'utilisateur taper à côté, quelle méthode utiliser ?", new string[] { "Console.WriteLine()", "Console.Write()", "Console.Read()", "Console.Clear()" }, 2),
                new Question("Laquelle de ces couleurs existe dans l'énumération ConsoleColor ?", new string[] { "DarkGreen", "LightOrange", "NeonPink", "PitchBlack" }, 1),
                new Question("Que signifie l'acronyme BCL dans le monde .NET (qui inclut System.Console) ?", new string[] { "Basic Code Lines", "Base Class Library", "Binary Console Logic", "Best CSharp Lessons" }, 2),
                new Question("Si j'utilise Console.Beep(800, 150), que représentent les paramètres ?", new string[] { "Volume et Durée", "Fréquence (Hz) et Volume", "Fréquence (Hz) et Durée (ms)", "Pitch et Vitesse" }, 3),
                new Question("Que se passe-t-il si l'on oublie d'appeler Console.ResetColor() après avoir changé la couleur de fond ?", new string[] { "Tout le texte suivant s'affichera avec cette nouvelle couleur de fond", "Rien ne se passe", "Le programme plante", "La couleur redevient normale au prochain WriteLine" }, 1),
                new Question("Comment insérer la variable 'nom' dans une chaîne de caractères lors de l'affichage (Interpolation) ?", new string[] { "$\"Bonjour {nom}\"", "Console.WriteLine('Bonjour ' nom)", "$\"Bonjour\" + nom", "Console.WriteLine(\"Bonjour {0}\", nom)" }, 1),
                new Question("A quoi correspond l'unité de temps utilisée dans Thread.Sleep(1000) ?", new string[] { "Les microsecondes", "Les millisecondes (1000 = 1 seconde)", "Les secondes", "Les cycles d'horloge" }, 2),
                new Question("Que retourne la méthode Console.Read() contrairement à Console.ReadLine() ?", new string[] { "Un entier (le code du caractère tapé)", "Un booléen", "Rien", "Une chaîne d'un seul caractère" }, 1),
                new Question("Quelles sont les coordonnées par défaut du curseur dans la console avant tout déplacement ?", new string[] { "Colonne 0, Ligne 0 (en haut à gauche)", "Colonne 1, Ligne 1", "Au centre de l'écran", "En bas à gauche" }, 1)
            };

            // On génère un objet "Random" pour gérer l'aléatoire.
            Random generateur = new Random();
            
            // On mélange la banque et on extrait 5 questions avec LINQ.
            Question[] questionsChoisies = banqueQuestions.OrderBy(x => generateur.Next()).Take(5).ToArray();

            // Variable pour stocker le score du joueur.
            int scoreObtenu = 0;

            // Boucle principale pour poser les 5 questions.
            for (int i = 0; i < questionsChoisies.Length; i++)
            {
                Afficheur.NettoyerEcran();
                
                Question questionActuelle = questionsChoisies[i];

                Console.WriteLine($"--- QUESTION {i + 1} / 5 ---\n");
                Console.WriteLine(questionActuelle.TexteQuestion);
                Console.WriteLine("--------------------------------------------------");
                
                // Boucle pour afficher les 4 propositions de réponse.
                for (int j = 0; j < questionActuelle.Propositions.Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {questionActuelle.Propositions[j]}");
                }
                
                Console.WriteLine("--------------------------------------------------");
                Console.Write("\nVotre réponse (tapez 1, 2, 3 ou 4) : ");

                // Lecture de la réponse de l'utilisateur.
                string saisieUtilisateur = Console.ReadLine() ?? "";
                
                // Vérification avec TryParse pour éviter les plantages si l'utilisateur tape du texte.
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

            // --- Sauvegarde des résultats dans le profil ---
            profilActuel.ScoreTotal += scoreObtenu;
            profilActuel.NombreQuizTermines++;
            profilActuel.ScoresQuizz.Add(scoreObtenu);

            // Affichage de l'écran de fin.
            Afficheur.NettoyerEcran();
            Console.WriteLine("=== RESULTAT DU QUIZ 5 ===");
            Console.WriteLine("Félicitations, vous avez terminé cette évaluation !");
            Console.WriteLine($"Score obtenu à ce quiz : {scoreObtenu} / 20");
            
            // Calcul de la moyenne globale.
            if (profilActuel.NombreQuizTermines > 1)
            {
                // Forcage d'une division en virgule flottante (double) et arrondi à 2 décimales.
                double moyenne = Math.Round((double)profilActuel.ScoreTotal / profilActuel.NombreQuizTermines, 2);
                Console.WriteLine($"Moyenne générale actuelle : {moyenne} / 20\n");
            }
            else
            {
                Console.WriteLine();
            }
            
            // Commentaire personnalisé en fonction du score.
            if (scoreObtenu == 20)
                Console.WriteLine("C'est un sans faute, vous êtes le maître de la Console !");
            else if (scoreObtenu >= 12)
                Console.WriteLine("Très bon travail ! Vous maîtrisez bien l'interactivité.");
            else
                Console.WriteLine("Quelques erreurs, n'hésitez pas à relire la fiche sur la Console !");
                
            Console.WriteLine("\nVos points ont été ajoutés à votre Profil global de l'application.");
        }
    }
}
