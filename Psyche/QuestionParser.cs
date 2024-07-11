namespace Psyche
{
    public class QuestionParser
    {
        public QuestionParser()
        {
        }

        public Question ParseQuestions(string filePath)
        {
            var text = File.ReadAllText(filePath);
            var result = Newtonsoft.Json.JsonConvert.DeserializeObject<Question>(text);
            return result;
        }
    }
}
