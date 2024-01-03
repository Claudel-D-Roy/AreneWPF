#### [BibliothèqueLogiqueCombat](readme.md 'readme')
### [BibliothèqueLogiqueCombat.Models.Arènes](readme.md#BibliothèqueLogiqueCombat.Models.Arènes 'BibliothèqueLogiqueCombat.Models.Arènes').[LogiqueArène](BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène.md 'BibliothèqueLogiqueCombat.Models.Arènes.LogiqueArène')

## LogiqueArène.AttaquerPersonnageNv10() Method

Auteur : Claudel D. Roy et Mathieu Duval    
Description : Permet de l'action de la case à cocher "tout" dans le xaml.    
Date : 2022-05-26   
  
```csharp  
do    
 {    
     MélangerListe();    
     AttaquerUnTourPersonnage();    
       
 } while (!_FinDuJeux);    
   
_FinDuJeux = true;    
  
boucle do/while et utiliser pour faire la méthode MélangerListe() et AttaquerUnTourPersonnage()      
u'à temps qu'un personnage ait atteint le niveau 10.  
```

```csharp
public void AttaquerPersonnageNv10();
```