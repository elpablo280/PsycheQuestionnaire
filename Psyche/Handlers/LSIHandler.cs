using Psyche.Interfaces;

namespace Psyche.Handlers
{
    public class LSIHandler : IHandler
    {
        private readonly List<int> Answers = new();

        public LSIHandler(List<int> answers)
        {
            Answers = answers;
        }

        // номера вопросов
        private readonly int[] indexesOtric = { 0, 15, 21, 27, 33, 41, 50, 60, 67, 76, 81, 89, 93 };
        private readonly int[] indexesPodavl = { 5, 10, 18, 24, 34, 42, 48, 58, 65, 74, 84, 88 };
        private readonly int[] indexesRegress = { 1, 13, 17, 25, 32, 47, 49, 57, 68, 77, 85, 87, 92, 94 };
        private readonly int[] indexesComp = { 2, 9, 23, 28, 36, 44, 51, 63, 64, 73 };
        private readonly int[] indexesProject = { 6, 8, 22, 26, 37, 40, 54, 62, 70, 72, 83, 91, 95 };
        private readonly int[] indexesZamesch = { 7, 14, 19, 30, 39, 46, 53, 59, 66, 75, 82, 90, 96 };
        private readonly int[] indexesIntellect = { 3, 12, 16, 29, 35, 43, 55, 61, 69, 79, 80, 86 };
        private readonly int[] indexesReact = { 4, 11, 20, 31, 38, 45, 52, 56, 71, 78 };

        public string GetResult()
        {
            string result = $"Методика «Индекс жизненного стиля». {Environment.NewLine}";
            int resultOtric = 0;
            int resultPodavl = 0;
            int resultRegress = 0;
            int resultComp = 0;
            int resultProject = 0;
            int resultZamesch = 0;
            int resultIntellect = 0;
            int resultReact = 0;

            for (int i = 0; i < Answers.Count; i++)
            {
                if (indexesOtric.Contains(i))
                {
                    resultOtric += Answers[i];
                }
                else if (indexesPodavl.Contains(i))
                {
                    resultPodavl += Answers[i];
                }
                else if (indexesRegress.Contains(i))
                {
                    resultRegress += Answers[i];
                }
                else if (indexesComp.Contains(i))
                {
                    resultComp += Answers[i];
                }
                else if (indexesProject.Contains(i))
                {
                    resultProject += Answers[i];
                }
                else if (indexesZamesch.Contains(i))
                {
                    resultZamesch += Answers[i];
                }
                else if (indexesIntellect.Contains(i))
                {
                    resultIntellect += Answers[i];
                }
                else if (indexesReact.Contains(i))
                {
                    resultReact += Answers[i];
                }
            }

            result += $"Отрицание: {resultOtric} (из 12) {Environment.NewLine}" +
                $"Подавление: {resultPodavl} (из 12) {Environment.NewLine}" +
                $"Регрессия: {resultRegress} (из 14) {Environment.NewLine}" +
                $"Компенсация: {resultComp} (из 10) {Environment.NewLine}" +
                $"Проекция: {resultProject} (из 13) {Environment.NewLine}" +
                $"Замещение: {resultZamesch} (из 13) {Environment.NewLine}" +
                $"Интеллектуализация: {resultIntellect} (из 12) {Environment.NewLine}" +
                $"Реактивное образование: {resultReact} (из 10) {Environment.NewLine}";

            return result;
        }
    }
}
