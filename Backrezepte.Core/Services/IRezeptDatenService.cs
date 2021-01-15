using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Services
{
    public interface IRezeptDatenService
    {
        List<IRezeptDatenService> All();

        bool Add(IRezeptDatenService rezept);

        bool Delete(IRezeptDatenService rezept);

        bool Save();

    }
}
