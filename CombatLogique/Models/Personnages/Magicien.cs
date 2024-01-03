using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliothèqueLogiqueCombat.Models.Personnages
{
    /// <summary>
    /// Auteur: Claudel D. Roy et Mathieu Duval  
    /// Description: Classe qui contient les spécification du magicien.   
    /// Date:  2002-05-26   
    /// </summary>
    public abstract class Magicien : Personnage
    {
        #region Énumérations
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Énumération pour trouver quel est le bonus de potion accordé au magicien.  
        /// Date:  2002-05-26   
        /// </summary>
        public enum Potions
        {
            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description: Ne donne aucun bonus.   
            /// Date:  2002-05-26  
            /// </summary>
            Rien,
            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description: Donne un bonus de vie.   
            /// Date:  2002-05-26  
            /// </summary>
            Mana,
            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description: Donne un bonus de mana.   
            /// Date:  2002-05-26  
            /// </summary>
            Vie
        }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Énumération pour trouver quel sont les sorts accordés au magicien.  
        /// Date:  2002-05-26   
        /// </summary>
        public enum Sorts
        {
            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description: Sort de feu.   
            /// Date:  2002-05-26  
            /// </summary>
            Feu,
            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description: Sort d'éléctrcité.     
            /// Date:  2002-05-26  
            /// </summary>
            Électricité,
            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description: Sort de terre.  
            /// Date:  2002-05-26  
            /// </summary>
            Terre,
            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description: Sort d'eau.   
            /// Date:  2002-05-26  
            /// </summary>
            Eau

        }
        #endregion
        #region Propriétés
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Permet d'appeler l'énumération.   
        /// Date:  2002-05-26  
        /// </summary>
        public Sorts Sort { get; set; }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Permet d'appeler l'énumération.   
        /// Date:  2002-05-26  
        /// </summary>
        public Potions Potion { get; set; }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Permet de contenir le nombre de mana.  
        /// Date:  2002-05-26  
        /// </summary>
        public int Mana { get; set; }

        #endregion
    }
}