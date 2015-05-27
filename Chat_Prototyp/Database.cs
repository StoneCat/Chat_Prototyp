using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.SQLite;

namespace Chat_Prototyp
{
    class Database
    {
        public string connectionString;
        public List<List<string>> ResultSet;
        public int nrOfCols;
        public int nrOfRows;

        public Database() { ResultSet = new List<List<string>>(); }

        public Database(string connectionString) { }

        public virtual bool Open() { return false; }

        public virtual void Close() { }

        public virtual bool Execute(string strCommand) { return false; }

        public virtual bool GenerateSampleData() { return false; }

        public virtual void queryDB(string sql) { }

        public virtual bool insertUser(string sfirstname, string slastname, string susername, string suserpassword) { return false; }
    }

    class DatabaseMySQL : Database
    {
        protected MySqlConnection connection;

        public DatabaseMySQL(string connString)
        {
            this.connectionString = connString;
        }

        public override bool Open()
        {
            bool retVal = false;
            if (connectionString.Length > 0)
            {
                connection = new MySqlConnection(connectionString);
                if (connection != null)
                {
                    connection.Open();
                    retVal = true;
                }
            }
            return retVal;
        }

        public bool TableExists(string strTabelName)
        {
            String strCommand;
            strCommand = "select count(table_name) from information_schema.tables where table_name='" + strTabelName + "'";
            Execute(strCommand);

            if (ResultSet[0][0] == "1")
                return true;
            else
                return false;
        }

        public override bool GenerateSampleData()
        {
            if (connection != null)
            {
                MySqlCommand sql_cmd = connection.CreateCommand();
                if (!TableExists("Chatuser"))
                {
                    sql_cmd.CommandText = "DROP DATABASE IF EXISTS Chat;";
                    sql_cmd.ExecuteNonQuery();
                    sql_cmd.CommandText = "CREATE DATABASE Chat;";
                    sql_cmd.ExecuteNonQuery();
                    sql_cmd.CommandText = "USE Chat;";
                    sql_cmd.ExecuteNonQuery();
                    sql_cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Chatuser (
                          id INTEGER PRIMARY KEY,
                          UserStatusID INTEGER NOT NULL,
                          firstname VARCHAR(50) NULL,
                          lastname VARCHAR(50) NULL,
                          username VARCHAR(50) NULL,
                          userpassword VARCHAR(255) NULL,
                          FriendListlistID INTEGER NOT NULL);";
                    sql_cmd.ExecuteNonQuery();
                }
                sql_cmd.CommandText = "use Chat;";
                sql_cmd.ExecuteNonQuery();
                sql_cmd.CommandText = "delete from Chatuser";
                sql_cmd.ExecuteNonQuery();
                sql_cmd.CommandText = "insert into user values (1, 'Hans')";
                sql_cmd.ExecuteNonQuery();
                sql_cmd.CommandText = "insert into user values (2, 'Peter')";
                sql_cmd.ExecuteNonQuery();
                sql_cmd.CommandText = @"INSERT INTO Chatuser 
                            (UserStatusID, firstname, lastname,
                            username, userpassword, FriendListlistID) 
                            VALUES(1, 'Nikolai', 'Luis', 'stonecat', 'yolo', 1);";
                sql_cmd.ExecuteNonQuery();

                sql_cmd.Dispose();
                return true;
            }
            else
                return false;
        }

        public override bool Execute(string strCommand)
        {
            MySqlCommand sql_cmd = connection.CreateCommand();

            sql_cmd.CommandText = strCommand;
            MySqlDataReader reader;
            reader = sql_cmd.ExecuteReader();

            ResultSet.Clear();
            nrOfRows = 0;
            nrOfCols = 0;
            while (reader.Read())
            {
                List<string> row = new List<string>();
                int pos = 0;
                int curCols = 0;
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row.Add(reader[pos++].ToString());
                    curCols++;
                }
                nrOfCols = Math.Max(curCols, nrOfCols);

                ResultSet.Add(row);
                nrOfRows++;
            }

            reader.Close();
            reader.Close();
            return true;
        }
    }

    class DatabaseSQLite : Database
    {
        protected SQLiteConnection connection;

        public DatabaseSQLite(string connString)
        {
            connectionString = connString;
            Open();
            this.GenerateSampleData();
        }

        public override bool Open()
        {
            bool retVal = false;
            if (connectionString.Length > 0)
            {
                connection = new SQLiteConnection(connectionString);
                if (connection != null)
                {
                    connection.Open();
                    retVal = true;
                }
            }
            return retVal;
        }

        public bool TableExists(string strTableName)
        {
            String strCommand;
            strCommand = "SELECT count(name) FROM sqlite_master WHERE type='table' and name='" + strTableName + "'";
            Execute(strCommand);

            if (ResultSet[0][0] == "1")
                return true;
            else
                return false;
        }

        public override bool GenerateSampleData()
        {
            if (connection != null)
            {
                SQLiteConnection.CreateFile("ChatDatabase.sql");
                SQLiteCommand sql_cmd = connection.CreateCommand();
                if (!TableExists("Chatuser"))
                {
                    sql_cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Chatuser (
                          id INTEGER PRIMARY KEY,
                          UserStatusID INTEGER NOT NULL,
                          firstname VARCHAR(50) NULL,
                          lastname VARCHAR(50) NULL,
                          username VARCHAR(50) NULL,
                          userpassword VARCHAR(255) NULL,
                          FriendListlistID INTEGER NOT NULL);";
                    sql_cmd.ExecuteNonQuery();
                }
                sql_cmd.CommandText = "delete from Chatuser;";
                sql_cmd.ExecuteNonQuery();
                sql_cmd.CommandText = @"INSERT INTO Chatuser 
                            (UserStatusID, firstname, lastname,
                            username, userpassword, FriendListlistID) 
                            VALUES(1, 'admin', 'admin', 'admin', 'admin', 1);";
                sql_cmd.ExecuteNonQuery();

                sql_cmd.Dispose();
                return true;
            }
            else
                return false;
        }

        public override bool Execute(string strCommand)
        {
            bool retVal = false;

            SQLiteCommand sql_cmd = connection.CreateCommand();
            sql_cmd.CommandText = strCommand;
            SQLiteDataReader reader = sql_cmd.ExecuteReader();

            nrOfRows = 0;
            nrOfCols = 0;
            while (reader.Read())
            {
                List<string> row = new List<string>();
                int pos = 0;
                int curCols = 0;
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row.Add(reader[pos++].ToString());
                    curCols++;
                }
                nrOfCols = Math.Max(curCols, nrOfCols);

                ResultSet.Add(row);
                nrOfRows++;
            }

            // Beenden des Readers und Freigabe aller Ressourcen.
            reader.Close();
            reader.Dispose();
            sql_cmd.Dispose();
            return retVal;
        }

        public void queryDB(string sql)
        {
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
        }

        public bool insertUser(string sfirstname, string slastname, string susername, string suserpassword)
        {
            this.queryDB(@"INSERT INTO Chatuser 
                            (UserStatusID, firstname, lastname,
                            username, userpassword, FriendListlistID) 
                            VALUES(1, '" + sfirstname + "', '" + slastname + "', '" + susername + "', '" + suserpassword + "', 1);");
            return true;
        }
    }
}
