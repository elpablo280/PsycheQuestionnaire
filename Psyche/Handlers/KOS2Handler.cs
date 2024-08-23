using Psyche.Interfaces;

namespace Psyche.Handlers
{
    public class KOS2Handler : IHandler
    {
        private readonly List<int> Answers = new();

        public KOS2Handler(List<int> answers)
        {
            Answers = answers;
        }

        public string GetResult()
        {
            string result = $"Тест КОС-2. {Environment.NewLine}";
            int resultC = 0;
            int resultO = 0;
            string resultCstring = "Уровень проявления коммуникативных склонностей - ";
            string resultOstring = "Уровень проявления организаторских склонностей - ";

            for (int i = 0; i < Answers.Count; i++)           // чётные ответы относятся к коммуникативным вопросам, нечётные - к организаторским
            {
                if (i % 2 == 0)
                {
                    resultC += Answers[i];
                }
                else
                {
                    resultO += Answers[i];
                }
            }

            double resultCcalculated = resultC / 20.0;
            double resultOcalculated = resultO / 20.0;

            if (resultCcalculated >= 0 && resultCcalculated <= 0.45)
            {
                resultCstring += "Низкий. ";
            }
            else if (resultCcalculated >= 0.46 && resultCcalculated <= 0.55)
            {
                resultCstring += "Ниже среднего. ";
            }
            else if (resultCcalculated >= 0.56 && resultCcalculated <= 0.65)
            {
                resultCstring += "Средний. ";
            }
            else if (resultCcalculated >= 0.66 && resultCcalculated <= 0.75)
            {
                resultCstring += "Высокий. ";
            }
            else if (resultCcalculated >= 0.76 && resultCcalculated <= 1)
            {
                resultCstring += "Очень высокий. ";
            }
            else
            {
                throw new Exception("Неправильный результат");
            }

            if (resultOcalculated >= 0 && resultOcalculated <= 0.45)
            {
                resultOstring += "Низкий. ";
            }
            else if (resultOcalculated >= 0.46 && resultOcalculated <= 0.55)
            {
                resultOstring += "Ниже среднего. ";
            }
            else if (resultOcalculated >= 0.56 && resultOcalculated <= 0.65)
            {
                resultOstring += "Средний. ";
            }
            else if (resultOcalculated >= 0.66 && resultOcalculated <= 0.75)
            {
                resultOstring += "Высокий. ";
            }
            else if (resultOcalculated >= 0.76 && resultOcalculated <= 1)
            {
                resultOstring += "Очень высокий. ";
            }
            else
            {
                throw new Exception("Неправильный результат");
            }

            result += $"{resultCstring}{Environment.NewLine}{resultOstring}{Environment.NewLine}";

            return result;
        }
    }
}
