using Psyche.Models;

namespace Psyche.Workers
{
    public class TestParser
    {
        public TestParser()
        {
        }

        public Test ParseTest(string filePath)
        {
            Test test = Newtonsoft.Json.JsonConvert.DeserializeObject<Test>(File.ReadAllText(filePath));
            if (test is not null)
            {
                return test;
            }
            else
            {
                throw new Exception($"Parsed test is null from filepath: {filePath}");
            }
        }
    }
}
