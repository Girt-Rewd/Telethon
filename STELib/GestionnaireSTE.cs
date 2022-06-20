using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELib
{
    public class GestionnaireSTE
    {
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
            // TODO gérer l’aggrandissement du tableau donateurs
            donateurs[Donateur.GetNbDonateur()] = new Donateur(prenom, nom, adresse, telephone, typeCarte, numeroCarte, dateExpiration);
        }

        public void AjouterCommanditaire(string prenom, string nom, string nomEntreprise){
            // TODO gérer l’aggrandissement du tableau Commanditaire
            // TODO
        }

        public void AjouterPrix(string description, double valeur, int quatite_originale, string commanditaire)
        {
            // TODO gérer l’aggrandissement du tableau Prix
            //TODO
        }
        public void AjouterDon(string date, string idDonateur, double montantDon)
        {
            // TODO gérer l’aggrandissement du tableau dons
            //TODO
        }

        public string AfficherDonateur()
        {
            string chaine = "";
            for (int i = 0; i < Donateur.GetNbDonateur(); i++) { 
                chaine += donateurs[i].ToString() + "\n";
            }
            return chaine;
        }

        public string AfficherCommanditaires()
        {
            string chaine = "";
            for (int i = 0; i < Commanditaire.GetNbCommanditaires(); i++)
            {
                chaine += commanditaires[i].ToString() + "\n";
            }
            return chaine;
        }
        public string AfficherPrix()
        {
            string chaine = "";
            for (int i = 0; i < Prix.GetNbPrix(); i++)
            {
                chaine += prix[i].ToString() + "\n";
            }
            return chaine;
        }
        public string AfficherDons()
        {
            string chaine = "";
            for (int i = 0; i < Don.GetNbDons(); i++)
            {
                chaine += prix[i].ToString() + "\n";
            }
            return chaine;
        }

        public Boolean EnregistrerDonateur()
        {
            //TODO
            return true;
        }




    }
}
