@echo off
:: Ce fichier est un "script Batch" (.bat). 
:: Il sert à automatiser des commandes que l'on taperait normalement à la main.

echo Compilation et lancement du programme...
echo ----------------------------------------

:: La commande "dotnet run" demande a l'ordinateur de preparer (compiler) notre code puis de l'executer.
dotnet run

echo ----------------------------------------
:: La commande "pause" empeche la fenetre noire de se fermer toute seule a la fin, pour qu'on puisse lire le resultat.
pause
