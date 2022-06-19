using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELib
{
    public class Prix
    {
        //TODO Constructeur par défaut
        //TODO Constructeur à arguments
        //TODO  ? Constructeur copie?
        //TODO Commentaires
        //TODO Accesseurs
        
        private static int nbPrix;
        
        private string idPrix;
        private string description;
        private double valeur;

        private int quantiteOriginale;
        private int quantiteActuelle;
        private string idCommanditaire;

        public new string ToString() { 
            return idPrix;//TODO
        }

        public void Deduire(int quantite) {
            quantiteActuelle -= quantite;
        }
    }
}
