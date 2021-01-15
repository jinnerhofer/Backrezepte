using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Backrezepte.Core.Models;
using Backrezepte.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using MvvmCross.Logging;

namespace Backrezepte.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        IRezeptDatenService _rezeptDatenService;
        IRezeptService _rezeptService;

        IMvxNavigationService _navigationService;
        private readonly IMvxLog _log;

        public MainViewModel(IRezeptDatenService rezeptDatenService, IRezeptService rezeptService, IMvxLog log, IMvxNavigationService navigationService)
        {
            
            this._rezeptDatenService = rezeptDatenService;
            this._rezeptService = rezeptService;
            this._log = log;
            this._navigationService = navigationService;
        }

        #region Prop: Rezeptname
        private string _rezeptname;

        public string Rezeptname 
        {
            get
            {
                return _rezeptname;
            }
            set 
            {
                SetProperty(ref _rezeptname, value);

            }
        
        
        }

        #endregion

        #region Prop: Schwierigkeit
        private int _schwierigkeit = 0;

        public int Schwierigkeit
        {
            get => this._schwierigkeit;
            set => SetProperty(ref _schwierigkeit, value);
        }
        #endregion

        #region Prop: SpeichernCommand
        private MvxCommand _SpeichernCommand = null;

        public MvxCommand SpeichernCommand
        {
            get
            {
                return _SpeichernCommand ?? (_SpeichernCommand = new MvxCommand(GenerateRezept));
            }
        }

        private void GenerateRezept()
        {
            var Rezeptname = this.Rezeptname;
        }

        #endregion

        #region Prop: Zutatenliste
        private List<string> _zutaten = new List<string>();
        private string _zutat = " ";

        public string Zutatenliste
        {
            get
            {
                _zutaten.Add(this._zutat);
                return this.Zutatenliste;
            }

            set
            {
                SetProperty(ref _zutat, value);
            }
        }
        #endregion

        #region Prop: Anleitung
        private string _anleitung;

        public string Anleitung
        {
            get
            {
                return _anleitung;
            }
            set
            {
                SetProperty(ref _anleitung, value);
            }


        }

        #endregion

        #region Prop: LoginCommand
        private MvxCommand _loginCommand = null;

        public MvxCommand LoginCommand
        {
            get
            {
                return _loginCommand ??
                    (_loginCommand = new MvxCommand(() =>
                    {
                        this._navigationService.Navigate<LogginViewModel>();
                    }));
            }
        }
        #endregion
    }
}

