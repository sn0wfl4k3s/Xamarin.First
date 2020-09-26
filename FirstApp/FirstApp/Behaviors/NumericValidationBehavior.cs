using Xamarin.Forms;

namespace FirstApp.Behaviors
{
    public class NumericValidationBehavior : Behavior<Entry>
    {
        public string MessageError { get; set; }

        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(bindable);
        }


        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            bool isValid = double.TryParse(args.NewTextValue, out _);
            
            (sender as Entry).TextColor = isValid ? Color.Default : Color.Red;
        }


    }
}
