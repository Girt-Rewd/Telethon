namespace STELib
{
    public abstract class Personne
    {
        //TODO Constructeur par défaut
        //TODO Constructeur à arguments
        //TODO  ? Constructeur copie?
        //TODO Commentaires
        //TODO Accesseurs

        private string prenom;
        private string nom;

        public override string ToString()
        {
            return  prenom +" " +nom;
        }
        
        public Personne(string prenom, string nom) { 
            this.prenom = prenom;
            this.nom = nom;
        }
    }
}