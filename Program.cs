using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace TripPreparation
{
    public static class DB
    {
        /// <summary>
        /// Строка подключения к базе данных
        /// </summary>
        private static MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=trip_preparation");

        /// <summary>
        /// Открытие соединения для отправки запросов INSERT, UPDATE, DELETE
        /// </summary>
        public static void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            else
                throw new Exception("Connection already opened");
        }

        /// <summary>
        /// Закрытие соединения
        /// </summary>
        public static void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            else
                throw new Exception("Connection already closed");
        }

        /// <summary>
        /// Отправка запроса на сервер
        /// </summary>
        /// <param name="post">Текст запроса</param>
        public static void SendPost(string post)
        {
            MySqlCommand command = new MySqlCommand(post, connection);

            OpenConnection();

            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить действие, приносим свои извинения.");
            }

            CloseConnection();
        }

        /// <summary>
        /// Отправка запроса на получение данных
        /// </summary>
        /// <param name="sqlCommand">Текст запроса</param>
        /// <returns></returns>
        public static DataTable GetData(string sqlCommand)
        {
            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand(sqlCommand, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;

            adapter.Fill(table);

            return table;
        }

        /// <summary>
        /// Получение номера участника похода
        /// </summary>
        /// <param name="userNumber">Номер пользователя</param>
        /// <param name="tripNumber">Номер похода</param>
        /// <returns></returns>
        public static int GetParticipantNumber(int userNumber, int tripNumber)
        {
            return (int)GetData($"SELECT Participant_number FROM participants_list WHERE User_number = {userNumber} AND Trip_number = {tripNumber}").Rows[0][0];
        }
        
        /// <summary>
        /// Добавление пользователя
        /// </summary>
        /// <param name="email">Электронная почта</param>
        /// <param name="password">Пароль</param>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="patr">Отчество</param>
        /// <param name="phone">Телефон</param>
        public static void AddUser(string email, string password, string name, string surname, string patr, string phone)
        {
            string PostSQL = "INSERT INTO user(User_number, Name, Surname, Patronymic, Allergies, Сhronic_diseases, Medications_taken, Phone_number, Email_address, Password) VALUES" +
                $"(NULL, '{name}', '{surname}', '{patr}', NULL, NULL, NULL, '{phone}', '{email}', '{password}')";

            SendPost(PostSQL);
        }

        /// <summary>
        /// Смена шрифта в DataGridView
        /// </summary>
        /// <param name="dataGrid">Таблица DataGridView</param>
        /// <param name="font">Размер шрифта</param>
        public static void ChangeFont(DataGridView dataGrid, float font)
        {
            foreach (DataGridViewColumn c in dataGrid.Columns)
                c.DefaultCellStyle.Font = new Font("Arial", font, GraphicsUnit.Pixel);
        }

        #region Неиспользуемый функционал
        /// <summary>
        /// Список названий таблиц базы данных
        /// </summary>
        private static string[] tableNameList;

        /// <summary>
        /// Получение названий таблиц в базе данных
        /// </summary>
        public static void GetTablesName()
        {
            string sqlQuery = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA = 'trip_preparation'";

            MySqlCommand command = new MySqlCommand(sqlQuery, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;

            DataTable table = new DataTable();

            adapter.Fill(table);

            int rowsCount = table.Rows.Count;

            tableNameList = new string[rowsCount];

            for (int i = 0; i < rowsCount; i++)
            {
                tableNameList[i] = table.Rows[i][0].ToString();
            }
        }

        /// <summary>
        /// Получение соединения
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection GetConnection()
        {
            return connection;
        }

        /// <summary>
        /// Получение статуса соединения
        /// </summary>
        /// <returns></returns>
        public static string GetStatus()
        {
            return connection.State.ToString();
        }

        /// <summary>
        /// Получение таблицы из базы данных
        /// </summary>
        /// <param name="tableName">Название таблицы</param>
        /// <returns></returns>
        public static DataTable GetTable(string tableName)
        {
            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `" + tableName + "`", connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;

            adapter.Fill(table);

            return table;
        }

        /// <summary>
        /// Заполнение DataGridView данными
        /// </summary>
        /// <param name="dataTable">Таблица с данными</param>
        /// <param name="dataGrid">Таблица для заполнения</param>
        public static void FillTable(DataTable dataTable, DataGridView dataGrid)
        {
            int stringCount = dataTable.Rows.Count;
            int columnCount = dataTable.Columns.Count;

            for (int i = 0; i < stringCount; i++)
            {
                DataRow table_row = dataTable.Rows[i];

                DataGridViewCell[] dataGridCells = new DataGridViewCell[columnCount];

                for (int j = 0; j < columnCount; j++)
                {
                    dataGridCells[j] = new DataGridViewTextBoxCell();

                    dataGridCells[j].Value = table_row[j];
                }

                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange(dataGridCells);

                dataGrid.Rows.Add(row);
            }
        }

        /// <summary>
        /// Добавление столбца в DataGridView и заполнение его данными
        /// </summary>
        /// <param name="dataTable">Таблица с данными</param>
        /// <param name="dataGrid">Таблица для заполнения</param>
        /// <param name="columnName">Название для столбца, который будет добавлен</param>
        /// <param name="columnNumber">Номер добавляемого из таблицы с данными столбца</param>
        public static void FillColumn(DataTable dataTable, DataGridView dataGrid, string columnName, int columnNumber)
        {
            int stringCount = dataTable.Rows.Count;
            int colNum = dataGrid.Columns.Count;

            dataGrid.Columns.Add(columnName, columnName);

            if (dataGrid.Rows.Count < stringCount)
                for (int i = 0; i < stringCount - dataGrid.Rows.Count; i++)
                    dataGrid.Rows.Add();

            for (int i = 0; i < stringCount; i++)
                dataGrid[colNum, i].Value = dataTable.Rows[i][columnNumber];
        }

        /// <summary>
        /// Заполнение DataGridView данными с указанием заголовков
        /// </summary>
        /// <param name="dataTable">Таблица с данными</param>
        /// <param name="dataGrid">Таблица для заполнения</param>
        public static void FillAllTable(DataTable dataTable, DataGridView dataGrid)
        {
            int columnCount = dataTable.Columns.Count;

            for (int i = 0; i < columnCount; i++)
            {
                DataGridViewTextBoxColumn dataGridCol = new DataGridViewTextBoxColumn();
                dataGridCol.Name = dataTable.Columns[i].ColumnName;
                dataGridCol.HeaderText = dataTable.Columns[i].ColumnName;
                dataGrid.Columns.Add(dataGridCol);
            }

            int stringCount = dataTable.Rows.Count;

            for (int i = 0; i < stringCount; i++)
            {
                DataRow table_row = dataTable.Rows[i];

                DataGridViewRow row = new DataGridViewRow();

                for (int j = 0; j < columnCount; j++)
                {
                    DataGridViewCell dataGridCell = new DataGridViewTextBoxCell();

                    dataGridCell.Value = table_row[j];

                    row.Cells.Add(dataGridCell);
                }

                dataGrid.Rows.Add(row);
            }
        }
        #endregion
    }

    static class Program
    {
        /// <summary>
        /// При запуске программы пользователь попадает в окно входа в систему
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
