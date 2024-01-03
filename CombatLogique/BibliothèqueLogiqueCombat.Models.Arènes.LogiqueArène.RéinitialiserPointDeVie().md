#### [BibliothèqueLogiqueCombat](readme.md 'readme')
### [BibliothèqueLogiqueCombat.Models.Arènes](readme.md#BibliothèqueLogiqueCombat.Models.Arènes 'BibliothèqueLogiqueCombat.Models.Arènes').[LogiqueArène](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène')

## LogiqueArène.RéinitialiserPointDeVie() Method

Auteur : Claudel D. Roy et Mathieu Duval    
Description : Permet de réinitialiser les points de vie après chaque combat.    
Date : 2022-05-26   
  
```csharp  
if (_listPersonnage[i].Nom.StartsWith("Archer"))    
    _listPersonnage[i].PointVie = _Archer.PointVie;    
else if (_listPersonnage[i].Nom.StartsWith("Chevalier"))    
    _listPersonnage[i].PointVie = _Chevalier.PointVie;    
else if (_listPersonnage[i].Nom.StartsWith("Noir"))    
    _listPersonnage[i].PointVie = _Noir.PointVie;    
else if (_listPersonnage[i].Nom.StartsWith("Blanc"))    
    _listPersonnage[i].PointVie = _Blanc.PointVie;    
ucle for est utilisé dans cette méthode pour remettre les points       
 des personnages à leur état initiale.  
```

```csharp
public void RéinitialiserPointDeVie();
```