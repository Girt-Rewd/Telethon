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

        
        private string idDon;
        private string dateDon;
        private double montantDon;
        private string idDonateur;

        // Constructeur à arguments
        public Don(string dateDon, string idDonateur, double montantDon, int nbDon)
        {
            this.idDon = "DON" + nbDon;
            this.dateDon = dateDon;
            this.montantDon = montantDon;
            this.idDonateur = idDonateur;
        }


        public new string ToString() {
            return "Identifiant du don : " + idDon + " date du don : " + dateDon + " montant : " + montantDon;
        }
    }
}
