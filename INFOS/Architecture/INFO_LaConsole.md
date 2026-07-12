[â¬…ï¸ Retour au README](../../README.md)

# ðŸ–¥ï¸ La Console en C#

La classe `Console` de l'espace de noms `System` est ta boÃ®te Ã  outils pour interagir avec le terminal. Elle te permet d'afficher du texte, de lire les entrÃ©es de l'utilisateur, de personnaliser les couleurs, de manipuler le curseur et bien plus encore.

> ðŸ’¡ **Toutes les mÃ©thodes et propriÃ©tÃ©s prÃ©sentÃ©es ici font partie de la classe statique `System.Console`.** Tu n'as donc pas besoin de crÃ©er d'objet : tu appelles directement `Console.NomDeLaMÃ©thode()`.

---

## ðŸ“‘ Table des matiÃ¨res

1. [EntrÃ©e et Sortie (Le standard)](#1--entrÃ©e-et-sortie-le-standard)
2. [Personnalisation de l'Apparence](#2--personnalisation-de-lapparence)
3. [Gestion du Curseur et de la FenÃªtre](#3--gestion-du-curseur-et-de-la-fenÃªtre)
4. [Signaux Sonores et Buffer](#4--signaux-sonores-et-buffer)
5. [RÃ©capitulatif GÃ©nÃ©ral](#5--rÃ©capitulatif-gÃ©nÃ©ral)

---

## 1. ðŸ“ EntrÃ©e et Sortie (Le standard)

### ðŸ“ Explication

C'est la base absolue de toute application console : **afficher du texte Ã  l'Ã©cran** et **rÃ©cupÃ©rer ce que l'utilisateur tape au clavier**. Sans ces outils, ton programme serait muet et sourd !

En C#, la classe `Console` fournit 5 mÃ©thodes fondamentales pour gÃ©rer les entrÃ©es/sorties :

| MÃ©thode | RÃ´le | Retourne |
| :--- | :--- | :--- |
| `WriteLine()` | Affiche du texte **suivi d'un retour Ã  la ligne** | `void` |
| `Write()` | Affiche du texte **sans retour Ã  la ligne** | `void` |
| `ReadLine()` | Lit **une ligne entiÃ¨re** (jusqu'Ã  EntrÃ©e) | `string` |
| `Read()` | Lit **un seul caractÃ¨re** (valeur entiÃ¨re) | `int` |
| `ReadKey()` | Attend qu'**une touche** soit pressÃ©e | `ConsoleKeyInfo` |

---

### ðŸ”¤ Syntaxe

```csharp
// --- SORTIE ---
Console.WriteLine("Texte avec retour Ã  la ligne");
Console.Write("Texte sans retour Ã  la ligne");

// --- ENTRÃ‰E ---
string ligne = Console.ReadLine();        // Lit une ligne entiÃ¨re
int codeCaractere = Console.Read();       // Lit un caractÃ¨re (code ASCII/Unicode)
ConsoleKeyInfo touche = Console.ReadKey(); // Attend une touche
```

---

### ðŸ’¡ Exemple Simple â€” Dire bonjour Ã  l'utilisateur

```csharp
using System; // On importe l'espace de noms System qui contient la classe Console

class Program
{
    static void Main()
    {
        // WriteLine() affiche le texte puis passe Ã  la ligne suivante
        Console.WriteLine("=== Bienvenue dans le programme ! ===");

        // Write() affiche le texte SANS passer Ã  la ligne
        // Le curseur reste juste aprÃ¨s les deux-points
        Console.Write("Comment t'appelles-tu ? ");

        // ReadLine() attend que l'utilisateur tape du texte et appuie sur EntrÃ©e
        // Le texte saisi est stockÃ© dans la variable "nom"
        string nom = Console.ReadLine();

        // On utilise l'interpolation de chaÃ®ne ($"...") pour insÃ©rer la variable
        Console.WriteLine($"EnchantÃ©, {nom} ! ðŸŽ‰");

        // ReadKey() met le programme en pause jusqu'Ã  ce qu'une touche soit pressÃ©e
        Console.WriteLine("Appuie sur une touche pour quitter...");
        Console.ReadKey();
    }
}
```

**RÃ©sultat dans la console :**
```
=== Bienvenue dans le programme ! ===
Comment t'appelles-tu ? Kevin
EnchantÃ©, Kevin ! ðŸŽ‰
Appuie sur une touche pour quitter...
```

---

### ðŸš€ Exemple AvancÃ© â€” Menu d'un jeu avec toutes les mÃ©thodes d'entrÃ©e

```csharp
using System;

class Program
{
    static void Main()
    {
        // --- Affichage du menu avec WriteLine() ---
        Console.WriteLine("â•”â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•—");
        Console.WriteLine("â•‘    âš”ï¸  DONJON DES OMBRES  âš”ï¸ â•‘");
        Console.WriteLine("â• â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•£");
        Console.WriteLine("â•‘  1. Nouvelle partie           â•‘");
        Console.WriteLine("â•‘  2. Charger une sauvegarde    â•‘");
        Console.WriteLine("â•‘  3. Options                   â•‘");
        Console.WriteLine("â•‘  4. Quitter                   â•‘");
        Console.WriteLine("â•šâ•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•");
        Console.WriteLine(); // Ligne vide pour aÃ©rer l'affichage

        // --- Utilisation de Write() pour garder le curseur sur la mÃªme ligne ---
        Console.Write("Entre le nom de ton hÃ©ros : ");

        // --- ReadLine() pour rÃ©cupÃ©rer le nom complet ---
        string nomHeros = Console.ReadLine();
        Console.WriteLine($"Bienvenue, {nomHeros} le brave !");
        Console.WriteLine();

        // --- ReadKey() pour capturer un choix par une seule touche ---
        Console.WriteLine("Choisis une option du menu (1-4) :");
        ConsoleKeyInfo choix = Console.ReadKey(true);
        // Le paramÃ¨tre 'true' (intercept) empÃªche la touche de s'afficher Ã  l'Ã©cran

        // La propriÃ©tÃ© KeyChar contient le caractÃ¨re de la touche pressÃ©e
        Console.WriteLine($"Tu as choisi l'option : {choix.KeyChar}");

        // On peut aussi vÃ©rifier quelle touche exacte a Ã©tÃ© pressÃ©e
        if (choix.Key == ConsoleKey.D1) // D1 = touche "1"
        {
            Console.WriteLine("ðŸ—¡ï¸ Une nouvelle aventure commence !");
        }
        else if (choix.Key == ConsoleKey.D4)
        {
            Console.WriteLine("ðŸ‘‹ Ã€ bientÃ´t, aventurier !");
        }

        Console.WriteLine();

        // --- Read() pour lire un seul caractÃ¨re (moins courant) ---
        Console.Write("Tape la premiÃ¨re lettre de ta classe (G/M/A) : ");
        int codeLettre = Console.Read(); // Retourne le code ASCII/Unicode
        char lettre = (char)codeLettre;  // On convertit l'entier en caractÃ¨re
        Console.WriteLine($"Tu as tapÃ© : '{lettre}' (code Unicode : {codeLettre})");

        // Attention : Read() laisse le '\n' (retour chariot) dans le buffer
        // Il faut le "vider" avec un ReadLine() supplÃ©mentaire
        Console.ReadLine(); // Vide le buffer du retour Ã  la ligne rÃ©siduel

        Console.WriteLine("\nAppuie sur Ã‰chap pour quitter...");

        // Boucle qui attend spÃ©cifiquement la touche Ã‰chap
        while (Console.ReadKey(true).Key != ConsoleKey.Escape)
        {
            Console.WriteLine("Ce n'est pas Ã‰chap ! RÃ©essaie...");
        }

        Console.WriteLine("Programme terminÃ©. ðŸ‘‹");
    }
}
```

---

### âš ï¸ Erreurs Courantes

1. **Oublier que `ReadLine()` retourne toujours une `string`**
   ```csharp
   // âŒ ERREUR : on ne peut pas stocker une string dans un int
   int age = Console.ReadLine();

   // âœ… CORRECT : il faut convertir la string en int
   int age = int.Parse(Console.ReadLine());

   // âœ… ENCORE MIEUX : utiliser TryParse pour gÃ©rer les erreurs de saisie
   if (int.TryParse(Console.ReadLine(), out int age))
   {
       Console.WriteLine($"Tu as {age} ans.");
   }
   else
   {
       Console.WriteLine("Ce n'est pas un nombre valide !");
   }
   ```

2. **Confondre `Read()` et `ReadLine()`**
   ```csharp
   // âš ï¸ Read() retourne un INT (le code Unicode), pas une string !
   int resultat = Console.Read(); // Si l'utilisateur tape 'A' â†’ resultat = 65
   ```

3. **Oublier que `Read()` laisse des caractÃ¨res dans le buffer**
   ```csharp
   // AprÃ¨s un Read(), le '\r\n' (retour Ã  la ligne) reste dans le buffer
   Console.Read();
   Console.ReadLine(); // â† Ce ReadLine() va consommer le '\n' rÃ©siduel et retourner ""
   ```

4. **Ne pas utiliser `intercept: true` avec `ReadKey()`**
   ```csharp
   // Sans le paramÃ¨tre true, la touche s'affiche dans la console
   Console.ReadKey();       // La touche pressÃ©e apparaÃ®t Ã  l'Ã©cran
   Console.ReadKey(true);   // La touche pressÃ©e N'apparaÃ®t PAS Ã  l'Ã©cran (mode silencieux)
   ```

---

### âœ… Bonnes Pratiques

- **PrÃ©fÃ¨re `ReadLine()` Ã  `Read()`** : `ReadLine()` est plus prÃ©visible et plus simple Ã  utiliser. `Read()` est rarement nÃ©cessaire.
- **Valide toujours les entrÃ©es utilisateur** : Ne fais jamais confiance Ã  ce que l'utilisateur tape. Utilise `TryParse()` plutÃ´t que `Parse()`.
- **Utilise `ReadKey(true)`** pour les menus interactifs : le paramÃ¨tre `true` (intercept) empÃªche la touche de s'afficher, rendant l'interface plus propre.
- **Utilise l'interpolation de chaÃ®nes** (`$"Bonjour {nom}"`) plutÃ´t que la concatÃ©nation (`"Bonjour " + nom`).
- **AÃ¨re tes affichages** avec `Console.WriteLine()` sans paramÃ¨tre pour insÃ©rer des lignes vides.

---

## 2. ðŸŽ¨ Personnalisation de l'Apparence

### ðŸ“ Explication

La console n'est pas condamnÃ©e Ã  rester un Ã©cran noir avec du texte blanc ! C# te permet de **personnaliser les couleurs du texte et du fond**, de **changer le titre de la fenÃªtre**, et mÃªme d'**effacer complÃ¨tement l'Ã©cran**. C'est trÃ¨s utile pour rendre tes programmes plus lisibles et plus professionnels.

| PropriÃ©tÃ© / MÃ©thode | RÃ´le |
| :--- | :--- |
| `ForegroundColor` | Change la **couleur du texte** |
| `BackgroundColor` | Change la **couleur de l'arriÃ¨re-plan** du texte |
| `ResetColor()` | RÃ©initialise les couleurs **aux valeurs par dÃ©faut** |
| `Clear()` | **Efface tout** le contenu de la console |
| `Title` | DÃ©finit le **titre** de la fenÃªtre de la console |

Les couleurs disponibles sont dÃ©finies dans l'Ã©numÃ©ration `ConsoleColor` :

| Couleur | Nom ConsoleColor |
| :--- | :--- |
| â¬› Noir | `ConsoleColor.Black` |
| ðŸ”µ Bleu foncÃ© | `ConsoleColor.DarkBlue` |
| ðŸŸ¢ Vert foncÃ© | `ConsoleColor.DarkGreen` |
| ðŸ”µ Cyan foncÃ© | `ConsoleColor.DarkCyan` |
| ðŸ”´ Rouge foncÃ© | `ConsoleColor.DarkRed` |
| ðŸŸ£ Magenta foncÃ© | `ConsoleColor.DarkMagenta` |
| ðŸŸ¡ Jaune foncÃ© | `ConsoleColor.DarkYellow` |
| â¬œ Gris | `ConsoleColor.Gray` |
| â¬› Gris foncÃ© | `ConsoleColor.DarkGray` |
| ðŸ”µ Bleu | `ConsoleColor.Blue` |
| ðŸŸ¢ Vert | `ConsoleColor.Green` |
| ðŸ”µ Cyan | `ConsoleColor.Cyan` |
| ðŸ”´ Rouge | `ConsoleColor.Red` |
| ðŸŸ£ Magenta | `ConsoleColor.Magenta` |
| ðŸŸ¡ Jaune | `ConsoleColor.Yellow` |
| â¬œ Blanc | `ConsoleColor.White` |

---

### ðŸ”¤ Syntaxe

```csharp
// Changer la couleur du texte
Console.ForegroundColor = ConsoleColor.NomDeLaCouleur;

// Changer la couleur de l'arriÃ¨re-plan du texte
Console.BackgroundColor = ConsoleColor.NomDeLaCouleur;

// RÃ©initialiser toutes les couleurs aux valeurs par dÃ©faut
Console.ResetColor();

// Effacer tout le contenu de la console
Console.Clear();

// Changer le titre de la fenÃªtre
Console.Title = "Mon Titre PersonnalisÃ©";
```

---

### ðŸ’¡ Exemple Simple â€” Texte en couleur

```csharp
using System;

class Program
{
    static void Main()
    {
        // On change le titre de la fenÃªtre du terminal
        Console.Title = "ðŸŽ¨ DÃ©mo des couleurs";

        // On change la couleur du texte en vert
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Ce texte est vert !");

        // On change la couleur du texte en rouge
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ce texte est rouge !");

        // On change la couleur du texte en jaune avec fond bleu
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Texte jaune sur fond bleu !");

        // IMPORTANT : on rÃ©initialise les couleurs pour ne pas affecter le reste
        Console.ResetColor();
        Console.WriteLine("Retour aux couleurs normales.");

        Console.ReadKey();
    }
}
```

**RÃ©sultat dans la console :**
```
Ce texte est vert !          â† (en vert)
Ce texte est rouge !         â† (en rouge)
Texte jaune sur fond bleu !  â† (jaune sur fond bleu)
Retour aux couleurs normales.
```

---

### ðŸš€ Exemple AvancÃ© â€” SystÃ¨me de logs colorÃ©s pour un jeu

```csharp
using System;

class Program
{
    // MÃ©thode utilitaire pour afficher un message avec un niveau de log colorÃ©
    static void AfficherLog(string niveau, string message, ConsoleColor couleur)
    {
        // On sauvegarde la couleur actuelle pour pouvoir la restaurer
        ConsoleColor couleurOriginale = Console.ForegroundColor;

        // On affiche le tag [NIVEAU] en couleur
        Console.ForegroundColor = couleur;
        Console.Write($"[{niveau}] ");

        // On remet la couleur d'origine pour le message
        Console.ForegroundColor = couleurOriginale;
        Console.WriteLine(message);
    }

    static void Main()
    {
        Console.Title = "âš”ï¸ Donjon des Ombres â€” Journal de bord";

        // On crÃ©e un fond sombre pour l'ambiance
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Clear(); // Clear APRÃˆS avoir changÃ© le BackgroundColor
        // Cela applique la couleur de fond Ã  TOUT l'Ã©cran

        Console.WriteLine("========================================");
        Console.WriteLine("   ðŸ“œ Journal de bord de l'aventurier   ");
        Console.WriteLine("========================================");
        Console.WriteLine();

        // DiffÃ©rents niveaux de log avec des couleurs distinctes
        AfficherLog("INFO",    "Tu entres dans la forÃªt sombre...", ConsoleColor.Cyan);
        AfficherLog("SUCCÃˆS",  "Tu as trouvÃ© une Ã©pÃ©e lÃ©gendaire ! ðŸ—¡ï¸", ConsoleColor.Green);
        AfficherLog("AVERTIR", "Un bruit Ã©trange se fait entendre...", ConsoleColor.Yellow);
        AfficherLog("DANGER",  "Un dragon apparaÃ®t devant toi ! ðŸ‰", ConsoleColor.Red);
        AfficherLog("CRITIQUE","Tu n'as plus que 1 PV !", ConsoleColor.DarkRed);

        Console.WriteLine();

        // Affichage d'une barre de vie colorÃ©e
        Console.Write("PV : ");
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("  â–ˆâ–ˆ  ");  // Barre de vie faible
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(" / ");
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("  â–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆ  ");  // Barre de vie totale
        Console.ResetColor();
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("Appuie sur une touche pour continuer...");
        Console.ReadKey(true);
    }
}
```

---

### âš ï¸ Erreurs Courantes

1. **Oublier `ResetColor()` aprÃ¨s avoir changÃ© les couleurs**
   ```csharp
   // âŒ PROBLÃˆME : tout le texte suivant sera rouge !
   Console.ForegroundColor = ConsoleColor.Red;
   Console.WriteLine("Erreur !");
   Console.WriteLine("Ce texte est aussi rouge, sans le vouloir...");

   // âœ… CORRECT : on remet les couleurs par dÃ©faut
   Console.ForegroundColor = ConsoleColor.Red;
   Console.WriteLine("Erreur !");
   Console.ResetColor(); // â† On rÃ©initialise !
   Console.WriteLine("Ce texte est normal.");
   ```

2. **Appeler `Clear()` AVANT de changer `BackgroundColor`**
   ```csharp
   // âŒ Le fond ne change que pour les nouvelles lignes Ã©crites
   Console.Clear();
   Console.BackgroundColor = ConsoleColor.DarkBlue;

   // âœ… Changer le BackgroundColor AVANT Clear() pour que tout l'Ã©cran change
   Console.BackgroundColor = ConsoleColor.DarkBlue;
   Console.Clear(); // Maintenant tout l'Ã©cran est bleu foncÃ©
   ```

3. **Confondre `ForegroundColor` et `BackgroundColor`**
   ```csharp
   // âš ï¸ ForegroundColor = couleur du TEXTE
   // âš ï¸ BackgroundColor = couleur DERRIÃˆRE le texte
   Console.ForegroundColor = ConsoleColor.DarkBlue;  // Le texte sera bleu foncÃ©
   Console.BackgroundColor = ConsoleColor.White;      // Le fond sera blanc
   ```

---

### âœ… Bonnes Pratiques

- **Toujours appeler `ResetColor()`** aprÃ¨s avoir utilisÃ© des couleurs personnalisÃ©es, pour ne pas polluer le reste de l'affichage.
- **CrÃ©e des mÃ©thodes utilitaires** (comme `AfficherLog`) pour encapsuler la logique de coloration. Cela rend ton code plus propre et rÃ©utilisable.
- **Utilise les couleurs avec parcimonie** : trop de couleurs rendent la console illisible. RÃ©serve-les pour les informations importantes (erreurs, succÃ¨s, alertes).
- **Pense aux terminaux qui ne supportent pas toutes les couleurs** : certains terminaux anciens ou certaines configurations peuvent ne pas afficher les 16 couleurs correctement.
- **Utilise `Console.Title`** pour donner un nom descriptif Ã  la fenÃªtre â€” c'est un petit dÃ©tail qui rend l'application plus professionnelle.

---

## 3. ðŸŽ¯ Gestion du Curseur et de la FenÃªtre

### ðŸ“ Explication

La console n'est pas juste un flux de texte de haut en bas ! Tu peux **dÃ©placer le curseur n'importe oÃ¹** sur l'Ã©cran, comme un pinceau sur une toile. C'est ce qui permet de crÃ©er des **menus interactifs**, des **barres de progression**, voire des **petits jeux** dans la console.

Le systÃ¨me de coordonnÃ©es de la console fonctionne ainsi :
- **`left` (colonne)** : position horizontale, commence Ã  `0` (tout Ã  gauche).
- **`top` (ligne)** : position verticale, commence Ã  `0` (tout en haut).

```
     Colonne (left) â†’
     0   1   2   3   4   5   ...
  0 [ ] [ ] [ ] [ ] [ ] [ ]
  1 [ ] [ ] [ ] [ ] [ ] [ ]
  2 [ ] [ ] [X] [ ] [ ] [ ]  â† Le curseur est en (2, 2)
  3 [ ] [ ] [ ] [ ] [ ] [ ]
  â†“
  Ligne (top)
```

| PropriÃ©tÃ© / MÃ©thode | RÃ´le |
| :--- | :--- |
| `SetCursorPosition(left, top)` | **DÃ©place** le curseur aux coordonnÃ©es donnÃ©es |
| `CursorLeft` | RÃ©cupÃ¨re ou dÃ©finit la **colonne** actuelle du curseur |
| `CursorTop` | RÃ©cupÃ¨re ou dÃ©finit la **ligne** actuelle du curseur |
| `CursorVisible` | Masque (`false`) ou affiche (`true`) le **curseur clignotant** |
| `WindowWidth` | RÃ©cupÃ¨re ou dÃ©finit la **largeur** de la fenÃªtre (en colonnes) |
| `WindowHeight` | RÃ©cupÃ¨re ou dÃ©finit la **hauteur** de la fenÃªtre (en lignes) |

---

### ðŸ”¤ Syntaxe

```csharp
// DÃ©placer le curseur Ã  la colonne 10, ligne 5
Console.SetCursorPosition(10, 5);

// RÃ©cupÃ©rer la position actuelle du curseur
int colonne = Console.CursorLeft;
int ligne = Console.CursorTop;

// Masquer le curseur clignotant
Console.CursorVisible = false;

// Obtenir la taille de la fenÃªtre
int largeur = Console.WindowWidth;
int hauteur = Console.WindowHeight;
```

---

### ðŸ’¡ Exemple Simple â€” Ã‰crire Ã  des positions prÃ©cises

```csharp
using System;

class Program
{
    static void Main()
    {
        // On masque le curseur pour un affichage plus propre
        Console.CursorVisible = false;

        // On efface l'Ã©cran
        Console.Clear();

        // On Ã©crit "Bonjour" Ã  la position (0, 0) â€” coin supÃ©rieur gauche (par dÃ©faut)
        Console.WriteLine("Coin supÃ©rieur gauche");

        // On dÃ©place le curseur au milieu de l'Ã©cran
        // WindowWidth / 2 = milieu horizontal, WindowHeight / 2 = milieu vertical
        int centreX = Console.WindowWidth / 2 - 5; // -5 pour centrer le texte "Au milieu!"
        int centreY = Console.WindowHeight / 2;
        Console.SetCursorPosition(centreX, centreY);
        Console.Write("Au milieu !");

        // On dÃ©place le curseur en bas Ã  droite
        Console.SetCursorPosition(Console.WindowWidth - 20, Console.WindowHeight - 1);
        Console.Write("En bas Ã  droite");

        // On affiche la taille de la fenÃªtre en haut Ã  droite
        string taille = $"FenÃªtre : {Console.WindowWidth}x{Console.WindowHeight}";
        Console.SetCursorPosition(Console.WindowWidth - taille.Length, 0);
        Console.Write(taille);

        // On remet le curseur visible et on attend
        Console.SetCursorPosition(0, Console.WindowHeight - 1);
        Console.CursorVisible = true;
        Console.ReadKey();
    }
}
```

---

### ðŸš€ Exemple AvancÃ© â€” Barre de progression animÃ©e

```csharp
using System;
using System.Threading; // NÃ©cessaire pour Thread.Sleep()

class Program
{
    static void DessinerBarreProgression(int pourcentage, int posY)
    {
        // Largeur de la barre en caractÃ¨res (50 caractÃ¨res = 100%)
        int largeurBarre = 50;

        // Nombre de blocs remplis proportionnel au pourcentage
        int blocsRemplis = (int)(largeurBarre * (pourcentage / 100.0));

        // On se positionne au dÃ©but de la barre
        Console.SetCursorPosition(0, posY);

        // Affichage du libellÃ©
        Console.Write("Progression : [");

        // Partie remplie en vert
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(new string('â–ˆ', blocsRemplis));

        // Partie vide en gris foncÃ©
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(new string('â–‘', largeurBarre - blocsRemplis));

        // Fermeture et pourcentage
        Console.ResetColor();
        Console.Write($"] {pourcentage,3}%"); // {pourcentage,3} = alignÃ© Ã  droite sur 3 caractÃ¨res
    }

    static void Main()
    {
        Console.Title = "ðŸ“Š Barre de Progression";
        Console.CursorVisible = false; // On masque le curseur pour un affichage propre
        Console.Clear();

        Console.WriteLine("=== TÃ©lÃ©chargement en cours ===");
        Console.WriteLine();

        // Animation de la barre de 0% Ã  100%
        for (int i = 0; i <= 100; i++)
        {
            DessinerBarreProgression(i, 2); // Dessine la barre Ã  la ligne 2
            Thread.Sleep(50); // Pause de 50ms pour l'animation
        }

        Console.SetCursorPosition(0, 4);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("âœ… TÃ©lÃ©chargement terminÃ© !");
        Console.ResetColor();

        Console.CursorVisible = true;
        Console.ReadKey();
    }
}
```

**RÃ©sultat dans la console (Ã  60%) :**
```
=== TÃ©lÃ©chargement en cours ===

Progression : [â–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–ˆâ–‘â–‘â–‘â–‘â–‘â–‘â–‘â–‘â–‘â–‘â–‘â–‘â–‘â–‘â–‘â–‘â–‘â–‘â–‘â–‘]  60%
```

---

### ðŸš€ Exemple AvancÃ© 2 â€” Menu interactif navigable au clavier

```csharp
using System;

class Program
{
    static void Main()
    {
        // Liste des options du menu
        string[] options = { "ðŸŽ® Nouvelle Partie", "ðŸ“‚ Charger", "âš™ï¸ Options", "ðŸšª Quitter" };

        int selection = 0; // Index de l'option actuellement sÃ©lectionnÃ©e
        bool continuer = true;

        Console.CursorVisible = false;
        Console.Title = "Menu Interactif";

        while (continuer)
        {
            Console.Clear();
            Console.WriteLine("â•”â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•—");
            Console.WriteLine("â•‘     MENU PRINCIPAL     â•‘");
            Console.WriteLine("â• â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•£");

            // On dessine chaque option du menu
            for (int i = 0; i < options.Length; i++)
            {
                if (i == selection) // Si c'est l'option sÃ©lectionnÃ©e
                {
                    // On la met en surbrillance (fond blanc, texte noir)
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"â•‘ â–º {options[i],-19}â•‘");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"â•‘   {options[i],-19}â•‘");
                }
            }

            Console.WriteLine("â•šâ•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•");
            Console.WriteLine("\n  â†‘â†“ pour naviguer, EntrÃ©e pour valider");

            // On capture la touche pressÃ©e (sans l'afficher)
            ConsoleKeyInfo touche = Console.ReadKey(true);

            switch (touche.Key)
            {
                case ConsoleKey.UpArrow: // FlÃ¨che du haut
                    selection = (selection == 0) ? options.Length - 1 : selection - 1;
                    // Si on est tout en haut, on boucle vers le bas
                    break;

                case ConsoleKey.DownArrow: // FlÃ¨che du bas
                    selection = (selection == options.Length - 1) ? 0 : selection + 1;
                    // Si on est tout en bas, on boucle vers le haut
                    break;

                case ConsoleKey.Enter: // Touche EntrÃ©e
                    Console.Clear();
                    Console.WriteLine($"Tu as sÃ©lectionnÃ© : {options[selection]}");

                    if (selection == options.Length - 1) // "Quitter"
                    {
                        continuer = false;
                    }
                    else
                    {
                        Console.WriteLine("Appuie sur une touche pour revenir au menu...");
                        Console.ReadKey(true);
                    }
                    break;
            }
        }

        Console.CursorVisible = true;
    }
}
```

---

### âš ï¸ Erreurs Courantes

1. **DÃ©passer les limites de la fenÃªtre**
   ```csharp
   // âŒ ERREUR : si la fenÃªtre fait 80 colonnes, la position 100 provoque une exception
   Console.SetCursorPosition(100, 5); // ArgumentOutOfRangeException !

   // âœ… CORRECT : toujours vÃ©rifier les limites
   int colonne = Math.Min(100, Console.WindowWidth - 1);
   Console.SetCursorPosition(colonne, 5);
   ```

2. **Modifier `CursorVisible` dans un environnement redirigÃ©**
   ```csharp
   // âš ï¸ Si la sortie console est redirigÃ©e (ex : dans un pipeline),
   // CursorVisible peut lever une exception sur certains systÃ¨mes.
   // Entoure-le d'un try/catch si ton programme peut Ãªtre utilisÃ© dans un pipeline.
   try
   {
       Console.CursorVisible = false;
   }
   catch (System.IO.IOException)
   {
       // La console n'est pas disponible (sortie redirigÃ©e)
   }
   ```

3. **Oublier de revenir Ã  la bonne position aprÃ¨s un dessin**
   ```csharp
   // âš ï¸ AprÃ¨s avoir dessinÃ© avec SetCursorPosition, le curseur reste Ã  la derniÃ¨re position
   // Pense Ã  le replacer lÃ  oÃ¹ tu veux Ã©crire ensuite
   Console.SetCursorPosition(0, Console.WindowHeight - 1);
   ```

---

### âœ… Bonnes Pratiques

- **Masque le curseur** (`CursorVisible = false`) quand tu dessines des interfaces animÃ©es â€” cela Ã©vite le clignotement parasite.
- **Sauvegarde et restaure la position du curseur** si tu as besoin de revenir Ã©crire au mÃªme endroit :
   ```csharp
   int ancienLeft = Console.CursorLeft;
   int ancienTop = Console.CursorTop;
   // ... dessin ailleurs ...
   Console.SetCursorPosition(ancienLeft, ancienTop);
   ```
- **VÃ©rifie `WindowWidth` et `WindowHeight`** avant de positionner le curseur pour Ã©viter les exceptions.
- **PrÃ©fÃ¨re `SetCursorPosition()`** Ã  la modification sÃ©parÃ©e de `CursorLeft` et `CursorTop` â€” c'est plus lisible et atomique.
- **Remets toujours `CursorVisible = true`** Ã  la fin du programme pour ne pas laisser le terminal dans un Ã©tat bizarre.

---

## 4. ðŸ”Š Signaux Sonores et Buffer

### ðŸ“ Explication

La console peut aussi **Ã©mettre des sons** ! La mÃ©thode `Console.Beep()` te permet de jouer des signaux sonores, allant du simple bip d'alerte Ã  de vÃ©ritables petites **mÃ©lodies 8-bit**. ðŸŽµ

En parallÃ¨le, le **buffer** de la console est la zone mÃ©moire oÃ¹ tout le texte affichÃ© est stockÃ©. C'est ce qui te permet de **scroller** vers le haut pour revoir du texte prÃ©cÃ©dent.

| PropriÃ©tÃ© / MÃ©thode | RÃ´le |
| :--- | :--- |
| `Beep()` | Ã‰met un **bip sonore standard** |
| `Beep(frÃ©quence, durÃ©e)` | Ã‰met un son Ã  une **frÃ©quence donnÃ©e** (Hz) pendant une **durÃ©e donnÃ©e** (ms) |
| `BufferWidth` | Largeur du **buffer** (zone de stockage) en colonnes |
| `BufferHeight` | Hauteur du **buffer** en lignes (nombre de lignes conservÃ©es pour le scroll) |

> âš ï¸ **Note importante** : `Console.Beep(frequency, duration)` ne fonctionne que sur **Windows**. Sur macOS et Linux, seule la version sans paramÃ¨tres `Console.Beep()` fonctionne (elle Ã©met le son du terminal).

---

### ðŸ”¤ Syntaxe

```csharp
// Bip simple (son par dÃ©faut du systÃ¨me)
Console.Beep();

// Bip personnalisÃ© : frÃ©quence en Hertz (37-32767), durÃ©e en millisecondes
Console.Beep(440, 500); // Note "La" (440 Hz) pendant 500 ms

// Taille du buffer
int largeurBuffer = Console.BufferWidth;
int hauteurBuffer = Console.BufferHeight;

// Modifier la taille du buffer (Windows uniquement)
Console.BufferHeight = 300; // Le buffer peut conserver 300 lignes de texte
```

---

### ðŸ’¡ Exemple Simple â€” Signaux sonores d'alerte

```csharp
using System;
using System.Threading; // Pour Thread.Sleep()

class Program
{
    static void Main()
    {
        Console.Title = "ðŸ”Š DÃ©mo Sonore";

        // --- Bip simple ---
        Console.WriteLine("ðŸ”” Bip standard du systÃ¨me :");
        Console.Beep(); // Ã‰met le son par dÃ©faut
        Thread.Sleep(500);

        // --- Sons personnalisÃ©s ---
        Console.WriteLine("ðŸŽµ Note basse (200 Hz, 300 ms) :");
        Console.Beep(200, 300);

        Console.WriteLine("ðŸŽµ Note moyenne (600 Hz, 300 ms) :");
        Console.Beep(600, 300);

        Console.WriteLine("ðŸŽµ Note haute (1200 Hz, 300 ms) :");
        Console.Beep(1200, 300);

        // --- Son d'erreur (3 bips rapides aigus) ---
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("âŒ ERREUR ! Bips d'alerte :");
        Console.ResetColor();

        for (int i = 0; i < 3; i++)
        {
            Console.Beep(800, 150); // Bip court et aigu
            Thread.Sleep(100);       // Petite pause entre les bips
        }

        // --- Affichage des infos du buffer ---
        Console.WriteLine();
        Console.WriteLine($"ðŸ“ Taille du buffer : {Console.BufferWidth} x {Console.BufferHeight}");
        Console.WriteLine($"ðŸ“ Taille de la fenÃªtre : {Console.WindowWidth} x {Console.WindowHeight}");

        Console.ReadKey();
    }
}
```

---

### ðŸš€ Exemple AvancÃ© â€” MÃ©lodie 8-bit et gestion du buffer

```csharp
using System;
using System.Threading;

class Program
{
    // Notes de musique en Hertz (octave 4)
    // Tu peux t'en servir comme rÃ©fÃ©rence pour crÃ©er des mÃ©lodies !
    const int Do  = 262;  // C4
    const int Re  = 294;  // D4
    const int Mi  = 330;  // E4
    const int Fa  = 349;  // F4
    const int Sol = 392;  // G4
    const int La  = 440;  // A4
    const int Si  = 494;  // B4
    const int Do5 = 523;  // C5

    // DurÃ©es en millisecondes
    const int Noire   = 400;  // Note standard
    const int Croche  = 200;  // Note rapide
    const int Blanche = 800;  // Note longue
    const int Pause   = 100;  // Silence entre les notes

    static void JouerNote(int frequence, int duree, string nomNote)
    {
        // Affichage visuel de la note jouÃ©e
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($"  â™ª {nomNote,-4}");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write($" ({frequence} Hz, {duree} ms) ");

        // Barre visuelle proportionnelle Ã  la durÃ©e
        Console.ForegroundColor = ConsoleColor.Yellow;
        int longueurBarre = duree / 50;
        Console.WriteLine(new string('â–ˆ', longueurBarre));
        Console.ResetColor();

        // On joue la note
        Console.Beep(frequence, duree);
        Thread.Sleep(Pause); // Petite pause entre les notes
    }

    static void Main()
    {
        Console.Title = "ðŸŽµ Lecteur Musical 8-bit";
        Console.CursorVisible = false;
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("â•”â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•—");
        Console.WriteLine("â•‘    ðŸŽµ MÃ©lodie : Gamme de Do ðŸŽµ    â•‘");
        Console.WriteLine("â• â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•£");
        Console.ResetColor();

        Console.WriteLine();

        // Jouer la gamme de Do majeur
        JouerNote(Do,  Noire,   "Do ");
        JouerNote(Re,  Noire,   "RÃ© ");
        JouerNote(Mi,  Noire,   "Mi ");
        JouerNote(Fa,  Noire,   "Fa ");
        JouerNote(Sol, Noire,   "Sol");
        JouerNote(La,  Noire,   "La ");
        JouerNote(Si,  Noire,   "Si ");
        JouerNote(Do5, Blanche, "Do!");

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("  âœ… MÃ©lodie terminÃ©e !");
        Console.ResetColor();

        // --- DÃ©monstration du Buffer ---
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("â•”â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•—");
        Console.WriteLine("â•‘   ðŸ“ Informations sur le Buffer   â•‘");
        Console.WriteLine("â• â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•â•£");
        Console.ResetColor();

        Console.WriteLine($"  Buffer  : {Console.BufferWidth} colonnes Ã— {Console.BufferHeight} lignes");
        Console.WriteLine($"  FenÃªtre : {Console.WindowWidth} colonnes Ã— {Console.WindowHeight} lignes");
        Console.WriteLine();

        // Le buffer est plus grand que la fenÃªtre = on peut scroller
        if (Console.BufferHeight > Console.WindowHeight)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  ðŸ’¡ Le buffer est plus grand que la fenÃªtre :");
            Console.WriteLine("     Tu peux scroller vers le haut pour revoir le texte prÃ©cÃ©dent !");
            Console.ResetColor();
        }

        Console.WriteLine();
        Console.WriteLine("  Appuie sur une touche pour quitter...");
        Console.CursorVisible = true;
        Console.ReadKey(true);
    }
}
```

---

### âš ï¸ Erreurs Courantes

1. **FrÃ©quence hors limites**
   ```csharp
   // âŒ ERREUR : la frÃ©quence doit Ãªtre entre 37 et 32767 Hz
   Console.Beep(10, 500);    // ArgumentOutOfRangeException !
   Console.Beep(50000, 500); // ArgumentOutOfRangeException !

   // âœ… CORRECT : rester dans l'intervalle [37, 32767]
   Console.Beep(440, 500);   // OK : 440 Hz est dans l'intervalle
   ```

2. **Utiliser `Beep(freq, dur)` sur Linux/macOS**
   ```csharp
   // âš ï¸ La surcharge Beep(frequency, duration) est spÃ©cifique Ã  Windows !
   // Sur Linux/macOS, elle lÃ¨ve une PlatformNotSupportedException
   // Utilise un try/catch si ton programme doit Ãªtre multiplateforme
   try
   {
       Console.Beep(440, 500);
   }
   catch (PlatformNotSupportedException)
   {
       Console.Beep(); // Version simple qui fonctionne partout
   }
   ```

3. **Modifier `BufferWidth` Ã  une valeur infÃ©rieure Ã  `WindowWidth`**
   ```csharp
   // âŒ Le buffer ne peut pas Ãªtre plus petit que la fenÃªtre !
   Console.BufferWidth = 10; // ArgumentOutOfRangeException si WindowWidth > 10

   // âœ… Le buffer doit Ãªtre >= Ã  la taille de la fenÃªtre
   Console.BufferWidth = Math.Max(Console.WindowWidth, 120);
   ```

---

### âœ… Bonnes Pratiques

- **Utilise `Beep()` avec modÃ©ration** : les sons rÃ©pÃ©titifs peuvent vite devenir agaÃ§ants pour l'utilisateur.
- **PrÃ©vois une option "mode silencieux"** dans tes programmes qui utilisent des sons.
- **GÃ¨re la compatibilitÃ© multiplateforme** : entoure `Beep(freq, dur)` d'un `try/catch` si ton programme peut tourner sur Linux/macOS.
- **Ne modifie pas `BufferWidth`** sauf si tu as une raison prÃ©cise : la valeur par dÃ©faut du systÃ¨me convient dans 99% des cas.
- **Utilise le buffer Ã  ton avantage** : un `BufferHeight` Ã©levÃ© permet Ã  l'utilisateur de remonter dans l'historique de la console.

---

## 5. ðŸ“‹ RÃ©capitulatif GÃ©nÃ©ral

### Tableau de synthÃ¨se de la classe `Console`

| CatÃ©gorie | Membre | Type | Description |
| :--- | :--- | :--- | :--- |
| **Sortie** | `WriteLine()` | MÃ©thode | Affiche du texte + retour Ã  la ligne |
| **Sortie** | `Write()` | MÃ©thode | Affiche du texte sans retour Ã  la ligne |
| **EntrÃ©e** | `ReadLine()` | MÃ©thode | Lit une ligne complÃ¨te â†’ `string` |
| **EntrÃ©e** | `Read()` | MÃ©thode | Lit un caractÃ¨re â†’ `int` |
| **EntrÃ©e** | `ReadKey()` | MÃ©thode | Attend une touche â†’ `ConsoleKeyInfo` |
| **Couleurs** | `ForegroundColor` | PropriÃ©tÃ© | Couleur du texte |
| **Couleurs** | `BackgroundColor` | PropriÃ©tÃ© | Couleur de l'arriÃ¨re-plan |
| **Couleurs** | `ResetColor()` | MÃ©thode | RÃ©initialise les couleurs |
| **FenÃªtre** | `Clear()` | MÃ©thode | Efface la console |
| **FenÃªtre** | `Title` | PropriÃ©tÃ© | Titre de la fenÃªtre |
| **Curseur** | `SetCursorPosition()` | MÃ©thode | DÃ©place le curseur |
| **Curseur** | `CursorLeft` / `CursorTop` | PropriÃ©tÃ©s | Position du curseur |
| **Curseur** | `CursorVisible` | PropriÃ©tÃ© | VisibilitÃ© du curseur |
| **FenÃªtre** | `WindowWidth` / `WindowHeight` | PropriÃ©tÃ©s | Taille de la fenÃªtre |
| **Son** | `Beep()` | MÃ©thode | Ã‰met un bip sonore |
| **Son** | `Beep(freq, dur)` | MÃ©thode | Son personnalisÃ© (Windows) |
| **Buffer** | `BufferWidth` / `BufferHeight` | PropriÃ©tÃ©s | Taille du buffer de texte |

- Note :  Le buffer est la zone de texte qui est affichÃ©e dans la console. La fenÃªtre est la zone de texte qui est visible par l'utilisateur. Le buffer est plus grand que la fenÃªtre, ce qui permet Ã  l'utilisateur de remonter dans l'historique de la console.

### ðŸ§  Ce qu'il faut retenir

1. **`WriteLine` / `Write`** sont tes outils de base pour afficher du texte.
2. **`ReadLine`** est la mÃ©thode standard pour lire une saisie utilisateur â€” pense toujours Ã  **valider** ce que l'utilisateur entre.
3. **`ReadKey`** est parfait pour les **menus interactifs** et les jeux (surtout avec `true` pour masquer la touche).
4. **`ForegroundColor` / `BackgroundColor`** permettent de rendre ta console **visuelle** â€” n'oublie pas `ResetColor()` !
5. **`SetCursorPosition`** transforme ta console en **canevas** â€” tu peux dessiner n'importe oÃ¹.
6. **`Beep`** ajoute du **feedback sonore** â€” utile pour les alertes et les jeux.



[â¬…ï¸ Retour au README](../../README.md)
