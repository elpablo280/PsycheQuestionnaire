using Microsoft.Data.Sqlite;
using Psyche.Models;
using System.Data;
using System.Data.SqlClient;

namespace Psyche.Forms
{
    public partial class ResultTabForm : Form
    {
        private readonly Config Config;

        public ResultTabForm(Config config)
        {
            // todo !!! мб в качестве критерия для селекта данных буквльно собирать строку на основе данных, ввёдённых юзером, типа "select * from 'выбор юзера' where 'критерии поиска, ввёдённые юзером'"

            InitializeComponent();
            Config = config;
            DataSet ds = new();
            SqlDataAdapter adapter;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            string sql = "SELECT * FROM SR 45";
            SqliteConnection con;
            DataTable dt;
            con = new SqliteConnection();
            con.ConnectionString = Config.ConnectionStrings.UsersDB;

            //using (SqlConnection connection = new(Config.ConnectionStrings.UsersDB))
            //{
            //    connection.Open();
            //    adapter = new SqlDataAdapter(sql, connection);

            //    ds = new DataSet();
            //    adapter.Fill(ds);
            //    dataGridView1.DataSource = ds.Tables[0];
            //}
            SqliteCommand cmd = new();
            cmd.Connection = con;

            dt = new DataTable();
            dataGridView1.DataSource = dt; // связываешь DataTable и таблицу на форме (просто dt)

            con.Open(); // открываешь соединение с БД
            cmd.CommandText = "Select * from SR45";
            dt.Clear();
            dt.Load(cmd.ExecuteReader()); // выполняешь SQL-запрос
            con.Close(); // закрываешь соединение с БД

            //SR45Handler sr45Handler = new(Config, null);
            //IEnumerable<Sr45>? result = sr45Handler.GetResultTab();

            //dataGridView1.DataSource = result;

            // todo надо связать result и dataGridView (походу через DataSet, надо раскурить)
        }
    }
}
