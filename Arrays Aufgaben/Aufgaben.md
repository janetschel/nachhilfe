# Aufgaben zu (zweidim.) Arrays

## Aufgabe 1
Schreib ein Programm, welches die Summe in einem eindimensionalen Integer-Array berechnet.

**Beispiel**:
```csharp
int[] array = {1, 2, 3, 4, 50};

// 60 
```

Zusatzaufgabe: falls noch nicht geschehen, schreibe das funktionierende Programm um, und pack das Berechnen in eine eigene Funktion, welche das Ergebnis zurückgibt.

## Aufgabe 2
Schreibe eine Funktion mit folgendem Funktionskopf:
```csharp
static int GetLineWithLargestSum(int[,] array)
```

Diese Funktion soll als Parameter ein zweidimensionales Integer Array übergeben bekommen.

Diese Funktion berechnet für jede Zeile die Summe der Zahlen, und gibt den Index der Zeile mit der größten Summe zurück.

**Beispiel**:  
Die Funktion, bei der Übergabe dieses Arrays
```csharp
int[,] array = { {70, -100, 2}, {0, -1, 20}, {1, 2, 3} };
```
gibt die Zahl 1 zurück, da die zweite Zeile die größte Summe hat.


## Aufgabe 3
Schreibe eine Funktion, welche ein zweidimensionales Integer-Array als `ref` Paramter übergeben bekommt, sowie die Integer-Parameter `x` und `y`.

Der Funktionskopf dieser Funktion könnte demnach folgendermaßen aussehen:
```csharp
static void Toggle(ref int[,] array, int x, int y)
```

Diese Funktion soll den angegebenen Index im Array "toggeln".  
Wenn der Wert an der Stelle (x, y) 0 ist, wird er 1, und andersrum.

## Aufgabe 4
Erweitere die Funktion aus Aufgabe 3 folgendermaßen:

Die Funktion soll nun einen weiteren Integer-Paramter übergeben bekommen: `delta`.  
Dieser Wert muss nicht übergeben werden und soll den Standardwert 1 besitzen.

Die Funktion zählt nun, an der Stelle (x, y), den Wert um `delta` hoch.

**Beispiel**:  
```csharp
int[,] array = { {1, 0, 0}, {0, 0, 0} };

// Aufruf der Funktionen
Toggle(ref array, 0, 0, 4);
Toggle(ref array, 0, 1);
Toggle(ref array, 1, 2, 70);

// Array nach dem Aufruf der Funktionen
// { {5, 1, 0}, {0, 0, 70} }
```

## Aufgabe 5
Schreibe eine Funktion, welche 2 zweidimensionale Integer-Arrays mit dem Namen `a` und `b` übergeben bekommt. Du kannst davon ausgehen, dass diese Arrays immer die gleiche Länge in allen Dimensionen haben.

Die Funktion soll sich folgendermaßen verhalten:
- Die Funktion erstellt ein neues Ergebnisarray `c`
- Rechne für jeden Index den Wert vom Array `a` und `b` zusammen.
- Falls dieser Wert 10 ist, soll an dieser Stelle 0 gespeichert werden
- Sonst (falls der Wert nicht 10 ist), soll der neu errechnete Wert an dieser Stelle gespeichert werden.
- Am Ende der Berechnungen gibt die Funktion das Ergebnisarray zurück

**Beispiel**:  
Anfangs-Arrays:
```csharp
int[,] a = { {1, 2, 3}, {4, 5, 6}, {5, 5, 15} };
int[,] b = { {0, 0, 1}, {10, 0, 1}, {5, 0, 5} };
```

Ergebnisarray nach dem Funktionsaufruf
```csharp
int[,] c = Calculate(a, b);

//{ {1, 2, 4}, {14, 5, 7}, {0, 5, 20} }
```
