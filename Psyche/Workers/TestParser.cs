using Psyche.Models;

namespace Psyche.Workers
{
    public class TestParser
    {
        public TestParser()
        {
        }

        public Test? ParseTest(string filePath) 
            => Newtonsoft.Json.JsonConvert.DeserializeObject<Test>(File.ReadAllText(filePath));
    }
}
