using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using TlkToSql.Model;

namespace TlkToSql.Database
{
    public class DataAccess : IDisposable
    {
        private readonly SQLiteConnection Connection;

        public DataAccess(string connectionString)
        {
            Connection = new SQLiteConnection(connectionString);
        }

        public void Setup()
        {
            if (!File.Exists("iedata.sqlite"))
            {
                SQLiteConnection.CreateFile("iedata.sqlite");

                var sql = @"CREATE TABLE StringData(
                               ID INTEGER PRIMARY KEY AUTOINCREMENT,
                               strref TEXT NOT NULL,
                               game TEXT NOT NULL,
                               stringText TEXT NOT NULL  
                            );";
                Connection.Open();
                var cmd = new SQLiteCommand(sql, Connection);
                cmd.ExecuteNonQuery();
            }
            else
            {
                Connection.Open();
            }
        }

        public void AddString(List<StringEntry> StringEntries, string game)
        {
            using SQLiteTransaction mytransaction = Connection.BeginTransaction();
            var sql = @"insert into StringData (strref, game, stringText) values (@strref, @game, @stringText)";
            var cmd = new SQLiteCommand(sql, Connection);
            foreach (var stringEntry in StringEntries)
            {
                cmd.Parameters.AddWithValue("@strref", stringEntry.Strref);
                cmd.Parameters.AddWithValue("@game", game);
                cmd.Parameters.AddWithValue("@stringText", stringEntry.Text);
                cmd.ExecuteNonQuery();
            }
            mytransaction.Commit();
        }

        public string GetString(int strref)
        {
            var sql = @"select stringText from StringData where strref = @strref";
            var cmd = new SQLiteCommand(sql, Connection);
            cmd.Parameters.AddWithValue("@strref", strref);
            var st = (string)cmd.ExecuteScalar();
            return st;
        }

        public void Dispose()
        {
            Connection?.Close();
        }
    }
}