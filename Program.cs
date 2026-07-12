// Program.cs est le point de départ de notre application. 
// Quand on lance le programme, c'est ici que l'ordinateur commence à lire et exécuter les instructions.

// Le mot-clé "using" indique à l'ordinateur d'utiliser les outils définis dans notre dossier "Modules" (notre espace de nom).
// Un "namespace" (espace de noms) est comme un tiroir dans lequel on range notre code pour bien l'organiser.
using MonPremierProjet.Modules;

// Ici, nous appelons (utilisons) une action (une "méthode") nommée "AfficherMessage".
// Cette méthode se trouve dans notre composant externe nommé "Afficheur".
// C'est comme si on disait : "Hé Afficheur, fais ton action AfficherMessage !".
Afficheur.AfficherMessage();
