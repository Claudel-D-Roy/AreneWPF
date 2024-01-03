#### [BibliothèqueLogiqueCombat](readme.md 'readme')
### [BibliothèqueLogiqueCombat.Models.Arènes](readme.md#BibliothèqueLogiqueCombat.Models.Arènes 'BibliothèqueLogiqueCombat.Models.Arènes').[LogiqueArène](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène')

## LogiqueArène.GénéréAttaque() Method

Auteur : Claudel D. Roy et Mathieu Duval    
Description : Permet de déterminé le nombre du dés 20 et les bonus d'attaque des personnages.    
Date : 2022-05-26   
  
```csharp  
int iDés20 = _rdn.Next(1, 21);    
return iDés20;    
//Plusieurs if sont utiliser dans cette méthodes pour parcourir les      
//possibilités pour les bonus de personnages.  
```

```csharp
public int GénéréAttaque();
```

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')