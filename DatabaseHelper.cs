using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

public class DatabaseHelper
{
    private string dbPath = "Data Source=mydb.db";

    public DatabaseHelper()
    {
        using (var conn = new SQLiteConnection(dbPath))
        {
            conn.Open();
            string sql = "CREATE TABLE IF NOT EXISTS Teams (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT NOT NULL, TotalPoints INT DEFAULT 0, BbPoints INT DEFAULT 0, HitwPoints INT DEFAULT 0," +
                "PkwsPoints INT DEFAULT 0, RsrPoints INT DEFAULT 0, SbPoints INT DEFAULT 0, TgttosPoints INT DEFAULT 0)";
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                cmd.ExecuteNonQuery();
            }

            sql = @"CREATE TABLE IF NOT EXISTS Members (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        TeamName TEXT NOT NULL,
                        Points INT DEFAULT 0,
                        BbPoints INT DEFAULT 0,
                        HitwPoints INT DEFAULT 0,
                        PkwsPoints INT DEFAULT 0,
                        RsrPoints INT DEFAULT 0,
                        SbPoints INT DEFAULT 0,
                        TgttosPoints INT DEFAULT 0,
                        FOREIGN KEY (TeamName) REFERENCES Teams(Name)
                    )";
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }

    public int ExecuteCommands(string sql)
    {
        using (var conn = new SQLiteConnection(dbPath))
        {
            try
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
    }

    public DataTable ExecuteConsults(string sql)
    {
        using (var conn = new SQLiteConnection(dbPath))
        {
            try
            {
                conn.Open();
                using (var da = new SQLiteDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}