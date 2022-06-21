using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELib
{
    public class Prix
    {
        //TODO Commentaires
        //TODO Accesseurs
        
        
        
        private string idPrix;
        private string description;
        private double valeur;

        private int quantiteOriginale;
        private int quantiteActuelle;
        private string idCommanditaire;


        // Constructeur à arguments
        public Prix(string description, double valeur, int quantite, string idCommanditaire, int nbPrix) {

            idPrix = "PRX" + nbPrix;
            this.description = description;
            this.valeur = valeur;
            quantiteOriginale = quantite;
            quantiteActuelle = quantite;
            this.idCommanditaire = idCommanditaire;
         
        }
        
        public new string ToString() { 
            string chaine = "idPrix: " + idPrix + ", description: " + description + ", valeur: "+ valeur +", quantite restante: " + quantiteActuelle + ", idCommanditaire: " + idCommanditaire;
            return chaine;
        }

        public void Deduire(int quantite) {

            quantiteActuelle -= quantite;
        }
       
    }
}
