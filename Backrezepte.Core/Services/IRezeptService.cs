using Backrezepte.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Services
{
    public interface IRezeptService
    {
        List<IRezeptItem> All();

        bool Add(IRezeptItem Rezept);

        bool Delete(IRezeptItem Rezept);

        bool Save();
    }
}
