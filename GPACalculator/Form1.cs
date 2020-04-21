using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GPACalculator
{
    public partial class Form1 : Form
    {
        private GPA gpa;
        public Form1()
        {
            gpa = new GPA();
            Thread t = new Thread(new ThreadStart(this.SplashStart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        // starts Splash Screen
        public void SplashStart()
        {
            Application.Run(new SplashScreen());
        }

        // gets Course-1's Credentials
        private Course getCourse1()
        {
            // Course Name is Missing
            if (this.textBoxCourseName_1.Text == "") 
            {
                MessageBox.Show("Course-1 name is missing");
                return null;
            }
            string name = this.textBoxCourseName_1.Text; //course Name
            int credits = Convert.ToInt32(Math.Round(this.numericUpDownCourse_1.Value, 0)); //Credit Hours

            bool isWithdraw = this.checkBoxCourse_1.Checked;
            string grade = "W";
            if (!isWithdraw) //if not withdraw
            {
                if (this.comboBoxCourse_1.Text == "")
                {
                    MessageBox.Show("Course-1 Grade is missing");
                    return null;
                }
                grade = this.comboBoxCourse_1.SelectedItem.ToString(); //Course grade
            }
            return new Course(name, credits, grade, isWithdraw); //returns new Course
        }

        // gets Course-2's Credentials
        private Course getCourse2()
        {
            // Course Name is Missing
            if (this.textBoxCourse_2.Text == "")
            {
                MessageBox.Show("Course-1 name is missing");
                return null;
            }
            string name = this.textBoxCourse_2.Text; //course Name
            int credits = Convert.ToInt32(Math.Round(this.numericUpDownCourse_2.Value, 0)); //Credit Hours

            bool isWithdraw = this.checkBoxCourse_2.Checked;
            string grade = "W";
            if (!isWithdraw) //if not withdraw
            {
                if (this.comboBoxCourse_2.Text == "")
                {
                    MessageBox.Show("Course-1 Grade is missing");
                    return null;
                }
                grade = this.comboBoxCourse_2.SelectedItem.ToString(); //Course grade
            }
            return new Course(name, credits, grade, isWithdraw); //returns new Course
        }

        // gets Course-3's Credentials
        private Course getCourse3()
        {
            // Course Name is Missing
            if (this.textBoxCourse_3.Text == "")
            {
                MessageBox.Show("Course-1 name is missing");
                return null;
            }
            string name = this.textBoxCourse_3.Text; //course Name
            int credits = Convert.ToInt32(Math.Round(this.numericUpDownCourse_3.Value, 0)); //Credit Hours

            bool isWithdraw = this.checkBoxCourse_3.Checked;
            string grade = "W";
            if (!isWithdraw) //if not withdraw
            {
                if (this.comboBoxCourse_3.Text == "")
                {
                    MessageBox.Show("Course-1 Grade is missing");
                    return null;
                }
                grade = this.comboBoxCourse_3.SelectedItem.ToString(); //Course grade
            }
            return new Course(name, credits, grade, isWithdraw); //returns new Course
        }

        // gets Course-4's Credentials
        private Course getCourse4()
        {
            // Course Name is Missing
            if (this.textBoxCourse_4.Text == "")
            {
                MessageBox.Show("Course-1 name is missing");
                return null;
            }
            string name = this.textBoxCourse_4.Text; //course Name
            int credits = Convert.ToInt32(Math.Round(this.numericUpDownCourse_4.Value, 0)); //Credit Hours

            bool isWithdraw = this.checkBoxCourse_4.Checked;
            string grade = "W";
            if (!isWithdraw) //if not withdraw
            {
                if (this.comboBoxCourse_4.Text == "")
                {
                    MessageBox.Show("Course-1 Grade is missing");
                    return null;
                }
                grade = this.comboBoxCourse_4.SelectedItem.ToString(); //Course grade
            }
            return new Course(name, credits, grade, isWithdraw); //returns new Course
        }

        // gets Course-5's Credentials
        private Course getCourse5()
        {
            // Course Name is Missing
            if (this.textBoxCourse_5.Text == "")
            {
                MessageBox.Show("Course-1 name is missing");
                return null;
            }
            string name = this.textBoxCourse_5.Text; //course Name
            int credits = Convert.ToInt32(Math.Round(this.numericUpDownCourse_5.Value, 0)); //Credit Hours

            bool isWithdraw = this.checkBoxCourse_5.Checked;
            string grade = "W";
            if (!isWithdraw) //if not withdraw
            {
                if (this.comboBoxCourse_5.Text == "")
                {
                    MessageBox.Show("Course-1 Grade is missing");
                    return null;
                }
                grade = this.comboBoxCourse_5.SelectedItem.ToString(); //Course grade
            }
            return new Course(name, credits, grade, isWithdraw); //returns new Course
        }

        // gets Course-6's Credentials
        private Course getCourse6()
        {
            // Course Name is Missing
            if (this.textBoxCourse_6.Text == "")
            {
                MessageBox.Show("Course-1 name is missing");
                return null;
            }
            string name = this.textBoxCourse_6.Text; //course Name
            int credits = Convert.ToInt32(Math.Round(this.numericUpDownCourse_6.Value, 0)); //Credit Hours

            bool isWithdraw = this.checkBoxCourse_6.Checked;
            string grade = "W";
            if (!isWithdraw) //if not withdraw
            {
                if (this.comboBoxCourse_6.Text == "")
                {
                    MessageBox.Show("Course-1 Grade is missing");
                    return null;
                }
                grade = this.comboBoxCourse_6.SelectedItem.ToString(); //Course grade
            }
            return new Course(name, credits, grade, isWithdraw); //returns new Course
        }


        // Exit Button
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        // Calculate Button
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            this.gpa.clear();

            Course c = getCourse1();
            if (c == null) return;
            gpa.addCourse(c);

            c = getCourse2();
            if (c == null) return;
            gpa.addCourse(c);

            c = getCourse3();
            if (c == null) return;
            gpa.addCourse(c);

            c = getCourse4();
            if (c == null) return;
            gpa.addCourse(c);

            c = getCourse5();
            if (c == null) return;
            gpa.addCourse(c);

            c = getCourse6();
            if (c == null) return;
            gpa.addCourse(c);

            GPADetails g = new GPADetails(this.gpa);
            g.ShowDialog();


            

            //MessageBox.Show("GPA: " + gpa.getGPA());
        }

        //Course-1 Withdraw Check Box
        private void checkBoxCourse_1_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBoxCourse_1.Enabled = !this.checkBoxCourse_1.Checked;
        }

        //Course-2 Withdraw Check Box
        private void checkBoxCourse_2_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBoxCourse_2.Enabled = !this.checkBoxCourse_2.Checked;   
        }

        //Course-3 Withdraw Check Box
        private void checkBoxCourse_3_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBoxCourse_3.Enabled = !this.checkBoxCourse_3.Checked; 
        }

        //Course-4 Withdraw Check Box
        private void checkBoxCourse_4_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBoxCourse_4.Enabled = !this.checkBoxCourse_4.Checked; 
        }

        //Course-5 Withdraw Check Box
        private void checkBoxCourse_5_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBoxCourse_5.Enabled = !this.checkBoxCourse_5.Checked; 
        }

        //Course-6 Withdraw Check Box
        private void checkBoxCourse_6_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBoxCourse_6.Enabled = !this.checkBoxCourse_6.Checked; 
        }
    }
}
