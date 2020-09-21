namespace FirstApp.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new FirstApp.App());
        }
    }
}
