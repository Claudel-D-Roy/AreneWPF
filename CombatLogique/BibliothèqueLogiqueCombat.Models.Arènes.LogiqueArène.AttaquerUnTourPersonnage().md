#### [BibliothèqueLogiqueCombat](readme.md 'readme')
### [BibliothèqueLogiqueCombat.Models.Arènes](readme.md#BibliothèqueLogiqueCombat.Models.Arènes 'BibliothèqueLogiqueCombat.Models.Arènes').[LogiqueArène](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène')

## LogiqueArène.AttaquerUnTourPersonnage() Method

Auteur : Claudel D. Roy et Mathieu Duval    
Description : Permet un tour complet, les huits personnages s'attaque un versus un.    
Date : 2022-05-26    
  
```csharp  
iDésAttaquant = _listPersonnage[iPosPerso1].Attaquer();    
iDésDéfence = _listPersonnage[iPosPerso1].Defendre();    
iDésAttaquant2 = _listPersonnage[iPosPerso2].Attaquer();    
iDésDéfence2 = _listPersonnage[iPosPerso2].Defendre();    
//La méthode attaquer() et défendre() provient de la classes Personnages,     
//elle contient les dés d'attaque et la classe d'armure de chaque personnage.  
```

```csharp
public void AttaquerUnTourPersonnage();
```