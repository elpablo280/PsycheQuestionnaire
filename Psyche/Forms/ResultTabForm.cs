using Microsoft.Data.Sqlite;
using Psyche.Models;
using Psyche.Workers;
using System.Data;

namespace Psyche.Forms
{
    public partial class ResultTabForm : Form
    {
        private readonly Config Config;
        private readonly string TestName;

        public ResultTabForm(Config config, string testName)
        {
            // todo !!! мб в качестве критерия для селекта данных буквльно собирать строку на основе данных, ввёдённых юзером, типа "select * from 'выбор юзера' where 'критерии поиска, ввёдённые юзером'"

            InitializeComponent();
            Config = config;
            TestName = testName;

            TestParser testParser = new TestParser();
            Test test = testParser.ParseTest(TestName);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            //using (SqlConnection connection = new(Config.ConnectionStrings.UsersDB))
            //{
            //    connection.Open();
            //    adapter = new SqlDataAdapter(sql, connection);

            //    ds = new DataSet();
            //    adapter.Fill(ds);
            //    dataGridView1.DataSource = ds.Tables[0];
            //}
            SqliteConnection con = null;
            try
            {
                con = new()
                {
                    ConnectionString = Config.ConnectionStrings.UsersDB
                };
                SqliteCommand cmd = new()
                {
                    Connection = con
                };

                DataTable dt = new();
                dataGridView1.DataSource = dt; // связываешь DataTable и таблицу на форме (просто dt)

                con.Open(); // открываешь соединение с БД
                cmd.CommandText = $"Select * from {test.NameDB}";
                dt.Clear();
                // todo если ещё нет таблицы
                dt.Load(cmd.ExecuteReader()); // выполняешь SQL-запрос
                Show();
                con.Close(); // закрываешь соединение с БД
            }
            catch
            {
                MessageBox.Show($"Произошла ошибка при подключении к базе данных. Возможно, такой таблицы ещё не существует. Таблица создаётся при первом прохождении теста.");
                Close();
            }
            con.Close(); // закрываешь соединение с БД
        }
    }
}
