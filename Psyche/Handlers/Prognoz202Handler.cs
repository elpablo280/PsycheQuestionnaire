using Psyche.Interfaces;

namespace Psyche.Handlers
{
    public class Prognoz202Handler : IHandler
    {
        private readonly List<int> Answers = new();

        public Prognoz202Handler(List<int> answers)
        {
            Answers = answers;
        }

        private readonly int[] indexesI = { 1, 5, 11, 14, 18, 20, 25, 32, 37, 43, 48, 51, 57, 60 };

        public string GetResult()
        {
            string result = $"Тест Прогноз-2-02. {Environment.NewLine}";
            int resultI = 0;
            int resultNPU = 0;
            string resultIstring = "Шкала искренности - ";
            string resultNPUstring = "Шкала нервно-психической устойчивости - ";

            for (int i = 0; i < Answers.Count; i++)           // порядковые номера столбцов с ответами в таблице
            {
                if (indexesI.Contains(i))
                {
                    resultI += Answers[i];
                }
                else
                {
                    resultNPU += Answers[i];
                }

            }

            if (resultI < 10)
            {
                resultIstring += $"{resultI} (< 10). ";
            }
            else
            {
                resultIstring += $"{resultI}, использовать данные анкеты не рекомендуется (>= 10). ";
            }

            if (resultNPU >= 35)
            {
                resultNPUstring += $"{resultNPU} - Неудовлетворительный (Неудовлетворительная нервно-психическая устойчивость или нервно-психическая неустойчивость (4-й уровень НПУ). Очень высокая вероятность нервно-психических срывов. Необходимо дополнительное обследование психиатра, невропатолога). ";
            }
            else if (resultNPU >= 16 && resultNPU <= 34)
            {
                resultNPUstring += $"{resultNPU} - Удовлетворительный (Удовлетворительная нервно-психическая устойчивость (3-й уровень НПУ). Нервно-психические срывы вероятны в экстремальных ситуациях, при значительных физических и психических нагрузках). ";
            }
            else if (resultNPU >= 4 && resultNPU <= 15)
            {
                resultNPUstring += $"{resultNPU} - Хороший (Хорошая нервно-психическая устойчивость (2-й уровень НПУ). Нервно-психические срывы маловероятны). ";
            }
            else if (resultNPU <= 3)
            {
                resultNPUstring += $"{resultNPU} - Высокий (Высокая нервно-психическая устойчивость (1-й уровень). При наличии других положительных данных можно рекомендовать для службы на воинских должностях, требующих повышенной НПУ). ";
            }
            else
            {
                throw new Exception("Неправильный результат");
            }

            result += $"{resultIstring}{Environment.NewLine}{resultNPUstring}{Environment.NewLine}";

            return result;
        }
    }
}
