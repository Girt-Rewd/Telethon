using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELib
{
    public class Don
    {
        
        /// <summary>
        /// La classe Don sert principalement de structure de données pour enregistrer les dons en argent entrants avant que ceux-ci ne soient 
        /// remisé dans un fichier txt (et éventuellement dans une base de donnée
        /// </summary>
        
        
        

        
        private string idDon;
        private string dateDon;
        private double montantDon;
        private string idDonateur;

        public double MontantDon { 
            get { return montantDon; }
            set { montantDon = value; }
        }

        // Constructeur à arguments
        public Don(string dateDon, string idDonateur, double montantDon, int nbDon)
        {
            this.idDon = "DON" + nbDon;
            this.dateDon = dateDon;
            this.montantDon = montantDon;
            this.idDonateur = idDonateur;
        }

        /// <summary>
        /// La fonction ToString présente les informations pertinentes d’un don sous forme de chaine de caractère
        /// </summary>
        /// <returns>string</returns>
        public new string ToString() {
            return "Identifiant du don : " + idDon + " date du don : " + dateDon + " montant : " + montantDon;
        }
    }
}
