[â¬…ï¸ Retour au README](../../README.md)

# Les variables en C-Sharp

Les variables sont des Ã©lÃ©ments fondamentaux en programmation. Elles permettent de stocker des donnÃ©es en mÃ©moire pour les manipuler dans un programme. En C#, les variables doivent Ãªtre dÃ©clarÃ©es avant d'Ãªtre utilisÃ©es. Voici comment dÃ©clarer et utiliser des variables en C#.

## DÃ©claration des variables en C-Sharp

En C#, les variables doivent Ãªtre dÃ©clarÃ©es avant d'Ãªtre utilisÃ©es. La dÃ©claration d'une variable se fait en spÃ©cifiant son type et son nom. Voici un exemple de dÃ©claration de variables en C# :

```csharp
int age;
string nom;
double prix;
```

Dans cet exemple, nous avons dÃ©clarÃ© trois variables : `age` de type `int`, `nom` de type `string` et `prix` de type `double`.

## Initialisation des variables en C-Sharp

AprÃ¨s avoir dÃ©clarÃ© une variable, vous pouvez lui attribuer une valeur en utilisant l'opÃ©rateur d'assignation `=`. Voici un exemple d'initialisation de variables en C# :

```csharp
int age = 30;
string nom = "Jean";
double prix = 19.99;
```

Dans cet exemple, nous avons initialisÃ© les variables `age`, `nom` et `prix` avec les valeurs `30`, `"Jean"` et `19.99` respectivement.

## Les types de variables en C-Sharp

En C#, il existe plusieurs types de variables, chacun ayant des caractÃ©ristiques spÃ©cifiques. Voici les principaux types de variables classÃ©s par frÃ©quence d'utilisation :

### Types indispensables (Ã  connaÃ®tre absolument)

| Type     | Description           | Exemple             |
| -------- | --------------------- | ------------------- |
| `int`    | Nombres entiers       | `42`, `-5`, `100`   |
| `string` | ChaÃ®nes de caractÃ¨res | `"Bonjour"`, `"C#"` |
| `bool`   | Valeurs boolÃ©ennes    | `true`, `false`     |
| `double` | Nombres dÃ©cimaux      | `3.14`, `-0.5`      |
| `var`    | InfÃ©rence de type (mot-clÃ©)| `var x = 10;`       |

```csharp
int age = 25;                    // Nombre entier simple
string nom = "Marie";            // Texte
bool estActif = true;            // Condition
double moyenne = 15.75;          // Calcul dÃ©cimal
var compteur = 0;                // Le compilateur dÃ©duit : int
```

> [!NOTE]
> **Important** : `var` n'est pas un type en soi, c'est une instruction au compilateur pour qu'il devine le type. Une fois compilÃ©, `var x = 10` est strictement identique Ã  `int x = 10`. C'est du "typage statique implicite".

### Types pour des besoins spÃ©cifiques

| Type      | Description              | Exemple        |
| --------- | ------------------------ | -------------- |
| `decimal` | Haute prÃ©cision dÃ©cimale | `19.99m`       |
| `long`    | Grands entiers           | `10000000000L` |
| `float`   | DÃ©cimal simple prÃ©cision | `3.14f`        |

```csharp
decimal prix = 19.99m;           // Prix exact, pas d'erreur d'arrondi
long idUtilisateur = 9876543210; // ID de base de donnÃ©es
float positionX = 1.5f;          // CoordonnÃ©e dans un jeu
```

**note** : Le suffixe `m` pour `decimal`, `L` pour `long` et `f` pour `float` est obligatoire lors de l'initialisation.

la diffÃ©rence principale entre `float`, `double` et `decimal` rÃ©side dans la prÃ©cision et l'utilisation prÃ©vue :

- `float` : simple prÃ©cision, utilisÃ© pour les graphiques et les jeux.
- `double` : double prÃ©cision, utilisÃ© pour la plupart des calculs scientifiques.
- `decimal` : trÃ¨s haute prÃ©cision, utilisÃ© pour les calculs financiers oÃ¹ les erreurs d'arrondi sont inacceptables.

### Types pour des cas trÃ¨s particuliers

| Type                               | Description               |
| ---------------------------------- | ------------------------- |
| `char`                             | CaractÃ¨re unique (`'A'`)  |
| `short`, `byte`                    | Petits entiers            |
| `sbyte`, `ushort`, `uint`, `ulong` | Entiers signÃ©s/non signÃ©s |

```csharp
char lettre = 'A';               // Un seul caractÃ¨re
byte octet = 255;                // Valeur 0-255 (donnÃ©es binaires)
```

**Note** : Plus de dÃ©tails dans une prochaine section sur les types de donnÃ©es.

## Utilisation des variables en C-Sharp

Une fois que vous avez dÃ©clarÃ© et initialisÃ© des variables, vous pouvez les utiliser dans votre programme. Voici un exemple d'utilisation de variables en C# :

```csharp
Console.WriteLine("Nom : " + nom);
Console.WriteLine("Age : " + age);
Console.WriteLine("Prix : " + prix);
```

Il n'est pas nÃ©cessaire de spÃ©cifier le type de la variable lors de son utilisation. Vous pouvez simplement utiliser son nom pour accÃ©der Ã  sa valeur. Mais il est important de noter que les variables doivent Ãªtre dÃ©clarÃ©es avant d'Ãªtre utilisÃ©es.

SpÃ©cifier le type de la variable lors de sa dÃ©claration permet de dÃ©finir la taille de l'espace mÃ©moire allouÃ© pour stocker la valeur de la variable. Cela permet Ã©galement au compilateur de vÃ©rifier que les opÃ©rations effectuÃ©es sur la variable sont valides.

Exemple de programme utilisant des variables en C# :

```csharp
// DÃ©claration des espaces de noms utilisÃ©s
using System;
// DÃ©claration de l'espace de nom du projet
namespace LesVariables
{
    // DÃ©claration de la classe du projet
    class Program
    {
        static void Main(string[] args)
        {
            int age = 30;
            string nom = "Jean";
            double prix = 19.99;
            var estActif = true; // Le type de la variable est dÃ©duit automatiquement

            Console.WriteLine("Nom : " + nom);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Prix : " + prix);
            Console.WriteLine("Est actif : " + estActif);
        }
    }
}
```

## Les constantes en C-Sharp

En plus des variables, vous pouvez Ã©galement dÃ©clarer des constantes en C#. Les constantes sont des valeurs immuables qui ne peuvent pas Ãªtre modifiÃ©es une fois qu'elles ont Ã©tÃ© dÃ©finies. Voici un exemple de dÃ©claration de constante en C# :

```csharp
const double PI = 3.14159;
const string MESSAGE = "Bonjour, monde !";
```

Dans cet exemple, nous avons dÃ©clarÃ© deux constantes : `PI` de type `double` et `MESSAGE` de type `string`. Les constantes doivent Ãªtre initialisÃ©es lors de leur dÃ©claration et ne peuvent pas Ãªtre modifiÃ©es par la suite.

Exemple de programme utilisant des constantes en C# :

```csharp
// DÃ©claration des espaces de noms utilisÃ©s
using System;
// DÃ©claration de l'espace de nom du projet
namespace LesVariables
{
    // DÃ©claration de la classe du projet
    class Program
    {
        static void Main()
        {
            // DÃ©claration d'une variable de type entier
            int entier = 10;
            Console.WriteLine("entier = " + entier);

            // DÃ©claration d'une variable nombre Ã  virgule
            float reel = 3.14f;
            Console.WriteLine("nombre Ã  virgule = " + reel);

            // DÃ©claration d'une variable de type caractÃ¨re
            char caractere = 'A';
            Console.WriteLine("caractere = " + caractere);

            // DÃ©claration d'une variable de type chaÃ®ne de caractÃ¨res
            string chaine = "Hello World!";
            Console.WriteLine("chaine = " + chaine);

            // DÃ©claration d'une variable de type boolÃ©en (true ou false)
            bool booleen = true;
            Console.WriteLine("booleen = " + booleen);

            // DÃ©claration d'une constante
            const double PI = 3.14159;
            Console.WriteLine("PI = " + PI);
        }
    }
}
```

## La concatÃ©nation de chaÃ®nes en C-Sharp

En C#, vous pouvez concatÃ©ner des chaÃ®nes en utilisant l'opÃ©rateur `+`. Voici un exemple de concatÃ©nation de chaÃ®nes en C# :

```csharp
string prenom = "Jean";
string nom = "Dupont";
string nomComplet = prenom + " " + nom;
Console.WriteLine("Nom complet : " + nomComplet);
```

Stocker une valeur donnÃ©e par l'utilisateur dans une variable :

```csharp
Console.WriteLine("Entrez votre nom : ");
// string? indique que la valeur peut Ãªtre nulle (depuis .NET 6)
string? nom = Console.ReadLine();
Console.WriteLine("Bonjour, " + nom + " !");
```

> [!WARNING]
> Depuis les versions rÃ©centes de .NET, `Console.ReadLine()` peut renvoyer `null`. Pour Ãªtre rigoureux, on utilise souvent `string?` (nullable) ou on gÃ¨re le cas null : `string nom = Console.ReadLine() ?? "";`.



## PortÃ©e des variables en C-Sharp

La portÃ©e d'une variable dÃ©termine oÃ¹ elle peut Ãªtre utilisÃ©e dans le code. En C#, il existe plusieurs types de portÃ©e :

- **Variable locale** : dÃ©clarÃ©e Ã  l'intÃ©rieur d'une mÃ©thode, accessible uniquement dans cette mÃ©thode.
- **Champ de classe** : dÃ©clarÃ©e dans une classe mais en dehors des mÃ©thodes, accessible dans toute la classe.
- **Variable statique** : partagÃ©e par toutes les instances de la classe.

### Exemple 1 : Variables locales vs champs de classe

```csharp
using System;

class Compteur
{
    // Champ de classe (accessible dans toute la classe)
    private int total = 0;

    public void Incrementer()
    {
        // Variable locale (accessible uniquement dans cette mÃ©thode)
        int increment = 1;
        total = total + increment;
        Console.WriteLine($"Total aprÃ¨s incrÃ©ment : {total}");
        // increment disparaÃ®t Ã  la fin de la mÃ©thode
    }

    public void AfficherTotal()
    {
        Console.WriteLine($"Total actuel : {total}");
        // Console.WriteLine(increment); // ERREUR : increment n'existe pas ici
    }
}

// Utilisation
class Program
{
    static void Main()
    {
        Compteur c = new Compteur();
        c.Incrementer(); // Affiche : Total aprÃ¨s incrÃ©ment : 1
        c.Incrementer(); // Affiche : Total aprÃ¨s incrÃ©ment : 2
        c.AfficherTotal(); // Affiche : Total actuel : 2
    }
}
```

**rÃ©sumÃ©** : Les variables locales sont temporaires et limitÃ©es Ã  la mÃ©thode, tandis que les champs de classe persistent tant que l'objet existe.

### Exemple 2 : Variables statiques partagÃ©es

```csharp
using System;

class Joueur
{
    // Champ de classe (propre Ã  chaque instance)
    private string nom;
    private int score;

    // Champ statique (partagÃ© par TOUS les joueurs)
    private static int nombreJoueurs = 0;

    public Joueur(string nom)
    {
        this.nom = nom;
        this.score = 0;
        nombreJoueurs++; // IncrÃ©mente pour tous les joueurs
    }

    public void AjouterPoints(int points)
    {
        score += points;
        Console.WriteLine($"{nom} a maintenant {score} points");
    }

    public static void AfficherNombreJoueurs()
    {
        Console.WriteLine($"Nombre total de joueurs : {nombreJoueurs}");
        // Console.WriteLine(nom); // ERREUR : une mÃ©thode statique ne peut pas accÃ©der aux champs d'instance
    }
}

// Utilisation
class Program
{
    static void Main()
    {
        Joueur j1 = new Joueur("Alice");
        Joueur j2 = new Joueur("Bob");
        Joueur j3 = new Joueur("Charlie");

        j1.AjouterPoints(10); // Alice a maintenant 10 points
        j2.AjouterPoints(5);  // Bob a maintenant 5 points

        Joueur.AfficherNombreJoueurs(); // Nombre total de joueurs : 3
    }
}
```

### Exemple 3 : PortÃ©e des variables dans les blocs

```csharp
using System;

class ExempleBlocs
{
    public void DemonstrationPortee()
    {
        int x = 10; // Variable de la mÃ©thode

        if (x > 5)
        {
            int y = 20; // Variable du bloc if
            Console.WriteLine($"x = {x}, y = {y}"); // OK
        }

        // Console.WriteLine(y); // ERREUR : y n'existe plus ici

        for (int i = 0; i < 3; i++)
        {
            int z = i * 2; // Variable du bloc for
            Console.WriteLine($"i = {i}, z = {z}");
        }

        // Console.WriteLine(i); // ERREUR : i n'existe plus ici
        // Console.WriteLine(z); // ERREUR : z n'existe plus ici

        Console.WriteLine($"x = {x}"); // OK : x existe toujours
    }
}
```

### Exemple 4 : Masquage de variables (shadowing)

```csharp
using System;

class ExempleMasquage
{
    private int valeur = 100; // Champ de classe

    public void Methode1()
    {
        Console.WriteLine($"Valeur de classe : {valeur}"); // 100
    }

    public void Methode2()
    {
        int valeur = 50; // Variable locale qui "masque" le champ
        Console.WriteLine($"Valeur locale : {valeur}"); // 50
        Console.WriteLine($"Valeur de classe : {this.valeur}"); // 100 (accÃ¨s avec 'this')
    }

    public void Methode3(int valeur) // ParamÃ¨tre qui masque le champ
    {
        Console.WriteLine($"ParamÃ¨tre : {valeur}"); // Valeur passÃ©e en paramÃ¨tre
        Console.WriteLine($"Champ de classe : {this.valeur}"); // 100
    }
}

// Utilisation
class Program
{
    static void Main()
    {
        ExempleMasquage ex = new ExempleMasquage();
        ex.Methode1(); // Valeur de classe : 100
        ex.Methode2(); // Valeur locale : 50, Valeur de classe : 100
        ex.Methode3(75); // ParamÃ¨tre : 75, Champ de classe : 100
    }
}
```

### RÃ©sumÃ© des portÃ©es

| Type de variable | DÃ©clarÃ©e dans       | Accessible dans                              | DurÃ©e de vie                 |
| ---------------- | ------------------- | -------------------------------------------- | ---------------------------- |
| Locale           | MÃ©thode/Bloc        | MÃ©thode/Bloc uniquement                      | Jusqu'Ã  la fin du bloc       |
| Champ d'instance | Classe (hors mÃ©th.) | Toute la classe                              | Tant que l'objet existe      |
| Champ statique   | Classe (static)     | Toute la classe + partout via `Classe.Champ` | Toute la durÃ©e du programme  |
| ParamÃ¨tre        | Signature mÃ©thode   | Corps de la mÃ©thode                          | Jusqu'Ã  la fin de la mÃ©thode |

## Variables implicites : `var` et `dynamic`

- **`var`** : le type est dÃ©terminÃ© Ã  la compilation, il ne peut pas changer par la suite.
- **`dynamic`** : le type est dÃ©terminÃ© Ã  l'exÃ©cution, il peut changer par la suite.

```csharp
var nombre = 42; // Le compilateur comprend que c'est un int
var texte = "Bonjour"; // string
// nombre = "texte"; // Erreur de compilation

dynamic valeur = 10;
valeur = "Maintenant une chaÃ®ne"; // Pas d'erreur Ã  la compilation
Console.WriteLine(valeur);
```

Voici ce que Ã§a implique :

- Le type rÃ©el de la variable dynamic est rÃ©solu au moment de lâ€™exÃ©cution, pas Ã  la compilation.

-Tu peux lui assigner une valeur de nâ€™importe quel type, puis lui rÃ©assigner une autre valeur dâ€™un type complÃ¨tement diffÃ©rent.

- Cela permet une grande flexibilitÃ©, mais au dÃ©triment de la sÃ©curitÃ© de type Ã  la compilation.

## Variables non initialisÃ©es et valeurs par dÃ©faut

En C#, les variables locales doivent Ãªtre initialisÃ©es avant d'Ãªtre utilisÃ©es. Les champs de classe reÃ§oivent une valeur par dÃ©faut.

```csharp
class ExempleDefaut
{
    int champClasse; // Par dÃ©faut : 0
    bool estActif;   // Par dÃ©faut : false

    void Afficher()
    {
        int local;
        // Console.WriteLine(local); // Erreur : la variable locale n'est pas initialisÃ©e
        Console.WriteLine(champClasse); // Affiche 0
        Console.WriteLine(estActif);    // Affiche False
    }
}
```

## Conversion de types (casting)

Il est parfois nÃ©cessaire de convertir une variable d'un type Ã  un autre.

```csharp
int entier = 10;
double reel = entier; // Conversion implicite (int vers double)

// Conversion explicite (cast)
double d = 9.7;
int i = (int)d; // i vaut 9, la partie dÃ©cimale est perdue

// Conversion de string vers int
string texte = "123";
int nombre = int.Parse(texte); // nombre vaut 123
// int nombre2 = int.Parse("abc"); // Provoque une exception
```

## Bonnes pratiques et erreurs courantes

- Toujours initialiser les variables locales avant utilisation.
- Utiliser des noms de variables explicites et significatifs.
- PrivilÃ©gier `var` pour les types Ã©vidents, mais Ã©viter pour les types ambigus.
- Attention Ã  la casse : `maVariable` et `mavariable` sont diffÃ©rents.

```csharp
// Mauvaise pratique :
int a = 1, b = 2, c = 3; // Peu lisible

// Bonne pratique :
int nombreApples = 1;
int nombreOranges = 2;
int nombreBananes = 3;
```

// Erreur courante : utiliser une variable non initialisÃ©e

```csharp
int x;
// Console.WriteLine(x); // Erreur de compilation
```

// Erreur courante : confusion entre affectation (=) et comparaison (==)

```csharp
int y = 5;
if (y == 5) // Comparaison correcte
{
    Console.WriteLine("y vaut 5");
}
// if (y = 5) // Erreur : affectation au lieu de comparaison
```


[â¬…ï¸ Retour au README](../../README.md)
