using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;
using Backrezepte.Core;

namespace Backrezepte.WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : MvxApplication
    {
        protected void RegisterSetup()
        { 
            this.RegisterSetupType<Backrezepte.WpfApp.Setup>(); 
        }
    }
}
