using Xamarin.Forms;

namespace FirstApp.Behaviors
{
    public class MaxLenValidationBehavior : FormValidationBehavior
    {
        protected override bool IsValid(TextChangedEventArgs args) => args.NewTextValue.Length <= 6;
    }
}
