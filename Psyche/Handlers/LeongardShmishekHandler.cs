using Psyche.Interfaces;

namespace Psyche.Handlers
{
    public class LeongardShmishekHandler : IHandler
    {
        private readonly List<int> Answers = new();

        public LeongardShmishekHandler(List<int> answers)
        {
            Answers = answers;
        }

        // номера вопросов
        private readonly int[] indexesDemon = { 6, 18, 21, 28, 40, 43, 62, 65, 72, 84, 87 };
        private readonly int[] indexesZastr = { 1, 14, 23, 33, 36, 55, 67, 77, 80, 11, 45, 58 };
        private readonly int[] indexesPedant = { 3, 13, 16, 25, 38, 47, 57, 60, 69, 79, 82, 35 };
        private readonly int[] indexesVozbud = { 7, 19, 29, 41, 51, 63, 73, 85 };
        private readonly int[] indexesGipertim = { 0, 10, 22, 32, 44, 54, 66, 76 };
        private readonly int[] indexesDistim = { 8, 20, 42, 74, 86, 30, 52, 64 };
        private readonly int[] indexesTrevog = { 15, 26, 37, 48, 59, 70, 81, 4 };
        private readonly int[] indexesExalt = { 9, 31, 53, 75 };
        private readonly int[] indexesEmotiv = { 2, 12, 34, 46, 56, 68, 78, 24 };
        private readonly int[] indexesCyclotim = { 5, 17, 27, 39, 49, 61, 71, 83 };

        public string GetResult()
        {
            string result = $"Методика диагностики соц.-псих. установок личности. {Environment.NewLine}";
            int resultDemon = 0;
            int resultZastr = 0;
            int resultPedant = 0;
            int resultVozbud = 0;
            int resultGipertim = 0;
            int resultDistim = 0;
            int resultTrevog = 0;
            int resultExalt = 0;
            int resultEmotiv = 0;
            int resultCyclotim = 0;

            for (int i = 0; i < Answers.Count; i++)
            {
                if (indexesDemon.Contains(i))
                {
                    resultDemon += Answers[i] * 2;
                }
                else if (indexesZastr.Contains(i))
                {
                    resultZastr += Answers[i] * 2;
                }
                else if (indexesPedant.Contains(i))
                {
                    resultPedant += Answers[i] * 2;
                }
                else if (indexesVozbud.Contains(i))
                {
                    resultVozbud += Answers[i] * 3;
                }
                else if (indexesGipertim.Contains(i))
                {
                    resultGipertim += Answers[i] * 3;
                }
                else if (indexesDistim.Contains(i))
                {
                    resultDistim += Answers[i] * 3;
                }
                else if (indexesTrevog.Contains(i))
                {
                    resultTrevog += Answers[i] * 3;
                }
                else if (indexesExalt.Contains(i))
                {
                    resultExalt += Answers[i] * 6;
                }
                else if (indexesEmotiv.Contains(i))
                {
                    resultEmotiv += Answers[i] * 3;
                }
                else if (indexesCyclotim.Contains(i))
                {
                    resultCyclotim += Answers[i] * 3;
                }
            }

            result += $"Демонстративность/демонстративный тип: {resultDemon}{Environment.NewLine} " +
                $"Застревание/застревающий тип: {resultZastr}{Environment.NewLine} " +
                $"Педантичность/педантичный тип: {resultPedant}{Environment.NewLine} " +
                $"Возбудимость/возбудимый тип: {resultVozbud}{Environment.NewLine} " +
                $"Гипертимность/гипертимный тип: {resultGipertim}{Environment.NewLine} " +
                $"Дистимность/дистимический тип: {resultDistim}{Environment.NewLine} " +
                $"Тревожность/тревожно-боязливый тип: {resultTrevog}{Environment.NewLine} " +
                $"Экзальтированность/аффективно-экзальтированный тип: {resultExalt}{Environment.NewLine} " +
                $"Эмотивность/эмотивный тип: {resultEmotiv}{Environment.NewLine} " +
                $"Циклотимность/циклотимный тип: {resultCyclotim}{Environment.NewLine} ";

            bool isAccent = false;
            string resultAccent = "Акцентуализирован: ";

            if (resultDemon > 18)
            {
                resultAccent += $"демонстративный характер; ";
                isAccent = true;
            }
            if (resultZastr > 18)
            {
                resultAccent += $"застревающий характер; ";
                isAccent = true;
            }
            if (resultPedant > 18)
            {
                resultAccent += $"педантичный характер; ";
                isAccent = true;
            }
            if (resultVozbud > 18)
            {
                resultAccent += $"возбудимый характер; ";
                isAccent = true;
            }
            if (resultGipertim > 18)
            {
                resultAccent += $"гипертимический темперамент; ";
                isAccent = true;
            }
            if (resultDistim > 18)
            {
                resultAccent += $"дистимический темперамент; ";
                isAccent = true;
            }
            if (resultTrevog > 18)
            {
                resultAccent += $"тревожно-боязливый темперамент; ";
                isAccent = true;
            }
            if (resultCyclotim > 18)
            {
                resultAccent += $"циклотимический темперамент; ";
                isAccent = true;
            }
            if (resultExalt > 18)
            {
                resultAccent += $"аффективный темперамент; ";
                isAccent = true;
            }
            if (resultEmotiv > 18)
            {
                resultAccent += $"эмотивный темперамент; ";
                isAccent = true;
            }

            if (isAccent)
            {
                result += resultAccent;
            }

            // todo спросить, надо ли добавлять текста

            return result;
        }
    }
}
