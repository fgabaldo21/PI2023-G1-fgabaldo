using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories {
    public static class TeacherRepository {
        public static GetTeacher (string username) {
            string sql = $"SELECT * FROM Teachers WHERE Username = '{username}'";
            return
        }

        public static GetTeacher(int id) {
            string sql = $"SELECT * FROM Teachers WHERE Id = '{id}'";
            return FetchTeacher(sql);
        }


        public static Teacher GetTeacher () {
            
        }
        private static TeacherRepository FetchTeacher(string sql) {
            Teacher teacher = null;
            string sql = $"SELECT * FROM Teachers WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) {
                reader.Read();
                teacher = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return teacher;
        }
        private static Teacher CreateObject(SqlDataReader reader) {
            Teacher teacher = new Teacher();

            teacher.Id = Convert.ToInt32(reader["ID"].ToString());
            teacher.FirstName = reader["FirstName"].ToString();
            teacher.LastName = reader["LastName"].ToString();
            teacher.Username = reader["Username"].ToString();
            teacher.Password = reader["Password"].ToString();

            return teacher;
        }
    }
}
