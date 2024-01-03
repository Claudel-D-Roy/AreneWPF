#### [BibliothèqueLogiqueCombat](readme.md 'readme')
### [BibliothèqueLogiqueCombat.Models.Personnages](readme.md#BibliothèqueLogiqueCombat.Models.Personnages 'BibliothèqueLogiqueCombat.Models.Personnages').[Blanc](BibliothèqueLogiqueCombat.Models.Personnages.Blanc.md 'BibliothèqueLogiqueCombat.Models.Personnages.Blanc')

## Blanc.Attaquer() Method

Auteur: Claudel D. Roy et Mathieu Duval    
Description: Méthode qui permet au magicien blanc d'attaquer un autre joueur.   
Date:  2002-05-26     
  
```csharp  
int iSort = _rdm.Next(0, 4);    
int iPotions = _rdm.Next(0, 3);    
int iLoup = _rdm.Next(0, 2);    
iDésDouble1 = _rdm.Next(1, 5);    
iDésDouble2 = _rdm.Next(1, 5);    
int iDés2d4 = iDésDouble1 + iDésDouble2;    
//Tout les bonus sont additionés et ajouter au iDés.    
return iDés;  
```

```csharp
public override int Attaquer();
```

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')