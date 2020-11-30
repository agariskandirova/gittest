using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Islam
{

    class Program
    {
        static void Main(string[] args)
        {
            // строка подключения к БД
            string connStr = "server=localhost;user=root;database=people;password=0000;";
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            // запрос
            string sql = "SELECT name FROM men WHERE id = 2";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            // выполняем запрос и получаем ответ
            string name = command.ExecuteScalar().ToString();
            // выводим ответ в консоль
            Console.WriteLine(name);
            // закрываем соединение с БД
            conn.Close();
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
