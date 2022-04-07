# Uppgiftsbeskrivning

## Scenario
I denna laboration ska en lista med personer skapas. Listan kan bestå av tre olika typer typer: man, kvinna eller barn.

## Del 1 - Listan
Skapa ett program som visar en lista med personer

- Personer, male eller female ska kunna läggas till i listan med för- och efternamn

- Ett prefix Male/Female skall visa könet på personen i listan

- Personer i listan ska kunna raderas

- Listan ska gå att sortera på efternamn sedan på förnamn. GÖR SÅ ATT LISTAN SKA AUTOMATISKT SORTERAS VARJE GÅNG MAN LÄGGER TILL/TAR BORT EN PERSON

- LISTAN MÅSTE VARA AV TYPEN PERSON

- FÖR ATT HÄMTA NAMN MÅSTE EN METOD GETNAME ANROPAS PÅ VARJE OBJEKT (PERSON MÅSTE HA EN ABSTRAKT METOD: GETNAME)

- För att sorteringsfunktionen ska fungera, ska basklassen Person implementera interfacet IComparable

- Personer ska kunna slås samman med en merge-funktion

**Klasser (personer)**

- Klasser som ska finnas är Person, Male, Female och Child. Klassen Person ska vara basklass för de övriga klasserna och det ska inte vara möjligt att skapa en instans av basklassen. Basklassen ska implementera en konstruktor där man kan skicka in förnamn och efternamn.

**Merge**

- Om två, och endast två personer, av olika kön är markerade (highlighted) när man klickar på Merge, så skall en Child skapas. Child ska få förnamn från Female och efternamn från Male och namnet ska föregås av Child (istället för Mr eller Miss)

## Del 2 - UML

Rita upp alla klasser i ett UML-diagram. Diagrammet ska tydligt visa vilken klass som är basklass och vilka klasser som ärver från denna.

## Regler för lösning

- Endast en lista (List<>) med personer får finnas och denna lista ska vara av typen Person (alltså List<Person>).

- Basklassen ska vara abstrakt

- Sub-klasserna Male, Female och Child måste ärva från Person som är en abstrakt klass.

- Varje sub-klass ska ha en egen metod/property för att returnera namn. Namn för Male ska exempelvis returnera ”Mr Patrik Hansson” och för en Female ”Miss Anna Måstensson”. D.v.s. polymorfism.

- För merge-funktionen skall överlagraing av + operator användas.

- Basklassen Person implementera interfacet IComparable
