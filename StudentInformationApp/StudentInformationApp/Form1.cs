using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationApp
{
    public partial class Form1 : Form
    {
        Student aStudent = new Student();
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {

            aStudent.regNo = regNoTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;

            MessageBox.Show(aStudent.GetName() + " your reg. no is " +aStudent.regNo);

            regNoTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();


        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            regNoTextBox.Text = aStudent.regNo;
            firstNameTextBox.Text = aStudent.firstName;
            lastNameTextBox.Text = aStudent.lastName;
        }
    }
}
