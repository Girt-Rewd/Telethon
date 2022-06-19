namespace STELib
{
    public abstract class Personne
    {
        //TODO Commentaires
        //TODO Accesseurs

        private string prenom;
        private string nom;

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