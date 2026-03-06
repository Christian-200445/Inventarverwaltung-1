using System;
using System.Collections.Generic;
using System.Text;

namespace Inventarverwaltung1.Data
{
    public class Ort
    {
        public Guid Id { get; set; }
        public int RegalNr { get; set; }
        public string? RegalOrt { get; set; }
    }
}
