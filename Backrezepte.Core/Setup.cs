using MvvmCross;
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
            Mvx.IoCProvider.RegisterSingleton<IRezeptDatenService>(new XmlData());
            Mvx.IoCProvider.RegisterType<IRezeptService, RezeptService>();

            RegisterAppStart<MainViewModel>();
        }
    }
}
