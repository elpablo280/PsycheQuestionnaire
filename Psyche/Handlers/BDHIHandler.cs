using Psyche.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psyche.Handlers
{
    public class BDHIHandler : IHandler
    {
        private readonly List<int> Answers = new();

        public BDHIHandler(List<int> answers)
        {
            Answers = answers;
        }

        // номера вопросов
        private readonly int[] indexesPhysAggr02 = { 1, 25, 33, 48, 55, 62, 68, 9, 17, 41 };
        private readonly int[] indexesIndAggr = { 2, 18, 34, 42, 56, 63, 10, 26, 49 };
        private readonly int[] indexesIrritation02 = { 3, 19, 27, 43, 50, 57, 64, 72, 11, 35, 69 };
        private readonly int[] indexesNegativism = { 4, 12, 20, 23, 36 };
        private readonly int[] indexesResentment01 = { 5, 13, 21, 29, 37, 51, 58, 44 };
        private readonly int[] indexesSuspicion01 = { 6, 14, 22, 30, 38, 45, 52, 59, 65, 70 };
        private readonly int[] indexesVerbalAggr02 = { 7, 15, 28, 31, 46, 53, 60, 71, 73, 39, 66, 74, 75 };
        private readonly int[] indexesFeelGuilty = { 8, 16, 24, 32, 40, 47, 54, 61, 67 };

        public string GetResult()
        {
            string result = $"Опросник уровня агрессивности Басса - Дарки(По Рогову Е.И.). {Environment.NewLine}";

            int resultHostility = 0;
            int resultAggr = 0;

            int resultIndAggr = 0;
            int resultNegativism = 0;
            int resultFeelGuilty = 0;
            int resultPhysAggr02 = 0;
            int resultIrritation02 = 0;
            int resultResentment01 = 0;
            int resultSuspicion01 = 0;
            int resultVerbalAggr02 = 0;

            for (int i = 0; i < Answers.Count; i++)
            {
                if (indexesPhysAggr02.Contains(i))
                {
                    resultPhysAggr02 += Answers[i];
                }
                else if (indexesIndAggr.Contains(i))
                {
                    resultIndAggr += Answers[i];
                }
                else if (indexesIrritation02.Contains(i))
                {
                    resultIrritation02 += Answers[i];
                }
                else if (indexesNegativism.Contains(i))
                {
                    resultNegativism += Answers[i];
                }
                else if (indexesResentment01.Contains(i))
                {
                    resultResentment01 += Answers[i];
                }
                else if (indexesSuspicion01.Contains(i))
                {
                    resultSuspicion01 += Answers[i];
                }
                else if (indexesVerbalAggr02.Contains(i))
                {
                    resultVerbalAggr02 += Answers[i];
                }
                else if (indexesFeelGuilty.Contains(i))
                {
                    resultFeelGuilty += Answers[i];
                }
            }

            resultHostility += resultSuspicion01;
            resultHostility += resultResentment01;
            resultAggr += resultVerbalAggr02;
            resultAggr += resultIrritation02;
            resultAggr += resultPhysAggr02;

            if (resultAggr <= 25 && resultAggr >= 17)
            {
                result += $"Уровень агрессивности в норме(норма 21 ± 4) - {resultAggr} {Environment.NewLine}";
            } else
            {
                result += $"Уровень агрессивности не в норме(норма 21 ± 4) - {resultAggr} {Environment.NewLine}";
            }

            if (resultHostility <= 10 && resultHostility >= 4)
            {
                result += $"Уровень враждебности в норме(норма 7 ± 3) - {resultHostility} {Environment.NewLine}";
            } else
            {
                result += $"Уровень враждебности не в норме(норма 7 ± 3) - {resultHostility} {Environment.NewLine}";
            }

            result += $"Косвенная агрессия - {resultIndAggr} {Environment.NewLine}";
            result += $"Негативизм - {resultNegativism} {Environment.NewLine}";
            result += $"Чувство вины - {resultFeelGuilty} {Environment.NewLine}";

            return result;
        }
    }
}
