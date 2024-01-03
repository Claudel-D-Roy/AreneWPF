#### [BibliothèqueLogiqueCombat](readme.md 'readme')
### [BibliothèqueLogiqueCombat.Models.Personnages](readme.md#BibliothèqueLogiqueCombat.Models.Personnages 'BibliothèqueLogiqueCombat.Models.Personnages').[Archer](BibliothèqueLogiqueCombat.Models.Personnages.Archer.md 'BibliothèqueLogiqueCombat.Models.Personnages.Archer')

## Archer.Defendre() Method

Auteur: Claudel D. Roy et Mathieu Duval    
Description: Méthode qui permet à l'archer de ce défendre contre un autre joueur.   
Date:  2002-05-26     
  
```csharp  
int iDéfend = _rdm.Next(0, 3);    
int Armure = 9;    
ClasseArmure = iClasseArmure;    
return iClasseArmure;    
//Un switch est utiliser déterminé les bonus optenu.     
//Ils sont par la suite ajoutés à la classe d'armure  
```

```csharp
public override int Defendre();
```

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')