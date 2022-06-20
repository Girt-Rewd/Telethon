using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELib
{
    public class Don
    {
        
        
        
        //TODO Commentaires
        //TODO Accesseurs

        private static int nbDon = 0;
        private string idDon;
        private string dateDon;
        private string idDonateur;
        private double montantDon;

        // Constructeur à arguments
        public Don(string dateDon, string idDonateur, double montantDon)
        {
            this.idDon = "DON" + nbDon;
            this.dateDon = dateDon;
            this.montantDon = montantDon;
            nbDon++;
            this.idDonateur = idDonateur;
        }


        public new string ToString() {
            return "Identifiant du don : " + idDon + " date du don : " + dateDon + " montant : " + montantDon;
        }
        public static int GetNbDons() { 
            return nbDon;
        }
    }
}
