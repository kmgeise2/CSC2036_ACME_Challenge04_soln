/*CSC2036 C# Programming
 * Murtaza Ansari
 Challenge 04*/
namespace CSC2036_ACME_Challenge04_soln
{
    partial class frmAddTeamLeader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmpNumber = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.txtShiftNumber = new System.Windows.Forms.TextBox();
            this.txtMonthlyBonus = new System.Windows.Forms.TextBox();
            this.txtRequiredTraining = new System.Windows.Forms.TextBox();
            this.txtEarnedTraining = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hourly Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Shift Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monthly Bonus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Required Training";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Earned Training";
            // 
            // txtEmpNumber
            // 
            this.txtEmpNumber.Location = new System.Drawing.Point(166, 17);
            this.txtEmpNumber.Name = "txtEmpNumber";
            this.txtEmpNumber.Size = new System.Drawing.Size(115, 25);
            this.txtEmpNumber.TabIndex = 7;
            this.txtEmpNumber.Tag = "Employee Number";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(166, 67);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(187, 25);
            this.txtEmpName.TabIndex = 8;
            this.txtEmpName.Tag = "Employee Name";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(166, 121);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(115, 25);
            this.txtHourlyRate.TabIndex = 9;
            this.txtHourlyRate.Tag = "Hourly Rate";
            // 
            // txtShiftNumber
            // 
            this.txtShiftNumber.Location = new System.Drawing.Point(166, 170);
            this.txtShiftNumber.Name = "txtShiftNumber";
            this.txtShiftNumber.Size = new System.Drawing.Size(115, 25);
            this.txtShiftNumber.TabIndex = 10;
            this.txtShiftNumber.Tag = "Shift Number";
            // 
            // txtMonthlyBonus
            // 
            this.txtMonthlyBonus.Location = new System.Drawing.Point(166, 226);
            this.txtMonthlyBonus.Name = "txtMonthlyBonus";
            this.txtMonthlyBonus.Size = new System.Drawing.Size(115, 25);
            this.txtMonthlyBonus.TabIndex = 11;
            this.txtMonthlyBonus.Tag = "Monthly Bonus";
            // 
            // txtRequiredTraining
            // 
            this.txtRequiredTraining.Location = new System.Drawing.Point(166, 280);
            this.txtRequiredTraining.Name = "txtRequiredTraining";
            this.txtRequiredTraining.Size = new System.Drawing.Size(115, 25);
            this.txtRequiredTraining.TabIndex = 12;
            this.txtRequiredTraining.Tag = "Required Training";
            // 
            // txtEarnedTraining
            // 
            this.txtEarnedTraining.Location = new System.Drawing.Point(166, 334);
            this.txtEarnedTraining.Name = "txtEarnedTraining";
            this.txtEarnedTraining.Size = new System.Drawing.Size(115, 25);
            this.txtEarnedTraining.TabIndex = 13;
            this.txtEarnedTraining.Tag = "Earned Training";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(60, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Tag = "";
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(224, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddTeamLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 434);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEarnedTraining);
            this.Controls.Add(this.txtRequiredTraining);
            this.Controls.Add(this.txtMonthlyBonus);
            this.Controls.Add(this.txtShiftNumber);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddTeamLeader";
            this.Text = "Add Team Leader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtEmpNumber;
        private TextBox txtEmpName;
        private TextBox txtHourlyRate;
        private TextBox txtShiftNumber;
        private TextBox txtMonthlyBonus;
        private TextBox txtRequiredTraining;
        private TextBox txtEarnedTraining;
        private Button btnSave;
        private Button btnCancel;
    }
}