using BibliothèqueLogiqueCombat.Models.Personnages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliothèqueLogiqueCombat.Models.Arènes
{
    /// <summary>
    /// Auteur: Claudel D. Roy et Mathieu Duval  
    /// Description: Classe qui contient la logique de l'arène de combat   
    /// Date:  2002-05-26   
    /// <code>
    /// Archer _archer = new Archer();  
    /// Chevalier _chevalier = new Chevalier();  
    /// Blanc _blanc = new Blanc();  
    /// Noir _noir = new Noie();  
    /// </code>
    /// </summary>
    public class LogiqueArène
    {
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Liste de nom pour les démons du magicien noir  
        /// Date:  2002-05-26   
        /// </summary>
        #region Champs
        public List<string> _NomDémon = new List<string>()
        {
            "Abaddon", "Asmodeus", "Baalberith", "Behemoth",
            "Damballa", "Ishtar", "Lilith", "Loki", "Sammael"
        };
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Liste de nom pour les loups du magicien blanc  
        /// Date:  2002-05-26   
        /// </summary>
        public List<string> _NomInvocation = new List<string>()
        {
            "Asura", "Carbuncle", "Kujata", "Ragnarok",
            "Remora", "Sylph", "Titan", "Zodiark"

        };
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Liste de nom pour les archers  
        /// Date:  2002-05-26   
        /// </summary>
        public List<string> _NomArcher = new List<string>()
        {
            "Huang Zhong", "Ishi", "Jumong", "Taishi",
            "Arjuna", "Artemis", "Ekalavya", "Einar"
        };
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Liste de nom pour les chevaliers  
        /// Date:  2002-05-26   
        /// </summary>
        public List<string> _NomChevalier = new List<string>()
        {
            "Perceval", "Sagremor", "Lancelot", "Arthur",
            "Bedwere", "Galahad", "Édouard", "Henri"
        };
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval  
        /// Description: Liste de nom pour les magiciens blancs  
        /// Date:  2002-05-26   
        /// </summary>
        public List<string> _NomBlanc = new List<string>()
        {
            "Asquith", "Flora", "Pandora", "Magnus",
            "Virion", "Eldon", "Lusha ", "Digby"
        };
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval   
        /// Description: Liste de nom pour les magiciens noirs  
        /// Date:  2002-05-26   
        /// </summary>
        public List<string> _NomNoir = new List<string>()
        {
            "Morden", "Gaius", "Jamis", "Heinrich",
            "Abaris", "Sherman", "Neroon", "Mira"
        };
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval
        /// Description: Liste qui contient les huits personnages  
        /// Date:  2002-05-26   
        /// </summary>
        public List<Personnage> _listPersonnage = new List<Personnage>();
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval   
        /// Description: Nouvelle objet pour initialiser les propriétés de bases  
        /// Date:  2002-05-26  
        /// </summary>
        public Archer _Archer = new Archer()
        {
            PointVie = 17,
            NbFlèches = 150
        };
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval    
        /// Description: Nouvelle objet pour initialiser les propriétés de bases  
        /// Date:  2002-05-26  
        /// </summary>
        public Chevalier _Chevalier = new Chevalier()
        {
            PointVie = 20
        };
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval   
        /// Description: Nouvelle objet pour initialiser les propriétés de bases  
        /// Date:  2002-05-26  
        /// </summary>
        public Noir _Noir = new Noir()
        {
            PointVie = 9,
            Mana = 250
        };
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval   
        /// Description: Nouvelle objet pour initialiser les propriétés de bases  
        /// Date:  2002-05-26  
        /// </summary>
        public Blanc _Blanc = new Blanc()
        {
            PointVie = 11,
            Mana = 250
        };
        Random _rdn = null;
        #endregion
        #region Constantes
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval   
        /// Description: Constante pour déterminé le bonus d'attaque de chaque personnage.  
        /// Date:  2002-05-26  
        /// </summary>
        public string _sAttaquant = "";
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval   
        /// Description: Constante pour déterminé le bonus d'attaque de chaque personnage.  
        /// Date:  2002-05-26  
        /// </summary>
        public string _sDéfenseur = "";
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval   
        /// Description: Constante pour déterminé si le niveau 10 est atteint.  
        /// Date:  2002-05-26  
        /// </summary>
        public bool _FinDuJeux = false;
        #endregion
        #region Méthodes
        /// <summary>
        /// Auteur : Claudel D. Roy et Mathieu Duval  
        /// Description : Permet de créé les équipes de façon aléatoire et remet la liste   
        ///               à zéro lors du recommencement de la parti.
        /// Date : 2022-05-26    
        /// <code>
        /// 
        ///   _listPersonnage.Add(new Archer()  
        ///       {  
        ///         Nom = "Archer " + _NomArcher[i],   
        ///         Niveau = 1,  
        ///         Expérience = 0,  
        ///         NbFlèches = 100,  
        ///         PointVie = 17  
        ///       });  
        /// //Un for contient toute les classes possibles, il compte jusqu'à temps que la liste soit complète.  
        /// </code>
        /// </summary>
        public void CréationDesÉquipes()
        {
            //Variables locales
            int iChoix = 0;
            _rdn = new Random();

            //Remise de la liste a zéro
            if (_listPersonnage.Count > 0)
            {
                for (int i = 8 - 1; i >= 0; i--)
                    _listPersonnage.RemoveAt(i);
            }

            //Les membres de l'équipe sont choisi au hasard
            for (int i = 0; i < 8; i++)
            {
                iChoix = _rdn.Next(0, 4);
                switch (iChoix)
                {
                    case 0:
                        _listPersonnage.Add(new Archer()
                        {
                            Nom = "Archer " + _NomArcher[i],
                            Niveau = 1,
                            Expérience = 0,
                            NbFlèches = 100,
                            PointVie = 17
                        });
                        break;
                    case 1:
                        _listPersonnage.Add(new Chevalier()
                        {
                            Nom = "Chevalier " + _NomChevalier[i],
                            PointVie = 20,
                            Niveau = 1,
                            Expérience = 0
                        });
                        break;
                    case 2:
                        _listPersonnage.Add(new Noir()
                        {
                            Nom = "Noir " + _NomNoir[i],
                            PointVie = 9,
                            Niveau = 1,
                            Expérience = 0,
                            NomDemon = _NomDémon[i]

                        });
                        break;
                    case 3:
                        _listPersonnage.Add(new Blanc()
                        {
                            Nom = "Blanc " + _NomBlanc[i],
                            PointVie = 11,
                            Niveau = 1,
                            Expérience = 0,
                            NomLoup = _NomInvocation[i]

                        });
                        break;
                }
            }
        }
        /// <summary>
        /// Auteur : Claudel D. Roy et Mathieu Duval  
        /// Description : Permet un tour complet, les huits personnages s'attaque un versus un.  
        /// Date : 2022-05-26  
        /// <code>
        ///     iDésAttaquant = _listPersonnage[iPosPerso1].Attaquer();  
        ///     iDésDéfence = _listPersonnage[iPosPerso1].Defendre();  
        ///     iDésAttaquant2 = _listPersonnage[iPosPerso2].Attaquer();  
        ///     iDésDéfence2 = _listPersonnage[iPosPerso2].Defendre();  
        ///     //La méthode attaquer() et défendre() provient de la classes Personnages,   
        ///     //elle contient les dés d'attaque et la classe d'armure de chaque personnage.  
        /// </code>
        /// </summary>
        public void AttaquerUnTourPersonnage()
        {

            int iPosPerso1 = 0;
            int iPosPerso2 = 1;
            bool _bValiderNiveau = false;
            bool _bValide = false;
            bool _bValideTour = false;


            //Le loop pour les 4 combat
            do
            {
                int iDésAttaquant = 0;
                int iDésAttaquant2 = 0;
                int iDésDéfence = 0;
                int iDésDéfence2 = 0;
                int iDés20 = 0;

                if (_listPersonnage[iPosPerso1].Niveau == 10)
                    _bValiderNiveau = true;
                else if (_listPersonnage[iPosPerso2].Niveau == 10)
                    _bValiderNiveau = true;

                if (_listPersonnage[iPosPerso1].NbAttaque == 0)
                {
                    _listPersonnage[iPosPerso1].NbAttaque = 0;
                    _listPersonnage[iPosPerso2].NbAttaque = 0;
                }


                RéinitialiserPointDeVie();
                AugmenterNiveau();
                //Attaque 1 vs 1
                do
                {
                    //Détermine si un personnage est niveau 10
                    if (_listPersonnage[iPosPerso1].Niveau == 10)
                    {
                        _bValide = true;
                        _bValiderNiveau = true;
                    }
                    else if (_listPersonnage[iPosPerso2].Niveau == 10)
                    {
                        _bValide = true;
                        _bValiderNiveau = true;
                    }

                    //Aide pour le bonus d'attaque
                    _sAttaquant = _listPersonnage[iPosPerso1].Nom;
                    _sDéfenseur = _listPersonnage[iPosPerso2].Nom;

                    //Détermine le dés 20 et les bonus d'attaque
                    iDés20 = GénéréAttaque();

                    //Ajuste le bonus d'attaque
                    if (_listPersonnage[iPosPerso1].Nom.StartsWith("Archer"))
                        _listPersonnage[iPosPerso1].BonusAttaque = _Archer.BonusAttaque;
                    else if (_listPersonnage[iPosPerso1].Nom.StartsWith("Noir"))
                        _listPersonnage[iPosPerso1].BonusAttaque = _Noir.BonusAttaque;
                    else if (_listPersonnage[iPosPerso1].Nom.StartsWith("Blanc"))
                        _listPersonnage[iPosPerso1].BonusAttaque = _Blanc.BonusAttaque;
                    else if (_listPersonnage[iPosPerso1].Nom.StartsWith("Chevalier"))
                        _listPersonnage[iPosPerso1].BonusAttaque = _Chevalier.BonusAttaque;

                    //Détermine le dés attaquant et celui qui donne la classe d'armure
                    iDésAttaquant = _listPersonnage[iPosPerso1].Attaquer();
                    iDésDéfence = _listPersonnage[iPosPerso1].Defendre();
                    iDésAttaquant2 = _listPersonnage[iPosPerso2].Attaquer();
                    iDésDéfence2 = _listPersonnage[iPosPerso2].Defendre();

                    //Détermine si le dés 20 est plus haut que la défence de l'adversaire et si c'est le cas, la vie de l'adversaire
                    //diminue et le dommage maximum est enregistrer. Si l'adversaire est vaincus, l'expérience est ajouter et la victoire 
                    // et la défaites est donnée à qui de droit.
                    if (iDés20 > iDésDéfence2)
                    {
                        _listPersonnage[iPosPerso2].PointVie = _listPersonnage[iPosPerso2].PointVie - iDésAttaquant;
                        _listPersonnage[iPosPerso1].NbAttaque++;
                        if (_listPersonnage[iPosPerso1].DommageMax == 0 || _listPersonnage[iPosPerso1].DommageMax > 0)
                        {
                            if (_listPersonnage[iPosPerso1].DommageMax < iDésAttaquant)
                                _listPersonnage[iPosPerso1].DommageMax = iDésAttaquant;
                            else if (_listPersonnage[iPosPerso1].DommageMax > iDésAttaquant)
                                _listPersonnage[iPosPerso1].DommageMax = _listPersonnage[iPosPerso1].DommageMax;

                        }

                        if (_listPersonnage[iPosPerso2].PointVie < 1)
                        {
                            _listPersonnage[iPosPerso1].Expérience = _listPersonnage[iPosPerso1].Expérience + 50;
                            _listPersonnage[iPosPerso1].Victoire++;
                            _listPersonnage[iPosPerso2].Défaites++;
                            _bValide = true;
                            break;
                        }
                        else if (_listPersonnage[iPosPerso1].PointVie < 1)
                        {
                            _listPersonnage[iPosPerso2].Expérience = _listPersonnage[iPosPerso2].Expérience + 50;
                            _listPersonnage[iPosPerso2].Victoire++;
                            _listPersonnage[iPosPerso1].Défaites++;
                            _bValide = true;
                            break;
                        }

                    }


                    //Aide pour le bonus d'attaque
                    _sAttaquant = _listPersonnage[iPosPerso2].Nom;
                    _sDéfenseur = _listPersonnage[iPosPerso1].Nom;

                    //Détermine le dés 20 et les bonus d'attaque
                    iDés20 = GénéréAttaque();

                    //Ajuste le bonus d'attaque
                    if (_listPersonnage[iPosPerso2].Nom.StartsWith("Archer"))
                        _listPersonnage[iPosPerso2].BonusAttaque = _Archer.BonusAttaque;
                    else if (_listPersonnage[iPosPerso2].Nom.StartsWith("Noir"))
                        _listPersonnage[iPosPerso2].BonusAttaque = _Noir.BonusAttaque;
                    else if (_listPersonnage[iPosPerso2].Nom.StartsWith("Blanc"))
                        _listPersonnage[iPosPerso2].BonusAttaque = _Blanc.BonusAttaque;
                    else if (_listPersonnage[iPosPerso2].Nom.StartsWith("Chevalier"))
                        _listPersonnage[iPosPerso2].BonusAttaque = _Chevalier.BonusAttaque;


                    //Détermine si le dés 20 est plus haut que la défence de l'adversaire et si c'est le cas, la vie de l'adversaire
                    //diminue et le dommage maximum est enregistrer. Si l'adversaire est vaincus, l'expérience est ajouter et la victoire 
                    // et la défaites est donnée à qui de droit.
                    if (iDés20 > iDésDéfence)
                    {
                        _listPersonnage[iPosPerso1].PointVie = _listPersonnage[iPosPerso1].PointVie - iDésAttaquant2;
                        _listPersonnage[iPosPerso2].NbAttaque++;

                        if (_listPersonnage[iPosPerso2].DommageMax == 0 || _listPersonnage[iPosPerso2].DommageMax > 0)
                        {
                            if (_listPersonnage[iPosPerso2].DommageMax < iDésAttaquant2)
                                _listPersonnage[iPosPerso2].DommageMax = iDésAttaquant2;
                            else if (_listPersonnage[iPosPerso2].DommageMax > iDésAttaquant2)
                                _listPersonnage[iPosPerso2].DommageMax = _listPersonnage[iPosPerso2].DommageMax;

                        }

                        if (_listPersonnage[iPosPerso2].PointVie < 1)
                        {
                            _listPersonnage[iPosPerso1].Expérience = _listPersonnage[iPosPerso1].Expérience + 50;
                            _listPersonnage[iPosPerso1].Victoire++;
                            _listPersonnage[iPosPerso2].Défaites++;
                            _bValide = true;
                            break;
                        }
                        else if (_listPersonnage[iPosPerso1].PointVie < 1)
                        {
                            _listPersonnage[iPosPerso2].Expérience = _listPersonnage[iPosPerso2].Expérience + 50;
                            _listPersonnage[iPosPerso2].Victoire++;
                            _listPersonnage[iPosPerso1].Défaites++;
                            _bValide = true;
                            break;
                        }
                    }

                } while (!_bValide && !_bValiderNiveau);
                //Remet le booléen a sa valeur d'origine
                _bValide = false;
                //Augmente la valeur de iPosPerso pour passer au prochain joueur.  
                iPosPerso1 = iPosPerso1 + 2;
                iPosPerso2 = iPosPerso2 + 2;

                //Remet le int à zéro pour recommencer le tour.
                if (iPosPerso1 == 8)
                {
                    iPosPerso1 = 0;
                    iPosPerso2 = 1;
                    _bValideTour = true;
                }


            } while (!_bValideTour && !_bValiderNiveau);
            
            RéinitialiserPointDeVie();
            AugmenterNiveau();
            //Détermine si le jeux est terminé.
            _bValideTour = false;
            if (_bValiderNiveau == true)
                _FinDuJeux = true;
        }
        /// <summary>
        /// Auteur : Claudel D. Roy et Mathieu Duval  
        /// Description : Permet de l'action de la case à cocher "tout" dans le xaml.  
        /// Date : 2022-05-26 
        /// <code>
        ///        do  
        ///         {  
        ///             MélangerListe();  
        ///             AttaquerUnTourPersonnage();  
        ///             
        ///         } while (!_FinDuJeux);  
        ///         
        ///        _FinDuJeux = true;  
        /// 
        /// // Une boucle do/while et utiliser pour faire la méthode MélangerListe() et AttaquerUnTourPersonnage()    
        /// // jusqu'à temps qu'un personnage ait atteint le niveau 10.  
        /// </code> 
        /// </summary>
        public void AttaquerPersonnageNv10()
        {
            //Le loop pour le niveau 10
            do
            {
                MélangerListe();
                AttaquerUnTourPersonnage();
            } while (!_FinDuJeux);
            _FinDuJeux = true;

        }
        /// <summary>
        /// Auteur : Claudel D. Roy et Mathieu Duval  
        /// Description : Permet de réinitialiser les points de vie après chaque combat.  
        /// Date : 2022-05-26 
        /// <code>
        ///        
        ///            if (_listPersonnage[i].Nom.StartsWith("Archer"))  
        ///                _listPersonnage[i].PointVie = _Archer.PointVie;  
        ///            else if (_listPersonnage[i].Nom.StartsWith("Chevalier"))  
        ///                _listPersonnage[i].PointVie = _Chevalier.PointVie;  
        ///            else if (_listPersonnage[i].Nom.StartsWith("Noir"))  
        ///                _listPersonnage[i].PointVie = _Noir.PointVie;  
        ///            else if (_listPersonnage[i].Nom.StartsWith("Blanc"))  
        ///                _listPersonnage[i].PointVie = _Blanc.PointVie;  
        ///    //Une boucle for est utilisé dans cette méthode pour remettre les points     
        ///    //de vie des personnages à leur état initiale.
        /// </code> 
        /// </summary>
        public void RéinitialiserPointDeVie()
        {
            //Remet les points de vie à leur valeur d'origine
            for (int i = 0; i < _listPersonnage.Count; i++)
            {
                if (_listPersonnage[i].Nom.StartsWith("Archer"))
                    _listPersonnage[i].PointVie = _Archer.PointVie;
                else if (_listPersonnage[i].Nom.StartsWith("Chevalier"))
                    _listPersonnage[i].PointVie = _Chevalier.PointVie;
                else if (_listPersonnage[i].Nom.StartsWith("Noir"))
                    _listPersonnage[i].PointVie = _Noir.PointVie;
                else if (_listPersonnage[i].Nom.StartsWith("Blanc"))
                    _listPersonnage[i].PointVie = _Blanc.PointVie;
            }
        }
        /// <summary>
        /// Auteur : Claudel D. Roy et Mathieu Duval  
        /// Description : Permet de mélanger le liste des personnages de façon aléatoire.  
        /// Date : 2022-05-26 
        /// <code>
        /// 
        /// int iAléatoire = _rdn.Next(0, 7);    
        /// ListePourAléatoire.Add(iAléatoire);  
        /// //Plusieurs boucle for sont utiliser pour avoir une liste de nombre aléatoire.    
        /// //Ces nombres sont associés au position des personnages dans la liste et de ce fait,   
        /// //mélange la liste des personnages.    
        /// 
        /// </code>
        /// </summary>
        public void MélangerListe()
        {
            List<int> ListePourAléatoire = new List<int>();
            List<Personnage> ListeMélanger = new List<Personnage>();
            int possition = 0;

            //Mélange la liste
            for (int i = 0; i < 8; i++)
            {
                int iAléatoire = _rdn.Next(0, 7);

                if (ListePourAléatoire.Count > 0)
                {
                    do
                    {
                        if (ListePourAléatoire.Contains(iAléatoire))
                            iAléatoire = _rdn.Next(0, 8);

                    } while (ListePourAléatoire.Contains(iAléatoire));

                }

                ListePourAléatoire.Add(iAléatoire);
            }
            //Associe la liste mélanger au personnage de la liste
            for (int i = 0; i < ListePourAléatoire.Count; i++)
            {
                possition = ListePourAléatoire[i];
                ListeMélanger.Add(_listPersonnage[possition]);
            }

            //Remet la liste de personnage a zéro
            for (int i = 8 - 1; i >= 0; i--)
                _listPersonnage.RemoveAt(i);



            //Mélange la liste
            for (int i = 0; i < ListeMélanger.Count; i++)
                _listPersonnage.Add(ListeMélanger[i]);

            //Remet les listes aléatoires a null; 
            for (int i = 8 - 1; i >= 0; i--)
            {
                ListeMélanger.RemoveAt(i);
                ListePourAléatoire.RemoveAt(i);

            }
        }
        /// <summary>
        /// Auteur : Claudel D. Roy et Mathieu Duval  
        /// Description : Permet de déterminé le nombre du dés 20 et les bonus d'attaque des personnages.  
        /// Date : 2022-05-26 
        /// <code>
        ///  int iDés20 = _rdn.Next(1, 21);  
        ///  return iDés20;  
        ///  //Plusieurs if sont utiliser dans cette méthodes pour parcourir les    
        ///  //possibilités pour les bonus de personnages.   
        /// </code>
        /// </summary>
        public int GénéréAttaque()
        {
            //Variables locales
            _rdn = new Random();
            int iDés20 = _rdn.Next(1, 21);


            //détermine le bonus d'attaque.
            if (_sAttaquant.StartsWith("Blanc"))
            {
                if (_sDéfenseur.StartsWith("Noir"))
                {
                    iDés20 = iDés20 + 1;
                    _Blanc.BonusAttaque = 1;
                }
                else if (_sDéfenseur.StartsWith("Chevalier"))
                {
                    _Blanc.BonusAttaque = 1;
                    iDés20 = iDés20 + 1;
                }
                else if (_sDéfenseur.StartsWith("Archer"))
                {
                    _Blanc.BonusAttaque = 1;
                    iDés20 = iDés20 + 1;

                }

            }
            else if (_sAttaquant.StartsWith("Noir"))
            {
                if (_sDéfenseur.StartsWith("Blanc"))
                {
                    iDés20 = iDés20 + 2;
                    _Noir.BonusAttaque = 2;

                }
                else if (_sDéfenseur.StartsWith("Chevalier"))
                {
                    iDés20 = iDés20 + 2;
                    _Noir.BonusAttaque = 2;
                }
                else if (_sDéfenseur.StartsWith("Archer"))
                {
                    iDés20 = iDés20 + 2;
                    _Noir.BonusAttaque = 2;
                }
            }
            else if (_sAttaquant.StartsWith("Chevalier"))
            {
                if (_sDéfenseur.StartsWith("Blanc"))
                {
                    _Chevalier.BonusAttaque = 2;
                    iDés20 = iDés20 + 2;
                }
                else if (_sDéfenseur.StartsWith("Noir"))
                {
                    _Chevalier.BonusAttaque = 2;
                    iDés20 = iDés20 + 2;
                }
                else if (_sDéfenseur.StartsWith("Archer"))
                {
                    _Chevalier.BonusAttaque = 2;
                    iDés20 = iDés20 + 2;
                }
            }
            else if (_sAttaquant.StartsWith("Archer"))
            {
                if (_sDéfenseur.StartsWith("Blanc"))
                {
                    _Archer.BonusAttaque = 2;
                    iDés20 = iDés20 + 2;
                }
                else if (_sDéfenseur.StartsWith("Noir"))
                {
                    _Archer.BonusAttaque = 2;
                    iDés20 = iDés20 + 2;
                }
                else if (_sDéfenseur.StartsWith("Chevalier"))
                {
                    _Archer.BonusAttaque = 3;
                    iDés20 = iDés20 + 3;
                }

            }

            return iDés20;

        }
        /// <summary>
        /// Auteur : Claudel D. Roy et Mathieu Duval  
        /// Description : Permet d'augmenter les niveaux des personnages.  
        /// Date : 2022-05-26 
        /// <code>
        ///  int Niveau = _listPersonnage[i].Niveau;  
        ///   //Deux boucle for sont utiliser pour parcourir chaque personnage et   
        ///  //modifier le niveau et les bonus de vie en conséquence.  
        /// </code>
        /// </summary>
        public void AugmenterNiveau()
        {
           

            for (int i = 0; i < _listPersonnage.Count; i++)
            {

                if (_listPersonnage[i].Expérience > 0)
                {

                    //Augmenter le niveau
                    if (_listPersonnage[i].Expérience < 300)
                        _listPersonnage[i].Niveau = 1;
                    else if (_listPersonnage[i].Expérience >= 300 && _listPersonnage[i].Expérience <= 899)
                        _listPersonnage[i].Niveau = 2;
                    else if (_listPersonnage[i].Expérience >= 900 && _listPersonnage[i].Expérience <= 2699)
                        _listPersonnage[i].Niveau = 3;
                    else if (_listPersonnage[i].Expérience >= 2700 && _listPersonnage[i].Expérience <= 6499)
                        _listPersonnage[i].Niveau = 4;
                    else if (_listPersonnage[i].Expérience >= 6700 && _listPersonnage[i].Expérience <= 13999)
                        _listPersonnage[i].Niveau = 5;
                    else if (_listPersonnage[i].Expérience >= 14000 && _listPersonnage[i].Expérience <= 22999)
                        _listPersonnage[i].Niveau = 6;
                    else if (_listPersonnage[i].Expérience >= 23000 && _listPersonnage[i].Expérience <= 33999)
                        _listPersonnage[i].Niveau = 7;
                    else if (_listPersonnage[i].Expérience >= 34000 && _listPersonnage[i].Expérience <= 47999)
                        _listPersonnage[i].Niveau = 8;
                    else if (_listPersonnage[i].Expérience >= 48000 && _listPersonnage[i].Expérience <= 63999)
                        _listPersonnage[i].Niveau = 9;
                    else if (_listPersonnage[i].Expérience >= 64000)
                        _listPersonnage[i].Niveau = 10;

                }

                if (_listPersonnage[i].Niveau > 1)
                {
                    //Variables locales
                    int Niveau = _listPersonnage[i].Niveau;

                    if (_listPersonnage[i].Nom.StartsWith("Archer"))
                        _listPersonnage[i].PointVie = ((int)(_listPersonnage[i].PointVie + (((double)(_listPersonnage[i].PointVie) * 0.13)) * Niveau - 1));
                    else if (_listPersonnage[i].Nom.StartsWith("Chevalier"))
                        _listPersonnage[i].PointVie = ((int)(_listPersonnage[i].PointVie + (((double)(_listPersonnage[i].PointVie) * 0.10)) * Niveau - 1));
                    else if (_listPersonnage[i].Nom.StartsWith("Blanc"))
                        _listPersonnage[i].PointVie = ((int)(_listPersonnage[i].PointVie + (((double)(_listPersonnage[i].PointVie) * 0.10)) * Niveau - 1));
                    else if (_listPersonnage[i].Nom.StartsWith("Noir"))
                        _listPersonnage[i].PointVie = ((int)(_listPersonnage[i].PointVie + (((double)(_listPersonnage[i].PointVie) * 0.12)) * Niveau - 1));
                }
            }

        }



        #endregion
    }
}