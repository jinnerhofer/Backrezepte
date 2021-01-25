using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Models
{
    public interface IRezeptItem
    {
        string RezeptId { get; set; }
        string Rezeptname { get; set; }

        string Rezeptanleitung { get; set; }

        List<string> All();
    }

}
