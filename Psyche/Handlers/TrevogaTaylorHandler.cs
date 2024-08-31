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

        private readonly int[] indexesLie = { 1, 9, 54, 15, 19, 26, 28, 40, 50, 58 };

        public string GetResult()
        {
            string result = $"Личностная шкала проявления тревоги (Дж. Тейлор, вариант В. Г. Норакидзе). {Environment.NewLine}";
            int resultInt = 0;
            int resultLieInt = 0;
            string resultString = "Уровень тревоги - ";
            string resultLieString = "";

            for (int i = 0; i < Answers.Count; i++)
            {
                if (indexesLie.Contains(i))
                {
                    resultLieInt += Answers[i];
                }
                else
                {
                    resultInt += Answers[i];
                }
            }

            if (resultLieInt > 6)
            {
                resultLieString += "Уровень лжи - испытуемый неискренен. ";
            }

            if (resultInt >= 41)
            {
                resultString += "Высокий уровень тревожности. Частая смена настроения, слабый контроль над эмоциями. Подвержен стрессогенности. Высокая чувствительность (синзетивность), вплоть до нейротизма личности. ";
            }
            else if (resultInt >= 26 && resultInt <= 40)
            {
                resultString += "Высокий уровень тревожности. Частая смена настроения, слабый контроль над эмоциями. Подвержен стрессогенности. Высокая чувствительность (синзетивность). ";
            }
            else if (resultInt >= 16 && resultInt <= 25)
            {
                resultString += "Умеренная тревожность, тенденция к высокой.«Зона эмоционального комфорта» (не сухарь, живой человек).Характерно для холериков и меланхоликов. ";
            }
            else if (resultInt >= 6 && resultInt <= 15)
            {
                resultString += "Умеренная тревожность, тенденция к низкой.«Зона полезной тревоги» (нельзя быть бесчувственным, толстокожим бегемотом).Характерно для сангвиников и флегматиков. ";
            }
            else if (resultInt <= 5)
            {
                resultString += "Эмоциональная стабильность, тревожность низкая. Стрессоустойчив. Низкая чувствительность. Некоторая эмоциональная холодность. Скудность эмоций. ";
            }
            else
            {
                throw new Exception("Неправильный результат");
            }
            //if (resultInt >= 40)
            //{
            //    resultString += "Очень высокий. ";
            //}
            //else if (resultInt >= 25 && resultInt <= 39)
            //{
            //    resultString += "Высокий. ";
            //}
            //else if (resultInt >= 15 && resultInt <= 24)
            //{
            //    resultString += "Средний (с тенденцией к высокому). ";
            //}
            //else if (resultInt >= 5 && resultInt <= 14)
            //{
            //    resultString += "Средний (с тенденцией к низкому). ";
            //}
            //else if (resultInt <= 4)
            //{
            //    resultString += "Низкий. ";
            //}
            //else
            //{
            //    throw new Exception("Неправильный результат");
            //}

            result += $"{resultString}{resultString}{Environment.NewLine}";

            return result;
        }
    }
}
