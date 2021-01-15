using Backrezepte.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Services
{
    public class RezeptDatenService : IRezeptDatenService
    {
        protected List<IRezeptDatenService> _rezepte = new List<IRezeptDatenService>();
        public bool Add(IRezeptDatenService rezept)
        {
            this._rezepte.Add(rezept);
            return true;
        }

        public List<IRezeptDatenService> All()
        {
            return this._rezepte;
        }

        public bool Delete(IRezeptDatenService rezept)
        {
            return this._rezepte.Remove(rezept);
        }

        public bool Save()
        {
            return true;
        }
    }
}
