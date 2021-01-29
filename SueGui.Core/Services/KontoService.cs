using Backrezepte.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Services
{
    public class KontoService : IKontoService
    {
        protected List<IAnmeldeItem> _konto = new List<IAnmeldeItem>();
        public bool Add(IAnmeldeItem Konto)
        {
            _konto.Add(Konto);
            return true;
        }

        public List<IAnmeldeItem> All()
        {
            return _konto;
        }

        public bool Delete(IAnmeldeItem Konto)
        {
            return this._konto.Remove(Konto);

        }

        public bool Save()
        {
            return true;
        }
    }
}
