using Xamarin.Forms;

namespace FirstApp.Behaviors
{
    public class MaxLenValidationBehavior : FormValidationBehavior
    {
        public int Length { get; set; }

        protected override bool IsValid(TextChangedEventArgs args) => args.NewTextValue.Length <= Length;
    }
}
