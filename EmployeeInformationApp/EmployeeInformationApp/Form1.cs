using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Employee employee1 = new Employee();
        private void showButton_Click(object sender, EventArgs e)
        {
            employee1.id = idTextBox.Text;
            employee1.name = nameTextBox.Text;
            employee1.salary = Convert.ToDouble(salaryTextBox.Text);

            MessageBox.Show("Employee Id: " + employee1.id + "\nEmployee Name: " + employee1.name + "\nEmployee Salary: " + employee1.salary);
            idTextBox.Clear();
            nameTextBox.Clear();
            salaryTextBox.Clear();
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = employee1.id;
            nameTextBox.Text = employee1.name;
            salaryTextBox.Text = Convert.ToString(employee1.salary);
        }
    }
}
