using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentID = StudentIDTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string firstName = FirstNameTextBox.Text;

            StudentInfo student = new StudentInfo(studentID, lastName, firstName);

            listBox1.Items.Add(student.StudentID);
            listBox2.Items.Add(student.FirstName);
            listBox3.Items.Add(student.LastName);

            StudentIDTextBox.Clear();
            LastNameTextBox.Clear();
            FirstNameTextBox.Clear();
        }
        public class StudentInfo
        {
            private string studentID;
            private string lastName;
            private string firstName;

            public string StudentID
            {
                get { return studentID; }
                set { studentID = value; }
            }
            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }
            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }
            public StudentInfo()
            {

            }
            public StudentInfo(string studentID, string lastName, string firstname)
            {
                this.studentID = studentID;
                this.lastName = lastName;
                this.firstName = firstname;
            }
        }
        
    }
}

