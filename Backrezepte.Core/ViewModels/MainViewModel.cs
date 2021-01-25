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
        IRezeptService _rezeptService;

        IMvxNavigationService _navigationService;
        private readonly IMvxLog _log;

        public MainViewModel(IRezeptService rezeptService, IMvxLog log, IMvxNavigationService navigationService)
        {
            
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
                SpeichernCommand.RaiseCanExecuteChanged();
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
                return _SpeichernCommand ?? (_SpeichernCommand = new MvxCommand(
                () =>
                {
                    IRezeptItem rezept = new RezeptItem();
                    rezept.Rezeptname = this.Rezeptname;
                    rezept.Rezeptanleitung = this.Anleitung;

                    this._rezeptService.Add(rezept);
                    this._log.Debug("Saved");
                    
                },
                () =>
                {
                    return this.Rezeptname?.Length > 0;
                }  
                ));
            }
        }


        #endregion

        #region Prop: Zutat
        private string _zutat = "";
        public string Zutat { 
            get => _zutat; 
            set
            {
                SetProperty(ref _zutat, value);
                ZutatHinzuCommand.RaiseCanExecuteChanged();
            }
        }
        #endregion

        #region Command: ZutatHinzuCommand
        private MvxCommand _zutatHinzuCommand = null;

        public MvxCommand ZutatHinzuCommand
        {
            get
            {
                return _zutatHinzuCommand ?? (_zutatHinzuCommand = new MvxCommand(
                    () => 
                    {
                        this.Zutaten.Add(this.Zutat);
                        this.Zutat = "";
                    },
                    () => 
                    {
                        return this.Zutat?.Length > 0;
                    }
                ));
            }
        }
        #endregion


        #region Prop: Zutaten
        private MvxObservableCollection<string> _zutaten = new MvxObservableCollection<string>();

        public MvxObservableCollection<string> Zutaten
        {
            get
            {
                return this._zutaten;
            }
            set
            {
                SetProperty(ref _zutaten, value);
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

        #region Prop: GeheZuRezepteList
        private MvxCommand _geheZuRezepteListCommand = null;

        public MvxCommand GeheZuRezepteListCommand
        {
            get
            {
                return _geheZuRezepteListCommand ??
                    (_geheZuRezepteListCommand = new MvxCommand(() =>
                    {
                        this._navigationService.Navigate<ListViewModel>();
                    }));
            }
        }
        #endregion

    }
}

