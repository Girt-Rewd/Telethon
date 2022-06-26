using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELib
{
    public class Donateur : Personne
    {
        
        /// <summary>
        /// Classe qui sert a garder en mémoire les données qui permettent d’identifier les donateurs durant le fonctionnement de l’application avant que ces données ne soient remisées
        /// </summary>

        private string idDonateur ;
        private string courriel;
        private string telephone;
        private char typeDeCarte;
        private string numeroDeCarte;
        private string dateExpiration;

        // Constructeur à arguments
        public Donateur(string nom, string prenom, string courriel, string telephone, char typeDeCarte, string numeroCarte, string dateExpiration, int nbDonateurs) : base(prenom, nom){

            this.idDonateur = "DNTR" + nbDonateurs;
            this.courriel = courriel;
            this.telephone = telephone;
            this.typeDeCarte = typeDeCarte;
            this.numeroDeCarte = numeroCarte;
            this.dateExpiration = dateExpiration;
             
        }
        /// <summary>
        /// ToString retourne les informations pertinentes d’un donateur sous forme de string
        /// </summary>
        /// <returns>string</returns>
        public new string ToString() {
             
            return "identifiant du donateur : " + idDonateur + " " + base.ToString(); 
        }
    
        
    }
}
