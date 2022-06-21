using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// TODO Appliquer les techniques de gestion d'erreurs et de traitement d'exceptions.
// TODO refaire l’interface de manière à alléger la surcharge d’information et de replacer les boutons aux endroit adéquats.
// TODO Clarifier que la carte de crédit fait partie des informations du donateur.
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

        public void AjouterDonateur(string prenom, string nom, string adresse, string telephone, char typeCarte, string numeroCarte, string dateExpiration, int nbDonateur)
        {

            donateurs.Add(new Donateur(prenom, nom, adresse, telephone, typeCarte, numeroCarte, dateExpiration, nbDonateur));
        }

        public void AjouterCommanditaire(string prenom, string nom, int nb)
        {
            commanditaires.Add(new Commanditaire(prenom, nom, nb ));

        }


        public void AjouterPrix(string description, double valeur, int quatite_originale, string commanditaire, int nbPrix)
        {
            prix.Add(new Prix(description, valeur, quatite_originale, commanditaire, nbPrix));
        }

        public void AjouterDon(string date, string idDonateur, double montantDon, int nbDon)
        {
            dons.Add(new Don(date, idDonateur, montantDon, nbDon));
        }


        public string AfficherDonateurs()
        {
            string chaine = "";
            for (int i = 0; i < donateurs.Count(); i++)
            {
                chaine += donateurs[i].ToString() + "\r\n";// ajout saut de ligne
            }
            return chaine;
        }

        public string AfficherCommanditaires()
        {
            string chaine = "";
            for (int i = 0; i < commanditaires.Count(); i++)
            {
                chaine += commanditaires[i].ToString() + "\r\n";// ajout saut de ligne
            }
            return chaine;
        }

        public string AfficherPrix()
        {
            string chaine = "";
            for (int i = 0; i < prix.Count(); i++)
            {
                chaine += prix[i].ToString() + "\r\n";// ajout saut de ligne
            }
            return chaine;
        }
        public string AfficherDons()
        {
            string chaine = "";
            for (int i = 0; i < dons.Count(); i++)
            {
                chaine += prix[i].ToString() + "\r\n";// ajout saut de ligne
            }
            return chaine;
        }
        public void AttribuerPrix()
        {
            // TODO AttribuerPrix() calcule le nombre de points associé au montant du don.  le nombre de point sera affiché dans la case « Quantité » du groupe Box « attribuer prix »
            // $50 – $199    -> 1 points
            // $200 – $349   -> 2 points
            // $350 – $499   -> 3 points
            // >= $500       -> 5 points
            // toute tranche additionnelle de 500$ donne droit à 400 points supplémentaires

            // (problème ergonomique sur la codification et nommage : le mot quantité et mal utilisé dans cette partie de l’interface)

            // TODO Ensuite Attribuer prix trouve le prix correspondant au nombre de points récompenses.
            // Televiseur       20 points
            // Calendrier        1 point
            // Repas pour deux  10 points
            // BBQ              15 points
            }
        public Boolean EnregistrerDonateur()
        {
            //TODO EnregistrerDonateur()
            return true;
        }




    }
}
