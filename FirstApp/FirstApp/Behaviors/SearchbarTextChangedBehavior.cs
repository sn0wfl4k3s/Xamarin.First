using Xamarin.Forms;

namespace FirstApp.Behaviors
{
    public class SearchbarTextChangedBehavior : Behavior<SearchBar>
    {
        protected override void OnAttachedTo(SearchBar bindable)
        {
            bindable.TextChanged += OnSearchbarChangedText;
            base.OnAttachedTo(bindable);
        }
        protected override void OnDetachingFrom(SearchBar bindable)
        {
            bindable.TextChanged -= OnSearchbarChangedText;
            base.OnDetachingFrom(bindable);
        }

        private void OnSearchbarChangedText(object sender, TextChangedEventArgs e)
        {
            (sender as SearchBar).SearchCommand?.Execute(e.NewTextValue);
        }

    }
}
