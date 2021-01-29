using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Models
{
    public interface IPasswordItem
    {
        string Password { get; set; }

        string Service { get; set; }

        DateTime GeneratedDateTime { get; set; }
    }
}
