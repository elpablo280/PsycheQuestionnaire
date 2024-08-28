using Psyche.Interfaces;

namespace Psyche.Handlers
{
    public class SACSHandler : IHandler
    {
        private readonly List<int> Answers = new();

        public SACSHandler(List<int> answers)
        {
            Answers = answers;
        }

        public string GetResult()
        {
            string result = $"Стратегии преодоления стрессовых ситуаций. {Environment.NewLine}";
            int resultAssertive = 0;
            int resultSocContact = 0;
            int resultSocSupport = 0;
            int resultCareful = 0;
            int resultImpulsive = 0;
            int resultAvoidance = 0;
            int resultIndirect = 0;
            int resultAntisocial = 0;
            int resultAgressive = 0;
            string resultICstring = "Индекс конструктивности - ";

            for (int i = 0; i < Answers.Count; i++)
            {
                switch (i % 9)
                {
                    case 0: resultAssertive += Answers[i]; break;
                    case 1: resultSocContact += Answers[i]; break;
                    case 2: resultSocSupport += Answers[i]; break;
                    case 3: resultCareful += Answers[i]; break;
                    case 4: resultImpulsive += Answers[i]; break;
                    case 5: resultAvoidance += Answers[i]; break;
                    case 6: resultIndirect += Answers[i]; break;
                    case 7: resultAntisocial += Answers[i]; break;
                    case 8: resultAgressive += Answers[i]; break;
                }
            }

            double resultIC = (resultAssertive + resultSocContact + resultSocSupport) / (resultAvoidance + resultAntisocial + resultAgressive);

            if (resultIC < 0.86)
            {
                resultICstring += $"{resultIC}, низкая конструктивность";
            }
            else if (resultIC >= 0.86 && resultIC <= 1.1)
            {
                resultICstring += $"{resultIC}, средняя конструктивность";
            }
            else if (resultIC > 1.1)
            {
                resultICstring += $"{resultIC}, средняя конструктивность";
            }

            result += $"{resultICstring}{Environment.NewLine}";

            return result;
        }
    }
}
