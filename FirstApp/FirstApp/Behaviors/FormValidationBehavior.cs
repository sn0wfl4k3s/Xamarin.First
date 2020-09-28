using System.Collections.Generic;
using Xamarin.Forms;

namespace FirstApp.Behaviors
{
    public abstract class FormValidationBehavior : Behavior<Entry>
    {
        private static readonly IList<string> ErrorList = new List<string>();

        public string ErrorMessage { get; set; }
        public string ErrorLabelName { get; set; }
        public string NameButtonToDisable { get; set; }


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

        protected abstract bool IsValid(TextChangedEventArgs args);

        protected void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            bool isValid = IsValid(args);

            (sender as Entry).TextColor = isValid ? Color.Default : Color.Red;

            var errorLabel = (sender as Entry).FindByName<Label>(ErrorLabelName);

            errorLabel.IsVisible = !isValid;

            string key = string.Format("{0} - {1}", ErrorLabelName, ErrorMessage);

            if (!isValid && !ErrorList.Contains(key))
            {
                ErrorList.Add(key);
            }

            if (isValid && ErrorList.Contains(key))
            {
                ErrorList.Remove(key);
            }

            if (!isValid)
            {
                errorLabel.Text = ErrorMessage;
                errorLabel.TextColor = Color.Red;
            }

            if (!string.IsNullOrEmpty(NameButtonToDisable))
            {
                (sender as Entry)
                    .FindByName<Button>(NameButtonToDisable)
                    .IsEnabled = ErrorList.Count is 0;
            }
        }
    }
}
