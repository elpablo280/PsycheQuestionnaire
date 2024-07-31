using Microsoft.Data.Sqlite;
using Psyche.Interfaces;
using Psyche.Models;

namespace Psyche.Handlers
{
    public class Test1Handler : IHandler
    {
        private readonly Config Config;
        private readonly User CurrentUser;

        public Test1Handler(Config config, User currentUser)
        {
            Config = config;
            CurrentUser = currentUser;
        }

        public string GetResult()
        {
            string result = $"Тест 1.{Environment.NewLine}";
            int resultL = 0;
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
                        CommandText = $"SELECT * FROM Test1 WHERE UserName='{FIO}' AND UserPlatoon='{CurrentUser.Group}'",
                    };
                    using (SqliteDataReader reader = commandCheck.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())           // todo костыль
                            {
                                for (int i = 5; i < 7; i++)           // порядковые номера столбцов с ответами в таблице
                                {
                                    resultL += Convert.ToInt32(reader.GetValue(i));
                                }
                                break;
                            }
                            if (resultL < 2)
                            {
                                result += $"Неправильно.{Environment.NewLine}";
                            }
                            else
                            {
                                result += $"Правильно.{Environment.NewLine}";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return result;
        }
    }
}
