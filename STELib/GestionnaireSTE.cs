using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELib
{
    public class GestionnaireSTE
    {
        //TODO Constructeur à arguments
        //TODO  ? Constructeur copie?
        //TODO Commentaires
        //TODO Accesseurs

        public Donateur[] donateurs;
        public Commanditaire[] commanditaires;
        public Don[] dons;
        public Prix[] prix;

        // Constructeur par défaut
        public GestionnaireSTE()
        {
            this.donateurs = new Donateur[8];
            this.commanditaires = new Commanditaire[8];
            this.dons = new Don[8];
            this.prix = new Prix[8];

            //TODO initialisation des prix disponibles;

        }

        public void AjouterDonateur(string prenom, string nom, string adresse, string telephone, char typeCarte, string numeroCarte, string dateExpiration) {
            donateurs[Donateur.GetNbDonateur()] = new Donateur(prenom, nom, adresse, telephone, typeCarte, numeroCarte, dateExpiration);
        }

        public void AjouterCommanditaire(string prenom, string nom, string nomEntreprise){
            //TODO
        }

        public void AjouterPrix(string description, double valeur, int quatite_originale, string commanditaire)
        {
            //TODO
        }
        public void AjouterDon(string date, string idDonateur, double montantDon)
        {
            //TODO
        }

        public string AfficherDonatueur()
        {
            //TODO
            return "";
        }

        public string AfficherCommanditaires()
        {
            //TODO
            return "";
        }
        public string AfficherPrix()
        {
            //TODO
            return "";
        }
        public string AfficherDons()
        {
            //TODO
            return "";
        }

        public int AttribuerPrix() { 
            //TODO
            return 0;
        }

        public Boolean EnregistrerDonateur()
        {
            //TODO
            return true;
        }




    }
}
