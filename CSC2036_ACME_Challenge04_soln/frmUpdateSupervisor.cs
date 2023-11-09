/*CSC2036 C# Programming
 * Murtaza Ansari
 Challenge 04*/
using CSC2036_ACME_Challenge04;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC2036_ACME_Challenge04_soln
{
    public partial class frmUpdateSupervisor : Form
    {
        private Form1 _EmployeesForm1;

        private ShiftSupervisor SelectedEmplyee;
        ShiftSupervisor tempEmployee = new ShiftSupervisor();
        public frmUpdateSupervisor()
        {
            InitializeComponent();
        }

        public frmUpdateSupervisor(Form1 employeesForm) : this()
        {
            // This constructor accepts a passed form
            // Update the field reference with the passed form reference
            _EmployeesForm1 = employeesForm;
        }

        public frmUpdateSupervisor(ShiftSupervisor employeeData)
        {
            // This constructor accepts a passed ProductionWorker
            // Cast employee data into a new employee object
            ShiftSupervisor selectedEmployee = employeeData;
        }

        private void frmUpdateSupervisor_Load(object sender, EventArgs e)
        {
            // Employee data is passed through this form's Tag field
            // Map the tag data to the ShiftSupervisor class
            // All of the data must be converted to string to display
            //
            SelectedEmplyee = (ShiftSupervisor)this.Tag;

            txtEmpNumber.Text = Convert.ToString(SelectedEmplyee.EmpNumber);
            txtEmpName.Text = SelectedEmplyee.EmpName;
            txtAnnualSalary.Text = Convert.ToString(SelectedEmplyee.AnnualSalary);
            txtAnnualBonus.Text = Convert.ToString(SelectedEmplyee.AnnualBonus);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tempEmployee.EmpNumber = Convert.ToInt32(txtEmpNumber.Text);
            tempEmployee.EmpName = txtEmpName.Text;
            tempEmployee.AnnualSalary = Convert.ToDouble(txtAnnualSalary.Text);
            tempEmployee.AnnualBonus = Convert.ToInt32(txtAnnualBonus.Text);

            // Update the Tag field
            this.Tag = tempEmployee;
            this.DialogResult = DialogResult.OK;
            // Close the form 
            this.Close();
        }
    }
}
