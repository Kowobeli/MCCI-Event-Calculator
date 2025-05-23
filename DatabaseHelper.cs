using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

public class DatabaseHelper
{
    private string dbPath = "Data Source=mydb.db";

    public DatabaseHelper()
    {
        using (var conn = new SQLiteConnection(dbPath))
        {
            conn.Open();
            string sql = "CREATE TABLE IF NOT EXISTS Teams (Id INTEGER PRIMARY KEY, Name TEXT NOT NULL, Points INT NOT NULL)";
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                cmd.ExecuteNonQuery();
            }

            sql = "CREATE TABLE IF NOT EXISTS Members (Id INTEGER PRIMARY KEY, Name TEXT NOT NULL, Team TEXT NOT NULL, Points INT NOT NULL)";
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void Save(string memberName, string teamName, int teamPoints, int memberPoints)
    {
        using (var conn = new SQLiteConnection(dbPath))
        {
            conn.Open();


            string teamSql = "INSERT INTO Teams (Name, Color, Points) VALUES (@teamName, @teamPoints)";
            using (var teamCmd = new SQLiteCommand(teamSql, conn))
            {
                teamCmd.Parameters.AddWithValue("@teamName", teamName);
                teamCmd.Parameters.AddWithValue("@teamPoints", teamPoints);
                teamCmd.ExecuteNonQuery();
            }


            string memberSql = "INSERT INTO Members (Name, Team, Points) VALUES (@memberName, @teamName, @memberPoints)";
            using (var memberCmd = new SQLiteCommand(memberSql, conn))
            {
                memberCmd.Parameters.AddWithValue("@memberName", memberName);
                memberCmd.Parameters.AddWithValue("@teamName", teamName);
                memberCmd.Parameters.AddWithValue("@memberPoints", memberPoints);
                memberCmd.ExecuteNonQuery();
            }
        }
    }

    public DataTable GetAllMembers()
    {
        using (var conn = new SQLiteConnection(dbPath))
        {
            conn.Open();
            string sql = "SELECT Id, Name, Team, Points FROM Members";
            using (var cmd = new SQLiteCommand(sql, conn))
            using (var adapter = new SQLiteDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}