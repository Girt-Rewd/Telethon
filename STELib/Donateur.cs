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

        private string idDonateur;
        private string courriel;
        private string telephone;
        private char typeCarte;
        private string numeroCarte;
        private string dateExpiration;
        private string CVC = "";

        public string IdDonateur
        {
            get => idDonateur;
        }
        public string Courriel { get => courriel; }
        public string Telephone { get => telephone; }
        public char TypeCarte { get => typeCarte; }
        public string NumeroCarte { get => numeroCarte; }
        public string DateExpiration { get => dateExpiration; }

        public string Cvc { get => CVC; }
    
    // Constructeur à arguments
    public Donateur(string nom, string prenom, string courriel, string telephone, char typeDeCarte, string numeroCarte, string dateExpiration, int nbDonateurs, string CVC) : base(prenom, nom)
    {

        this.idDonateur = "DNTR" + nbDonateurs;
        this.courriel = courriel;
        this.telephone = telephone;
        this.typeCarte = typeDeCarte;
        this.numeroCarte = numeroCarte;
        this.dateExpiration = dateExpiration;
        this.CVC = CVC;
    }
    /// <summary>
    /// ToString retourne les informations pertinentes d’un donateur sous forme de string
    /// </summary>
    /// <returns>string</returns>
    public new string ToString()
    {
        string Carte = "";
        if (this.typeCarte.Equals("V")) Carte = "VISA";
        if (this.typeCarte.Equals("M"))
        {
            Carte = "MASTERCARD";
        }
        else Carte = "AMEX";

        return base.ToString() + "\n\rIDD: " + idDonateur + "\n\rTél : " + telephone + "\n\rCourriel: " + courriel + "\n\rCarte de crédit :" + Carte + "  #" + numeroCarte + "\n\rExp: " + dateExpiration + "  CVC: " + CVC;
    }
    public string getId()
    {
        return idDonateur;
    }


}
}
