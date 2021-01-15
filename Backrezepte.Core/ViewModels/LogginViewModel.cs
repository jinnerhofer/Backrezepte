using Backrezepte.Core.Models;
using Backrezepte.Core.Services;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Backrezepte.Core.ViewModels
{
    public class LogginViewModel : MvxViewModel
    {
        private MvxNavigationService _navigationService;
        private IRezeptDatenService _rezeptDatenService;
        private MvxObservableCollection<IRezeptItem> _rezepte;

        public MvxObservableCollection<IRezeptItem> Rezepte
        {
            get => _rezepte;
            set => SetProperty(ref _rezepte, value);
        }
         
        public LogginViewModel(MvxNavigationService navigationService, IRezeptDatenService rezeptDatenService)
        {
            this._navigationService = navigationService;
            this._rezeptDatenService = rezeptDatenService;
        }

        private MvxCommand _backCommand = null;

        public MvxCommand GoBackCommand
        {
            get
            {
                return _backCommand ?? (_backCommand = new MvxCommand(() =>
                {
                    this._navigationService.Close(this);
                }));
            }
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            var rezepte = _rezeptDatenService.All();

            Rezepte = new MvxObservableCollection<IRezeptItem>(Rezepte);
        }
    }
}
