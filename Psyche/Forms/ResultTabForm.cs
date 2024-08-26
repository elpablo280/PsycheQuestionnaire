using Microsoft.Data.Sqlite;
using Psyche.Models;
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

            SqliteConnection con = new()
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
            cmd.CommandText = $"Select * from {TestName}";
            dt.Clear();
            // todo если ещё нет таблицы
            try
            {
                dt.Load(cmd.ExecuteReader()); // выполняешь SQL-запрос
            }
            catch
            {
                //MessageBox.Show("Произошла ошибка при подключении к базе данных. Возможно, такой таблицы ещё не существует. Таблица создаётся после первого прохождения теста.");
                //Close();
            }
            con.Close(); // закрываешь соединение с БД
        }
    }
}
