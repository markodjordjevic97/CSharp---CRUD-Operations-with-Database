using BusinessLayer;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private readonly StudentBL student;
        public Form1()
        {
            this.student = new StudentBL();
            InitializeComponent();
        }

        private void FillListBox()
        {
            listBoxStudents.Items.Clear();
            List<Student> st = this.student.GetAllStud();
            foreach(Student s in st)
            {
                listBoxStudents.Items.Add(s.WriteStudent());
            }
        }
        private void clearFields()
        {
            nameStudent.Text = null;
            indexStudent.Text = null;
            averageStudent.Text = null;
            FillListBox();
        }
       

        private void showStudents_Click(object sender, EventArgs e)
        {
            clearFields();
        }


        private void add_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = nameStudent.Text;
            s.IndexNumber = indexStudent.Text;
            s.AverageMark = Convert.ToDecimal(averageStudent.Text);

            if (this.student.InsertStudent(s) > 0)
            {
                MessageBox.Show("Uspesan unos");
                clearFields();
            }
            else
                MessageBox.Show("Greksa pri unosu");
           
        }

        private void updateStudent_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            try
            {
                s.Name = nameStudent.Text;
                s.IndexNumber = indexStudent.Text;
                s.AverageMark = Convert.ToDecimal(averageStudent.Text);

                s.Id = int.Parse(listBoxStudents.SelectedItem.ToString().Split(' ')[0]);

                this.student.UpdateStudent(s);
                clearFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("Niste uneli Average Mark");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Niste selektovali Studenta");
            }
            
        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            try
            {
                s.Name = nameStudent.Text;
                s.IndexNumber = indexStudent.Text;
                s.AverageMark = Convert.ToDecimal(averageStudent.Text);

                s.Id = Convert.ToInt32(listBoxStudents.SelectedItem.ToString().Split(' ')[0]);

                this.student.DeleteStudent(s);
                clearFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("Niste uneli Average Mark");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Niste selektovali Studenta");
            }
            
        }

        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fields = listBoxStudents.SelectedItem.ToString();
            string[] array = fields.Split(' ');
            nameStudent.Text = array[1];
            indexStudent.Text = array[2];
            averageStudent.Text = array[3];
        }
    }
}
