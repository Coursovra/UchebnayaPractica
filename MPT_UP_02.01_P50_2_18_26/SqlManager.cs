using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MPT_UP_02._01_P50_2_18_26
{
    public static class SqlManager
    {
        private static readonly SqlConnection SqlConnect = new(
            @"Data Source=localhost;Initial Catalog=MPT_UP_02.01_P50_2_18_26;Integrated Security=True");

        private static SqlCommand _command;
        private static bool _isConnected;
        private static SqlDataReader _dataReader;
        private static SqlDataAdapter _dataAdapter;

        /// <summary>
        /// Создание нового подключения
        /// </summary>
        /// <returns>Строку подключения</returns>
        public static SqlConnection NewConnection()
        {
            if (_isConnected) return SqlConnect;
            SqlConnect.Open();
            _command = new SqlCommand {Connection = SqlConnect};
            _isConnected = true;
            return SqlConnect;
        }

        /// <summary>
        /// Загрузка данных из бд в таблицу по запросу
        /// </summary>
        /// <param name="dataGridView">таблица</param>
        /// <param name="command">запрос</param>
        public static void LoadToDGV(DataGridView dataGridView, string command)
        {
            NewConnection();
            DataSet dataSet = new DataSet();
            _dataAdapter = new SqlDataAdapter(command, SqlConnect.ConnectionString);
            _dataAdapter.Fill(dataSet);
            dataGridView.DataSource = dataSet.Tables[0];
        }
        
        /// <summary>
        /// Выполняет команду
        /// </summary>
        /// <param name="command">команда</param>
        /// <returns>результат</returns>
        public static List<String> ExecuteCommand(string command)
        {
            NewConnection();
            List<String> result = new List<string>();
            
            string query = command;
            _command = new SqlCommand(query, SqlConnect);

            try
            {
                if (_dataReader.IsClosed)
                    _dataReader = _command.ExecuteReader();
            }
            catch
            {
                _dataReader = _command.ExecuteReader();
            }

            if (_dataReader.HasRows)
            {
                while (_dataReader.Read())
                {
                    for (int i = 0; i < _dataReader.FieldCount; i++)
                    {
                        result.Add(_dataReader.GetValue(i).ToString());
                    }
                }
            }
            _dataReader.Close();
            return result;
        }
        
        /// <summary>
        /// Создает запись в базе данных
        /// </summary>
        /// <param name="table">таблица</param>
        /// <param name="fields">поля для заполнения</param>
        /// <param name="dataStrings">данные для этих полей</param>
        public static void InsertData(string table, string[] fields, string[] dataStrings)
        {
            NewConnection();
            
            string columns = String.Empty;
            columns = String.Join(", ", fields);

            #region GetData
            string data = String.Empty;

            for (int i = 0; i < dataStrings.Length; i++)
            {
                dataStrings[i] = dataStrings[i].Replace("'", "");
            }
            
            List<String> temp = new List<string>();
            foreach (var value in dataStrings)
            {
   
                temp.Add("N'" + value + "'");
                
            }
            data = String.Join(", ", temp);
            #endregion
            
            _command.CommandText =
                String.Format("insert into [{0}] ({1}) values ({2})", table, columns, data);
            _command.ExecuteNonQuery();
            SqlConnect.Close();
            _isConnected = false;
        }
        
        /// <summary>
        /// Удаляет запись из базы данных
        /// </summary>
        /// <param name="tableName">наименование таблицы</param>
        /// <param name="UniqueFieldName">уникальное поле, по которому будет проходить идентификация</param>
        /// <param name="UniqueFieldData">данные этого поля</param>
        public static void DeleteData(string tableName, string UniqueFieldName, string UniqueFieldData)
        {
            NewConnection();
            _command = new SqlCommand();
            _command.Connection = SqlConnect;
            _command.CommandText =
                String.Format(
                    "delete from [{0}] where {1}='{2}'",tableName, UniqueFieldName, UniqueFieldData);
            _command.ExecuteNonQuery();
            SqlConnect.Close();
            _isConnected = false;
        }
        
        /// <summary>
        /// Изменяет запись в базе данных
        /// </summary>
        /// <param name="tableName">наименование таблицы</param>
        /// <param name="FieldName1">наименование поля для изменения</param>
        /// <param name="FieldData1">данные этого поля</param>
        /// <param name="PrimaryKeyField">уникальное поле, по которому будет проходить идентификация</param>
        /// <param name="PrimaryKeyData">данные этого поля</param>
        public static void ChangeData(string tableName, string FieldName1, string FieldData1, string PrimaryKeyField, string PrimaryKeyData)
        {
            NewConnection();
            _command = new SqlCommand();
            _command.Connection = SqlConnect;
            _command.CommandText =
                String.Format(
                    "update [{0}] set {1}='{2}' where {3}='{4}'",tableName,
                    FieldName1, FieldData1, PrimaryKeyField, PrimaryKeyData);
            _command.ExecuteNonQuery();
            SqlConnect.Close();
            _isConnected = false;
        }
    }
}