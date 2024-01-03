#### [BibliothèqueLogiqueCombat](readme.md 'readme')
### [BibliothèqueLogiqueCombat.Models.Arènes](readme.md#BibliothèqueLogiqueCombat.Models.Arènes 'BibliothèqueLogiqueCombat.Models.Arènes').[LogiqueArène](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène')

## LogiqueArène.MélangerListe() Method

Auteur : Claudel D. Roy et Mathieu Duval    
Description : Permet de mélanger le liste des personnages de façon aléatoire.    
Date : 2022-05-26   
  
```csharp  
int iAléatoire = _rdn.Next(0, 7);      
ListePourAléatoire.Add(iAléatoire);    
//Plusieurs boucle for sont utiliser pour avoir une liste de nombre aléatoire.      
//Ces nombres sont associés au position des personnages dans la liste et de ce fait,     
//mélange la liste des personnages.  
```

```csharp
public void MélangerListe();
```