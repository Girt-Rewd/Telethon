namespace STELib
{
    public abstract class Personne
    {
        /// <summary>
        /// Classe abstraite qui permet de créer les classes Commanditaire et Donateur
        /// </summary>

        private string prenom;
        private string nom;

        /// <summary>
        /// Retourne le nom complet de la personne
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return  prenom +" " +nom;
        }
        // Constructeur à arguments
        public Personne(string prenom, string nom) { 
            this.prenom = prenom;
            this.nom = nom;
        }
    }
}