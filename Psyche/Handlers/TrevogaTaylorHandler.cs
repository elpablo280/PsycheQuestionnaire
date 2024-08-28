using Psyche.Interfaces;

namespace Psyche.Handlers
{
    public class TrevogaTaylorHandler : IHandler
    {
        private readonly List<int> Answers = new();

        public TrevogaTaylorHandler(List<int> answers)
        {
            Answers = answers;
        }

        public string GetResult()
        {
            string result = $"Личностная шкала проявления тревоги (Дж. Тейлор). {Environment.NewLine}";
            int resultInt = 0;
            string resultString = "Уровень тревоги - ";

            for (int i = 0; i < Answers.Count; i++)
            {
                resultInt += Answers[i];
            }

            // todo непонятные пороги

            if (resultInt >= 40)
            {
                resultString += "Очень высокий. ";
            }
            else if (resultInt >= 25 && resultInt <= 39)
            {
                resultString += "Высокий. ";
            }
            else if (resultInt >= 15 && resultInt <= 24)
            {
                resultString += "Средний (с тенденцией к высокому). ";
            }
            else if (resultInt >= 5 && resultInt <= 14)
            {
                resultString += "Средний (с тенденцией к низкому). ";
            }
            else if (resultInt <= 4)
            {
                resultString += "Низкий. ";
            }
            else
            {
                throw new Exception("Неправильный результат");
            }

            result += $"{resultString}{Environment.NewLine}";

            return result;
        }
    }
}
