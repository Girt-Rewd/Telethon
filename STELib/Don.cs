using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STELib
{
    public class Don
    {
        //TODO Constructeur par défaut
        //TODO Constructeur à arguments
        //TODO  ? Constructeur copie?
        //TODO Commentaires
        //TODO Accesseurs

        private static int nbDon = 0;
        private string idDon;
        private string dateDon; //TODO  formatter a l’aide d’une regex
        private double montantDon;

        public new string ToString() {
            return "Identifiant du don : " + idDon + " date du don : " + dateDon + " montant : " + montantDon;
        }

    }
}
