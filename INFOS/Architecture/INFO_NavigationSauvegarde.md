[⬅️ Retour au README](../../README.md)

# Navigation et Sauvegarde : Comment ça marche ?

Dans cette étape, nous avons transformé notre application pour qu'elle devienne **interactive**. Voici les grands concepts que nous avons introduits :

## 1. Les Variables (`int`, `string`, `bool`)
Une variable est comme une boîte dans laquelle on range une information. 
- Nous avons utilisé un `int` (entier) pour retenir le numéro de l'étape (`etapeActuelle`).
- Nous avons utilisé un `string` (texte) pour lire ce que l'utilisateur tape au clavier.
- Nous avons utilisé un `bool` (vrai/faux) pour savoir si le programme doit continuer ou s'arrêter.

## 2. La Boucle `while`
Habituellement, un programme s'exécute de haut en bas puis s'arrête. Pour créer un menu interactif, il faut empêcher le programme de s'arrêter. La boucle `while` (Tant que) permet de répéter un bloc de code à l'infini, jusqu'à ce qu'on lui dise de s'arrêter avec la commande `break`.

## 3. Les Conditions `if / else if / else`
Pour réagir à ce que l'utilisateur tape, nous devons poser des questions à l'ordinateur :
- **Si** (`if`) l'utilisateur tape "S", alors on sauvegarde.
- **Sinon si** (`else if`) l'utilisateur tape "R", alors on recule.
- **Sinon** (`else`), pour toute autre touche, on avance.

## 4. La Sauvegarde avec `System.IO`
Pour que l'ordinateur se souvienne de notre étape même après l'avoir éteint, nous devons écrire cette information sur le disque dur. Le module `System.IO.File` nous permet de créer un petit fichier texte (`progression.txt`) et de lire ce qu'il contient au prochain lancement.

[⬅️ Retour au README](../../README.md)
