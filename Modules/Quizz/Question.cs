// L'espace de noms qui regroupe les éléments des évaluations.
namespace MonPremierProjet.Modules.Quizz
{
    /// <summary>
    /// Représente une question individuelle d'un quiz, avec ses propositions et la réponse attendue.
    /// Ceci est une "Classe Conteneur" (explication disponible dans INFO_TableauxObjets.md).
    /// </summary>
    public class Question
    {
        // Les "Propriétés" (get; set;) permettent de définir la structure de notre moule.
        // C'est comme déclarer les tiroirs de notre boîte.

        /// <summary>
        /// Le texte de la question posée à l'élève.
        /// </summary>
        public string TexteQuestion { get; set; }

        /// <summary>
        /// Tableau contenant les 4 propositions de réponse (numérotées visuellement de 1 à 4).
        /// </summary>
        public string[] Propositions { get; set; }

        /// <summary>
        /// Le numéro de la bonne réponse.
        /// Attention : on demandera à l'utilisateur de taper 1, 2, 3 ou 4.
        /// </summary>
        public int BonneReponse { get; set; }

        /// <summary>
        /// Le "Constructeur" est une méthode spéciale qui porte le même nom que la classe.
        /// Il sert à construire (initialiser) la boîte avec les bonnes données dès sa création.
        /// </summary>
        public Question(string texte, string[] propositions, int bonneReponse)
        {
            TexteQuestion = texte;
            Propositions = propositions;
            BonneReponse = bonneReponse;
        }
    }
}
