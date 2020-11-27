using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StudentRepository
    {
        public List<Student> GetAllStudents()
        {
            using(SqlConnection sql = new SqlConnection(Constants.nameString))
            {
                sql.Open();
                List<Student> st = new List<Student>();
                SqlCommand comm = new SqlCommand(
                    "SELECT * FROM dbo.Students",
                    sql);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Student s = new Student();
                    s.Id = reader.GetInt32(0);
                    s.Name = reader.GetString(1);
                    s.IndexNumber = reader.GetString(2);
                    s.AverageMark = reader.GetDecimal(3);
                    st.Add(s);

                }
                return st;
            }
        }
        public int InsertStudent(Student student)
        {
            using (SqlConnection sql = new SqlConnection(Constants.nameString))
            {
                sql.Open();
                SqlCommand comm = new SqlCommand(
                    string.Format("INSERT INTO dbo.Students VALUES('{0}','{1}','{2}')", student.Name, student.IndexNumber, student.AverageMark),
                    sql);
                return comm.ExecuteNonQuery();
            }
        }
        public int UpdateStudent(Student student)
        {
            using (SqlConnection sql = new SqlConnection(Constants.nameString))
            {
                sql.Open();
                SqlCommand comm = new SqlCommand(
                   string.Format("UPDATE dbo.Students SET IndexNumber='{0}', Name='{1}' WHERE Id = {2}", student.IndexNumber, student.Name, student.Id), sql);

                return comm.ExecuteNonQuery();
            }
        }
        public int DeleteStudent(Student student)
        {
            using (SqlConnection sql = new SqlConnection(Constants.nameString))
            {
                sql.Open();
                SqlCommand comm = new SqlCommand(
                   string.Format("DELETE dbo.Students WHERE Id = {0}", student.Id),sql);
                return comm.ExecuteNonQuery();
            }
        }
    }
}
