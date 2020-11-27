using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentBL
    {
        private readonly StudentRepository student;
        public StudentBL()
        {
            this.student = new StudentRepository();
        }

        public List<Student> GetAllStud()
        {
            return this.student.GetAllStudents();
        }
        public List<Student> GetByAverageMark(decimal mark)
        {
            return this.student.GetAllStudents().Where(s => s.AverageMark > mark).ToList();
        }
        public int InsertStudent(Student student)
        {
            return this.student.InsertStudent(student);
        }
        public int DeleteStudent(Student student)
        {
            return this.student.DeleteStudent(student);
        }
        public int UpdateStudent(Student student)
        {
            return this.student.UpdateStudent(student);
        }
    }
}
