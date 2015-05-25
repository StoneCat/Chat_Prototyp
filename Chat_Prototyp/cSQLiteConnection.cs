using System;
using System.IO;
using System.Data.SQLite;
using System.Collections.Generic;

namespace Chat_Prototyp
{
    class cSQLiteConnection
    {
        private string sDatabaseName = "ChatDatabase.sqlite";
        private SQLiteConnection m_dbConnection;
        private SQLiteCommand command;

        public cSQLiteConnection()
        {
            this.createDatabaseFile();
            this.connectDB();
            //Beispieldaten
            this.queryDB("DROP TABLE IF EXISTS Chatuser;");
            this.queryDB(@"CREATE TABLE IF NOT EXISTS Chatuser (
                          id INTEGER PRIMARY KEY,
                          UserStatusID INTEGER NOT NULL,
                          firstname VARCHAR(50) NULL,
                          lastname VARCHAR(50) NULL,
                          username VARCHAR(50) NULL,
                          userpassword VARCHAR(255) NULL,
                          FriendListlistID INTEGER NOT NULL);");
            this.queryDB(@"INSERT INTO Chatuser 
                            (UserStatusID, firstname, lastname,
                            username, userpassword, FriendListlistID) 
                            VALUES(1, 'Nikolai', 'Luis', 'stonecat', 'yolo', 1);");
        }

        private void createDatabaseFile()
        {
            if (!File.Exists(sDatabaseName))
            {
                SQLiteConnection.CreateFile(sDatabaseName);
            }
        }

        private void connectDB()
        {
            m_dbConnection = new SQLiteConnection("Data Source=" + sDatabaseName + ";Version=3;");
            m_dbConnection.Open();
        }

        public void queryDB(string sql)
        {
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        public List<string> selectDB(string sql)
        {
            List<string> items = new List<string>();
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                items.Add(reader["id"].ToString());
            }
            return items;
        }

        public void closeDB()
        {
            m_dbConnection.Close();
        }
    }
}
