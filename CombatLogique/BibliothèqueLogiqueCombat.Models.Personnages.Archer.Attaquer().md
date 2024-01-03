#### [BibliothèqueLogiqueCombat](readme.md 'readme')
### [BibliothèqueLogiqueCombat.Models.Personnages](readme.md#BibliothèqueLogiqueCombat.Models.Personnages 'BibliothèqueLogiqueCombat.Models.Personnages').[Archer](BibliothèqueLogiqueCombat.Models.Personnages.Archer.md 'BibliothèqueLogiqueCombat.Models.Personnages.Archer')

## Archer.Attaquer() Method

Auteur: Claudel D. Roy et Mathieu Duval    
Description: Méthode qui permet à l'archer d'attaquer un autre joueur.   
Date:  2002-05-26     
  
```csharp  
int iDés = 0;  
int iDés8 = _rdm.Next(1, 9);  
int iFlèches = _rdm.Next(0, 3);  
//Bonus de flèche + iDés8 --> iDés  
 return iDés;  
```

```csharp
public override int Attaquer();
```

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')