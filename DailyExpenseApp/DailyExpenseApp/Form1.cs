using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace DailyExpenseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string path = @"E:\shawon\17-Dec-2014\dailyExpense.csv";

        private void saveButton_Click(object sender, EventArgs e)
        {
            string amount = amountTextBox.Text;
            string particular = particularTextBox.Text;
            string category = catagoryComboBox.Text;
            FileStream aFileStream = new FileStream(path, FileMode.Append);
            CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
            List<string> dailyExpList = new List<string>();


            dailyExpList.Add(amount);
            dailyExpList.Add(particular);
            MessageBox.Show("Successfully Added");
            amountTextBox.Clear();
            particularTextBox.Clear();

            aWriter.WriteRow(dailyExpList);
            aFileStream.Close();
        }

        private void viewShowButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(path, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aFileStream);
            List<string> viewCategoryReader = new List<string>();
            
            double sum = 0;
            showListBox.Items.Clear();
            while ((aReader.ReadRow(viewCategoryReader)))
            {
                string amountReader = viewCategoryReader[0];
                string particularReader = viewCategoryReader[1];
                
                if(viewCategoryComboBox.Enabled==true)
                {
                    showListBox.Items.Add(amountReader + " " + particularReader);
                    
                    double amunt = Convert.ToDouble(viewCategoryReader[0]);
                    sum += amunt;
                }
                else
                {
                    continue;
                }
                
            }
            totalTextBox.Text = Convert.ToString(sum);
            aFileStream.Close();
        }

        private void viewCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(path, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aFileStream);
            List<string> viewSummayReader = new List<string>();
            double sum = 0;
            showListBox.Items.Clear();
            while ((aReader.ReadRow(viewSummayReader)))
            {
                string amountReader = viewSummayReader[0];
                double amunt = Convert.ToDouble(viewSummayReader[0]);
                sum += amunt;
            }
            totalExpenseTextBox.Text = Convert.ToString(sum);
            aFileStream.Close();
        }
    }
}
