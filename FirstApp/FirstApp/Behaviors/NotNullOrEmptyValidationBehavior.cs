namespace FirstApp.Behaviors
{
    public class NotNullOrEmptyValidationBehavior : FormValidationBehavior
    {
        protected override bool IsValid(string text)
            => !string.IsNullOrEmpty(text);
    }
}
