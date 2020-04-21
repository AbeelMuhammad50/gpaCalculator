using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPACalculator
{
    public partial class GPADetails : Form
    {
        private GPA gpa; // for receiving data form main Form

        internal GPADetails(GPA g)
        {
            gpa = g;
            InitializeComponent();
        }

        // Function adds Data to Data Grid View 
        private void GPADetails_Load(object sender, EventArgs e)
        {
            int i = 1;
            foreach (Course c in gpa.Courses)
            {
                int n = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[n].Cells[0].Value = i;
                this.dataGridView1.Rows[n].Cells[1].Value = c.CourseName;//name
                this.dataGridView1.Rows[n].Cells[2].Value = c.CourseGrade;//grade
                this.dataGridView1.Rows[n].Cells[3].Value = c.CourseCredits;//Credits
                this.dataGridView1.Rows[n].Cells[4].Value = c.calculateGradePoints();//GradePoints
                this.dataGridView1.Rows[n].Cells[5].Value = c.WithdrawCourse;//withdraw
               
                i++;
            }

            this.gpaValue.Text = string.Format("{0:0.00}", this.gpa.getGPA());
        }

        //Close Button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
