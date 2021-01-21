using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Backrezepte.WpfApp
{
    /// <summary>
    /// Interaktionslogik für App.xaml
    /// </summary>
    public partial class App : MvxApplication
    {
        protected void RegisterSetup()
        {
            this.RegisterSetupType<Backrezepte.WpfApp.Setup>();
        }
    }
}
