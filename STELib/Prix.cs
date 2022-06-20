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
        
        private static int nbPrix;
        
        private string idPrix;
        private string description;
        private double valeur;

        private int quantiteOriginale;
        private int quantiteActuelle;
        private string idCommanditaire;


        //TODO Constructeur à arguments
        public Prix(string description, double valeur, int quantite, string idCommanditaire) {
            idPrix = "PRX" + nbPrix;
            this.description = description;
            this.valeur = valeur;
            quantiteOriginale = quantite;
            quantiteActuelle = quantite;
            this.idCommanditaire = idCommanditaire;
            nbPrix++;
        }
        
        public new string ToString() { 
            return idPrix;//TODO
        }

        public void Deduire(int quantite) {
            quantiteActuelle -= quantite;
        }
        public static int GetNbPrix()
        {
            return nbPrix;
        }
    }
}
