using Microsoft.Data.Sqlite;
using Psyche.Models;

namespace Psyche.Forms
{
    public partial class ResultTextForm : Form
    {
        private readonly Config Config;
        private readonly User CurrentUser;

        public ResultTextForm(User currentUser, Config config)
        {
            InitializeComponent();
            Config = config;
            CurrentUser = currentUser;

            string results = "";

            try
            {
                using (var connection = new SqliteConnection(Config.ConnectionStrings.UsersDB))
                {
                    connection.Open();

                    string FIO = $"{CurrentUser.Name}";

                    List<string> Tables = new();

                    SqliteCommand commandGetTableNames = new()
                    {
                        Connection = connection,
                        CommandText = $"Select name from sqlite_sequence where name is not 'Users'",
                    };
                    using (SqliteDataReader reader = commandGetTableNames.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())   // построчно считываем данные
                            {
                                Tables.Add(reader.GetValue(0).ToString());   // получаем названия таблиц с результатами тестов
                            }
                        }
                    }

                    foreach (var table in Tables)
                    {
                        SqliteCommand commandGetResults = new()
                        {
                            Connection = connection,
                            CommandText = $"Select Result from {table} where UserName is '{FIO}'",
                        };
                        using (SqliteDataReader reader = commandGetResults.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())   // построчно считываем данные
                                {
                                    results += $"{reader.GetValue(0)}{Environment.NewLine}";
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка : {ex.Message}");
            }

            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.WordWrap = true;

            textBox1.Text = $"Психологическая характеристика{Environment.NewLine}" +
                $"ФИО:{Environment.NewLine}" +
                $"{currentUser.Name}{Environment.NewLine}" +
                $"Группа:{Environment.NewLine}" +
                $"{currentUser.Platoon}{Environment.NewLine}" +
                $"Результаты тестовых методик:{Environment.NewLine}" +
                results;
        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
