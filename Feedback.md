
## Feedback C# OO Programming



#### Kennismaking Visual Studio 2019

- [x] *Aanmaken solution binnen GIT-repository*
- [ ] *Eenvoudige consoletoepassing (met invoer gebruiker)*
- [x] *Eenvoudige WinForm toepassing*
- [x] *Een klasse toevoegen*

#### Gebruik GIT

- [x] *Je gebruikt 'atomaire' commits*
- [x] *Je gebruikt zinvolle commit messages*

* Je commits zijn niet (altijd) atomair: je hebt commits waarin je meerdere losstaande wijzigingen hebt gedaan.


#### Debugging

- [x] *Code stap voor stap uitvoeren*
- [x] *Breakpoints*
- [x] *De waarde van variabelen bekijken tijdens de uitvoering van je programma*

#### Programmeerstijl

- [ ] *Huisregels voor programmeerstijl volgen*
 
* Je volgt niet altijd de regels voor naamgeving.
   * Gebruik geen underscores in namen (pas de automatisch gegenereerde namen met underscores aan).
* Schrijf geen te lange methoden (richtlijn ~20 lijnen).
* Gebruik voor alle velden, klassen, methodes, properties steeds access modifiers (public, private...).
* Hanteer de gevraagde volgorde voor de verschillende onderdelen van je klasse (properties na de velden en voor de constructor).
* Vermijd overbodige blanco lijnen (bv. twee achter elkaar of een blanco lijn tussen twee accolades).
* Werk niet met statische methodes of variabelen tenzij daar een heel goede reden voor is.

* Je hebt de 'ILogic' interface leeg gelaten maar implementeert die wel in `CyclonMain`, `Map`en `Tile`. Waarom???
* Zet geen twee statements op één lijn (zoals in 'MainForm.StartDrawing').

* Volgende code is niet echt zinvol:    
    ```csharp
       var taskDone = await Task.Run(() => ModernDrawing());    
       if (taskDone == TaskStatus.RanToCompletion || taskDone == TaskStatus.Canceled)
       {
          GenerateButton.Enabled = true;
       }
    ```
    Als er bij de await geen exception optreedt dan kan de TaskStatus enkel 'RanToCompletion' of 'Canceled' zijn.

* Tip: hou rekening met de messages en warnings uit de 'Error List'.


#### Exceptions

- [x] *try..catch*
- [ ] *try..catch..finally*
- [ ] *Je werpt bruikbare exceptions op wanneer je een foutsituatie detecteert die niet lokaal op een beter manier kan afgehandeld worden.*

* Door in je datalaag een debug message weg te schrijven is het probleem dat de exception veroorzaakte niet opgelost. Is dat geen probleem in je toepassing?


#### Enumerations

- [x] *Declaratie en gebruik van enum-type*

#### Properties

- [x] *Full property (with private backing field)*
- [ ] *Extra code in getter of setter (bv. validatie)*
- [x] *Auto-implemented property*
- [ ] *Access-modifiers voor Getters en Setters*

#### Interpolated strings

- [x] *Interpolated strings*

#### Generic collections

- [x] *List<T>*
- [ ] *Dictionary<T,T>*
- [ ] *Overzicht andere generic collections*

#### Interfaces

--> Nog niet beoordeeld

- [ ] *Interface declaratie*
- [ ] *Interface implementatie*
- [ ] *Interface gebruiken als type*

* In de `ICyclonMain` interface geef je ook al een default-implementatie voor de methodes. Behalve in zeer sepcifieke uitzonderlijke situaties is dat absoluut niet de bedoeling!


#### Architectuur van een toepassing - Meerlagenmodel

- [x] *Klasseblibliotheken*
- [x] *Meerlagenmodel - 3lagenmodel*
- [x] *'Loose coupling' - dependency injection*
- [x] *Interface gebruiken als scheiding tussen architectuurlagen*

* De 'FileSelector' in 'Dataverwerker' omvat interactie met de gebruiker en hoort dus thuis in de presentatielaag.
* Het lezen uit een bestand (zoals bv. in 'KiesRandomRol') hoort in de datalaag en niet in de logische laag. Hetzéelfde geldt voor alle maniupluaties van bestanden (lezen, schrijven, aanmaken...)

#### Bestanden en 'streams'

- [x] *Statische klassen uit 'System.IO'*
- [x] *Streams*
- [x] *Serialisatie*

#### 'Value' en 'Reference' types, cloning van objecten

- [x] 'value' en 'reference' types, 'deep' versus 'shallow' copy, object cloning*

* De 'copy-constructor' van 'Map' is geen echte copy-constructor: het maakt geen 'deep'-copy van de originele map: de nieuwe Map-instantie heeft een referentie naar hetzelfde 'NoiseValues' object als de originele (het is dus een 'shallow' copy).

#### Klassen - klassehiërarchie

- [x] *Klasse declaratie*
- [x] *constructor overloading*
- [x] *Klasse-hiërarchie - subklasse - base-constructor*
- [ ] *Klasse-hiërarchie - virtual methods - override*
- [x] *Abstracte klasse + implementatie*

* Je abstracte klasse 'circlegradient' is niet zo zinvol binnen je toepassing: er zijn geen abstracte of virtuele methdoes, er is geen specifieke base-constructor, er is slechts één subklasse.

#### Structs

- [x] *Structs*

##### Extension methods

- [x] *Extension method schrijven*
- [x] *Functioneel gebruik van extension methods*

#### Delegates

--> Nog niet beoordeeld

- [ ] *(Predefined) Delegates*

#### Lambda expressions


- [x] *Lambda expressions*

* Je gebruikt enkel heel elementaire lambda expressionz (om je Tasks te starten).

#### Language Integrated Query (Linq)

--> Nog niet beoordeeld

- [ ] *Linq standard query operator syntax*
- [ ] *Linq method syntax*
- [ ] *Basismethodes voor Linq*

#### Events

- [ ] *Event 'Publisher'*
- [x] *Event 'Consumer'*

* Je reageert op externe events maar nog niet op eigen events die vanuit je eigen code gestart worden.
7/01/2022, 10/01/2022: wat is hier veranderd na bovenstaande feedback?

#### Concurrent programmatie: Tasks

- [x] *Tasks*
- [x] *Cross-thread' interactie vanuit een Task met de userinterface*
- [ ] *Exceptions in Tasks*
- [ ] *Parallel loops*

* Het is niet de bedoeling dat je zelf 'TaskStatus' waarden doorgeeft uit een methode. Dat wordt door .Net op een specifieke manier gebruikt om de toestand van een Task aan te geven.

 
#### Concurrent programming: Task synchronisation

--> Nog niet beoordeeld

- [ ] *Lock*
- [ ] *Concurrent/ thread safe collections*

#### Asynchronous programming: async .. await

- [x] *async .. await*

#### (Recursie)

--> Nog niet beoordeeld

- [ ] *Recursie - concept*
- [ ] *Backtracking*

#### (Indexers & Iteratoren)
 
--> Nog niet beoordeeld

- [ ] *Indexers*
- [ ] *Enumeratoren*

#### (Statische klassen, methoden, velden)

- [x] *Zinvol gebruik statische klassen, methoden, velden*

* Het gebruik van het statisch '_seedData' veld in 'SeedData' is een antipattern! Maak daar gewoon instance veld van en zorg dat je maar één instantie van 'SeedData' maakt die je dan via de constructor injecteert op alle plaatsen waar je die nodig hebt.
* Het heeft geen enkele meerwaarde dat `CheckOrCreate` een statische methode is. Ook dat is een antipattern.
* 
#### Code Reviews

--> Nog niet beoordeeld

- [ ] *Code reviews*
