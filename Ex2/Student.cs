using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Student
    {
        private double marks; //store grade as number

        //Student Constructor
        public Student(double m)
        {
            marks = m;
        }

        //Converts marks to P or F and returns as a string
        public string getLetterGrades()
        {
            string letterGrade;

            if (marks > 0 && marks <= 60)
                letterGrade = "F";
            else if (marks > 60 && marks <= 100)
                letterGrade = "P";
            else
                letterGrade = "NA";

            return letterGrade;
        }
    }
}
