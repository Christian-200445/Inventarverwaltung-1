using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Inventarverwaltung1.Data
{
    public class Benutzer
    {
        public Guid Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Mail { get; set;}

    }
}
