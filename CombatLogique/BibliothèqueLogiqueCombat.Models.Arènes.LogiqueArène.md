#### [BibliothèqueLogiqueCombat](readme.md 'readme')
### [BibliothèqueLogiqueCombat.Models.Arènes](readme.md#BibliothèqueLogiqueCombat.Models.Arènes 'BibliothèqueLogiqueCombat.Models.Arènes')

## LogiqueArène Class

Auteur: Claudel D. Roy et Mathieu Duval    
Description: Classe qui contient la logique de l'arène de combat     
Date:  2002-05-26     
  
```csharp  
Archer _archer = new Archer();    
Chevalier _chevalier = new Chevalier();    
Blanc _blanc = new Blanc();    
Noir _noir = new Noie();  
```

```csharp
public class LogiqueArène
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; LogiqueArène

| Fields | |
| :--- | :--- |
| [_Archer](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._Archer.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._Archer') | Auteur: Claudel D. Roy et Mathieu Duval   <br/>Description: Nouvelle objet pour initialiser les propriétés de bases  <br/>Date:  2002-05-26 |
| [_Blanc](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._Blanc.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._Blanc') | Auteur: Claudel D. Roy et Mathieu Duval   <br/>Description: Nouvelle objet pour initialiser les propriétés de bases  <br/>Date:  2002-05-26 |
| [_Chevalier](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._Chevalier.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._Chevalier') | Auteur: Claudel D. Roy et Mathieu Duval    <br/>Description: Nouvelle objet pour initialiser les propriétés de bases  <br/>Date:  2002-05-26 |
| [_FinDuJeux](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._FinDuJeux.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._FinDuJeux') | Auteur: Claudel D. Roy et Mathieu Duval   <br/>Description: Constante pour déterminé si le niveau 10 est atteint.  <br/>Date:  2002-05-26 |
| [_listPersonnage](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._listPersonnage.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._listPersonnage') | Auteur: Claudel D. Roy et Mathieu Duval<br/>Description: Liste qui contient les huits personnages  <br/>Date:  2002-05-26 |
| [_Noir](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._Noir.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._Noir') | Auteur: Claudel D. Roy et Mathieu Duval   <br/>Description: Nouvelle objet pour initialiser les propriétés de bases  <br/>Date:  2002-05-26 |
| [_NomArcher](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._NomArcher.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._NomArcher') | Auteur: Claudel D. Roy et Mathieu Duval  <br/>Description: Liste de nom pour les archers  <br/>Date:  2002-05-26 |
| [_NomBlanc](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._NomBlanc.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._NomBlanc') | Auteur: Claudel D. Roy et Mathieu Duval  <br/>Description: Liste de nom pour les magiciens blancs  <br/>Date:  2002-05-26 |
| [_NomChevalier](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._NomChevalier.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._NomChevalier') | Auteur: Claudel D. Roy et Mathieu Duval  <br/>Description: Liste de nom pour les chevaliers  <br/>Date:  2002-05-26 |
| [_NomDémon](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._NomDémon.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._NomDémon') | Auteur: Claudel D. Roy et Mathieu Duval  <br/>Description: Liste de nom pour les démons du magicien noir  <br/>Date:  2002-05-26 |
| [_NomInvocation](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._NomInvocation.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._NomInvocation') | Auteur: Claudel D. Roy et Mathieu Duval  <br/>Description: Liste de nom pour les loups du magicien blanc  <br/>Date:  2002-05-26 |
| [_NomNoir](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._NomNoir.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._NomNoir') | Auteur: Claudel D. Roy et Mathieu Duval   <br/>Description: Liste de nom pour les magiciens noirs  <br/>Date:  2002-05-26 |
| [_sAttaquant](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._sAttaquant.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._sAttaquant') | Auteur: Claudel D. Roy et Mathieu Duval   <br/>Description: Constante pour déterminé le bonus d'attaque de chaque personnage.  <br/>Date:  2002-05-26 |
| [_sDéfenseur](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._sDéfenseur.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène._sDéfenseur') | Auteur: Claudel D. Roy et Mathieu Duval   <br/>Description: Constante pour déterminé le bonus d'attaque de chaque personnage.  <br/>Date:  2002-05-26 |

| Methods | |
| :--- | :--- |
| [AttaquerPersonnageNv10()](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.AttaquerPersonnageNv10().md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.AttaquerPersonnageNv10()') | Auteur : Claudel D. Roy et Mathieu Duval  <br/>Description : Permet de l'action de la case à cocher "tout" dans le xaml.  <br/>Date : 2022-05-26 |
| [AttaquerUnTourPersonnage()](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.AttaquerUnTourPersonnage().md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.AttaquerUnTourPersonnage()') | Auteur : Claudel D. Roy et Mathieu Duval  <br/>Description : Permet un tour complet, les huits personnages s'attaque un versus un.  <br/>Date : 2022-05-26 |
| [AugmenterNiveau()](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.AugmenterNiveau().md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.AugmenterNiveau()') | Auteur : Claudel D. Roy et Mathieu Duval  <br/>Description : Permet d'augmenter les niveaux des personnages.  <br/>Date : 2022-05-26 |
| [CréationDesÉquipes()](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.CréationDesÉquipes().md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.CréationDesÉquipes()') | Auteur : Claudel D. Roy et Mathieu Duval  <br/>Description : Permet de créé les équipes de façon aléatoire et remet la liste   <br/>              à zéro lors du recommencement de la parti.<br/>Date : 2022-05-26 |
| [GénéréAttaque()](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.GénéréAttaque().md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.GénéréAttaque()') | Auteur : Claudel D. Roy et Mathieu Duval  <br/>Description : Permet de déterminé le nombre du dés 20 et les bonus d'attaque des personnages.  <br/>Date : 2022-05-26 |
| [MélangerListe()](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.MélangerListe().md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.MélangerListe()') | Auteur : Claudel D. Roy et Mathieu Duval  <br/>Description : Permet de mélanger le liste des personnages de façon aléatoire.  <br/>Date : 2022-05-26 |
| [RéinitialiserPointDeVie()](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.RéinitialiserPointDeVie().md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.RéinitialiserPointDeVie()') | Auteur : Claudel D. Roy et Mathieu Duval  <br/>Description : Permet de réinitialiser les points de vie après chaque combat.  <br/>Date : 2022-05-26 |
