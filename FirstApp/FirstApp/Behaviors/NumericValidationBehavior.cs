using Xamarin.Forms;

namespace FirstApp.Behaviors
{
    public class NumericValidationBehavior : FormValidationBehavior
    {
        protected override bool IsValid(TextChangedEventArgs args) 
            => double.TryParse(args.NewTextValue, out _) || string.IsNullOrEmpty(args.NewTextValue);
    }
}
