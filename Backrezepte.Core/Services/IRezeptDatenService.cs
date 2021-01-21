using Backrezepte.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Services
{
    public interface IRezeptDatenService
    {
        List<IRezeptItem> All();

        bool Add(IRezeptItem rezept);

        bool Delete(IRezeptItem rezept);

        bool Save();

    }
}
