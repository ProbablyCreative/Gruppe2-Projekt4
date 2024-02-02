## Titel
Unser Spiel heißt **Bloons**, was sich an das Spiel [Bloons Tower Defence](https://btd6.com/) anlehnt. 

## Idee

## Mitwirkende

## Verwendete Tools

### Software

### Hardware

## Verwendete Assets und Fremdmaterialien

Wir haben **keine** Assets und Fremdmaterialien benutzt und alle Grafiken und Skripts selbst geschrieben. (Mit Ausnahme des XR Plugins von Unity und dem Standard TextMeshPro Plugin von Unity selbst, allerdings gehören diese ja zu Unity)

## Skripts

### Bloon Skrips

#### bloonSkript.cs
![[bloonSkript.cs]]
- *Autor: Alexander Hinz*
Dieses Skript verwaltet die Layer der Bloons und gibt die Möglichkeit einen Hit einzutragen (`hitThisBloon(int)`). Diese Funktion ruft `updateLayer()` auf, welche die Layer visuell aktualisiert.

### Button Skripts

#### BuyNextCoolDown.cs
![[BuyNextCoolDown.cs]]
- *Autor: Alexander Hinz*
Diese Klasse managend ein Upgrade Cube, welcher die die Angriffsgeschwindigkeit erhöht. Bei Aktivierung von `ActivateButton()` , was bei auswählen mit dem Controller passiert, wird überprüft ob es noch ein weiters Lvl gibt, und ob genug Geld vorhanden ist. Wenn beides zutrifft, dann wird das Geld abgezogen, ein Update an den Upgrade Manager geschickt um die Anzeigen aller Upgrade Objekte zu aktualisieren. 

#### BuyNextDart.cs
![[BuyNextDart.cs]]
- *Autor: Alexander Hinz*
Diese Klasse verwaltet wie *BuyNextCoolDown.cs* auch ein Upgrade und funktioniert auch gleich, nur das sie einen besseren Dart freischaltet. 

#### BuySecondWapon.cs
![[BuySecondWapon.cs]]
- *Autor: Alexander Hinz*
Diese Klasse verwaltet wie *BuyNextCoolDown.cs* auch ein Upgrade und funktioniert auch gleich, nur das sie eine weitere Waffe freischaltet. 

#### GroupButtons.cs
![[GroupButtons.cs]]
- *Autor: Alexander Hinz*
Diese Skript ist nur da, um der Gruppe von Buttons den Zugriff auf den UpgradeManager zu gewähren

#### StartButton
![[StartButton.cs]]
- *Autor: Alexander Hinz*
Dieses Skript hat nur die Funktion `activateStartButton()` welche vom Controller ausgelöst wird und die Spielszene (Szene 1) lädt.

### Dart Skipts

#### dart.cs
![[dart.cs]]
- *Autor: Alexander Hinz*
Hier werden die Daten von Darts wie Haltbarkeit und Kraft gespeichert.
Zusätzlich wird hier ein Trigger verwaltet, welches checkt ob ein Bloon getroffen wurde und dann `hitThisBloon(int)` von dem Bloon aufruft.

#### HitEnvironment.cs
![[HitEnvironment.cs]]
- *Autor: Alexander Hinz*
Dieses Skript schaut ob Darts unter die y: -15 Grenze kommt und löscht es dann. (Ursprünglich mit Collition mit einem Environment, aber diese Version ist performanter.)

#### LookInMovementDirection.cs
![[LookInMovementDirection.cs]]
- *Autor: Alexander Hinz*
Dreht ein  Objekt in die Richtung in die es sich bewegt. Sorgt dafür das Darts gerade Fliegen. 


### Manager Skripts
#### UpgradeManager.cs
![[UpgradeManager.cs]]
- *Autor: Alexander Hinz*
Diese Klasse verwaltet alle UpgradeModule, welche sich bei diesem selbst registrieren. Die `UpdateBuyStuff()` ruft die Updatefunktion aller UpgradeSkripts auf. Dies ist eine Optimierung um nicht jeden Frame diese Update durchführen zu müssen, sondern nur wenn sich was ändert. 

#### BloonsGoal_BackUp.cs
![[BloonsGoal_BackUp.cs]]
- *Autor: Alexander Hinz*
Diese Klasse verwaltet das Event, wenn ein Bloon das ende Erreicht, updatet die HP und Beendet das Spiel.
Die Backup Benennung ist entstanden, da diese Klassen ursprünglich als Backup erstellt wurden, da diese ursprünglich von einem anderem Gruppenmitglied geplant wahren. 

#### GameData.cs 
![[GameData.cs]]
- *Autor: Alexander Hinz*
Diese Klasse hat nur Statische Elemente und ist für die Speicherung aller Statistiken wie Geld, HP und Score verantwortlich. Da dies Statisch ist, kann jedes Element und jede andere Klasse jederzeit diese Statistiken lesen.

#### GameManager_BackUp.cs
![[GameManager_BackUp.cs]]
- *Autor: Alexander Hinz*
Diese Klasse speichert alle Wichtigen Einstellungen des Aktuellen 
Spiels wie z.b. CoolDown / StartHP / Costen / Upgrades etc.
Zudem hat diese Klasse eine `updateScore(int,int)` und eine `updateMoney(int)` Funktion, welche immer zum ändern des Scores und des Geldes verwendet wird. Dies Funktionen updaten auch zugehörige Displays.

### Light Skripts

#### GoDart.cs
![[GoDark.cs]]
- *Autor: Alexander Hinz*
Diese Klasse ändert die Tageszeit zu Abend ab einem Bestimmtem Score. 
