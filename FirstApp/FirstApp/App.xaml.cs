using Xamarin.Forms;
using FirstApp.Views;
using FirstApp.Services;
using FirstApp.Models;

namespace FirstApp
{
    public partial class App : Application
    {
        public App()
        {

            DependencyService.Register<IDataStore<Note>, NoteService>();

            InitializeComponent();

            MainPage = new MainPage();
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
