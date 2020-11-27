using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IndexNumber { get; set; }
        public decimal AverageMark { get; set; }

        public Student()
        {

        }
        public string WriteStudent()
        {
            return string.Format("{0} {1} {2} {3}",this.Id, this.Name,this.IndexNumber,this.AverageMark);
        }
    }
}
