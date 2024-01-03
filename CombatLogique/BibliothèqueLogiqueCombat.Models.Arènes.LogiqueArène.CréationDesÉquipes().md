#### [BibliothèqueLogiqueCombat](readme.md 'readme')
### [BibliothèqueLogiqueCombat.Models.Arènes](readme.md#BibliothèqueLogiqueCombat.Models.Arènes 'BibliothèqueLogiqueCombat.Models.Arènes').[LogiqueArène](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène')

## LogiqueArène.CréationDesÉquipes() Method

Auteur : Claudel D. Roy et Mathieu Duval    
Description : Permet de créé les équipes de façon aléatoire et remet la liste     
              à zéro lors du recommencement de la parti.  
Date : 2022-05-26      
  
```csharp  
_listPersonnage.Add(new Archer()    
    {    
      Nom = "Archer " + _NomArcher[i],     
      Niveau = 1,    
      Expérience = 0,    
      NbFlèches = 100,    
      PointVie = 17    
    });    
Un for contient toute les classes possibles, il compte jusqu'à temps que la liste soit complète.  
```

```csharp
public void CréationDesÉquipes();
```