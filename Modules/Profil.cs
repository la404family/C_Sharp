// Espace de noms pour nos modules.
namespace MonPremierProjet.Modules
{
    /// <summary>
    /// Représente les données de l'élève (son profil).
    /// </summary>
    // Une classe peut servir de "Conteneur" pour regrouper plusieurs variables liées entre elles.
    public class Profil
    {
        /// <summary>
        /// Numéro de l'étape en cours.
        /// </summary>
        // "public" permet d'y accéder de l'extérieur. "int" car c'est un nombre entier.
        public int EtapeActuelle = 1;

        /// <summary>
        /// Somme totale de tous les points gagnés aux quiz.
        /// </summary>
        // Cette variable retient l'accumulation des scores sous forme de nombre entier.
        public int ScoreTotal = 0;

        /// <summary>
        /// Le nombre total de quiz que l'élève a terminés.
        /// </summary>
        // Cette valeur permet de diviser le ScoreTotal pour obtenir une moyenne.
        public int NombreQuizTermines = 0;
    }
}
