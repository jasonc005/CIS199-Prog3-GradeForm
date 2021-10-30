using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Team 6 - Jason Chandler, William Benedict
 * This program creates a list of Student objects and saves a new one each time the button is pressed.
 */

namespace Ex2
{
    public partial class GradeForm : Form
    {
        
        public GradeForm()
        {
            InitializeComponent();
        }

        //Create a list of Student objects
        List<Student> students = new List<Student>();

        //Creates Student object and adds to the List
        private void addButton_Click(object sender, EventArgs e)
        {
            //Create Student object with value in textbox as marks
            Student st = new Student(double.Parse(marksTextbox.Text));

            //Display message with student's letter grade
            MessageBox.Show("This student's letter grade: " + st.getLetterGrades());

            //Add object to the list
            students.Add(st);
        }
    }
}
