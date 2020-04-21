using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator
{

    //class Course 
    // Stores Info About a course
    class Course
    {
        // GradePoints Dictionary
        private static Dictionary<string, double> GRADE_POINTS = new Dictionary<string, double>()
            {
                {"A+", 4.00}, {"A-", 3.70}, {"B+", 3.30}, {"B", 3.00}, {"B-", 2.70},
                {"C+", 2.30}, {"C", 2.00}, {"C-", 1.70}, {"D", 1.00}, {"F", 0.00}, {"W", 0.00}
            };

        private string name; // Name of Course
        private int credits; //Credits of course
        private string grade; //Course Grade
        private bool iswithdraw; // for withdraw

        // Course Name Property
        public string CourseName
        {
            set { this.name = value; }
            get { return this.name; }
        }

        //Course Credits Property
        public int CourseCredits
        {
            set { this.credits = value; }
            get { return this.WithdrawCourse ? 0 : this.credits; }
        }

        // Course Grade Property
        public string CourseGrade
        {
            set { this.grade = value; }
            get { return this.grade; }
        }

        // Withdraw Property
        public bool WithdrawCourse
        {
            set { this.iswithdraw = value; }
            get { return this.iswithdraw; }
        }

        // Constructor
        public Course(string name, int credits,string grade, bool isWithdraw = false)
        {
            this.CourseName = name;
            this.CourseCredits = credits;
            this.CourseGrade = grade;
            this.WithdrawCourse = isWithdraw;
        }

        //returns GradePoints earned for this Course
        public double calculateGradePoints()
        {
            // if course is withdraw then 0 otherwise 
            return (this.WithdrawCourse) ? 0.0 : this.CourseCredits * GRADE_POINTS[this.CourseGrade];
        }
    }
}