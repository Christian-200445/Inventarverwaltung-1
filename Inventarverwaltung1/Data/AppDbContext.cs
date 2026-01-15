using Microsoft.EntityFrameworkCore;

namespace Inventarverwaltung1.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Inventargegenstand> Inventargegenstaende => Set<Inventargegenstand>();
    public DbSet<Abteilung> Abteilungen => Set<Abteilung>();
    public DbSet<Gruppe> Gruppen => Set<Gruppe>();
    public DbSet<Fach> Faecher => Set<Fach>();
    public DbSet<Ort> Orte => Set<Ort>();
    public DbSet<Zustand> Zustaende => Set<Zustand>();
    public DbSet<Ausleihe> Ausleihen => Set<Ausleihe>();
    public DbSet<Benutzer> Benutzer => Set<Benutzer>();
    public DbSet<Rolle> Rollen => Set<Rolle>();
}
