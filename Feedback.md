
## Feedback C# OO Programming


#### Kennismaking Visual Studio 2019

- [x] *Aanmaken solution binnen GIT-repository*
- [ ] *Eenvoudige consoletoepassing (met invoer gebruiker)*
- [x] *Eenvoudige WinForm toepassing*
- [x] *Een klasse toevoegen*

* Je toepassing is geschreven met het .Net Framework versie 4.7.2. Voor dit vak verwacht ik code met .Net Core versie 5 of 6.


#### Gebruik GIT

- [x] *Je gebruikt 'atomaire' commits*
- [x] *Je gebruikt zinvolle commit messages*

* Je commit messages zijn niet altijd voldoende informatief. Beschrijf telkens concreet wat er veranderd is sinds de vorige commit.
* Je hebt je .gitIgnore bestand aangemaakt nadat je al commits gedaan hebt vanuit je Visual Studio solution. Daardoor zijn er al een aantal 'ongewenste' bestande gemarkeerd voor tracking door GIT.    
   Op volgende blog kan je informatie vinden over hoe je dat moet oplossen: https://www.codeblocq.com/2016/01/Untrack-files-already-added-to-git-repository-based-on-gitignore/.
 

#### Debugging

--> Nog niet beoordeeld (kan enkel interactief gebeuren)

- [ ] *Code stap voor stap uitvoeren*
- [ ] *Breakpoints*
- [ ] *De waarde van variabelen bekijken tijdens de uitvoering van je programma*

#### Programmeerstijl

--> Nog niet beoordeeld

- [ ] *Huisregels voor programmeerstijl volgen*
 
* Je volgt niet altijd de regels voor naamgeving.
  * De waarden voor een enum-type moeten PascalCased zijn.
  * Start de namen van private velden met een underscore (gevolgd door de naam in camelCasing).
  * Voor methodes en klassen wordt PascalCasing gebruikt.
  * Gebruik geen underscores in namen (pas de automatisch gegenereerde namen met underscores aan).
* Geef je bestand dezelfde naam als de klasse die het bevat (Spyfall / startGUI.cs)
* Schrijf geen te lange methoden (richtlijn ~20 lijnen).
* Gebruik voor alle velden, klassen, methodes, properties steeds access modifiers (public, private...).
* Gebruik type inference ('var') volgens de conventie uit de stijlregels.
* Hanteer de gevraagde volgorde voor de verschillende onderdelen van je klasse (properties na de velden en voor de constructor).
* Vermijd overbodige blanco lijnen (bv. twee achter elkaar of een blanco lijn tussen twee accolades).
* Werk niet met statische methodes of variabelen tenzij daar een heel goede reden voor is (Je 'Dataverwerker' is bv. helemaal niet object georiënteerd). ).
* Verwijder de commentaar die geen meerwaarde heeft ten opzichte van de code waar ze bij staat.   
    Bijvoorbeeld:    
   ```csharp
        //een random gaan genereren met als maximum het aantal lijnen in ons data document
        int randomGetal = random.Next(0, File.ReadLines(filePath).Count());
   ```

* In bovenstaande code Lees je het volledige bestand in om het aantal lijnen te kennen. De ingelezen inhoud gooi je dan weg om in het volgende statement die inhoud opnieuw te lezen. Dat is niet echt efficiënt!
* Je gebruikt 'Random' niet op een efficiënte manier (je maakt steeds een nieuwe instantie aan bij de oproep van je methodes).
* Zoals je nu vensters aanmaakt en toont, geef je de gebruiekr de kans om meerdere keren gelijkaardige vensters aan te maken en die open te laten terwijl de rest van het spel uitgeveord wordt. Gebruik 'ShowDialog' ipv 'Show' waardat relevant is..
* Tip: Om te testen of een string leeg is,  vervang je `if (input == null)` beter door `string.IsNullOrWhiteSpace(input)`
* Tip: hou rekening met de messages en warnings uit de 'Error List'.


#### Exceptions

- [x] *try..catch*
- [ ] *try..catch..finally*
- [x] *Je werpt bruikbare exceptions op wanneer je een foutsituatie detecteert die niet lokaal op een beter manier kan afgehandeld worden.*

* Een exceptie opgooien in een 'try' blok om die dan onmiddellijk in de catch blok weer op te vangen, is geen goede aanpak. Een exceptie dient voor een onverwachte foutsituatie die je in de methode waar ze gedetecteerd wordt niet kan opvangen.    
Je kan volgende code: 

   ```csharp
      try
      {
         if (!File.Exists(filePath))
                throw new FileNotFoundException($"Het bestand bestaat niet op de opgegeven locatie: {filePath}");
      }
      catch (FileNotFoundException)
      {
          return false;
      }
   ```

    
    veel beter vervangen door:   


    `if (!File.Exists(filePath)) return false; `

 

#### Enumerations

--> Nog niet beoordeeld

- [ ] *Declaratie en gebruik van enum-type*
 
#### Properties

- [x] *Full property (with private backing field)*
- [ ] *Extra code in getter of setter (bv. validatie)*
- [x] *Auto-implemented property*
- [ ] *Access-modifiers voor Getters en Setters*

#### Interpolated strings

- [x] *Interpolated strings*

#### Generic collections

--> Nog niet beoordeeld

- [ ] *List<T>*
- [ ] *Dictionary<T,T>*
- [ ] *Overzicht andere generic collections*

#### Interfaces

--> Nog niet beoordeeld

- [ ] *Interface declaratie*
- [ ] *Interface implementatie*
- [ ] *Interface gebruiken als type*

#### Architectuur van een toepassing - Meerlagenmodel

--> Nog niet beoordeeld

- [ ] *Klasseblibliotheken*
- [ ] *Meerlagenmodel - 3lagenmodel*
- [ ] *'Loose coupling' - dependency injection*
- [ ] *Interface gebruiken als scheiding tussen architectuurlagen*

* De 'FileSelector' in 'Dataverwerker' omvat interactie met de gebruiker en hoort dus thuis in de presentatielaag.
* Het lezen uit een bestand (zoals bv. in 'KiesRandomRol') hoort in de datalaag en niet in de logische laag. Hetzéelfde geldt voor alle maniupluaties van bestanden (lezen, schrijven, aanmaken...)

#### Bestanden en 'streams'

- [x] *Statische klassen uit 'System.IO'*
- [ ] *Streams*
- [ ] *Serialisatie*

#### 'Value' en 'Reference' types, cloning van objecten

--> Nog niet beoordeeld

- [ ] *'value' en 'reference' types, 'deep' versus 'shallow' copy, object cloning*

#### Klassen - klassehiërarchie

--> Nog niet beoordeeld

- [ ] *Klasse declaratie*
- [ ] *constructor overloading*
- [ ] *Klasse-hiërarchie - subklasse - base-constructor*
- [ ] *Klasse-hiërarchie - virtual methods - override*
- [ ] *Abstracte klasse + implementatie*

#### Structs

--> Nog niet beoordeeld

- [ ] *Structs*

##### Extension methods

--> Nog niet beoordeeld

- [ ] *Extension method schrijven*
- [ ] *Functioneel gebruik van extension methods*

#### Delegates

--> Nog niet beoordeeld

- [ ] *(Predefined) Delegates*

#### Lambda expressions

--> Nog niet beoordeeld

- [ ] *Lambda expressions*

#### Language Integrated Query (Linq)

--> Nog niet beoordeeld

- [ ] *Linq standard query operator syntax*
- [ ] *Linq method syntax*
- [ ] *Basismethodes voor Linq*

#### Events

--> Nog niet beoordeeld

- [ ] *Event 'Publisher'*
- [ ] *Event 'Consumer'*

#### Concurrent programmatie: Tasks

--> Nog niet beoordeeld

- [ ] *Tasks*
- [ ] *Cross-thread' interactie vanuit een Task met de userinterface*
- [ ] *Exceptions in Tasks*
- [ ] *Parallel loops*
 
#### Concurrent programming: Task synchronisation

--> Nog niet beoordeeld

- [ ] *Lock*
- [ ] *Concurrent/ thread safe collections*

#### Asynchronous programming: async .. await

--> Nog niet beoordeeld

- [ ] *async .. await*

#### (Recursie)

--> Nog niet beoordeeld

- [ ] *Recursie - concept*
- [ ] *Backtracking*

#### (Indexers & Iteratoren)
 
--> Nog niet beoordeeld

- [ ] *Indexers*
- [ ] *Enumeratoren*

#### (Statische klassen, methoden, velden)

--> Nog niet beoordeeld

- [ ] *Zinvol gebruik statische klassen, methoden, velden*

#### Code Reviews

--> Nog niet beoordeeld

- [ ] *Code reviews*
