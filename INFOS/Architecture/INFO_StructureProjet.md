[⬅️ Retour au README](../../README.md)

# Organisation et Structure du Projet

## Pourquoi séparer le code ?

Quand on débute, on pourrait être tenté d'écrire tout le code dans un seul fichier (par exemple `Program.cs`). Cependant, dans le monde professionnel, les programmes sont très volumineux. 

C'est pourquoi nous adoptons une **approche modulaire** dès le début :
1. **`Program.cs`** : C'est le chef d'orchestre. Il ne fait pas le travail lui-même, il donne les ordres. C'est le point d'entrée de notre application.
2. **`Modules/GestionnaireLecons.cs`** : C'est notre "Aiguilleur". Son seul travail est de regarder l'étape actuelle et d'appeler le bon fichier.
3. **Les sous-dossiers (ex: `Modules/Lecons/`)** : Chaque leçon possède son propre fichier (`Lecon1.cs`, `Lecon2.cs`, etc.). C'est ce qu'on appelle la **séparation des responsabilités**. 

## L'avantage des modules et des sous-dossiers

Séparer la logique d'affichage permet de :
- Garder les fichiers petits, propres et lisibles. Imaginez si les 100 futures leçons étaient toutes écrites dans `GestionnaireLecons.cs` ! Le fichier ferait des milliers de lignes.
- Pouvoir travailler à plusieurs développeurs : l'un modifie la `Lecon1.cs` pendant qu'un autre crée la `Lecon5.cs` sans se gêner mutuellement.
- Mieux s'y retrouver quand on doit corriger une erreur : on sait exactement dans quel fichier regarder !

[⬅️ Retour au README](../../README.md)
