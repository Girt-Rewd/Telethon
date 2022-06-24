using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// TODO Appliquer les techniques de gestion d'erreurs et de traitement d'exceptions.


namespace STELib
{
    public class GestionnaireSTE
    {
        /// <summary>
        /// La classe Gestionnaire est le moteur de ce projet. On y retrouve l’ensemble des fonctions qui permettent l’ajout et l’affichage des 
        /// éléments du projets.  Elle stocke les données jusqu’à leur remisage. Elle contient aussi des méthodes de calcul qui lient les autres objets
        /// </summary>

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

            // initialisation des prix disponibles;
            prix.Add(new Prix("Calendrier", 10.00, 2000, "CMDT10000", prix.Count));
            prix.Add(new Prix("Repas pour deux", 100.00, 200, "CMDT10000", prix.Count));
            prix.Add(new Prix("BBQ", 300, 30, "CMDT10000", prix.Count));
            prix.Add(new Prix("Téléviseur", 1000, 20, "CMDT10000", prix.Count));


        }
        /// <summary>
        /// Permet d’ajouter un donateur au tableau donateur. 
        /// </summary>
        /// <param name="prenom"></param>
        /// <param name="nom"></param>
        /// <param name="adresse"></param>
        /// <param name="telephone"></param>
        /// <param name="typeCarte"></param>
        /// <param name="numeroCarte"></param>
        /// <param name="dateExpiration"></param>
        /// <param name="nbDonateur"></param>
        public void AjouterDonateur(string prenom, string nom, string adresse, string telephone, char typeCarte, string numeroCarte, string dateExpiration, int nbDonateur)
        {

            donateurs.Add(new Donateur(prenom, nom, adresse, telephone, typeCarte, numeroCarte, dateExpiration, nbDonateur));
        }

        /// <summary>
        /// Crée et ajoute un commanditaire au tableau commanditaires. 
        /// </summary>
        /// <param name="prenom"></param>
        /// <param name="nom"></param>
        /// <param name="nb"></param>
        public void AjouterCommanditaire(string prenom, string nom, int nb)
        {
            commanditaires.Add(new Commanditaire(prenom, nom, nb ));
        }
        /// <summary>
        /// Crée et ajoute un prix au tableau prix. 
        /// </summary>
        /// <param name="description"></param>
        /// <param name="valeur"></param>
        /// <param name="quatite_originale"></param>
        /// <param name="commanditaire"></param>
        /// <param name="nbPrix"></param>
        public void AjouterPrix(string description, double valeur, int quatite_originale, string commanditaire, int nbPrix)
        {
            prix.Add(new Prix(description, valeur, quatite_originale, commanditaire, nbPrix));
        }

        /// <summary>
        /// Crée et ajoute un don au tableau dons. 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="idDonateur"></param>
        /// <param name="montantDon"></param>
        /// <param name="nbDon"></param>
        public void AjouterDon(string date, string idDonateur, double montantDon, int nbDon)
        {
            dons.Add(new Don(date, idDonateur, montantDon, nbDon));
        }

        /// <summary>
        /// Affiche tous les donateurs enregistrés
        /// </summary>
        /// <returns>string</returns>
        public string AfficherDonateurs()
        {
            string chaine = "";
            foreach (Donateur listDonateurs in donateurs)
            {
                chaine += listDonateurs.ToString() + "\r\n";
            }
            return chaine;
        }

        /// <summary>
        /// Affiche tous les commanditaires enregistrés
        /// </summary>
        /// <returns></returns>
        public string AfficherCommanditaires()
        {
            string chaine = "";
            foreach (Commanditaire listCommanditaire in commanditaires)
            {
                chaine += listCommanditaire.ToString() + "\r\n";
            }
            return chaine;
        }

        /// <summary>
        /// Affiche tous les prix enregistrés
        /// </summary>
        /// <returns>string</returns>
        public string AfficherPrix()
        {
            string chaine = "";
            foreach (Prix listPrix in prix)
            {
                chaine += listPrix.ToString() + "\r\n";
            }
            return chaine;
        }

        /// <summary>
        /// Affiche tous les dons enregistrés
        /// </summary>
        /// <returns></returns>
        public string AfficherDons()
        {
            string chaine = "";
            foreach (Don listDons in dons)
            {
                chaine += listDons.ToString() + "\r\n";
            }
            return chaine;
        }

        /// <summary>
        /// Permet de 
        ///     1. calculer les points gagnés par un donateur en fonction de son don
        ///     2. Attribuer un prix correspondant au nombre de points
        /// </summary>
        public static string AttribuerPrix(double montant)
        {
            int points = 0;
            if (montant < 50) { 
            }
            else if (montant >= 50 && montant < 200)
            {
                points = 1;
            }
            else if (montant >= 200 && montant < 350)
            {
                points = 2;
            }
            else if (montant >= 350 && montant < 500)
            {
                points = 3;
            }
            else { 
                points = 5 + 4*((int)(montant/500)-1);
            }

            string recompense;
            if (points >= 20)
            {
                recompense = "Téléviseur";
            }
            else if (points >= 15)
            {
                recompense = "BBQ";

            }
            else if (points >= 10)
            {
                recompense = "Repas pour deux";

            }
            else if (points >= 1)
            {
                recompense = "Calendrier";
            }
            else
            {
                recompense = String.Empty;
            }

            return recompense;
            }

        /// <summary>
        /// TODO Commentaire EnregistrerDonateur()
        /// On enregistre les donateurs dans un fichier?
        /// </summary>
        /// <returns></returns>
        public static Boolean EnregistrerDonateur()
        {
            //TODO EnregistrerDonateur()
            return true;
        }
    }
}
