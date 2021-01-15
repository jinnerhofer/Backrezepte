using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Models
{
    public interface IRezeptItem
    {
        public string Rezeptname { get; set; }

        public string Rezeptanleitung { get; set; }

        List<Zutaten> All();
    }

    public class Zutaten
    {
        List<Zutaten> _zutaten = new List<Zutaten>();
    }
}
