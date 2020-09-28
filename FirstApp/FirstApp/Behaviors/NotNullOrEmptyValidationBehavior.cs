using Xamarin.Forms;

namespace FirstApp.Behaviors
{
    public class NotNullOrEmptyValidationBehavior : FormValidationBehavior
    {
        protected override bool IsValid(TextChangedEventArgs args) 
            => !string.IsNullOrEmpty(args.NewTextValue);
    }
}
