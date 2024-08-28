using Psyche.Interfaces;

namespace Psyche.Handlers
{
    public class PotemkinaHandler : IHandler
    {
        private readonly List<int> Answers = new();

        public PotemkinaHandler(List<int> answers)
        {
            Answers = answers;
        }

        // номера вопросов
        private readonly int[] indexesProcess = { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36 };
        private readonly int[] indexesResult = { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37 };
        private readonly int[] indexesAltruism = { 2, 6, 10, 14, 18, 22, 26, 30, 34, 38 };
        private readonly int[] indexesEgoism = { 3, 7, 11, 15, 19, 23, 27, 31, 35, 39 };
        private readonly int[] indexesLabour = { 40, 44, 48, 52, 56, 60, 64, 68, 72, 76 };
        private readonly int[] indexesFreedom = { 41, 45, 49, 53, 57, 61, 65, 69, 73, 77 };
        private readonly int[] indexesPower = { 42, 46, 50, 54, 58, 62, 66, 70, 74, 78 };
        private readonly int[] indexesMoney = { 43, 47, 51, 55, 59, 63, 67, 71, 75, 79 };

        public string GetResult()
        {
            string result = $"Методика диагностики соц.-псих. установок личности. {Environment.NewLine}";
            int resultProcess = 0;
            int resultResult = 0;
            int resultAltruism = 0;
            int resultEgoism = 0;
            int resultLabour = 0;
            int resultFreedom = 0;
            int resultPower = 0;
            int resultMoney = 0;

            for (int i = 0; i < Answers.Count; i++)
            {
                if (indexesProcess.Contains(i))
                {
                    resultProcess += Answers[i];
                }
                else if (indexesResult.Contains(i))
                {
                    resultResult += Answers[i];
                }
                else if (indexesAltruism.Contains(i))
                {
                    resultAltruism += Answers[i];
                }
                else if (indexesEgoism.Contains(i))
                {
                    resultEgoism += Answers[i];
                }
                else if (indexesLabour.Contains(i))
                {
                    resultLabour += Answers[i];
                }
                else if (indexesFreedom.Contains(i))
                {
                    resultFreedom += Answers[i];
                }
                else if (indexesPower.Contains(i))
                {
                    resultPower += Answers[i];
                }
                else if (indexesMoney.Contains(i))
                {
                    resultMoney += Answers[i];
                }
            }

            result += $"Процесс: {resultProcess}{Environment.NewLine} " +
                $"Результат: {resultResult}{Environment.NewLine} " +
                $"Альтруизм: {resultAltruism}{Environment.NewLine} " +
                $"Эгоизм: {resultEgoism}{Environment.NewLine} " +
                $"Труд: {resultLabour}{Environment.NewLine} " +
                $"Свобода: {resultFreedom}{Environment.NewLine} " +
                $"Власть: {resultPower}{Environment.NewLine} " +
                $"Деньги: {resultMoney}{Environment.NewLine} ";

            return result;
        }
    }
}
