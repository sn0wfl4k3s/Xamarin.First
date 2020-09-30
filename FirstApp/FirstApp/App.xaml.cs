using FirstApp.Contracts;
using FirstApp.Models;
using FirstApp.Resources;
using FirstApp.Services;
using FirstApp.Views;

using Xamarin.Forms;

namespace FirstApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<IDataStore<Note>, NoteService>();

            AppResources.Culture = System.Threading.Thread.CurrentThread.CurrentCulture;

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
