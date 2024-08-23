using Psyche.Interfaces;

namespace Psyche.Handlers
{
    public class STAIHandler : IHandler
    {
        private readonly List<int> Answers = new();

        public STAIHandler(List<int> answers)
        {
            Answers = answers;
        }

        public string GetResult()
        {
            string result = $"Шкала тревоги Спилбергера. {Environment.NewLine}";
            int resultS = 0;
            int resultL = 0;
            string resultSstring = "Шкала ситуативной тревожности - ";
            string resultLstring = "Шкала личной тревожности - ";

            for (int i = 0; i < Answers.Count; i++)
            {
                if (i < 20)
                {
                    resultS += Answers[i];
                }
                else
                {
                    resultL += Answers[i];
                }
            }

            if (resultS <= 30)
            {
                resultSstring += $"{resultS} (до 30 баллов – низкая)";
            }
            else if (resultS >= 31 && resultS <= 44)
            {
                resultSstring += $"{resultS} (31 - 44 балла - умеренная)";
            }
            else if (resultS >= 45)
            {
                resultSstring += $"{resultS} (45 и более - высокая)";
            }
            else
            {
                throw new Exception("Неправильный результат");
            }

            if (resultL <= 30)
            {
                resultLstring += $"{resultL} (до 30 баллов – низкая)";
            }
            else if (resultL >= 31 && resultL <= 44)
            {
                resultLstring += $"{resultL} (31 - 44 балла - умеренная)";
            }
            else if (resultL >= 45)
            {
                resultLstring += $"{resultL} (45 и более - высокая)";
            }
            else
            {
                throw new Exception("Неправильный результат");
            }

            result += $"{resultSstring}{Environment.NewLine}{resultLstring}{Environment.NewLine}";

            return result;
        }
    }
}
