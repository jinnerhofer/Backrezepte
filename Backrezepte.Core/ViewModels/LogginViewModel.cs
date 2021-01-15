using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backrezepte.Core.ViewModels
{
    public class LogginViewModel : MvxViewModel
    {
        MvxNavigationService _navigationService;
         
        public LogginViewModel(MvxNavigationService navigationService)
        {
            this._navigationService = navigationService;
        }

        #region Prop: LoginCommand
        private MvxCommand _mainviewCommand = null;

        public MvxCommand MainViewCommand
        {
            get
            {
                return _mainviewCommand ??
                    (_mainviewCommand = new MvxCommand(() =>
                    {
                        this._navigationService.Navigate<MainViewModel>();
                    }));

                
            }

        }
        #endregion
    }
}
