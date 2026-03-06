using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Inventarverwaltung1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Inventargegenstand> Inventargegenstand { get; set; }
        public DbSet<Gruppe> Gruppe { get; set; }
        public DbSet<Zustand> Zustand { get; set; }
        public DbSet<Ort> Ort { get; set; }
        public DbSet<Rolle> Rolle { get; set; }
        public DbSet<Abteilung> Abteilung { get; set; }
        public DbSet<Fach> Fach { get; set; }
        public DbSet<Benutzer> Benutzer { get; set; }
        public DbSet<Ausleihe> Ausleihe { get; set; }
    }
}
