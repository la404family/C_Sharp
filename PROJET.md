# 📘 Projet : Cursus d'apprentissage C# Interactif

## 🎯 Objectif du Projet
Ce projet est une **application console interactive** développée en C#. Son but est de guider un utilisateur débutant à travers différentes étapes d'apprentissage du langage C# de manière pédagogique. 

Au lieu d'être un simple programme linéaire, l'application agit comme une véritable plateforme d'e-learning en mode console, avec des leçons théoriques, des quiz d'évaluation et un suivi de la progression.

## ✨ Fonctionnalités Principales

- **Navigation Interactive :** L'utilisateur peut avancer, reculer ou quitter l'application à l'aide de commandes simples traitées par une boucle de jeu (`while`).
- **Système de Leçons et de Quizz :** Le parcours alterne entre des leçons d'explication théorique et des quiz interactifs pour valider les acquis.
- **Sauvegarde de la Progression :** Grâce au module `System.IO`, le profil de l'utilisateur (l'étape où il s'est arrêté, ses scores aux quiz) est sauvegardé de manière persistante sur le disque dur.
- **Calcul de Moyenne :** L'application est capable de conserver un historique des scores obtenus aux quiz et de calculer une moyenne dynamique.

## 🏗️ Architecture et Structure du Code

Afin de respecter les bonnes pratiques de développement (comme dans un environnement professionnel), le code applique le principe de **séparation des responsabilités**. L'application est modulaire et divisée en plusieurs fichiers :

- **`Program.cs` (Le Chef d'Orchestre) :** C'est le point d'entrée. Il maintient le programme en vie grâce à une boucle `while` et capte les entrées (choix) de l'utilisateur.
- **`Modules/GestionnaireLecons.cs` (L'Aiguilleur) :** Il reçoit le numéro de l'étape actuelle et fait appel au bon fichier (Leçon ou Quiz) à afficher.
- **`Modules/Profil.cs` :** Une classe (Objet) qui sert de conteneur pour stocker toutes les données du joueur en cours de session (Étape actuelle, Liste des scores, etc.).
- **`Modules/Sauvegarde.cs` :** Ce module se charge exclusivement de transformer l'objet `Profil` en données textuelles pour l'écrire dans un fichier de sauvegarde, et inversement (chargement au démarrage).
- **`Modules/Afficheur.cs` :** Gère l'esthétique et le nettoyage de la console.
- **Sous-dossiers `Lecons/` et `Quizz/` :** Chaque étape (une leçon ou un quiz) est isolée dans son propre fichier (ex: `Lecon1.cs`, `Quizz1.cs`). Cela permet de garder un code propre et facilement extensible.

## ⚙️ Comment ça marche techniquement ?

1. **Au lancement :** `Program.cs` demande à `Sauvegarde.cs` de lire le fichier texte de sauvegarde (historique) et de reconstruire l'objet `Profil`.
2. **Boucle principale :** Une boucle `while (continuer)` s'exécute indéfiniment.
3. **Affichage :** `GestionnaireLecons.cs` lit l'étape dans le `Profil` et affiche la leçon ou le quiz correspondant.
4. **Interaction :** Le programme attend une entrée utilisateur (`Console.ReadLine()`).
5. **Logique Conditionnelle :** À l'aide de `if / else if / else`, le programme analyse la saisie :
   - `S` : Appelle la méthode pour écrire l'état actuel dans le fichier de sauvegarde.
   - `R` : Décrémente la variable d'étape (recule).
   - *Autre touche* : Incrémente l'étape (avance) et met à jour le profil.

## 📚 Documentation Technique
Le projet inclut également un dossier `INFOS/Architecture/` contenant des fiches Markdown (comme `INFO_NavigationSauvegarde.md` ou `INFO_StructureProjet.md`). Ces fiches servent de base de connaissances théoriques pour expliquer en détail les choix architecturaux et les concepts du langage C# (Variables, Boucles, Conditions, POO, etc.) abordés lors de la création de cet outil.
