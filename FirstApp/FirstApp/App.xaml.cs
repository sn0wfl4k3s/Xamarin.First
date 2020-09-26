using Xamarin.Forms;
using FirstApp.Views;
using FirstApp.Services;
using FirstApp.Models;
using FirstApp.DataAccess;

namespace FirstApp
{
    public partial class App : Application
    {


        public App()
        {
            InitializeComponent();

            DependencyService.Register<IDataStore<Note>, NoteService>();

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
