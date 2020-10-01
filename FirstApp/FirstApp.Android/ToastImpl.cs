using Android.Widget;
using FirstApp.Contracts;
using FirstApp.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(ToastImpl))]
namespace FirstApp.Droid
{
    public class ToastImpl : IToast
    {
        public void Show(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
        }
    }
}