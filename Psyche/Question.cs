namespace Psyche
{
    public class Question
    {
        public string? Text { get; set; }
        public IEnumerable<bool>? Variants { get; set; }
    }
}
