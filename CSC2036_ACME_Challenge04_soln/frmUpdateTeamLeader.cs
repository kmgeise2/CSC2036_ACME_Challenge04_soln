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
    public partial class frmUpdateTeamLeader : Form
    {
        private Form1 _employeesForm1;

        private TeamLeader selectedEmployee;
        TeamLeader tempEmployee = new TeamLeader();
        public frmUpdateTeamLeader()
        {
            //Default Constructor.
            InitializeComponent();
        }

        public frmUpdateTeamLeader(Form1 employeesForm) : this()
        {
            // This constructor accepts a passed form
            // Update the field reference with the passed form reference
            _employeesForm1 = employeesForm;
        }

        public frmUpdateTeamLeader(TeamLeader employeeData)
        {
            // This constructor accepts a passed TeamLeader
            // Cast employee data into a new employee object
            TeamLeader selectedEmployee = employeeData;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateTeamLeader_Load(object sender, EventArgs e)
        {
            // Employee data is passed through this form's Tag field
            // Map the tag data to the TeamLeader class
            // All of the data must be converted to string to display
            //
            selectedEmployee = (TeamLeader)this.Tag;

            txtEmpNumber.Text = Convert.ToString(selectedEmployee.EmpNumber);
            txtEmpName.Text = selectedEmployee.EmpName;
            txtHourlyRate.Text = Convert.ToString(selectedEmployee.HourlyRate);
            txtShiftNumber.Text = Convert.ToString(selectedEmployee.ShiftNumber);
            txtMonthlyBonus.Text = Convert.ToString(selectedEmployee.MonthlyBonus);
            txtRequiredTraining.Text = Convert.ToString(selectedEmployee.RequiredTraining);
            txtEarnedTraining.Text = Convert.ToString(selectedEmployee.EarnedTraining);


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            tempEmployee.EmpNumber = Convert.ToInt32(txtEmpNumber.Text);
            tempEmployee.EmpName = txtEmpName.Text;
            tempEmployee.HourlyRate = Convert.ToDouble(txtHourlyRate.Text);
            tempEmployee.ShiftNumber = Convert.ToInt32(txtShiftNumber.Text);
            tempEmployee.MonthlyBonus = Convert.ToDouble(txtMonthlyBonus.Text);
            tempEmployee.RequiredTraining = Convert.ToInt32(txtRequiredTraining.Text);
            tempEmployee.EarnedTraining = Convert.ToInt32(txtEarnedTraining.Text);

            // Update the Tag field
            this.Tag = tempEmployee;
            this.DialogResult = DialogResult.OK;
            // Close the form 
            this.Close();
        }
    }
}
