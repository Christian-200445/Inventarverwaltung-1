using System;
using System.Collections.Generic;
using System.Text;

namespace Inventarverwaltung1.Data
{
    public class Ausleihe
    {
        public Guid Id { get; set; }
        public DateTime VonDatum { get; set; }
        public DateTime BisDatum { get; set; }
        public string? Bemerkung { get; set; }

        // Fremdschlüssel
        public Guid? BenutzerId { get; set; }
        public Guid? InventargegenstaendeId { get; set; }

        // Navigation
        public Benutzer? Benutzer { get; set; }
        public Inventargegenstand? Inventargegenstand { get; set; }
    }
}
