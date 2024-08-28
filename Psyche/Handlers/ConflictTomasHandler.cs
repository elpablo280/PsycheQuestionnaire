using Psyche.Interfaces;

namespace Psyche.Handlers
{
    public class ConflictTomasHandler : IHandler
    {
        private readonly List<int> Answers = new();

        public ConflictTomasHandler(List<int> answers)
        {
            Answers = answers;
        }

        public string GetResult()
        {
            string result = $"Типы поведения в конфликте (К. Томас) {Environment.NewLine}";
            int resultSop = 0;
            int resultSot = 0;
            int resultKom = 0;
            int resultIzb = 0;
            int resultPri = 0;

            for (int i = 0; i < Answers.Count; i++)
            {
                switch (Answers[i])
                {
                    case 1: resultSop++ ; break;
                    case 2: resultSot++ ; break;
                    case 3: resultKom++ ; break;
                    case 4: resultIzb++ ; break;
                    case 5: resultPri++ ; break;
                    default: throw new Exception("Ошибка!");
                }
            }

            result += $"Соперничество: {resultSop}{Environment.NewLine} " +
                $"Сотрудничество: {resultSot}{Environment.NewLine} " +
                $"Компромисс: {resultKom}{Environment.NewLine} " +
                $"Избегание: {resultIzb}{Environment.NewLine} " +
                $"Приспособление: {resultPri}{Environment.NewLine} ";

            return result;
        }
    }
}
