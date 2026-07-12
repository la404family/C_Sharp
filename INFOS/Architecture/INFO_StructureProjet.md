[⬅️ Retour au README](../../README.md)

# Organisation et Structure du Projet

## Pourquoi séparer le code ?

Quand on débute, on pourrait être tenté d'écrire tout le code dans un seul fichier (par exemple `Program.cs`). Cependant, dans le monde professionnel, les programmes sont très volumineux. 

C'est pourquoi nous adoptons une **approche modulaire** dès le début :
1. **`Program.cs`** : C'est le chef d'orchestre. Il ne fait pas le travail lui-même, il donne les ordres. C'est le point d'entrée de notre application.
2. **`Modules/Afficheur.cs`** : C'est notre spécialiste. C'est un composant externe dont le seul but est de gérer l'affichage de texte dans la console. Le chef d'orchestre (`Program.cs`) va faire appel à lui.

## L'avantage des modules complémentaires

Séparer la logique d'affichage (le "Hello World !") de l'orchestration principale permet de :
- Garder le fichier principal propre et lisible.
- Pouvoir réutiliser le module d'affichage pour d'autres projets plus tard sans tout recréer.
- Mieux s'y retrouver quand on doit corriger une erreur liée à l'affichage : on sait exactement dans quel fichier regarder !

[⬅️ Retour au README](../../README.md)
