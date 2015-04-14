using Windows.UI.Xaml;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

namespace Template10
{
    sealed partial class App : Common.BootStrapper
    {
        public App() : base()
        {
            this.InitializeComponent();
        }

        protected override Task OnInitializeAsync()
        {
            // use splitview shell
            Window.Current.Content = new Views.Shell(this.RootFrame);
            return base.OnInitializeAsync();
        }

        protected override Task OnLaunchedAsync(LaunchActivatedEventArgs e)
        {
            // first launch navigation
            this.NavigationService.Navigate(typeof(Views.MainPage));
            return base.OnLaunchedAsync(e);
        }
    }
}
