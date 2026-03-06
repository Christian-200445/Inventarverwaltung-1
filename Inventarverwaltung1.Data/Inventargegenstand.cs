    using System;
using System.Collections.Generic;
using System.Text;

namespace Inventarverwaltung1.Data
{
    public class Inventargegenstand
    {
        public Guid Id { get; set; }
        public Guid? BenutzerID { get; set; }
        public Benutzer? Benutzer { get; set; }
        public string? Bezeichnung { get; set; }
        public string Seriennummer { get; set; } = "";
        public DateTime? Anschaffungsdatum { get; set; }
        public string? Beschreibung { get; set; }
        public string? Bemerkung { get; set; }

       
        public Guid? GruppeId { get; set; }
        public Guid? ZustandId { get; set; }
        public Guid? OrtId { get; set; }

  
        public Gruppe? Gruppe { get; set; }
        public Zustand? Zustand { get; set; }
        public Ort? Ort { get; set; }
    }
}
