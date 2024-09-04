namespace Psyche.Models
{
    public class Test
    {
        public string? Name { get; set; }
        public string? NameDB { get; set; }
        public int TimeLimit { get; set; }
        public string Instruction { get; set; }
        public Question[]? Questions { get; set; }
    }
}
