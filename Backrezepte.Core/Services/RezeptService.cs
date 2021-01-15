using Backrezepte.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Services
{
    public class RezeptService : IRezeptService
    {
        protected List<IRezeptItem> _rezept = new List<IRezeptItem>();
        public bool Add(IRezeptItem Rezept)
        {
            _rezept.Add(Rezept);
            return true;
        }

        public List<IRezeptItem> All()
        {
            return _rezept;
        }

        public bool Delete(IRezeptItem Rezept)
        {
            return this._rezept.Remove(Rezept);
        }

        public bool Save()
        {
            return true;
        }
    }
}
