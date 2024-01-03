using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliothèqueLogiqueCombat.Models.Personnages
{
    /// <summary>
    /// Auteur: Claudel D. Roy et Mathieu Duval  
    /// Description: Classe qui contient les spécification du magicien blanc.   
    /// Date:  2002-05-26   
    /// </summary>
    public class Blanc : Magicien
    {
        #region Énumérations
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Énumération pour trouver quel est le bonus de l'invocation accordé au magicien blanc.  
        /// Date:  2002-05-26   
        /// </summary>
        public enum Invocation
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
        /// Description: Permet de donner un nombre au bonus du loup.   
        /// Date:  2002-05-26  
        /// </summary>
        public string NomLoup { get; set; }

        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Permet d'appeler l'énumération.   
        /// Date:  2002-05-26  
        /// </summary>
        public Invocation Invoquer { get; set; }

        #endregion
        #region Méthodes

        
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Méthode qui permet au magicien blanc d'attaquer un autre joueur. 
        /// Date:  2002-05-26   
        /// <code>
        ///  int iSort = _rdm.Next(0, 4);  
        ///  int iPotions = _rdm.Next(0, 3);  
        ///  int iLoup = _rdm.Next(0, 2);  
        ///  iDésDouble1 = _rdm.Next(1, 5);  
        ///  iDésDouble2 = _rdm.Next(1, 5);  
        ///  int iDés2d4 = iDésDouble1 + iDésDouble2;  
        ///  //Tout les bonus sont additionés et ajouter au iDés.  
        ///  return iDés;  
        /// </code>
        /// </summary>
        public override int Attaquer()
        {
            //Variables locales
            int iDés = 0;
            int iDésDouble1 = 0;
            int iDésDouble2 = 0;
            int iLoupAttaque = 0;
            int iLoupDéfence = 0;


            int iSort = _rdm.Next(0, 4);
            int iPotions = _rdm.Next(0, 3);
            int iLoup = _rdm.Next(0, 2);
            iDésDouble1 = _rdm.Next(1, 5);
            iDésDouble2 = _rdm.Next(1, 5);
            int iDés2d4 = iDésDouble1 + iDésDouble2;
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

                switch (iLoup)
                {
                    case 0:
                        iLoupAttaque = _rdm.Next(1, 35);
                        Mana = Mana - 20;
                        Invoquer = Invocation.Attaquer;
                        iDés = iDés2d4 + iLoupAttaque;
                        break;
                    case 1:
                        iLoupDéfence = _rdm.Next(1, 35);
                        Mana = Mana - 10;
                        Invoquer = Invocation.Défendre;
                        ClasseArmure = iLoupDéfence;
                        break;
                }
                switch (iPotions)
                {
                    case 0:
                        iDés = iDés2d4;
                        Potion = Potions.Rien;
                        break;
                    case 1:
                        int iMana = _rdm.Next(1, 21);
                        Potion = Potions.Mana;
                        Mana = Mana + iMana;
                        break;
                    case 2:
                        int iVie = _rdm.Next(1, 10);
                        Potion = Potions.Vie;
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
        /// Description: Méthode qui permet au magicien blanc de ce défendre contre un autre joueur. 
        /// Date:  2002-05-26   
        /// <code>
        ///    int Armure = 10;  
        ///    ClasseArmure = iClasseArmure;  
        ///    return iClasseArmure;  
        /// </code>
        /// </summary>
        public override int Defendre()
        {
            //Variables locales
            int iClasseArmure = 0;
            int Armure = 10;
            iClasseArmure = ClasseArmure + Armure;

            ClasseArmure = iClasseArmure;
            return iClasseArmure;
        }

        #endregion
    }
}