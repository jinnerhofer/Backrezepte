using MvvmCross.Commands;
using MvvmCross.ViewModels;
using Backrezepte.Core.Models;
using Backrezepte.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace Backrezepte.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {

        ICheckPasswordService _checkPasswordService;
        IDataService _dataService;

        public MainViewModel(ICheckPasswordService checkPasswordService, IDataService dataService)
        {
            this._checkPasswordService = checkPasswordService;
            this._dataService = dataService;
        }

        #region Prop: Name
        private string _name;

        public string Name
        {
            get 
            {
                
                return _name; 
            }
            set 
            { 
                _name = value;
                RaisePropertyChanged(() => Name);
                
            }
        }
        #endregion

        #region Prop: Password
        private string _password = "";
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }
        #endregion

        #region Prop: UseRandomNumber

        private bool _useRandomNumber = false;

        public bool UseRandomNumber
        {
            get { return _useRandomNumber = false; }
            set { SetProperty(ref _useRandomNumber, value); }
        }

        #endregion

        #region Prop: RatingValue
        private int _ratingValue = 0;

        public int RatingValue 
        { 
            get => this._ratingValue; 
            set => SetProperty(ref _ratingValue, value); 
        }
        #endregion

        #region Password Command
        private MvxCommand _PasswordCommand = null;
        public MvxCommand PasswordCommand

        {
            get
            {
                // ?? schaut bei _PasswordCommand nach, ob null drinn ist...
                // wenn ja , dann belegt er es mit dem GeneratePassword!
                return _PasswordCommand ?? (_PasswordCommand = new MvxCommand(GeneratePassword, CanGeneratePassword));
            }
        }
        private bool CanGeneratePassword()
        {
            return this.Name?.Length > 0;
        }

        private void GeneratePassword()
        {
            Debug.WriteLine("hier");
            var eB = Name.Substring(0,1).ToLower();
            var z = "#";
            var aZ = this.Name.Length;


            this.Password = eB + z + aZ;

            if (this.UseRandomNumber)
            {
                Random r = new Random();
                this.Password = this.Password + z + r.Next(1,51);

            }

            PasswordItem pwd = new PasswordItem();
            pwd.Password = this.Password;
            pwd.Service = "Url";
            pwd.GeneratedDateTime = DateTime.Now;

            this.RatingValue = this._checkPasswordService.RatePassword(pwd);


        }

        #endregion


    }
}
