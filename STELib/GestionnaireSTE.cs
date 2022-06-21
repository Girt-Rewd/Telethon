using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// TODO Appliquer les techniques de gestion d'erreurs et de traitement d'exceptions.
// TODO Le préposé doit être redirigé par l’interface s’il y a une erreur de frappe ou un champ non saisi (guidage en ergonomie)
// TODO L’ajout du Donateur, Commanditaire ou Don n’est valide que si tous leschamps sont saisis sauf l’E-mail qui n’est pas obligatoire
// TODO refaire l’interface de manière à alléger la surcharge d’information et de replacer les boutons aux endroit adéquats.
// TODO Clarifier que la carte de crédit fait partie des informations du donateur.
// TODO Ajouter un bouton ou un onglet sur l’interface qui décrit votre projet et son fonctionnement, en mentionnant dans l’en tête les participantsdu projet (nom et prénom des étudiant du groupe).
// TODO Mettre des info-bulles aux besoins pour le guidage de l’utilisateur
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
            foreach (Donateur listDonateurs in donateurs)
            {
                chaine += listDonateurs.ToString() + "\r\n";
            }
            return chaine;
        }

        public string AfficherCommanditaires()
        {
            string chaine = "";
            foreach (Commanditaire listCommanditaire in commanditaires)
            {
                chaine += listCommanditaire.ToString() + "\r\n";
            }
            return chaine;
        }

        public string AfficherPrix()
        {
            string chaine = "";
            foreach (Prix listPrix in prix)
            {
                chaine += listPrix.ToString() + "\r\n";
            }
            return chaine;
        }
        public string AfficherDons()
        {
            string chaine = "";
            foreach (Don listDons in dons)
            {
                chaine += listDons.ToString() + "\r\n";
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
