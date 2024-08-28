using Psyche.Interfaces;

namespace Psyche.Handlers
{
    public class IsenkTemperamentHandler : IHandler
    {
        private readonly List<int> Answers = new();

        public IsenkTemperamentHandler(List<int> answers)
        {
            Answers = answers;
        }

        // номера вопросов
        private readonly int[] indexesEI = { 0, 2, 8, 10, 13, 16, 18, 21, 24, 26, 29, 34, 37, 40, 42, 45, 48, 52, 56, 5, 32, 50, 54, 58 };
        //private readonly int[] indexesN = { 1, 4, 6, 9, 12, 14, 17, 20, 22, 25, 28, 30, 33, 36, 38, 41, 44, 46, 49, 51, 53, 55, 57, 59 };
        private readonly int[] indexesLie = { 7, 15, 23, 27, 35, 43, 3, 11, 19, 31, 35, 39, 47 };

        public string GetResult()
        {
            string result = $"Методика Айзенка по определению темперамента. {Environment.NewLine}";
            int resultEI = 0;
            int resultN = 0;
            int resultLie = 0;

            for (int i = 0; i < Answers.Count; i++)
            {
                if (indexesLie.Contains(i))
                {
                    resultLie += Answers[i];
                }
                else if (indexesEI.Contains(i))
                {
                    resultEI += Answers[i];
                }
                // необязательно проверять лишний раз
                //else if (resultN.Contains(i))
                //{
                //    resultAltruism += Answers[i];
                //}
                else
                {
                    resultN += Answers[i];
                }
            }

            if (resultLie > 5)
            {
                result += $"Показатель шкалы лжи - {resultLie} (> 5). Результат недостоверен.{Environment.NewLine} ";
            }

            result += $"Экстраверсия-интроверсия: {resultEI}{Environment.NewLine} " +
                $"Нейротизм: {resultN}{Environment.NewLine} ";

            // todo спросить у Миши, нужно ли переносить много текста по типам

            return result;
        }
    }
}
