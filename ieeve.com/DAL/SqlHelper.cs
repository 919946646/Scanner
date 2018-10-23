using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SQLite;
using System.Data;

namespace ieeve.com.DAL
{
    class SqlHelper
    {

        public static readonly string Connstr = "Data Source=" + Environment.CurrentDirectory + "\\Data\\ieeve.com.db;Synchronous=Off;Pooling=true;Journal Mode=WAL;";
        public static int ExecuteNonQuery(string cmdText,
            params SQLiteParameter[] parameters)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Connstr))
            {
                conn.Open();
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string cmdText,
            params SQLiteParameter[] parameters)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Connstr))
            {
                conn.Open();
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static DataTable ExecuteDataTable(string cmdText,
            params SQLiteParameter[] parameters)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Connstr))
            {
                conn.Open();
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    cmd.Parameters.AddRange(parameters);
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static SQLiteDataReader ExecuteDataReader(string cmdText,
            params SQLiteParameter[] parameters)
        {
            SQLiteConnection conn = new SQLiteConnection(Connstr);
            conn.Open();
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = cmdText;
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }
    }
}
