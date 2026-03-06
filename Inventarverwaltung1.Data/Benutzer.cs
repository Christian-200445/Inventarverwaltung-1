using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Inventarverwaltung1.Data
{
    public class Benutzer
    {
        public Guid Id { get; set; }
        public string? Vorname { get; set; }
        public string? Nachname { get; set; }
        public string? Passwort { get; set; }
        public string? Mail { get; set; }

        // Fremdschlüssel
        public Guid? RolleId { get; set; }
        public Guid? AbteilungId { get; set; }

        // Navigation
        public Rolle? Rolle { get; set; }
        public Abteilung? Abteilung { get; set; }

    }
}
