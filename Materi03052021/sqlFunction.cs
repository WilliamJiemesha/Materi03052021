using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Materi03052021
{
    class sqlFunction
    {
        private string tableName;
        private MySqlConnection connSql;
        public sqlFunction(string connString)
        {
            connSql = new MySqlConnection(connString);
        }
        public DataTable selectQuery(string queryString)
        {
            string query = queryString;
            MySqlCommand sqlCommand = new MySqlCommand(query, connSql);
            connSql.Open();
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter();
            sqlAdapter.SelectCommand = sqlCommand;
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            connSql.Close();
            return dt;
        }
        public void insertQuery(string queryString)
        {
            string query = queryString;
            MySqlCommand sqlCommand = new MySqlCommand(query, connSql);
            MySqlDataReader sqlReader;
            connSql.Open();
            sqlCommand.ExecuteNonQuery();
            connSql.Close();
        }
        public void updateQuery(string queryString)
        {
            string query = queryString;
            MySqlCommand sqlCommand = new MySqlCommand(query, connSql);
            MySqlDataReader sqlReader;
            connSql.Open();
            sqlCommand.ExecuteNonQuery();
            connSql.Close();
        }
        public void deleteQuery(string queryString)
        {
            string query = queryString;
            MySqlCommand sqlCommand = new MySqlCommand(query, connSql);
            MySqlDataReader sqlReader;
            connSql.Open();
            sqlCommand.ExecuteNonQuery();
            connSql.Close();
        }
        public void runFunctions(string queryString)
        {
            string query = queryString;
            MySqlCommand sqlCommand = new MySqlCommand(query, connSql);
            MySqlDataReader sqlReader;
            connSql.Open();
            sqlCommand.ExecuteNonQuery();
            connSql.Close();
        }
    }
}
