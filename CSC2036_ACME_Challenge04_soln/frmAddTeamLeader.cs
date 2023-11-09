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
    public partial class frmAddTeamLeader : Form
    {
        public frmAddTeamLeader()
        {
            //Default Constructor.
            InitializeComponent();
        }

        private Employee? employee = null;  //Avoid null reference.

        public Employee GetNewEmployee()
        {
            this.ShowDialog();
            return employee;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes the form.
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validate the textboxes and save info.
            if (IsValidData())
            {
                employee = new TeamLeader(Convert.ToInt32(txtEmpNumber.Text), txtEmpName.Text,
                Convert.ToDouble(txtHourlyRate.Text), Convert.ToInt32(txtShiftNumber.Text), Convert.ToDouble(txtMonthlyBonus.Text),
                Convert.ToInt32(txtRequiredTraining.Text), Convert.ToInt32(txtEarnedTraining.Text));
                this.Tag = employee;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private bool IsValidData() //Validate the textboxes, and alert a message if nothing entered.
        {
            bool success = true;
            string errorMessage = "";
            errorMessage += Validator.IsPresent(txtEmpNumber.Text, txtEmpNumber.Tag.ToString());
            errorMessage += Validator.IsPresent(txtEmpName.Text, txtEmpName.Tag.ToString());
            errorMessage += Validator.IsPresent(txtHourlyRate.Text, txtHourlyRate.Tag.ToString());
            errorMessage += Validator.IsPresent(txtShiftNumber.Text, txtShiftNumber.Tag.ToString());
            errorMessage += Validator.IsPresent(txtMonthlyBonus.Text, txtMonthlyBonus.Tag.ToString());
            errorMessage += Validator.IsPresent(txtRequiredTraining.Text, txtRequiredTraining.Tag.ToString());
            errorMessage += Validator.IsPresent(txtEarnedTraining.Text, txtEarnedTraining.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }
    }
}