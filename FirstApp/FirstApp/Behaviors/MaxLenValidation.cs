using Xamarin.Forms;

namespace FirstApp.Behaviors
{
    public class MaxLenValidation : FormValidationBehavior
    {
        protected override bool IsValid(TextChangedEventArgs args) => args.NewTextValue.Length <= 6;
    }
}
