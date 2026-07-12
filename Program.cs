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
    // On transmet l'objet Profil complet à l'Aiguilleur.
    continuer = GestionnaireLecons.AfficherEtape(monProfil);

    // Si on doit arrêter, on "break" (casse) la boucle while pour en sortir immédiatement.
    if (continuer == false)
    {
        break;
    }

    // On lit la touche tapée par l'utilisateur (le ?? "" évite les avertissements si rien n'est tapé).
    string choix = (Console.ReadLine() ?? "").ToUpper();

    // On vérifie ce que l'utilisateur a tapé.
    if (choix == "S")
    {
        // On sauvegarde le profil complet !
        Sauvegarde.SauvegarderProfil(monProfil);
    }
    else if (choix == "R")
    {
        // On recule d'une étape sans aller en dessous de 1.
        if (monProfil.EtapeActuelle > 1)
        {
            monProfil.EtapeActuelle--; 
        }
    }
    else
    {
        // On avance à l'étape suivante.
        monProfil.EtapeActuelle++;
    }
}
