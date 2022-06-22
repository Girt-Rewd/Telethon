﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// TODO Appliquer les techniques de gestion d'erreurs et de traitement d'exceptions.
// TODO Le préposé doit être redirigé par l’interface s’il y a une erreur de frappe ou un champ non saisi (guidage en ergonomie)
// TODO L’ajout du Donateur, Commanditaire ou Don n’est valide que si tous leschamps sont saisis sauf l’E-mail qui n’est pas obligatoire
// TODO refaire l’interface de manière à alléger la surcharge d’information et de replacer les boutons aux endroit adéquats.
// TODO Mettre des info-bulles aux besoins pour le guidage de l’utilisateur
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

            //TODO initialisation des prix disponibles;

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

        /// <summary>
        /// TODO Commentair EnregistrerDonateur()
        /// On enregistre les donateurs dans un fichier?
        /// </summary>
        /// <returns></returns>
        public Boolean EnregistrerDonateur()
        {
            //TODO EnregistrerDonateur()
            return true;
        }




    }
}
