# business-application-project

Interdisciplinary project to create a business application in C\#.

## Auftragsverwaltungs-System

### Einführung

Dieses Projekt, durchgeführt als Teil eines Schulprojekts, zielt darauf ab, eine effiziente und benutzerfreundliche Softwarelösung zur Auftragsverwaltung zu entwickeln. Es konzentriert sich auf die Implementierung eines robusten Datenverwaltungs- und -verarbeitungssystems und berücksichtigt dabei die besten Praktiken des Softwareengineerings.

Die Entwicklung dieses Projekts erfolgte unter Anwendung moderner Softwareentwicklungsmethoden und -werkzeuge und umfasste verschiedene Phasen von der Konzeption bis zur Implementierung.

## Installationsanleitung

### Voraussetzungen

1.  [.NET Core SDK u](https://learn.microsoft.com/de-de/ef/core/get-started/overview/install)nd Entity Framework Core Tools
2.  Eine lauffähige Instanz von Microsoft SQL Server oder ein kompatibler SQL-Dienst
3.  Das Projekt muss von GitHub geklont werden

### Einrichtung der Datenbank

Konfigurieren Sie die Datenbankverbindung in der OnConfiguring-Methode des AppDbContext.

Führen Sie die Migrationen aus:

```
dotnet ef migrations add InitialCreate
dotnet ef database update
```

Die InsertSeedData-Methode im DataSeeder wird verwendet, um Testdaten in die Datenbank einzufügen.

### Starten der Applikation

Führen Sie dotnet run im Stammverzeichnis des Projekts aus, um die Anwendung zu starten.

## Lizenz

Da es sich um ein Schulprojekt handelt, unterliegt dieses Projekt keiner spezifischen Lizenz.

### Kontaktinformationen

**Entwickler** Maximilian Degen,Khabat Rammo, Elias Götte
