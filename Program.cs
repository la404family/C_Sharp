// "using" permet d'accéder à nos modules personnalisés et aux outils de base de C#.
using System;
using MonPremierProjet.Modules;

// On demande à notre module "Sauvegarde" de charger le profil complet de l'utilisateur.
// On le stocke dans une variable nommée "monProfil" de type "Profil" (la classe que nous avons créée).
Profil monProfil = Sauvegarde.ChargerProfil();

// "bool" est un type de variable qui ne peut être que 'true' (vrai) ou 'false' (faux).
// On l'utilise ici pour savoir si le programme doit continuer à tourner.
bool continuer = true;

// La boucle "while" (tant que) répète le code entre les accolades {} TANT QUE la condition est vraie.
while (continuer)
{
    // Vérification : si le nom d'utilisateur est vide, c'est qu'il s'agit d'une nouvelle partie (ou après une réinitialisation).
    // string.IsNullOrWhiteSpace vérifie si le texte est nul, vide, ou s'il ne contient que des espaces.
    if (string.IsNullOrWhiteSpace(monProfil.NomUtilisateur))
    {
        Afficheur.NettoyerEcran();
        Console.WriteLine("==================================================");
        Console.WriteLine("   BIENVENUE DANS VOTRE CURSUS D'APPRENTISSAGE   ");
        Console.WriteLine("==================================================\n");
        Console.Write("Pour commencer, veuillez entrer votre prénom ou pseudo : ");
        
        // On enregistre la saisie dans le profil. S'il ne tape rien, on met "Elève" par défaut.
        string saisieNom = Console.ReadLine() ?? "";
        monProfil.NomUtilisateur = string.IsNullOrWhiteSpace(saisieNom) ? "Elève" : saisieNom;
        
        // On sauvegarde immédiatement ce nouveau profil.
        Sauvegarde.SauvegarderProfil(monProfil, true);
    }
    // On transmet l'objet Profil complet à l'Aiguilleur.
    continuer = GestionnaireLecons.AfficherEtape(monProfil);

    // Si on doit arrêter, on "break" (casse) la boucle while pour en sortir immédiatement.
    if (continuer == false)
    {
        // On effectue une sauvegarde automatique (silencieuse) avant de quitter à la fin du cursus.
        Sauvegarde.SauvegarderProfil(monProfil, true);
        break;
    }

    // On utilise "Console.ReadKey(true)" au lieu de ReadLine. 
    // Cela capte immédiatement la touche sans attendre "Entrée". 
    // Le "true" empêche l'ordinateur d'afficher la lettre tapée à l'écran.
    ConsoleKeyInfo saisie = Console.ReadKey(true);

    // On vérifie si l'utilisateur maintient la touche "Control" (Ctrl) enfoncée 
    // EN MEME TEMPS que la touche "R" (pour Reset / Recommencer).
    if (saisie.Modifiers == ConsoleModifiers.Control && saisie.Key == ConsoleKey.R)
    {
        // On détruit le fichier de sauvegarde
        Sauvegarde.ReinitialiserProfil();
        
        // On remplace notre profil actuel par une toute nouvelle boîte vierge (Etape 1, Score 0)
        monProfil = new Profil();
        
        // On indique à la console d'effacer l'écran pour repartir au propre
        Afficheur.NettoyerEcran();
        
        // "continue" force la boucle while à repartir immédiatement au début (tour suivant), 
        // affichant ainsi l'étape 1 sans lire le code en dessous.
        continue;
    }

    // On analyse la touche simple tapée par l'utilisateur
    if (saisie.Key == ConsoleKey.Q)
    {
        // L'utilisateur souhaite quitter. On sauvegarde silencieusement sa progression !
        Sauvegarde.SauvegarderProfil(monProfil, true);
        break;
    }
    else if (saisie.Key == ConsoleKey.R) // R seul (sans Ctrl)
    {
        // On recule d'une étape sans aller en dessous de 1.
        if (monProfil.EtapeActuelle > 1)
        {
            monProfil.EtapeActuelle--; 
            // Sauvegarde automatique et silencieuse du recul de l'étape.
            Sauvegarde.SauvegarderProfil(monProfil, true);
        }
    }
    else if (saisie.Key == ConsoleKey.Enter)
    {
        // On avance à l'étape suivante uniquement s'il appuie sur Entrée.
        monProfil.EtapeActuelle++;
        // Sauvegarde automatique et silencieuse de l'avancée de l'étape.
        Sauvegarde.SauvegarderProfil(monProfil, true);
    }
}
