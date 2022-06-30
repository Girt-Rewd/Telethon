using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELib
{
    public class Prix
    {
        /// <summary>
        /// Classe qui sert a garder en mémoire les données qui permettent d’identifier les prix durant le fonctionnement de l’application avant que ces données ne soient remisées
        /// </summary>
        private string idPrix = "PRX";
        private string description;

        public string Descripition
        { 
            get => description;
            set => description = value;
        }
        private double valeur;

        private int quantiteOriginale;
        private int quantiteActuelle;
        public int QuantiteActuelle { 
            get => quantiteActuelle;
            set => quantiteActuelle = value;
        }

        private string idCommanditaire;


        // Constructeur à arguments
        public Prix(string description, double valeur, int quantite, string idCommanditaire, int nbPrix) {

            idPrix = ""+(nbPrix);
            this.description = description;
            this.valeur = valeur;
            quantiteOriginale = quantite;
            quantiteActuelle = quantite;
            this.idCommanditaire = idCommanditaire;
         
        }

        /// <summary>
        /// ToString retourne les informations pertinentes d’un prix sous forme de string
        /// </summary>
        /// <returns>string</returns>
        public new string ToString() { 
            string chaine = idPrix + ", " + description + ", valeur: "+ valeur +", quantite restante: " + quantiteActuelle + ", idCommanditaire: " + idCommanditaire+"\n\r";
            return chaine;
        }

        /// <summary>
        /// Permet de mettre à jour l’inventaire des prix suite à une attribution
        /// </summary>
        /// <param name="quantite"></param>
        public void Deduire(int quantite) {

            quantiteActuelle -= quantite;
        }
       
    }
}
