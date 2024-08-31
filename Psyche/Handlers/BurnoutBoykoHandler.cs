using Psyche.Interfaces;

namespace Psyche.Handlers
{
    public class BurnoutBoykoHandler : IHandler
    {
        private readonly List<int> Answers = new();

        public BurnoutBoykoHandler(List<int> answers)
        {
            Answers = answers;
        }

        // номера вопросов
        //private readonly int[] indexesPsychhoTrauma = { 0, 15, 21, 27, 33, 41, 50, 60, 67, 76, 81, 89, 93 };
        //private readonly int[] indexesDissatisfaction = { 5, 10, 18, 24, 34, 42, 48, 58, 65, 74, 84, 88 };
        //private readonly int[] indexesCage = { 1, 13, 17, 25, 32, 47, 49, 57, 68, 77, 85, 87, 92, 94 };
        //private readonly int[] indexesAnxietyDepression = { 2, 9, 23, 28, 36, 44, 51, 63, 64, 73 };
        //private readonly int[] indexesInadequate = { 6, 8, 22, 26, 37, 40, 54, 62, 70, 72, 83, 91, 95 };
        //private readonly int[] indexesDisorientation = { 7, 14, 19, 30, 39, 46, 53, 59, 66, 75, 82, 90, 96 };
        //private readonly int[] indexesEmotionsEconomy = { 3, 12, 16, 29, 35, 43, 55, 61, 69, 79, 80, 86 };
        //private readonly int[] indexesReduction = { 4, 11, 20, 31, 38, 45, 52, 56, 71, 78 };
        //private readonly int[] indexesEmotionalDeficit = { 4, 11, 20, 31, 38, 45, 52, 56, 71, 78 };
        //private readonly int[] indexesEmotionalDetachment = { 4, 11, 20, 31, 38, 45, 52, 56, 71, 78 };
        //private readonly int[] indexesDepersonalization = { 4, 11, 20, 31, 38, 45, 52, 56, 71, 78 };
        //private readonly int[] indexesPsychosomavegeta = { 4, 11, 20, 31, 38, 45, 52, 56, 71, 78 };

        public string GetResult()
        {
            string result = $"Методика «Индекс жизненного стиля». {Environment.NewLine}";
            int resultPsychhoTrauma = 0;
            int resultDissatisfaction = 0;
            int resultCage = 0;
            int resultAnxietyDepression = 0;
            int resultInadequate = 0;
            int resultDisorientation = 0;
            int resultEmotionsEconomy = 0;
            int resultReduction = 0;
            int resultEmotionalDeficit = 0;
            int resultEmotionalDetachment = 0;
            int resultDepersonalization = 0;
            int resultPsychosomavegeta = 0;

            for (int i = 0; i < Answers.Count; i++)
            {
                switch (i % 12)
                {
                    case 1: resultPsychhoTrauma += Answers[i]; break;
                    case 2: resultDissatisfaction += Answers[i]; break;
                    case 3: resultCage += Answers[i]; break;
                    case 4: resultAnxietyDepression += Answers[i]; break;
                    case 5: resultInadequate += Answers[i]; break;
                    case 6: resultDisorientation += Answers[i]; break;
                    case 7: resultEmotionsEconomy += Answers[i]; break;
                    case 8: resultReduction += Answers[i]; break;
                    case 9: resultEmotionalDeficit += Answers[i]; break;
                    case 10: resultEmotionalDetachment += Answers[i]; break;
                    case 11: resultDepersonalization += Answers[i]; break;
                    case 0: resultPsychosomavegeta += Answers[i]; break;
                }
            }

            int resultStress = resultPsychhoTrauma + resultDissatisfaction + resultCage + resultAnxietyDepression;
            int resultResistance = resultInadequate + resultDisorientation + resultEmotionsEconomy + resultReduction;
            int resultExhaustion = resultEmotionalDeficit + resultEmotionalDetachment + resultDepersonalization + resultPsychosomavegeta;

            result += $"Переживание психотравмирующих обстоятельств: {GetSymptomGrade(resultPsychhoTrauma)}{Environment.NewLine}" +
                $"Неудовлетворенность собой: {GetSymptomGrade(resultDissatisfaction)}{Environment.NewLine}" +
                $"«Загнанность в клетку»: {GetSymptomGrade(resultCage)}{Environment.NewLine}" +
                $"Тревога и депрессия: {GetSymptomGrade(resultAnxietyDepression)}{Environment.NewLine}" +
                $"Неадекватное избирательное эмоциональное реагирование: {GetSymptomGrade(resultInadequate)}{Environment.NewLine}" +
                $"Эмоционально-нравственная дезориентация: {GetSymptomGrade(resultDisorientation)}{Environment.NewLine}" +
                $"Расширение сферы экономии эмоций: {GetSymptomGrade(resultEmotionsEconomy)}{Environment.NewLine}" +
                $"Редукция профессиональных обязанностей: {GetSymptomGrade(resultReduction)}{Environment.NewLine}" +
                $"Эмоциональный дефицит: {GetSymptomGrade(resultEmotionalDeficit)}{Environment.NewLine}" +
                $"Эмоциональная отстраненность: {GetSymptomGrade(resultEmotionalDetachment)}{Environment.NewLine}" +
                $"Личностная отстраненность (деперсонализация): {GetSymptomGrade(resultDepersonalization)}{Environment.NewLine}" +
                $"Психосоматические и психовегетативные нарушения: {GetSymptomGrade(resultPsychosomavegeta)}{Environment.NewLine}" +
                $"Факторы: {Environment.NewLine}" +
                $"Напряжение: {resultStress}{Environment.NewLine}" +
                $"Резистенция: {resultResistance}{Environment.NewLine}" +
                $"Истощение: {resultExhaustion}{Environment.NewLine}";

            return result;
        }

        private string GetSymptomGrade(int result)
        {
            string symptom = "";

            if (result <= 9)
            {
                symptom += $" - не сложившийся симптом (9 и менее); ";
            }
            else if (result >= 10 && result <= 15)
            {
                symptom += $" - складывающийся симптом (10 - 15); ";
            }
            else
            {
                symptom += $" - сложившийся симптом (16 и более); ";
            }

            return symptom;
        }
    }
}
