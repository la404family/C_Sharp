[⬅️ Retour au README](../../README.md)

# Les Tableaux (Arrays) et les Objets (Classes)

Le système de sauvegarde nécessite de retenir trois informations simultanément : l'étape actuelle, le score total, et le nombre de quiz terminés. Pour cela, deux concepts majeurs en C# sont utilisés :

## 1. L'Objet (Classe `Profil`)
Plutôt que d'avoir trois variables indépendantes qui se baladent toutes seules, nous avons créé une classe `Profil`.
Une classe peut être vue comme une "Boîte" personnalisée (un objet). Dans cette boîte, on range nos trois variables (qu'on appelle alors des "propriétés").
- Avantage : Au lieu d'envoyer trois variables différentes à nos méthodes, on n'envoie que notre "boîte" `Profil`. C'est bien plus propre !

## 2. Les Tableaux (`Arrays`)
Un tableau est une liste structurée. On peut le voir comme un meuble avec plusieurs tiroirs numérotés.
En informatique, le premier tiroir porte toujours le numéro `0`.
Pour lire ou écrire dans le fichier texte avec plusieurs informations, le module `System.IO` utilise des tableaux de chaînes de caractères (`string[]`).
- La ligne 1 du fichier de sauvegarde correspond à la case `[0]` du tableau.
- La ligne 2 correspond à la case `[1]`.
- La ligne 3 correspond à la case `[2]`.

En combinant notre "Boîte" (Profil) et nos "Tiroirs" (Tableau), nous sommes capables de transformer facilement de l'information complexe en de simples lignes de texte dans `progression.txt` !

[⬅️ Retour au README](../../README.md)
