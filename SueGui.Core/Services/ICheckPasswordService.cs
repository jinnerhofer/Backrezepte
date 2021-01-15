using Backrezepte.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Services
{
    public interface ICheckPasswordService
    {

        int RatePassword(IPasswordItem password);
        

    }
}
