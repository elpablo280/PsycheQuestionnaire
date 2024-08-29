namespace Psyche.Models
{
    public class Preset
    {
        public string Name { get; set; }
        public string[] TestFilepaths { get; set; }

        public Preset(string name, string[] testFilepaths)
        {
            Name = name;
            TestFilepaths = testFilepaths;
        }
    }
}
