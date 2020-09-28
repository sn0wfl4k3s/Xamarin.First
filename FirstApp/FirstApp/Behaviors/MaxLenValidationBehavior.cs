namespace FirstApp.Behaviors
{
    public class MaxLenValidationBehavior : FormValidationBehavior
    {
        public int Length { get; set; }

        protected override bool IsValid(string text) 
            => string.IsNullOrEmpty(text) || text.Length <= Length;
    }
}
