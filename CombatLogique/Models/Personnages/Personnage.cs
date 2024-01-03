using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliothèqueLogiqueCombat.Models.Personnages
{
    /// <summary>
    /// Auteur: Claudel D. Roy et Mathieu Duval  
    /// Description: Classe qui contient les spécification des personnages.   
    /// Date:  2002-05-26   
    /// </summary>
    public abstract class Personnage
    {
        #region Propriétés
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Contient le nom du personnage.  
        /// Date:  2002-05-26   
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Contient le niveau du personnage.  
        /// Date:  2002-05-26   
        /// </summary>
        public int Niveau { get; set; }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Contient l'expérience du personnage.    
        /// Date:  2002-05-26   
        /// </summary>
        public int Expérience { get; set; }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Contient la classe d'armure du personnage.  
        /// Date:  2002-05-26   
        /// </summary>
        public int ClasseArmure { get; set; }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Contient les points de vie du personnage.  
        /// Date:  2002-05-26   
        /// </summary>
        public int PointVie { get; set; }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Contient le bonus d'attaque du personnage.   
        /// Date:  2002-05-26   
        /// </summary>
        public int BonusAttaque { get; set; }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Contient le maximum de dommage du personnage.  
        /// Date:  2002-05-26   
        /// </summary>
        public int DommageMax { get; set; }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Contient le nombre de victoire du personnage.  
        /// Date:  2002-05-26   
        /// </summary>
        public int Victoire { get; set; }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Contient le nombre de défaite du personnage.  
        /// Date:  2002-05-26   
        /// </summary>
        public int Défaites { get; set; }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Contient le nombre d'attaque du personnage.  
        /// Date:  2002-05-26   
        /// </summary>
        public int NbAttaque { get; set; }
        #endregion

        #region Méthodes
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Permet de donner la méthode Attauqer(); à tous les personnages.  
        /// Date:  2002-05-26   
        /// </summary>
        public abstract int Attaquer();


        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Permet de donner la méthode Defendre(); à tous les personnages.  
        /// Date:  2002-05-26   
        /// </summary>
        public abstract int Defendre();


        #endregion
    }
}