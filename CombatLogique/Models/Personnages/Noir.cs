using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliothèqueLogiqueCombat.Models.Personnages
{
    /// <summary>
    /// Auteur: Claudel D. Roy et Mathieu Duval  
    /// Description: Classe qui contient les spécification du magicien noir.   
    /// Date:  2002-05-26   
    /// </summary>
    public class Noir : Magicien
    {
        #region Énumérations
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Énumération pour trouver quel est le bonus du démon accordé au magicien blanc.  
        /// Date:  2002-05-26   
        /// </summary>
        public enum Demon
        {

            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description: Donne un bonus d'attaque.   
            /// Date:  2002-05-26  
            /// </summary>
            Attaquer,
            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description: Donne un bonus de défence.   
            /// Date:  2002-05-26  
            /// </summary>
            Défendre
        }
        #endregion
        #region Champs
        Random _rdm = new Random();
        #endregion
        #region Propriétés
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Permet de donner un nombre au bonus du démon.   
        /// Date:  2002-05-26  
        /// </summary>
        public string NomDemon { get; set; }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Permet d'appeler l'énumération.   
        /// Date:  2002-05-26  
        /// </summary>
        public Demon AttaqueDémon { get; set; }
        #endregion
        #region Méthodes
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Méthode qui permet au magicien noir d'attaquer un autre joueur. 
        /// Date:  2002-05-26   
        /// <code>
        /// int iDés10 = _rdm.Next(1, 11);
        /// int iDémon = _rdm.Next(0, 2);
        /// int iSort = _rdm.Next(0, 4);
        /// int iPotions = _rdm.Next(0, 3);
        ///  //Tout les bonus sont additionés et ajouter au iDés.  
        ///  return iDés;  
        /// </code>
        /// </summary>
        public override int Attaquer()
        {
            //Variables locales
            int iDés = 0;
            int iDémonDéfence = 0;
            int iDémonAttaque = 0;
            int iDés10 = _rdm.Next(1, 11);
            int iDémon = _rdm.Next(0, 2);
            int iSort = _rdm.Next(0, 4);
            int iPotions = _rdm.Next(0, 3);
            ClasseArmure = 0;

            if (NbAttaque == 0 || Niveau == 1)
                Mana = 200;
            else if (NbAttaque == 0 || Niveau > 1)
            {
                Mana = 200;
                Mana = ((int)(Mana + (((double)(Mana) * 0.10)) * Niveau - 1));

            }

            if (Mana < 0)
                iDés = 0;
            else
            {
                switch (iDémon)
                {

                    case 0:
                        iDémonAttaque = _rdm.Next(1, 40);
                        AttaqueDémon = Demon.Attaquer;
                        Mana = Mana - 20;
                        iDés = iDés10 + iDémonAttaque;
                        break;
                    case 1:
                        iDémonDéfence = _rdm.Next(1, 35);
                        AttaqueDémon = Demon.Défendre;
                        Mana = Mana - 10;
                        ClasseArmure = iDémonDéfence;
                        break;
                }
                switch (iPotions)
                {
                    case 0:
                        Potion = Potions.Rien;
                        iDés = iDés10;
                        break;
                    case 1:
                        Potion = Potions.Mana;
                        int iMana = _rdm.Next(1, 21);
                        Mana = Mana + iMana;
                        break;
                    case 2:
                        Potion = Potions.Vie;
                        int iVie = _rdm.Next(1, 10);
                        PointVie = PointVie + iVie;
                        break;
                }
                switch (iSort)
                {
                    case 0:
                        Sort = Sorts.Feu;
                        Mana = Mana - 5;
                        break;
                    case 1:
                        Sort = Sorts.Électricité;
                        Mana = Mana - 5;
                        break;
                    case 2:
                        Sort = Sorts.Terre;
                        Mana = Mana - 5;
                        break;
                    case 3:
                        Sort = Sorts.Eau;
                        Mana = Mana - 5;
                        break;
                }
            }

            return iDés;

        }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Méthode qui permet au magicien noir de ce défendre contre un autre joueur. 
        /// Date:  2002-05-26   
        /// <code>
        ///    int Armure = 8;
        ///    ClasseArmure = iClasseArmure;
        ///    return iClasseArmure;
        /// </code>
        /// </summary>
        public override int Defendre()
        {
            //Variables locales
            int iClasseArmure = 0;

            int Armure = 8;
            iClasseArmure = ClasseArmure + Armure;
            ClasseArmure = iClasseArmure;
            return iClasseArmure;
        }
        #endregion
    }
}