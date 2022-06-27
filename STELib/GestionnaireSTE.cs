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
        public  string AttribuerPrix(double montantDon)
        {
            int points = 0;
            if (montantDon < 50) { 
            }
            else if (montantDon >= 50 && montantDon < 200)
            {
                points = 1;
            }
            else if (montantDon >= 200 && montantDon < 350)
            {
                points = 2;
            }
            else if (montantDon >= 350 && montantDon < 500)
            {
                points = 3;
            }
            else { 
                points = 5 + 4*((int)(montantDon/500)-1);
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

            recompense = chercherPrix(recompense);
            return recompense;
            }

        /// <summary>
        /// On enregistre les donateurs dans un fichier pour qu’ils soient disponibles à la prochaine session
        /// </summary>
        /// <returns></returns>
        public static Boolean EnregistrerDonateur()
        {
            //TODO EnregistrerDonateur()
            return true;
        }

        /// <summary>
        /// ChercherPrix : On fournit le plus haut prix auquel le donateur aurait droit. La méthode cherche si cette récompense est toujours disponible
        /// dans l’inventaire. Si c’est le cas elle renvoie la mếme récompense. Sinon elle renvoie la plus haute récompense disponible d’une moindre valeur
        /// </summary>
        /// <param name="prixCherche"></param>
        /// <returns></returns>
        public string chercherPrix(string prixCherche) {
            string[] prixPossible = { "Téléviseur", "BBQ", "Repas pour deux", "Calendrier" };
            int indicePrix = Array.IndexOf(prixPossible, prixCherche);
            string prixNonTrouve = "Désolé nous n’avons plus de récompenses";

            //Chercher dans le tableau prix la chaine prix determiner
            //pour chaque éléments de prix[]
            for(int j = indicePrix; j < prixPossible.Length; j++)
            {
                for (int i = 0; i < prix.Count; i++)
                {
                    if (prixPossible[j] == prix[i].Descripition) {
                        if (prix[i].QuantiteActuelle > 0) {
                            prix[i].Deduire(1);
                            return prixPossible[j];
                            
                        }
                    }
                }
            }
            
            return prixNonTrouve;
        }
        public int SommeDons() {
            int total = 0;


            return total;
        }
    }
}
