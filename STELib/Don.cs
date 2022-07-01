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
        public Don(string dateDon, double montantDon, int nbDon, string idDonateur)
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
            return  idDon + " date " + dateDon + " montant : " + montantDon+"$";
        }
        public double getMontantDon()
        {
            return montantDon;
        }
    }
}
