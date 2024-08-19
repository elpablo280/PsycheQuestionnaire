using Microsoft.Data.Sqlite;
using Psyche.Models;

namespace Psyche
{
    public partial class DataEntryForm : Form
    {
        private readonly string CurrentTestFilepath;
        private readonly Config Config;
        public readonly TestsMenuForm TestsMenuForm;

        public DataEntryForm(string currentTestFilepath, Config config, TestsMenuForm testsMenuForm)
        {
            InitializeComponent();
            CurrentTestFilepath = currentTestFilepath;
            Config = config;
            TestsMenuForm = testsMenuForm;
        }

        // добавляем (проверяем наличие) юзера в базу и запускаем тест
        private void BeginTestButton_Click(object sender, EventArgs e)
        {
            string FIO = $"{lastNameTextBox.Text} {firstNameTextBox.Text} {middleNameTextBox.Text}";

            User user = new(
                FIO,
                groupTextBox.Text
            );

            using (var connection = new SqliteConnection(Config.ConnectionStrings.UsersDB))
            {
                connection.Open();

                // создаём таблицу (если она не создана) с юзерами
                SqliteCommand commandCreate = new()
                {
                    Connection = connection,
                    CommandText = "CREATE TABLE IF NOT EXISTS Users(ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, Name TEXT NOT NULL, Platoon TEXT NOT NULL)",
                };
                commandCreate.ExecuteNonQuery();

                // проверяем, есть ли такой юзер в базе
                SqliteCommand commandCheck = new()
                {
                    Connection = connection,
                    CommandText = $"SELECT * FROM Users WHERE Name='{user.Name}' AND Platoon='{user.Platoon}'",
                };
                using (SqliteDataReader reader = commandCheck.ExecuteReader())
                {
                    if (reader.HasRows)       // если нашёл такого юзера
                    {
                        MessageBox.Show("Такой пользователь уже есть в базе данных!");
                    }
                    else
                    {
                        // добавляем юзера в базу
                        SqliteCommand commandInsert = new()
                        {
                            Connection = connection,
                            CommandText = $"INSERT INTO Users (Name, Platoon) VALUES ('{FIO}', '{user.Platoon}')"
                        };
                        commandInsert.ExecuteNonQuery();
                        //MessageBox.Show($"Новый пользователь добавлен в таблицу Users");
                    }
                }
            }

            TestForm currentTestForm = new(CurrentTestFilepath, user, Config, TestsMenuForm);
            currentTestForm.Show();

            Close();
        }
    }
}
