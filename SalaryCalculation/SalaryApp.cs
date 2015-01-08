using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculation
{
    public partial class SalaryApp : Form
    {
        public SalaryApp()
        {
            InitializeComponent();
        }
        Employee aEmployee=new Employee();
        
        private int count = 0;
        private void saveButton_Click(object sender, EventArgs e)
        {
            aEmployee.Email = emailEntryTextBox.Text;
            aEmployee.Name = nameEntryTextBox.Text;
            aEmployee.Id = idEntryTextBox.Text;

            Salary aSalary = new Salary();

            aSalary.Convenyence = Convert.ToDouble(conveneynceEntryTextBox.Text);
            aSalary.Basic = Convert.ToDouble(basicEntryTextBox.Text);
            aSalary.Medical = Convert.ToDouble(medicalEntryTextBox.Text);
            aEmployee.ASalary = aSalary;
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            noOfIncrementDisplayTextBox.Text = count.ToString();
            basicDisplayTextBox.Text = aEmployee.ASalary.Basic.ToString();
            conveneynceDisplayTextBox.Text = aEmployee.ASalary.ConveneyenceAmount().ToString();
            medicalDisplayTextBox.Text = aEmployee.ASalary.MedicalAmount().ToString();
            totalDisplayTextBox.Text = aEmployee.ASalary.TotalSalary().ToString();
        }

        

        private void incrementButton_Click(object sender, EventArgs e)
        {
            count++;
            basicDisplayTextBox.Text = (aEmployee.ASalary.Increment(Convert.ToDouble(amountEntryTextBox.Text))).ToString();

        }

        
       
    }
}
