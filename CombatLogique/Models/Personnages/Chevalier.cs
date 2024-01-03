using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliothèqueLogiqueCombat.Models.Personnages
{
    /// <summary>
    /// Auteur: Claudel D. Roy et Mathieu Duval  
    /// Description: Classe qui contient les spécification du chevalier.   
    /// Date:  2002-05-26   
    /// </summary>
    public class Chevalier : Guerrier
    {
        #region Énumérations
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Énumération pour trouver quel est le bonus du cheval accordé au chevalier.  
        /// Date:  2002-05-26   
        /// </summary>
        public enum AttaqueChevals
        {
            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description: Ne donne aucun bonus.   
            /// Date:  2002-05-26  
            /// </summary>
            Rien,
            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description: Donne un bonus de charge au cheval.   
            /// Date:  2002-05-26  
            /// </summary>
            Charger,
            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description: Donne un bonus de frappe au cheval.   
            /// Date:  2002-05-26  
            /// </summary>
            Frapper
        }
        #endregion
        #region Champs
        Random _rdm = new Random();
        #endregion

        #region Propriétés
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Permet de mettre une valeur au bonus du cheval.   
        /// Date:  2002-05-26  
        /// </summary>
        public int Cheval { get; set; }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Permet de mettre une valeur au bonus du cheval.   
        /// Date:  2002-05-26  
        /// </summary>
        public AttaqueChevals AttaqueCheval { get; set; }
        #endregion
        #region Méthodes

        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Méthode qui permet au chevalier d'attaquer un autre joueur. 
        /// Date:  2002-05-26   
        /// <code>
        /// int iDés = 0;  
        /// int iDés8 = _rdm.Next(1, 9);  
        /// int iChevalAttaque = _rdm.Next(0, 3);  
        /// //Bonus du cheval + iDés8 --> iDés  
        ///  return iDés;  
        /// </code>
        /// </summary>
        public override int Attaquer()
        {
            //Variables locales
            int iDés = 0;
            int iCharger = 0;
            int iFrapper = 0;
            int iDés8 = _rdm.Next(1, 9);
            int iChevalAttaque = _rdm.Next(0, 3);

            //Pour l'attaque de cheval
            switch (iChevalAttaque)
            {
                case 0:
                    iDés = iDés8;
                    AttaqueCheval = AttaqueChevals.Rien;
                    break;
                case 1:
                    iCharger = _rdm.Next(1, 4);
                    AttaqueCheval = AttaqueChevals.Charger;
                    Cheval = iCharger;
                    break;
                case 2:
                    iFrapper = _rdm.Next(1, 4);
                    AttaqueCheval = AttaqueChevals.Frapper;
                    Cheval = iFrapper;
                    break;

            }

            iDés = iDés8 + Cheval;
            Cheval = 0;
            return iDés;

        }

        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Méthode qui permet au chevalier de ce défendre contre un autre joueur. 
        /// Date:  2002-05-26   
        /// <code>
        ///    int iDéfend = _rdm.Next(0, 3);
        ///    int Armure = 11;
        ///    iClasseArmure = Armure + Défence;
        ///    ClasseArmure = iClasseArmure;
        ///    return iClasseArmure;
        ///    //Un switch est utiliser déterminé les bonus optenu. 
        ///    //Ils sont par la suite ajoutés à la classe d'armure.  
        /// </code>
        /// </summary>
        public override int Defendre()
        {
            //Variables locales
            int iClasseArmure = 0;
            int iBouclier = 0;
            int iÉviter = 0;
            int iIntimider = 0;
            int iDéfend = _rdm.Next(0, 4);

            //Bonus de défence
            switch (iDéfend)
            {
                case 0:
                    NomDéfence = Défend.Rien;
                    break;
                case 1:
                    iBouclier = _rdm.Next(1, 3);
                    NomDéfence = Défend.Bouclier;
                    Défence = iBouclier;
                    break;
                case 2:
                    iÉviter = _rdm.Next(1, 4);
                    NomDéfence = Défend.Éviter;
                    Défence = iÉviter;
                    break;
                case 3:
                    iIntimider = _rdm.Next(1, 3);
                    NomDéfence = Défend.Intimide;
                    Défence = iIntimider;
                    break;

            }

            int Armure = 11;
            iClasseArmure = Armure + Défence;
            ClasseArmure = 0;
            Défence = 0;
            ClasseArmure = iClasseArmure;
            return iClasseArmure;
        }

        #endregion
       
    }
}