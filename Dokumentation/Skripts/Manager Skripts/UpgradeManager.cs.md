![[UpgradeManager.cs]]
- *Autor: Alexander Hinz*
Diese Klasse verwaltet alle UpgradeModule, welche sich bei diesem selbst registrieren. Die `UpdateBuyStuff()` ruft die Updatefunktion aller UpgradeSkripts auf. Dies ist eine Optimierung um nicht jeden Frame diese Update durchführen zu müssen, sondern nur wenn sich was ändert. 
