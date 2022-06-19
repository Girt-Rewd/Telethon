using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELib
{
    public class Commanditaire : Personne
    {
        /*La classe commanditaire est principalement une classe de données. Elle n’a pas de fonction propre à part Son ToString
         Les commanditaires sont des entreprises qui donne des produits de leur fabrication. Le téléthon à sont tour offre ces articles
        en guise de récompense à ses donateurs en remerciement pour leur dons.
         */

        //TODO Accesseurs

        private static int nbCommanditaires = 001;
        private string idCommanditaire;private string nomEntreprise;
        
        
        // Constructeur à arguments
        public Commanditaire(string prenom, string nom, string nomEntreprise) : base(prenom, nom)
        {         
            this.idCommanditaire = "CMDT" + nbCommanditaires; 
            this.nomEntreprise = nomEntreprise;           
            nbCommanditaires++;          
        }


        public override string ToString() { 
            
                return  "identifiant du commanditaire: "+ nomEntreprise + "  ID(" + idCommanditaire + ")   personne contact->" + base.ToString(); 
        }

    }
}
