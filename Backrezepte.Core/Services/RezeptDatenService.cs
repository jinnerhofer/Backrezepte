using Backrezepte.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Services
{
    public class RezeptDatenService : IRezeptService
    {
        protected List<IRezeptItem> _rezepte = new List<IRezeptItem>();
        public bool Add(IRezeptItem rezept)
        {
            this._rezepte.Add(rezept);
            return true;
        }

        public List<IRezeptItem> All()
        {
            return this._rezepte;
        }

        public bool Delete(IRezeptItem rezept)
        {
            return this._rezepte.Remove(rezept);
        }

        public bool Save()
        {
            return true;
        }
    }
}
