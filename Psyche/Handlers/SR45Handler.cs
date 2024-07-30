using Microsoft.Data.Sqlite;
using Psyche.Models;

namespace Psyche.Handlers
{
    public class SR45Handler
    {
        private readonly Config Config;
        private readonly User CurrentUser;

        public SR45Handler(Config config, User currentUser)
        {
            Config = config;
            CurrentUser = currentUser;
        }

        public string GetResult()
        {
            int resultL = 0;
            int resultSr = 0;
            try
            {
                using (var connection = new SqliteConnection(Config.ConnectionStrings.UsersDB))
                {
                    connection.Open();

                    string FIO = $"{CurrentUser.LastName} {CurrentUser.FirstName} {CurrentUser.MiddleName}";

                    // todo
                    SqliteCommand commandCheck = new()
                    {
                        Connection = connection,
                        CommandText = $"SELECT * FROM SR45 WHERE UserName='{FIO}' AND UserPlatoon='{CurrentUser.Group}'",
                    };
                    using (SqliteDataReader reader = commandCheck.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())           // костыль
                            {
                                for (int i = 5; i < 50; i++)           // порядковые номера столбцов с ответами в таблице
                                {
                                    if (i == 14 ||
                                        i == 15 ||
                                        i == 21 ||
                                        i == 24 ||
                                        i == 26 ||
                                        i == 28 ||
                                        i == 32 ||
                                        i == 37 ||
                                        i == 42 ||
                                        i == 45)
                                    {
                                        resultL += Convert.ToInt32(reader.GetValue(i));
                                    }
                                    else
                                    {
                                        resultSr += Convert.ToInt32(reader.GetValue(i));
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            string result = "";

            if (resultL < 6)
            {
                result = $"Низкий показатель по шкале лжи. Полученные данные достоверны.{Environment.NewLine}";
            }
            else
            {
                result = $"Высокий показатель по шкале лжи. Полученные данные недостоверны.{Environment.NewLine}";
            }

            double resultSrCaclulated = resultSr / 35.0;

            if (resultSrCaclulated >= 0.01f && resultSrCaclulated <= 0.23f)
            {
                result += "Низкий уровень склонности к суицидальным реакциям";
            }
            else if (resultSrCaclulated >= 0.24f && resultSrCaclulated <= 0.38f)
            {
                result += "Суицидальная реакция может возникнуть только на фоне длительной психической травматизации и при реактивных состояниях психики.";
            }
            else if (resultSrCaclulated >= 0.39f && resultSrCaclulated <= 0.59f)
            {
                result += "«Потенциал» склонности к суицидальным реакциям не отличается высокой устойчивостью.";
            }
            else if (resultSrCaclulated >= 0.6f && resultSrCaclulated <= 0.74f)
            {
                result += "Группа суицидального риска с высоким уровнем проявления склонности к суицидальным реакциям (при нарушениях адаптации возможна суицидальная попытка или реализация саморазрушающего поведения).";
            }
            else if (resultSrCaclulated >= 0.75f && resultSrCaclulated <= 1f)
            {
                result += "Группа суицидального риска с очень высоким уровнем проявления склонности к суицидальным реакциям (ситуация внутреннего и внешнего конфликта, нуждаются в медико-психологической помощи).";
            }
            else
            {
                throw new Exception("Неправильный результат");
            }

            return result;
        }
    }
}
