using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BibliothèqueLogiqueCombat.Models;
using CombatWPF.Models;
using BibliothèqueLogiqueCombat.Models.Arènes;
using BibliothèqueLogiqueCombat.Models.Personnages;

namespace CombatWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Champs
        LogiqueArène Logique = new LogiqueArène();
        const string _URIImages = "pack://application:,,,/Images/";
        const string NOM_FICHIER = "Statistique.json";
        #endregion
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval 
        /// Description : code permettant le fonctionnement du xaml
        /// Date: 2022-05-26
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Logique.CréationDesÉquipes();
            lstStats.ItemsSource = Logique._listPersonnage;
            TrierListe();
            lstStats.Items.Refresh();
            AfficherImages();

        }
        #region Méthodes
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval 
        /// Description : Permet d'afficher les images et les spécialités des personnages
        /// Date: 2022-05-26
        /// </summary>
        public void AfficherImages()
        {


            //Image 1
            if (Logique._listPersonnage[0].Nom.StartsWith("Archer"))
            {
                lblImage1.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Archer_Droit.png")));
                if (Logique._listPersonnage[0].Niveau > 1)
                {
                    int Fleches = 0;
                    Fleches = ((int)(Logique._Archer.NbFlèches + (((double)(Logique._Archer.NbFlèches) * 0.13)) * Logique._listPersonnage[0].Niveau - 1));
                    lblPersonnage1.Content = Logique._listPersonnage[0].Nom+ "\r\n" + "Max Flèches : " + Fleches;
                }
                else
                    lblPersonnage1.Content =Logique._listPersonnage[0].Nom + "\r\n" + "Max Flèches : " + Logique._Archer.NbFlèches;
            }
            else if (Logique._listPersonnage[0].Nom.StartsWith("Chevalier"))
            {
                lblImage1.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "chevalier_Droit.png")));
                lblPersonnage1.Content = Logique._listPersonnage[0].Nom + "\r\n" ;
            }
            else if (Logique._listPersonnage[0].Nom.StartsWith("Blanc"))
            {
                lblImage1.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Blanc_Droit.png")));
                if (Logique._listPersonnage[0].Niveau > 1)
                {
                    int Mana = 0;
                    Mana = ((int)(Logique._Blanc.Mana + (((double)(Logique._Blanc.Mana) * 0.10)) * Logique._listPersonnage[0].Niveau - 1));
                    lblPersonnage1.Content = Logique._listPersonnage[0].Nom + "\r\n" + "Loup : " + Logique._NomInvocation[0] + "\r\n" + "Max Mana : " + Mana;
                }
                else
                    lblPersonnage1.Content = Logique._listPersonnage[0].Nom + "\r\n" + "Loup : " + Logique._NomInvocation[0] + "\r\n" + "Max Mana : " + Logique._Blanc.Mana;
            }
            else if (Logique._listPersonnage[0].Nom.StartsWith("Noir"))
            {
                lblImage1.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Noir_Droit.png")));
                if (Logique._listPersonnage[0].Niveau > 1)
                {
                    int Mana = 0;
                    Mana = ((int)(Logique._Noir.Mana + (((double)(Logique._Noir.Mana) * 0.10)) * Logique._listPersonnage[0].Niveau - 1));
                    lblPersonnage1.Content = Logique._listPersonnage[0].Nom + "\r\n" + "Démon : " + Logique._NomInvocation[0] + "\r\n" + "Max Mana : " + Mana;
                }
                else
                    lblPersonnage1.Content = Logique._listPersonnage[0].Nom + "\r\n" + "Démon : " + Logique._NomInvocation[0] + "\r\n" + "Max Mana : " + Logique._Noir.Mana;
            }

            //Image 2
            if (Logique._listPersonnage[1].Nom.StartsWith("Archer"))
            {
                lblImage2.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Archer_Gauche.png")));
                if (Logique._listPersonnage[1].Niveau > 1)
                {
                    int Fleches = 0;
                    Fleches = ((int)(Logique._Archer.NbFlèches + (((double)(Logique._Archer.NbFlèches) * 0.13)) * Logique._listPersonnage[1].Niveau - 1));
                    lblPersonnage2.Content = Logique._listPersonnage[1].Nom + "\r\n" + "Max Flèches : " + Fleches;
                }
                else
                    lblPersonnage2.Content = Logique._listPersonnage[1].Nom + "\r\n" + "Max Flèches : " + Logique._Archer.NbFlèches;
            }
            else if (Logique._listPersonnage[1].Nom.StartsWith("Chevalier"))
            {
                lblImage2.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "chevalier_Gauche.png")));
                lblPersonnage2.Content = Logique._listPersonnage[1].Nom + "\r\n" ;
            }
            else if (Logique._listPersonnage[1].Nom.StartsWith("Blanc"))
            {
                lblImage2.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Blanc_Gauche.png")));
                if (Logique._listPersonnage[1].Niveau > 1)
                {
                    int Mana = 0;
                    Mana = ((int)(Logique._Blanc.Mana + (((double)(Logique._Blanc.Mana) * 0.10)) * Logique._listPersonnage[1].Niveau - 1));
                    lblPersonnage2.Content = Logique._listPersonnage[1].Nom + "\r\n" + "Loup : " + Logique._NomInvocation[1] + "\r\n" + "Max Mana : " + Mana;
                }
                else
                    lblPersonnage2.Content = Logique._listPersonnage[1].Nom + "\r\n" + "Loup : " + Logique._NomInvocation[1] + "\r\n" + "Max Mana : " + Logique._Blanc.Mana;
            }
            else if (Logique._listPersonnage[1].Nom.StartsWith("Noir"))
            {
                lblImage2.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Noir_Gauche.png")));
                if (Logique._listPersonnage[1].Niveau > 1)
                {
                    int Mana = 0;
                    Mana = ((int)(Logique._Noir.Mana + (((double)(Logique._Noir.Mana) * 0.10)) * Logique._listPersonnage[1].Niveau - 1));
                    lblPersonnage2.Content = Logique._listPersonnage[1].Nom + "\r\n" + "Démon : " + Logique._NomInvocation[1] + "\r\n" + "Max Mana : " + Mana;
                }
                else
                    lblPersonnage2.Content = Logique._listPersonnage[1].Nom + "\r\n" + "Démon : " + Logique._NomInvocation[1] + "\r\n" + "Max Mana : " + Logique._Noir.Mana;
            }

            //Image 3
            if (Logique._listPersonnage[2].Nom.StartsWith("Archer"))
            {
                lblImage3.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Archer_Droit.png")));
                if (Logique._listPersonnage[2].Niveau > 1)
                {
                    int Fleches = 0;
                    Fleches = ((int)(Logique._Archer.NbFlèches + (((double)(Logique._Archer.NbFlèches) * 0.13)) * Logique._listPersonnage[2].Niveau - 1));
                    lblPersonnage3.Content = Logique._listPersonnage[2].Nom + "\r\n" + "Max Flèches : " + Fleches;
                }
                else
                    lblPersonnage3.Content =Logique._listPersonnage[2].Nom + "\r\n" + "Max Flèches : " + Logique._Archer.NbFlèches;
            }
            else if (Logique._listPersonnage[2].Nom.StartsWith("Chevalier"))
            {
                lblImage3.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "chevalier_Droit.png")));
                lblPersonnage3.Content =Logique._listPersonnage[2].Nom + "\r\n";
            }
            else if (Logique._listPersonnage[2].Nom.StartsWith("Blanc"))
            {
                lblImage3.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Blanc_Droit.png")));
                if (Logique._listPersonnage[2].Niveau > 1)
                {
                    int Mana = 0;
                    Mana = ((int)(Logique._Blanc.Mana + (((double)(Logique._Blanc.Mana) * 0.10)) * Logique._listPersonnage[2].Niveau - 1));
                    lblPersonnage3.Content = Logique._listPersonnage[2].Nom + "\r\n" + "Loup : " + Logique._NomInvocation[2] + "\r\n" + "Max Mana : " + Mana;
                }
                else
                    lblPersonnage3.Content = Logique._listPersonnage[2].Nom + "\r\n" + "Loup : " + Logique._NomInvocation[2] + "\r\n" + "Max Mana : " + Logique._Blanc.Mana;
            }
            else if (Logique._listPersonnage[2].Nom.StartsWith("Noir"))
            {
                lblImage3.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Noir_Droit.png")));
                if (Logique._listPersonnage[2].Niveau > 1)
                {
                    int Mana = 0;
                    Mana = ((int)(Logique._Noir.Mana + (((double)(Logique._Noir.Mana) * 0.10)) * Logique._listPersonnage[2].Niveau - 1));
                    lblPersonnage3.Content =  Logique._listPersonnage[2].Nom + "\r\n" + "Démon : " + Logique._NomInvocation[2] + "\r\n" + "Max Mana : " + Mana;
                }
                else
                    lblPersonnage3.Content = Logique._listPersonnage[2].Nom + "\r\n" + "Démon : " + Logique._NomInvocation[2] + "\r\n" + "Max Mana : " + Logique._Noir.Mana;
            }

            //Image 4
            if (Logique._listPersonnage[3].Nom.StartsWith("Archer"))
            {
                lblImage4.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Archer_Gauche.png")));
                if (Logique._listPersonnage[3].Niveau > 1)
                {
                    int Fleches = 0;
                    Fleches = ((int)(Logique._Archer.NbFlèches + (((double)(Logique._Archer.NbFlèches) * 0.13)) * Logique._listPersonnage[3].Niveau - 1));
                    lblPersonnage4.Content = Logique._listPersonnage[3].Nom + "\r\n" + "Max Flèches : " + Fleches;
                }
                else
                    lblPersonnage4.Content =  Logique._listPersonnage[3].Nom + "\r\n" + "Max Flèches : " + Logique._Archer.NbFlèches;
            }
            else if (Logique._listPersonnage[3].Nom.StartsWith("Chevalier"))
            {
                lblImage4.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "chevalier_Gauche.png")));
                lblPersonnage4.Content = Logique._listPersonnage[3].Nom + "\r\n" ;
            }
            else if (Logique._listPersonnage[3].Nom.StartsWith("Blanc"))
            {
                lblImage4.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Blanc_Gauche.png")));
                if (Logique._listPersonnage[3].Niveau > 1)
                {
                    int Mana = 0;
                    Mana = ((int)(Logique._Blanc.Mana + (((double)(Logique._Blanc.Mana) * 0.10)) * Logique._listPersonnage[3].Niveau - 1));
                    lblPersonnage4.Content =  Logique._listPersonnage[3].Nom + "\r\n" + "Loup : " + Logique._NomInvocation[3] + "\r\n" + "Max Mana : " + Mana;
                }
                else
                    lblPersonnage4.Content = Logique._listPersonnage[3].Nom + "\r\n" + "Loup : " + Logique._NomInvocation[3] + "\r\n" + "Max Mana : " + Logique._Blanc.Mana;
            }
            else if (Logique._listPersonnage[3].Nom.StartsWith("Noir"))
            {
                lblImage4.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Noir_Gauche.png")));
                if (Logique._listPersonnage[3].Niveau > 1)
                {
                    int Mana = 0;
                    Mana = ((int)(Logique._Noir.Mana + (((double)(Logique._Noir.Mana) * 0.10)) * Logique._listPersonnage[3].Niveau - 1));
                    lblPersonnage4.Content =  Logique._listPersonnage[3].Nom + "\r\n" + "Démon : " + Logique._NomInvocation[3] + "\r\n" + "Max Mana : " + Mana;
                }
                else
                    lblPersonnage4.Content = Logique._listPersonnage[3].Nom + "\r\n" + "Démon : " + Logique._NomInvocation[3] + "\r\n" + "Max Mana : " + Logique._Noir.Mana;
            }

            //Image 5
            if (Logique._listPersonnage[4].Nom.StartsWith("Archer"))
            {
                lblImage5.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Archer_Droit.png")));
                if (Logique._listPersonnage[4].Niveau > 1)
                {
                    int Fleches = 0;
                    Fleches = ((int)(Logique._Archer.NbFlèches + (((double)(Logique._Archer.NbFlèches) * 0.13)) * Logique._listPersonnage[4].Niveau - 1));
                    lblPersonnage5.Content =  Logique._listPersonnage[4].Nom + "\r\n" + "Max Flèches : " + Fleches;
                }
                else
                    lblPersonnage5.Content = Logique._listPersonnage[4].Nom + "\r\n" + "Max Flèches : " + Logique._Archer.NbFlèches;
            }
            else if (Logique._listPersonnage[4].Nom.StartsWith("Chevalier"))
            {
                lblImage5.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "chevalier_Droit.png")));
                lblPersonnage5.Content =  Logique._listPersonnage[4].Nom + "\r\n";
            }
            else if (Logique._listPersonnage[4].Nom.StartsWith("Blanc"))
            {
                lblImage5.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Blanc_Droit.png")));
                if (Logique._listPersonnage[4].Niveau > 1)
                {
                    int Mana = 0;
                    Mana = ((int)(Logique._Blanc.Mana + (((double)(Logique._Blanc.Mana) * 0.10)) * Logique._listPersonnage[4].Niveau - 1));
                    lblPersonnage5.Content =  Logique._listPersonnage[4].Nom + "\r\n" + "Loup : " + Logique._NomInvocation[4] + "\r\n" + "Max Mana : " + Mana;
                }
                else
                    lblPersonnage5.Content =  Logique._listPersonnage[4].Nom + "\r\n" + "Loup : " + Logique._NomInvocation[4] + "\r\n" + "Max Mana : " + Logique._Blanc.Mana;
            }
            else if (Logique._listPersonnage[4].Nom.StartsWith("Noir"))
            {
                lblImage5.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Noir_Droit.png")));
                if (Logique._listPersonnage[4].Niveau > 1)
                {
                    int Mana = 0;
                    Mana = ((int)(Logique._Noir.Mana + (((double)(Logique._Noir.Mana) * 0.10)) * Logique._listPersonnage[4].Niveau - 1));
                    lblPersonnage5.Content = Logique._listPersonnage[4].Nom + "\r\n" + "Démon : " + Logique._NomInvocation[4] + "\r\n" + "Max Mana : " + Mana;
                }
                else
                    lblPersonnage5.Content = Logique._listPersonnage[4].Nom + "\r\n" + "Démon : " + Logique._NomInvocation[4] + "\r\n" + "Max Mana : " + Logique._Noir.Mana;
            }

            //Image 6
            if (Logique._listPersonnage[5].Nom.StartsWith("Archer"))
            {
                lblImage6.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Archer_Gauche.png")));
                if (Logique._listPersonnage[5].Niveau > 1)
                {
                    int Fleches = 0;
                    Fleches = ((int)(Logique._Archer.NbFlèches + (((double)(Logique._Archer.NbFlèches) * 0.13)) * Logique._listPersonnage[5].Niveau - 1));
                    lblPersonnage6.Content =  Logique._listPersonnage[5].Nom + "\r\n" + "Max Flèches : " + Fleches;
                }
                else
                    lblPersonnage6.Content =  Logique._listPersonnage[5].Nom + "\r\n"+ "Max Flèches : " + Logique._Archer.NbFlèches;
            }
            else if (Logique._listPersonnage[5].Nom.StartsWith("Chevalier"))
            {
                lblImage6.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "chevalier_Gauche.png")));
                lblPersonnage6.Content = Logique._listPersonnage[5].Nom + "\r\n";
            }
            else if (Logique._listPersonnage[5].Nom.StartsWith("Blanc"))
            {
                lblImage6.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Blanc_Gauche.png")));
                if (Logique._listPersonnage[5].Niveau > 1)
                {
                    int Mana = 0;
                    Mana = ((int)(Logique._Blanc.Mana + (((double)(Logique._Blanc.Mana) * 0.10)) * Logique._listPersonnage[5].Niveau - 1));
                    lblPersonnage6.Content =  Logique._listPersonnage[5].Nom + "\r\n" + "Loup : " + Logique._NomInvocation[5] + "\r\n" + "Max Mana : " + Mana;
                }
                else
                    lblPersonnage6.Content =  Logique._listPersonnage[5].Nom + "\r\n" + "Loup : " + Logique._NomInvocation[5] + "\r\n" + "Max Mana : " + Logique._Blanc.Mana;
            }
            else if (Logique._listPersonnage[5].Nom.StartsWith("Noir"))
            {
                lblImage6.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Noir_Gauche.png")));
                if (Logique._listPersonnage[5].Niveau > 1)
                {
                    int Mana = 0;
                    Mana = ((int)(Logique._Noir.Mana + (((double)(Logique._Noir.Mana) * 0.10)) * Logique._listPersonnage[5].Niveau - 1));
                    lblPersonnage6.Content =  Logique._listPersonnage[5].Nom + "\r\n" + "Démon : " + Logique._NomInvocation[5] + "\r\n" + "Max Mana : " + Mana;
                }
                else
                    lblPersonnage6.Content =  Logique._listPersonnage[5].Nom + "\r\n" + "Démon : " + Logique._NomInvocation[5] + "\r\n" + "Max Mana : " + Logique._Noir.Mana;
            }

            //Image 7
            if (Logique._listPersonnage[6].Nom.StartsWith("Archer"))
            {
                lblImage7.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Archer_Droit.png")));
                if (Logique._listPersonnage[6].Niveau > 1)
                {
                    int Fleches = 0;
                    Fleches = ((int)(Logique._Archer.NbFlèches + (((double)(Logique._Archer.NbFlèches) * 0.13)) * Logique._listPersonnage[6].Niveau - 1));
                    lblPersonnage7.Content =  Logique._listPersonnage[6].Nom + "\r\n" + "Max Flèches : " + Fleches;
                }
                else
                    lblPersonnage7.Content =  Logique._listPersonnage[6].Nom + "\r\n" + "Max Flèches : " + Logique._Archer.NbFlèches;
            }
            else if (Logique._listPersonnage[6].Nom.StartsWith("Chevalier"))
            {
                lblImage7.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "chevalier_Droit.png")));
                lblPersonnage7.Content =  Logique._listPersonnage[6].Nom + "\r\n" ;
            }
            else if (Logique._listPersonnage[6].Nom.StartsWith("Blanc"))
            {
                lblImage7.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Blanc_Droit.png")));
                if (Logique._listPersonnage[6].Niveau > 1)
                {
                    int Mana = 0;
                    Mana = ((int)(Logique._Blanc.Mana + (((double)(Logique._Blanc.Mana) * 0.10)) * Logique._listPersonnage[6].Niveau - 1));
                    lblPersonnage7.Content =  Logique._listPersonnage[6].Nom + "\r\n" + "Loup : " + Logique._NomInvocation[6] + "\r\n" + "Max Mana : " + Mana;
                }
                else
                    lblPersonnage7.Content =  Logique._listPersonnage[6].Nom + "\r\n" + "Loup : " + Logique._NomInvocation[6] + "\r\n" + "Max Mana : " + Logique._Blanc.Mana;
            }
            else if (Logique._listPersonnage[6].Nom.StartsWith("Noir"))
            {
                lblImage7.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Noir_Droit.png")));
                if (Logique._listPersonnage[6].Niveau > 1)
                {
                    int Mana = 0;
                    Mana = ((int)(Logique._Noir.Mana + (((double)(Logique._Noir.Mana) * 0.10)) * Logique._listPersonnage[6].Niveau - 1));
                    lblPersonnage7.Content =  Logique._listPersonnage[6].Nom + "\r\n" + "Démon : " + Logique._NomInvocation[6] + "\r\n" + "Max Mana : " + Mana;
                }
                else
                    lblPersonnage7.Content =  Logique._listPersonnage[6].Nom + "\r\n" + "Démon : " + Logique._NomInvocation[6] + "\r\n" + "Max Mana : " + Logique._Noir.Mana;
            }

            //Image 8
            if (Logique._listPersonnage[7].Nom.StartsWith("Archer"))
            {
                lblImage8.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Archer_Gauche.png")));
                if (Logique._listPersonnage[7].Niveau > 1)
                {
                    int Fleches = 0;
                    Fleches = ((int)(Logique._Archer.NbFlèches + (((double)(Logique._Archer.NbFlèches) * 0.13)) * Logique._listPersonnage[7].Niveau - 1));
                    lblPersonnage8.Content = Logique._listPersonnage[7].Nom + "\r\n" + "Max Flèches : " + Fleches;
                }
                else
                    lblPersonnage8.Content = Logique._listPersonnage[7].Nom + "\r\n" + "Max Flèches : " + Logique._Archer.NbFlèches;
            }
            else if (Logique._listPersonnage[7].Nom.StartsWith("Chevalier"))
            {
                lblImage8.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "chevalier_Gauche.png")));
                lblPersonnage8.Content =  Logique._listPersonnage[7].Nom + "\r\n" ;
            }
            else if (Logique._listPersonnage[7].Nom.StartsWith("Blanc"))
            {
                lblImage8.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Blanc_Gauche.png")));
                if (Logique._listPersonnage[7].Niveau > 1)
                {
                    int Mana = 0;
                    Mana = ((int)(Logique._Blanc.Mana + (((double)(Logique._Blanc.Mana) * 0.10)) * Logique._listPersonnage[7].Niveau - 1));
                    lblPersonnage8.Content =  Logique._listPersonnage[7].Nom + "\r\n" + "Loup : " + Logique._NomInvocation[7] + "\r\n" + "Max Mana : " + Mana;
                }
                else
                    lblPersonnage8.Content =  Logique._listPersonnage[7].Nom + "\r\n" + "Loup : " + Logique._NomInvocation[7] + "\r\n" + "Max Mana : " + Logique._Blanc.Mana;

            }
            else if (Logique._listPersonnage[7].Nom.StartsWith("Noir"))
            {
                lblImage8.Background = new ImageBrush(new BitmapImage(new Uri(_URIImages + "Noir_Gauche.png")));
                if (Logique._listPersonnage[7].Niveau > 1)
                {
                    int Mana = 0;
                    Mana = ((int)(Logique._Noir.Mana + (((double)(Logique._Noir.Mana) * 0.10)) * Logique._listPersonnage[7].Niveau - 1));
                    lblPersonnage8.Content =  Logique._listPersonnage[7].Nom + "\r\n" + "Démon : " + Logique._NomInvocation[7] + "\r\n" + "Max Mana : " + Mana;
                }
                else
                    lblPersonnage8.Content =  Logique._listPersonnage[7].Nom + "\r\n" + "Démon : " + Logique._NomInvocation[7] + "\r\n" + "Max Mana : " + Logique._Noir.Mana;

            }
        }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval 
        /// Description : LinQ permettant de trier la liste.
        /// Date: 2022-05-26
        /// </summary>
        public void TrierListe()
        {
            var req = from Liste in Logique._listPersonnage
                      orderby Liste.Niveau
                      select Liste;
            lstStats.ItemsSource = req.OrderByDescending(req => req.Expérience).ToList();
        }
        #endregion


        #region Évenements
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval 
        /// Description : Bouton pour les combats.
        /// Date: 2022-05-26
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCombattre_Click(object sender, RoutedEventArgs e)
        {

            if (chkTout.IsChecked == false)
            {
                if (Logique._FinDuJeux == true)
                {
                    btnCombattre.IsEnabled = true;
                }
                else
                {
                    Logique.AttaquerUnTourPersonnage();
                    TrierListe();
                    lstStats.Items.Refresh();
                    Logique.MélangerListe();
                    AfficherImages();

                }
            }
            else if (chkTout.IsChecked == true)
            {

                if (Logique._FinDuJeux == true)
                {
                    btnCombattre.IsEnabled = true;
                }
                else
                {
                    Logique.AttaquerPersonnageNv10();
                    TrierListe();
                    lstStats.Items.Refresh();
                    AfficherImages();

                }
            }

        }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval 
        /// Description : Bouton pour recommencer la parti.
        /// Date: 2022-05-26
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRéinitialiser_Click(object sender, RoutedEventArgs e)
        {

            Logique._FinDuJeux = false;
            chkTout.IsChecked = false;
            Logique.CréationDesÉquipes();
            TrierListe();
            lstStats.Items.Refresh();
            AfficherImages();
        }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval 
        /// Description : Bouton pour charger la liste.
        /// Date: 2022-05-26
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCharger_Click(object sender, RoutedEventArgs e)
        {

            // Lire le fichier jSON
            if (File.Exists(NOM_FICHIER))
            {
                StreamReader sr = new StreamReader(NOM_FICHIER);
                string sJson = sr.ReadToEnd();
                sr.Close();

                var options = new JsonSerializerOptions
                {
                    Converters = { new PersonnageConverter() },
                    WriteIndented = true
                };

                // Désérialiser le texte JSON
                Logique._listPersonnage = JsonSerializer.Deserialize<List<Personnage>>(sJson, options);
                lstStats.ItemsSource = Logique._listPersonnage;
                TrierListe();
                lstStats.Items.Refresh();
            }

        }
        /// <summary>
        /// Auteur: Claudel D. Roy et Mathieu Duval 
        /// Description : Bouton pour sauvegarder la liste.
        /// Date: 2022-05-26
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSauvegarder_Click(object sender, RoutedEventArgs e)
        {

            var options = new JsonSerializerOptions
            {
                Converters = { new PersonnageConverter() },
                WriteIndented = true
            };
            string sJson = JsonSerializer.Serialize(Logique._listPersonnage, options);


            StreamWriter sw = new StreamWriter(NOM_FICHIER);
            sw.WriteLine(sJson);
            sw.Close();

        }
        #endregion
    }


}

