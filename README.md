# Cursus d'apprentissage C# et .NET

## But de l'application
Cette application est une console interactive guidant l'utilisateur à travers différentes étapes d'apprentissage du langage C#. Le système intègre la navigation de leçon en leçon, la sauvegarde du profil de l'utilisateur (incluant les scores), et l'évaluation des connaissances via des modules de quiz interactifs.
Une moyenne des scores est calculée et affichée de manière dynamique, et **un fichier texte récapitulatif (certificat) est généré** à la toute fin du cursus.
## Architecture du projet
Le code source est organisé de manière modulaire, appliquant le principe de séparation des responsabilités :
- `LancerProjet.bat` : Script d'automatisation pour la compilation et l'exécution du projet via Windows Terminal ou PowerShell.
- `Program.cs` : Point d'entrée principal du programme gérant la boucle d'exécution (`while`) et la lecture des choix de l'utilisateur.
- `MonPremierProjet.csproj` : Fichier de configuration du projet C# pour le compilateur .NET.
- `Modules/Afficheur.cs` : Composant dédié à l'affichage et au nettoyage bas niveau de l'interface console.
- `Modules/GestionnaireLecons.cs` : Composant routeur dirigeant l'exécution de l'application vers la leçon ou le quiz correspondant à l'étape actuelle.
- `Modules/Profil.cs` : Classe conteneur (objet) stockant et structurant les données du joueur (étape en cours, scores obtenus).
- `Modules/Sauvegarde.cs` : Composant gérant la persistance des données. **Une sauvegarde automatique et silencieuse** garantit que la progression de l'utilisateur n'est jamais perdue, même en quittant via l'option dédiée `[Q] Quitter`. Il est aussi possible de **réinitialiser la sauvegarde** via le raccourci `[Ctrl + R]`.
- `Modules/Lecons/` : Sous-dossier contenant un fichier indépendant pour chaque leçon théorique (`Lecon1.cs` à `LeconXXX.cs`).
- `Modules/Quizz/` : Sous-dossier contenant un fichier indépendant pour chaque évaluation (`Quizz1.cs` à `Quizzxxx.cs`).

## Documentation Détaillée (`INFOS/Architecture/`)
La documentation théorique expliquant les concepts techniques abordés dans ce projet est disponible dans le sous-dossier `INFOS/Architecture/`. 

Ce dossier contient des fiches factuelles et intemporelles expliquant les choix d'architecture :
- [INFO_StructureProjet.md](INFOS/Architecture/INFO_StructureProjet.md) : Explique le concept de séparation des responsabilités, le rôle de routeur, et l'organisation en modules.
- [INFO_NavigationSauvegarde.md](INFOS/Architecture/INFO_NavigationSauvegarde.md) : Détaille l'utilisation des boucles de contrôle (`while`), des instructions conditionnelles (`if`), et le fonctionnement de l'écriture/lecture de données dans un fichier texte.
- [INFO_TableauxObjets.md](INFOS/Architecture/INFO_TableauxObjets.md) : Explique l'utilisation de classes conteneurs (Programmation Orientée Objet) et des Tableaux (`Arrays`) pour structurer et sauvegarder de multiples données complexes.
- [INFO_LaConsole.md](INFOS/Architecture/INFO_LaConsole.md) : Détaille l'utilisation de la classe System.Console pour gérer les entrées/sorties, les couleurs, le curseur et l'interactivité avancée.
- [INFO_LesVariables.md](INFOS/Architecture/INFO_LesVariables.md) : Explique en profondeur la gestion des données, le typage, la portée, et la conversion de types en C#.
