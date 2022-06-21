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

        public List<Donateur> donateurs;
        public List<Commanditaire> commanditaires;
        public List<Don> dons;
        public List<Prix> prix;

        // Constructeur par défaut
        public GestionnaireSTE()
        {
            this.donateurs = new List<Donateur>();
            this.commanditaires = new List<Commanditaire>();
            this.dons = new List<Don>();
            this.prix = new List<Prix>();

            //TODO initialisation des prix disponibles;

        }

        public void AjouterDonateur(string prenom, string nom, string adresse, string telephone, char typeCarte, string numeroCarte, string dateExpiration)
        {

            donateurs.Add(new Donateur(prenom, nom, adresse, telephone, typeCarte, numeroCarte, dateExpiration));

        }

        public void AjouterCommanditaire(string prenom, string nom, string nomEntreprise)
        {
            commanditaires.Add(new Commanditaire(prenom, nom, nomEntreprise));
        }


        public void AjouterPrix(string description, double valeur, int quatite_originale, string commanditaire, int nbPrix)
        {
            prix.Add(new Prix(description, valeur, quatite_originale, commanditaire, nbPrix));
        }

        public void AjouterDon(string date, string idDonateur, double montantDon)
        {
            dons.Add(new Don(date, idDonateur, montantDon));
        }


        public string AfficherDonateur()
        {
            string chaine = "";
            for (int i = 0; i < Donateur.GetNbDonateur(); i++)
            {
                chaine += donateurs[i].ToString() + "\n";
            }
            return chaine;
        }

        public string AfficherCommanditaires()
        {
            string chaine = "";
            for (int i = 0; i < commanditaires.Count(); i++)
            {
                chaine += commanditaires[i].ToString() + "\n";
            }
            return chaine;
        }
        public string AfficherPrix()
        {
            string chaine = "";
            for (int i = 0; i < prix.Count(); i++)
            {
                chaine += prix[i].ToString() + "\n";
            }
            return chaine;
        }
        public string AfficherDons()
        {
            string chaine = "";
            for (int i = 0; i < dons.Count(); i++)
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
