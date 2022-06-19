using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELib
{
    public class Commanditaire : Personne
    {
        //TODO Constructeur par défaut
        //TODO Constructeur à arguments
        //TODO  ? Constructeur copie?
        //TODO Commentaires
        //TODO Accesseurs
        // New comment

        private static int nbCommanditaires = 001;
        private string idCommanditaire;
      //  private string nomCommanditaire;
      //  private string prenomCommanditaire;
        private string nomEntreprise;

        public Commanditaire(string prenom, string nom, string nomEntreprise):base(prenom, nom)
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
