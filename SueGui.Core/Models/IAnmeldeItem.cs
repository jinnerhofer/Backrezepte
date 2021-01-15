using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Models
{
    public interface IAnmeldeItem
    {
        public string Vorname { get; set; }

        public string Nachname { get; set; }

        public int IdNummer { get; set; }

        public PasswordItem Password { get; set; } 
    }
}
