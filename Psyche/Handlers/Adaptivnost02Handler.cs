using Psyche.Interfaces;

namespace Psyche.Handlers
{
    public class Adaptivnost02Handler : IHandler
    {
        private readonly List<int> Answers = new();

        public Adaptivnost02Handler(List<int> answers)
        {
            Answers = answers;
        }

        // номера вопросов
        private readonly int[] indexesD = { 0, 9, 18, 30, 50, 68, 77, 91, 100, 115, 127, 137, 147 };
        private readonly int[] indexesNPU = { 3, 5, 6, 7, 10, 11, 14, 15, 16, 17, 19, 20, 27, 28, 29, 26, 38, 39, 40, 46, 56, 59,
        62, 64, 66, 67, 69, 70, 72, 74, 79, 81, 82, 83, 85, 88, 93, 94, 95, 97, 101, 102, 107, 108, 109, 
        110, 111, 112, 114, 116, 117, 118, 119, 121, 122, 123,
        128, 130, 134, 135, 136, 138, 142, 145, 148, 152, 153,
        154, 155, 156, 157, 160, 161,
        1, 2, 4, 22, 24, 31, 37, 43, 44, 48, 51, 52, 53, 54, 57, 61, 65, 86,
        104, 126, 131, 133, 139};
        private readonly int[] indexesCP = { 8, 23, 26, 32, 42, 45, 60, 63, 80, 87, 89, 98, 103, 105, 113, 120, 125, 132, 141, 150, 151,
        25, 33, 34, 47, 73, 84, 106, 129, 143, 146, 158};
        private readonly int[] indexesMN = { 0, 10, 22, 32, 44, 54, 66, 76, 78, 90, 92, 124, 140, 144, 149, 163, 164,
        12, 75, 96, 99, 159, 162};

        public string GetResult()
        {
            string result = $"Опросник Адаптивность-02. {Environment.NewLine}";
            int resultD = 0;
            int resultAS = 0;
            int resultNPU = 0;
            int resultCP = 0;
            int resultMN = 0;

            for (int i = 0; i < Answers.Count; i++)
            {
                if (indexesD.Contains(i))
                {
                    resultD += Answers[i];
                }
                else if (indexesNPU.Contains(i))
                {
                    resultNPU += Answers[i];
                    resultAS += Answers[i];
                }
                else if (indexesCP.Contains(i))
                {
                    resultCP += Answers[i];
                    resultAS += Answers[i];
                }
                else if (indexesMN.Contains(i))
                {
                    resultMN += Answers[i];
                    resultAS += Answers[i];
                }
            }

            string resultDstring = "Шкала достоверности - ";
            string resultASstring = "Шкала адаптивных способностей - ";
            string resultNPUstring = "Шкала нервно-психической устойчивости - ";
            string resultCPstring = "Шкала коммуникативного потенциала - ";
            string resultMNstring = "Шкала моральной нормативности - ";

            if (resultD <= 10)
            {
                resultDstring += $"{resultD} (<= 10). ";
            }
            else
            {
                resultDstring += $"{resultD}, использовать данные анкеты не рекомендуется (> 10). ";
            }

            int scoreAS = 0;
            int scoreNPU = 0;
            int scoreCP = 0;
            int scoreMN = 0;

            if (resultAS >= 104)
            {
                scoreAS = 1;
            }
            else if (resultAS >= 87 && resultAS <= 103)
            {
                scoreAS = 2;
            }
            else if (resultAS >= 72 && resultAS <= 86)
            {
                scoreAS = 3;
            }
            else if (resultAS >= 57 && resultAS <= 71)
            {
                scoreAS = 4;
            }
            else if (resultAS >= 43 && resultAS <= 56)
            {
                scoreAS = 5;
            }
            else if (resultAS >= 36 && resultAS <= 42)
            {
                scoreAS = 6;
            }
            else if (resultAS >= 29 && resultAS <= 35)
            {
                scoreAS = 7;
            }
            else if (resultAS >= 23 && resultAS <= 28)
            {
                scoreAS = 8;
            }
            else if (resultAS >= 19 && resultAS <= 22)
            {
                scoreAS = 9;
            }
            else if (resultAS <= 18)
            {
                scoreAS = 10;
            }
            else
            {
                throw new Exception("Неправильный результат АС");
            }

            if (resultNPU >= 68)
            {
                scoreNPU = 1;
            }
            else if (resultNPU >= 52 && resultNPU <= 67)
            {
                scoreNPU = 2;
            }
            else if (resultNPU >= 41 && resultNPU <= 51)
            {
                scoreNPU = 3;
            }
            else if (resultNPU >= 30 && resultNPU <= 40)
            {
                scoreNPU = 4;
            }
            else if (resultNPU >= 20 && resultNPU <= 29)
            {
                scoreNPU = 5;
            }
            else if (resultNPU >= 15 && resultNPU <= 19)
            {
                scoreNPU = 6;
            }
            else if (resultNPU >= 10 && resultNPU <= 14)
            {
                scoreNPU = 7;
            }
            else if (resultNPU >= 8 && resultNPU <= 9)
            {
                scoreNPU = 8;
            }
            else if (resultNPU >= 6 && resultNPU <= 7)
            {
                scoreNPU = 9;
            }
            else if (resultNPU <= 5)
            {
                scoreNPU = 10;
            }
            else
            {
                throw new Exception("Неправильный результат НПУ");
            }

            if (resultCP >= 25)
            {
                scoreCP = 1;
            }
            else if (resultCP >= 22 && resultCP <= 24)
            {
                scoreCP = 2;
            }
            else if (resultCP >= 19 && resultCP <= 21)
            {
                scoreCP = 3;
            }
            else if (resultCP >= 16 && resultCP <= 18)
            {
                scoreCP = 4;
            }
            else if (resultCP >= 14 && resultCP <= 15)
            {
                scoreCP = 5;
            }
            else if (resultCP >= 36 && resultCP <= 42)
            {
                scoreCP = 6;
            }
            else if (resultCP >= 29 && resultCP <= 35)
            {
                scoreCP = 7;
            }
            else if (resultCP >= 23 && resultCP <= 28)
            {
                scoreCP = 8;
            }
            else if (resultCP >= 19 && resultCP <= 22)
            {
                scoreCP = 9;
            }
            else if (resultCP <= 18)
            {
                scoreCP = 10;
            }
            else
            {
                throw new Exception("Неправильный результат КП");
            }

            if (resultMN >= 18)
            {
                scoreMN = 1;
            }
            else if (resultMN >= 16 && resultMN <= 17)
            {
                scoreMN = 2;
            }
            else if (resultMN >= 14 && resultMN <= 15)
            {
                scoreMN = 3;
            }
            else if (resultMN >= 12 && resultMN <= 13)
            {
                scoreMN = 4;
            }
            else if (resultMN >= 10 && resultMN <= 11)
            {
                scoreMN = 5;
            }
            else if (resultMN == 9)
            {
                scoreMN = 6;
            }
            else if (resultMN >= 7 && resultMN <= 8)
            {
                scoreMN = 7;
            }
            else if (resultMN == 6)
            {
                scoreMN = 8;
            }
            else if (resultMN == 5)
            {
                scoreMN = 9;
            }
            else if (resultMN <= 4)
            {
                scoreMN = 10;
            }
            else
            {
                throw new Exception("Неправильный результат МН");
            }

            if (scoreNPU >= 9 && scoreNPU <= 10)
            {
                resultNPUstring += $"{scoreNPU} - Высокая НПУ – характеризуется низкой вероятностью нарушений психической деятельности, высоким уровнем поведенческой регуляции. ";
            }
            else if (scoreNPU >= 6 && scoreNPU <= 8)
            {
                resultNPUstring += $"{scoreNPU} - Хорошая НПУ – характеризуется низкой вероятностью нервно-психических срывов, адекватными самооценкой и оценкой окружающей действительности. Возможны единичные, кратковременные нарушения поведения в экстремальных ситуациях при значительных физических и эмоциональных нагрузках. ";
            }
            else if (scoreNPU >= 3 && scoreNPU <= 5)
            {
                resultNPUstring += $"{scoreNPU} - Удовлетворительная НПУ - характеризуется возможностью в экстремальных ситуациях умеренных нарушений психической деятельности, сопровождающихся неадекватными поведением,  самооценкой и (или) восприятием окружающей действительности. ";
            }
            else if (scoreNPU <= 2)
            {
                resultNPUstring += $"{scoreNPU} - Неудовлетворительная НПУ – характеризуется склонностью к нарушениям психической деятельности при значительных психических и физических нагрузках. ";
            }
            else
            {
                throw new Exception("Неправильный результат");
            }

            if (scoreAS >= 5)
            {
                resultASstring += $"{scoreAS} - Группы высокой и нормальной адаптации. ";
            }
            else if (scoreAS >= 3 && scoreAS <= 4)
            {
                resultASstring += $"{scoreAS} - Группа удовлетворительной адаптации. ";
            }
            else if (scoreAS <= 2)
            {
                resultASstring += $"{scoreAS} - Группа низкой адаптации. ";
            }
            else
            {
                throw new Exception("Неправильный результат");
            }

            if (scoreCP >= 9)
            {
                resultCPstring += $"{scoreCP} - Обладают высоким уровнем развития коммуникативных способностей, легко устанавливают контакты с сослуживцами, окружающими, не конфликтны. ";
            }
            else if (scoreCP <= 3)
            {
                resultCPstring += $"{scoreCP} - Обладают низким уровнем коммуникативных способностей, испытывают затруднение в построении контактов с окружающими, проявляют агрессивность, повышенную конфликтность. ";
            }

            if (scoreMN >= 9)
            {
                resultMNstring += $"{scoreMN} - Реально оценивают свою роль в коллективе, ориентированы на соблюдение общепринятых норм поведения. ";
            }
            else if (scoreMN <= 3)
            {
                resultMNstring += $"{scoreMN} - Не могут адекватно оценить свое место и роль в коллективе, не стремятся соблюдать общепринятые нормы поведения. ";
            }

            result += $"{resultDstring}{Environment.NewLine} " +
                $"{resultASstring}{Environment.NewLine} " +
                $"{resultNPUstring}{Environment.NewLine} " +
                $"{resultCPstring}{Environment.NewLine} " +
                $"{resultMNstring}{Environment.NewLine} ";

            // todo спросить, надо ли добавлять текста

            return result;
        }
    }
}
