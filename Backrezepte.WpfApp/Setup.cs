using MvvmCross.Logging;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.ViewModels;
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
    /// Interaktionslogik für NLog.xaml
    /// </summary>
    public partial class Setup : MvxWpfSetup
    {
        protected override IMvxApplication CreateApp()
        {
            return new Backrezepte.Core.Setup();
        }

        public override MvxLogProviderType GetDefaultLogProviderType() => MvxLogProviderType.NLog;

    }
}
