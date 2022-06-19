using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELib
{
    public class Donateur : Personne
    {
        //TODO Constructeur par défaut
        //TODO Constructeur à arguments
        //TODO  ? Constructeur copie?
        //TODO Commentaires
        //TODO Accesseurs

        private static int nbDonateurs;

        private string idDonateur;
        private string courriel;
        private string telephone;
        private char typeDeCarte;
        private string numeroDeCarte;
        private string dateExpiration;

        public Donateur(string nom, string prenom, string courriel, string telephone, char typeDeCarte, string numeroCarte, string dateExpiration) : base(prenom, nom){

            this.idDonateur = "DNTR" + nbDonateurs;
            nbDonateurs++;
            this.courriel = courriel;
            this.telephone = telephone;
            this.typeDeCarte = typeDeCarte;
            this.numeroDeCarte = numeroCarte;
            this.dateExpiration = dateExpiration;
             
        }
        public new string ToString() {
             
            return "identifiant du donateur : " + idDonateur + " " + base.ToString(); 
        }
    }
}
