using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories {
    public static class ActivityRepository
    {
        private static Activity CreateObject(SqlDataReader reader) {
            Activity aktivnost = new Activity();

            aktivnost.Id = Convert.ToInt32(reader["ID"].ToString());
            aktivnost.Name = reader["Name"].ToString();
            aktivnost.Description = reader["Description"].ToString();
            int.TryParse(reader["MaxPoints"].ToString(), out int maxPoints);
            int.TryParse(reader["MinPointsForGrade"].ToString(), out int minPointsForGrade);
            int.TryParse(reader["MinPointsForSignature"].ToString(), out int minPointsForSignature);
            aktivnost.MaxPoints = maxPoints;
            aktivnost.MinPointsForGrade = minPointsForGrade;
            aktivnost.MinPointsForSignature = minPointsForSignature;

            return aktivnost;
        }

        public static Activity GetActivity(int id) {
            Activity aktivnost = null;
            string sql = $"SELECT * FROM Aktivnosti WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) {
                reader.Read();
                aktivnost = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return aktivnost;
        }

        public static List<Activity> GetActivities() {
            List<Activity> aktivnosti = new List<Activity>();

            string sql = "SELECT * FROM Activities";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read()) {
                Activity aktivnost = CreateObject(reader);
                aktivnosti.Add(aktivnost);
            }

            reader.Close();
            DB.CloseConnection();

            return aktivnosti;
        }
    }
}
