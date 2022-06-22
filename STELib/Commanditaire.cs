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

        

        private string idCommanditaire;
  
        
        // Constructeur à arguments
        public Commanditaire(string prenom, string nom, int nbCommanditaire) : base(prenom, nom)
        {              
            this.idCommanditaire = "CMDT" + nbCommanditaire;                                          
        }
        /// <summary>
        /// Cette fonction ToString retourne les informations pertinentes d’un commanditaire sous forme de chaîne de caractères
        /// </summary>
        /// <returns>string</returns>
        public override string ToString() { 
          
                return  "identifiant du commanditaire: "+  "  ID(" + idCommanditaire + ")   personne contact->" + base.ToString(); 
        }     

    }
}
