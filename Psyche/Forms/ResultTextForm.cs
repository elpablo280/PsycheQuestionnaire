using Psyche.Handlers;
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

            //try
            //{
            //    using (var connection = new SqliteConnection(Config.ConnectionStrings.UsersDB))
            //    {
            //        connection.Open();

            //        string FIO = $"{CurrentUser.Name}";

            //        // todo
            //        SqliteCommand commandCheck = new()
            //        {
            //            Connection = connection,
            //            CommandText = $"SELECT * FROM SR45 WHERE UserName='{FIO}' AND UserPlatoon='{CurrentUser.Platoon}'",
            //        };
            //        using (SqliteDataReader reader = commandCheck.ExecuteReader())
            //        {
            //            if (reader.HasRows)
            //            {
            //                while (reader.Read())           // todo костыль
            //                {
            //                    for (int i = 5; i < 50; i++)           // порядковые номера столбцов с ответами в таблице
            //                    {
            //                        if (i == 14 ||
            //                            i == 15 ||
            //                            i == 21 ||
            //                            i == 24 ||
            //                            i == 26 ||
            //                            i == 28 ||
            //                            i == 32 ||
            //                            i == 37 ||
            //                            i == 42 ||
            //                            i == 45)
            //                        {
            //                            resultL += Convert.ToInt32(reader.GetValue(i));
            //                        }
            //                        else
            //                        {
            //                            resultSr += Convert.ToInt32(reader.GetValue(i));
            //                        }
            //                    }
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //}

            //// todo пока перечисление
            //SR45Handler sr45Handler = new(Config, CurrentUser, );
            //string results = $"{sr45Handler.GetResult()}{Environment.NewLine}";

            //textBox1.ScrollBars = ScrollBars.Both;
            //textBox1.WordWrap = true;

            //textBox1.Text = $"Психологическая характеристика{Environment.NewLine}" +
            //    $"ФИО:{Environment.NewLine}" +
            //    $"{currentUser.Name}{Environment.NewLine}" +
            //    $"Группа:{Environment.NewLine}" +
            //    $"{currentUser.Platoon}{Environment.NewLine}" +
            //    $"Результаты тестовых методик:{Environment.NewLine}" +
            //    results;
        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
