using FirstApp.Contracts;
using FirstApp.iOS;
using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(ToastImpl))]
namespace FirstApp.iOS
{
    public class ToastImpl : IToast
    {
        const double LONG_DELAY = 3.5;


        NSTimer alertDelay;
        UIAlertController alert;

        public void Show(string message)
        {
            ShowAlert(message, LONG_DELAY);
        }


        void ShowAlert(string message, double seconds)
        {
            alertDelay = NSTimer.CreateScheduledTimer(seconds, (obj) =>
            {
                DismissMessage();
            });
            alert = UIAlertController.Create(null, message, UIAlertControllerStyle.Alert);
            UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(alert, true, null);
        }
        void DismissMessage()
        {
            if (alert is not null)
            {
                alert.DismissViewController(true, null);
            }
            if (alertDelay is not null)
            {
                alertDelay.Dispose();
            }
        }
    }
}