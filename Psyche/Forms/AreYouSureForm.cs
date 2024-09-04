using Microsoft.Data.Sqlite;
using Psyche.Models;

namespace Psyche.Forms
{
    public partial class AreYouSureForm : Form
    {
        private readonly Config Config;

        public AreYouSureForm(Config config)
        {
            InitializeComponent();
            Config = config;
        }

        private void ClearDBButton_Click(object sender, EventArgs e)
        {
            // todo мб стоит бэкапить базу под другим именем на всякий случай

            try
            {
                using (var connection = new SqliteConnection(Config.ConnectionStrings.UsersDB))
                {
                    connection.Open();

                    List<string> Tables = new();

                    SqliteCommand commandGetTableNames = new()
                    {
                        Connection = connection,
                        CommandText = $"Select name from sqlite_sequence",
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
                        SqliteCommand commandDelete = new()
                        {
                            Connection = connection,
                            CommandText = $"Delete from {table}",
                        };
                        commandDelete.ExecuteReader();              // удаляем данные
                    }
                }

                MessageBox.Show("Данные удалены!");
            }
            catch
            {
                MessageBox.Show("Возникла ошибка при очистке данных. Возможно, базы данных ещё не существует.");
            }
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
