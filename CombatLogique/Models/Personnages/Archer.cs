using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliothèqueLogiqueCombat.Models.Personnages
{    /// <summary>
     /// Auteur: Claudel D. Roy et Mathieu Duval  
     /// Description: Classe qui contient les spécification de l'archer.   
     /// Date:  2002-05-26   
     /// </summary>
    public class Archer : Guerrier
    {
        #region Énumérations
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Énumération pour trouver quel est le bonus de flèche accordé à l'archer.  
        /// Date:  2002-05-26  
        /// </summary>
        public enum Flèches
        {
            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description: Ne donne aucun bonus.   
            /// Date:  2002-05-26  
            /// </summary>
            Rien,
            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description: Donne un bonus de flèche double.   
            /// Date:  2002-05-26  
            /// </summary>
            Double,
            /// <summary>
            /// Auteur: Claudel D. Roy et Mathieu Duval  
            /// Description: Donne un bonus de flèche tripple.   
            /// Date:  2002-05-26  
            /// </summary>
            Tripple
        }
        #endregion

        #region Champs
        Random _rdm = new Random();
        #endregion

        #region Propriétés
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Contient le nombre de flèches.   
        /// Date:  2002-05-26   
        /// </summary>
        public int NbFlèches { get; set; }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Contient l'énumération des flèches.   
        /// Date:  2002-05-26   
        /// </summary>
        public Flèches Flèche { get; set; }
        #endregion

        #region Méthodes

        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Méthode qui permet à l'archer d'attaquer un autre joueur. 
        /// Date:  2002-05-26   
        /// <code>
        /// int iDés = 0;
        /// int iDés8 = _rdm.Next(1, 9);
        /// int iFlèches = _rdm.Next(0, 3);
        /// //Bonus de flèche + iDés8 --> iDés
        ///  return iDés;
        /// </code>
        /// </summary>
        public override int Attaquer()
        {
            //Variables locales
            int iDés = 0;
            int iDés8 = _rdm.Next(1, 9);
            int iFlèches = _rdm.Next(0, 3);
            int iDouble = 0;
            int iTripple = 0;

            if (NbAttaque == 0 || Niveau == 1)
                NbFlèches = 100;
            else if (NbAttaque == 0 || Niveau > 1)
            {
                NbFlèches = 100;
                NbFlèches = ((int)(NbFlèches + (((double)(NbFlèches) * 0.13)) * Niveau - 1));
            }

            if (NbFlèches < 0)
                iDés = 0;
            else
            {

                //Bonus de flèche
                switch (iFlèches)
                {
                    case 0:
                        NbFlèches--;
                        Flèche = Flèches.Rien;
                        iDés = iDés8;
                        break;
                    case 1:
                        iDouble = _rdm.Next(1, 3);
                        NbFlèches = NbFlèches - 2;
                        Flèche = Flèches.Double;
                        iDés = iDés8 + iDouble;
                        break;
                    case 2:
                        iTripple = _rdm.Next(1, 5);
                        NbFlèches = NbFlèches - 3;
                        Flèche = Flèches.Tripple;
                        iDés = iDés8 + iTripple;
                        break;
                }
            }

            return iDés;


        }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Méthode qui permet à l'archer de ce défendre contre un autre joueur. 
        /// Date:  2002-05-26   
        /// <code>
        ///    int iDéfend = _rdm.Next(0, 3);  
        ///    int Armure = 9;  
        ///    ClasseArmure = iClasseArmure;  
        ///    return iClasseArmure;  
        ///    //Un switch est utiliser déterminé les bonus optenu.   
        ///    //Ils sont par la suite ajoutés à la classe d'armure  
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
                    Défence = iBouclier;
                    NomDéfence = Défend.Bouclier;
                    break;
                case 2:
                    iÉviter = _rdm.Next(1, 4);
                    Défence = iÉviter;
                    NomDéfence = Défend.Éviter;
                    break;
                case 3:
                    iIntimider = _rdm.Next(1, 3);
                    Défence = iIntimider;
                    NomDéfence = Défend.Intimide;
                    break;

            }

            int Armure = 9;
            iClasseArmure = Armure + Défence;
            ClasseArmure = 0;
            ClasseArmure = iClasseArmure;
            return iClasseArmure;
        }
        
        #endregion
    }

}