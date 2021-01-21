using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Models
{
    public class RezeptItem : IRezeptItem
    {
        public string RezeptId { get; set; } = Guid.NewGuid().ToString();
        public string Rezeptname { get ; set; }
        public string Rezeptanleitung { get; set; }

        public List<Zutaten> All()
        {
            return new List<Zutaten>();
        }
    }
}
