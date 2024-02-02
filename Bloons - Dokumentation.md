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
Dieses Skript verwaltet die Layer der Bloons und gibt die Möglichkeit einen Hit einzutragen (`hitThisBloon(int)`). Diese Funktion ruft `updateLayer()` auf, welche die Layer visuell aktualisiert.
