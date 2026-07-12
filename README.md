# Inventarverwaltung1

Webbasierte Inventarverwaltung für Firmen/Schulen, entwickelt mit Blazor Server und Entity Framework Core.

Entstanden als Schulprojekt im Rahmen der Ausbildung zum Fachinformatiker für Anwendungsentwicklung. Enthält u. a. ER-Modell, Use-Case- und Klassendiagramm sowie einen Projektzeitplan (siehe [`ProjektMaterialU`](./ProjektMaterialU)).

## Funktionen

- **Login** mit E-Mail/Passwort (Passwörter werden mit BCrypt gehasht)
- **Rollenbasierter Zugriff** – Admin- und Standard-Nutzeransicht
- **Inventarverwaltung** – Gegenstände anlegen, bearbeiten, löschen, durchsuchen
- **Ausleihe-Tracking** – Zeitraum (von/bis) und Bemerkungen pro Ausleihvorgang
- **Benutzerverwaltung** (Admin) – Nutzer anlegen, bearbeiten, Passwort zurücksetzen
- **Stammdatenverwaltung** (Admin) – Gruppen, Zustände, Standorte, Abteilungen, Fächer, Rollen
- **CSV-Export** für Inventarlisten und Benutzerlisten

## Tech-Stack

| Bereich | Technologie |
|---|---|
| Frontend/Backend | ASP.NET Core Blazor (Interactive Server Components), .NET 10 |
| Datenzugriff | Entity Framework Core |
| Datenbank | SQL Server |
| UI-Komponenten | Radzen.Blazor |
| Auth | BCrypt.Net (Passwort-Hashing) |

## Projektstruktur

```
Inventarverwaltung1/          Blazor-Webanwendung (Pages, Layout, Program.cs)
Inventarverwaltung1.Data/     Datenmodelle & EF-Core DbContext
ProjektMaterialU/             Projektunterlagen (ER-Modell, Diagramme, Zeitplan)
```

## Voraussetzungen

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- SQL Server (lokal oder als Container)

## Setup

1. Repository klonen
   ```bash
   git clone https://github.com/Christian-200445/Inventarverwaltung-1.git
   cd Inventarverwaltung-1
   ```

2. Connection String setzen (lokal, **nicht** in `appsettings.json` eintragen)
   ```bash
   cd Inventarverwaltung1
   dotnet user-secrets init
   dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=localhost,1433;Database=Inventar5;User Id=sa;Password=<dein-passwort>;TrustServerCertificate=True;"
   ```

3. Datenbank erstellen
   ```bash
   dotnet ef migrations add InitialCreate --project ../Inventarverwaltung1.Data --startup-project .
   dotnet ef database update --project ../Inventarverwaltung1.Data --startup-project .
   ```

4. Anwendung starten
   ```bash
   dotnet run
   ```

## Diagramme

Siehe [`ProjektMaterialU`](./ProjektMaterialU): ER-Modell, Klassendiagramm, Use-Case-Diagramm, Wireframe.

## Status

Schulprojekt – nicht produktiv im Einsatz.
