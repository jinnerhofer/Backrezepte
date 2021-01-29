using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Models
{
    public class AnmeldeItem : IAnmeldeItem
    {
        public string Vorname { get; set; }

        public string Nachname { get; set; }

        public int IdNummer { get; set; }

        public PasswordItem Password { get; set; }
    }
}
