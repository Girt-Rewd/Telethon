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

        private static int nbCommanditaires = 0;
        private string idCommanditaire;
        private string nomCommanditaire;
        private string prenomCommanditaire;
        private string nomEntreprise;

        public Commanditaire(string prenom, string nom, string nomEntreprise):base(prenom, nom)
        {         
            idCommanditaire = "CMDT" + nbCommanditaires; 
            this.nomEntreprise = nomEntreprise;
            this.nomCommanditaire = nom;
            prenomCommanditaire = prenom;
            nbCommanditaires++;          
        }


        public override string ToString() { 
            
                return  ("identifiant du commanditaire : " + idCommanditaire + " " + nomCommanditaire); 
        }

    }
}
