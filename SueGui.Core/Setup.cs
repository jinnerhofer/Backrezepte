﻿using MvvmCross;
using MvvmCross.ViewModels;
using Backrezepte.Core.Services;
using Backrezepte.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core
{
    public class Setup : MvxApplication
    {
        
        

        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<ICheckPasswordService, CheckPasswordService>();
            Mvx.IoCProvider.RegisterType<IDataService, DataService>();
            Mvx.IoCProvider.RegisterType<IKontoService, KontoService>();

            RegisterAppStart<MainViewModel>();

        }
    }
}
