@echo off
:: Ce fichier est un "script Batch" (.bat). 
:: Il sert à automatiser le lancement de notre programme.

echo Recherche d'une console moderne (Windows Terminal ou PowerShell)...

:: On lance Windows Terminal avec un seul onglet PowerShell.
:: L'argument -NoExit permet de garder la fenetre ouverte a la fin (remplace le vieux 'pause').
wt.exe -d . powershell.exe -NoProfile -NoExit -Command "dotnet run" 2>nul

:: Si wt.exe n'est pas installé, on ouvre une fenêtre PowerShell bleue classique.
if %errorlevel% neq 0 (
    start powershell.exe -NoProfile -NoExit -Command "dotnet run"
)
