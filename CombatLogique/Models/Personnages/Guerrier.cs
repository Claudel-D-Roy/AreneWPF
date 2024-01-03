using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliothèqueLogiqueCombat.Models.Personnages
{
    /// <summary>
    /// Auteur: Claudel D. Roy et Mathieu Duval  
    /// Description: Classe qui contient les spécification des guerriers.   
    /// Date:  2002-05-26   
    /// </summary>
    public abstract class Guerrier : Personnage
    {
        #region Énumérations 
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Énumération qui contient les bonus de défences.   
        /// Date:  2002-05-26   
        /// </summary>
        public enum Défend
        {
            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description: Ne donne aucun bonus.   
            /// Date:  2002-05-26  
            /// </summary>
            Rien,
            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description: Donne un bonus de défence.   
            /// Date:  2002-05-26  
            /// </summary>
            Bouclier,
            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description:  Donne un bonus de défence.   
            /// Date:  2002-05-26  
            /// </summary>
            Éviter,
            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description:  Donne un bonus de défence.   
            /// Date:  2002-05-26  
            /// </summary>
            Intimide
        }


        #endregion

        #region Propriétés
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Contient le nombre qui est associé au bonus de défence.   
        /// Date:  2002-05-26  
        /// </summary>
        public int Défence { get; set; }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Contient l'énumération qui est associé au bonus de défence.   
        /// Date:  2002-05-26  
        /// </summary>
        public Défend NomDéfence { get; set; }
        #endregion
    }
}