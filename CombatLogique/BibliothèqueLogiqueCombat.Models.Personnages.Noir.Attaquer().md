#### [BibliothèqueLogiqueCombat](readme.md 'readme')
### [BibliothèqueLogiqueCombat.Models.Personnages](readme.md#BibliothèqueLogiqueCombat.Models.Personnages 'BibliothèqueLogiqueCombat.Models.Personnages').[Noir](BibliothèqueLogiqueCombat.Models.Personnages.Noir.md 'BibliothèqueLogiqueCombat.Models.Personnages.Noir')

## Noir.Attaquer() Method

Auteur: Claudel D. Roy et Mathieu Duval    
Description: Méthode qui permet au magicien noir d'attaquer un autre joueur.   
Date:  2002-05-26     
  
```csharp  
int iDés10 = _rdm.Next(1, 11);  
int iDémon = _rdm.Next(0, 2);  
int iSort = _rdm.Next(0, 4);  
int iPotions = _rdm.Next(0, 3);  
 //Tout les bonus sont additionés et ajouter au iDés.    
 return iDés;  
```

```csharp
public override int Attaquer();
```

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')