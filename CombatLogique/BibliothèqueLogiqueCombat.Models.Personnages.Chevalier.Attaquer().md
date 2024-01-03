#### [BibliothèqueLogiqueCombat](readme.md 'readme')
### [BibliothèqueLogiqueCombat.Models.Personnages](readme.md#BibliothèqueLogiqueCombat.Models.Personnages 'BibliothèqueLogiqueCombat.Models.Personnages').[Chevalier](BibliothèqueLogiqueCombat.Models.Personnages.Chevalier.md 'BibliothèqueLogiqueCombat.Models.Personnages.Chevalier')

## Chevalier.Attaquer() Method

Auteur: Claudel D. Roy et Mathieu Duval    
Description: Méthode qui permet au chevalier d'attaquer un autre joueur.   
Date:  2002-05-26     
  
```csharp  
int iDés = 0;    
int iDés8 = _rdm.Next(1, 9);    
int iChevalAttaque = _rdm.Next(0, 3);    
//Bonus du cheval + iDés8 --> iDés    
 return iDés;  
```

```csharp
public override int Attaquer();
```

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')