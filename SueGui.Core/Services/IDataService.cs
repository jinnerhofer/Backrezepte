using Backrezepte.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Services
{
    public interface IDataService
    {
        List<IPasswordItem> All();
        bool Add(IPasswordItem password);
        bool Delete(IPasswordItem password);
        bool Save();

        
   
    }
}
