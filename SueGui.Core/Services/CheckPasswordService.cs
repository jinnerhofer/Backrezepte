using MvvmCross;
using Backrezepte.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.Services
{
    public class CheckPasswordService : ICheckPasswordService
    {
        public int RatePassword(IPasswordItem password)
        {
           

            var quality = 0;
           if(password?.Password?.Length > 4)
            {
                quality = quality +1;
            }

            return quality;
        }
    }
}
