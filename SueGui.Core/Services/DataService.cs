using Backrezepte.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Services
{
    public class DataService : IDataService
    {
        protected List<IPasswordItem> _passwords = new List<IPasswordItem>();
        public bool Add(IPasswordItem password)
        {
            this._passwords.Add(password);
            return true;
        }

        public List<IPasswordItem> All()
        {
            return this._passwords;
        }

        public bool Delete(IPasswordItem password)
        {
            return this._passwords.Remove(password);
        }

        public bool Save()
        {
            return true;
        }
    }
}
