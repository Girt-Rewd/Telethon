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
            if (Donateur.GetNbDonateur() >= donateurs.Length)
            {
                // TODO gérer l’aggrandissement du tableau
            }
            else { 
                donateurs[Donateur.GetNbDonateur()] = new Donateur(prenom, nom, adresse, telephone, typeCarte, numeroCarte, dateExpiration);
            }
        }

        public void AjouterCommanditaire(string prenom, string nom, string nomEntreprise){
            if (Commanditaire.GetNbCommanditaires() >= commanditaires.Length) { 
                // TODO gérer l’aggrandissement du tableau Commanditaire
            }
            else { 
                commanditaires[Commanditaire.GetNbCommanditaires()] = new Commanditaire(prenom, nom, nomEntreprise);
            }
        }

        public void AjouterPrix(string description, double valeur, int quatite_originale, string commanditaire)
        {
            if (Prix.GetNbPrix() >= prix.Length)
            { 
                // TODO gérer l’aggrandissement du tableau Prix
            }
            else 
            {
                prix[Prix.GetNbPrix()] = new Prix(description, valeur, quatite_originale, commanditaire);
            }
        }
        public void AjouterDon(string date, string idDonateur, double montantDon)
        {
            if (Don.GetNbDons() >= dons.Length) 
            { 
                // TODO gérer l’aggrandissement du tableau dons
            }
            else
            {
                dons[Don.GetNbDons()] = new Don(date, idDonateur, montantDon);
            }
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
