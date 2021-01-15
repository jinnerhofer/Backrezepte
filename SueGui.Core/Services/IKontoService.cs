using Backrezepte.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Services
{
    public interface IKontoService
    {
        List<IAnmeldeItem> All();

        bool Add(IAnmeldeItem Konto);
        bool Delete(IAnmeldeItem Konto);
        bool Save();


    }
}
