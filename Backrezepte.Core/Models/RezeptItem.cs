using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Models
{
    public class RezeptItem : IRezeptItem
    {
        private List<string> _zutaten = new List<string>();

        [PrimaryKey, Column("id")]
        public string RezeptId { get; set; } = Guid.NewGuid().ToString();

        [MaxLength(250), NotNull, Column("name")]
        public string Rezeptname { get ; set; }

        [MaxLength(250), NotNull, Column("anleitung")]
        public string Rezeptanleitung { get; set; }

        public List<string> All()
        {
            return this._zutaten;
        }
    }
}
