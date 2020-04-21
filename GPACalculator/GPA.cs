using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator
{
    //Class Stores List of courses and calculates GPA
    class GPA
    {
        private List<Course> courses; //courses List

        // Constructor
        public GPA() 
        {
            this.courses = new List<Course>();
        }

        // Courses Property
        public List<Course> Courses
        {
            get { return this.courses; }
        }

        // adds Course to Courses List
        public void addCourse(Course c)
        {
            this.courses.Add(c);
        }

        // calculates and returns GPA
        public double getGPA()
        {
            int totalCredits = 0;
            double totalGradePoints = 0.0;

            foreach (Course c in this.courses)
            {
                totalCredits += c.CourseCredits; //adds to total Credits
                totalGradePoints += c.calculateGradePoints(); // adds to total Grade Points
            }
            return totalGradePoints / totalCredits; //returns GPA
        }

        //clears Courses
        public void clear()
        {
            this.courses.Clear();
        }
    }
}
