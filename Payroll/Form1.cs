using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Payroll
{
    public partial class Payroll_Application : Form
    {
        SQLiteDatabase database;
        int currentMouseOverRow;

        public Payroll_Application()
        {
            InitializeComponent();
            this.Text = "Payroll Application";
            this.Size = new Size(700, 500);
            database = new SQLiteDatabase();

            updateForm();
        }

        private void updateForm()
        {
            dataGridViewEmployeeDatabase.DataSource = database.table;
            labelTotalRegisteredEmployees.Text = database.table.Rows.Count.ToString();
        }

        private void buttonRegisterNewEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in groupBoxRegistrationFields.Controls)
                {
                    validateControls(c);
                }

                Employee employee = new Employee
                {
                    EmployeeID = Convert.ToInt32(labelTotalRegisteredEmployees.Text) + 1,
                    EmploymentStatus = "Current",
                    Name = textBoxRegistrationEmployeeName.Text,
                    HourlyRate = Convert.ToDouble(textBoxRegistrationHourlyRate.Text),
                    HoursWorked = 0.0,
                    CheckRunStatus = "Pending",
                    Occupation = textBoxRegistrationOccupation.Text,
                    JoinDate = Convert.ToDateTime(textBoxRegistrationJoinDate.Text),
                    VacationDaysAllowedPerYear = Convert.ToDouble(textBoxRegistrationVacationDaysAllowedPerYear.Text),
                    AccruedVacationDays = Convert.ToDouble(textBoxRegistrationVacationDaysAllowedPerYear.Text) / 52.0,
                    SickDaysAllowedPerYear = Convert.ToDouble(textBoxRegistrationSickDaysAllowedPerYear.Text),
                    AccruedSickDays = Convert.ToDouble(textBoxRegistrationSickDaysAllowedPerYear.Text) / 52.0,
                    FederalTaxPercent = Convert.ToDouble(textBoxRegistrationFederalTaxPercentWithheld.Text),
                    FederalTaxWithheld = 0.0,
                    StateTaxPercent = Convert.ToDouble(textBoxRegistrationStateTaxPercentWithheld.Text),
                    StateTaxWithheld = 0.0,
                    MedicareTaxPercent = Convert.ToDouble(textBoxRegistrationMedicareTaxPercentWithheld.Text),
                    MedicareTaxWithheld = 0.0,
                    SocialSecurityTaxPercent = Convert.ToDouble(textBoxRegistrationSocialSecurityTaxPercentWithheld.Text),
                    SocialSecurityTaxWithheld = 0.0,
                };

                database.CreateRow(employee);

                foreach (Control c in groupBoxRegistrationFields.Controls)
                    if (c is TextBox)
                        c.Text = "";

                updateForm();
                MessageBox.Show("New employee Registered");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewEmployeeDatabase_MouseClick(object sender, MouseEventArgs e)
        {
            currentMouseOverRow = dataGridViewEmployeeDatabase.HitTest(e.X, e.Y).RowIndex + 1;

            if (currentMouseOverRow >= 1 && e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(dataGridViewEmployeeDatabase, new Point(e.X, e.Y));
            }
        }

        private void changeCheckRunStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                database.command = new SQLiteCommand(String.Format("Update employee_table set check_run_status = case " + 
                                                        "when check_run_status = 'Approved' then 'Pending' else 'Approved' end " +
                                                        "Where employee_ID = {0}", currentMouseOverRow), database.dbConnection);
                database.command.ExecuteNonQuery();
                database.DrawTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            updateForm();
        }

        private void editEmployeeAccountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.SelectedIndex = 2;
                labelAccountDetailEmployeeID.Text = currentMouseOverRow.ToString();

                var row = from a in database.table.AsEnumerable()
                          where a.Field<int>("employee_id").Equals(currentMouseOverRow)
                          select a;

                textBoxAccountDetailEmployeeName.Text = row.ElementAt(0).Field<string>("name").ToString();
                textBoxAccountDetailJoinDate.Text = row.ElementAt(0).Field<DateTime>("join_date").ToString();
                textBoxAccountDetailOccupation.Text = row.ElementAt(0).Field<string>("occupation").ToString();
                textBoxAccountDetailHourlyRate.Text = row.ElementAt(0).Field<double>("hourly_rate").ToString();
                textBoxAccountDetailHoursWorked.Text = row.ElementAt(0).Field<double>("hours_worked").ToString();
                textBoxAccountDetailVacationDaysAllowedPerYear.Text = row.ElementAt(0).Field<double>("vacation_days_allowed_per_year").ToString();
                textBoxAccountDetailSickDaysAllowedPerYear.Text = row.ElementAt(0).Field<double>("sick_days_allowed_per_year").ToString();
                textBoxAccountDetailFederalTaxPercent.Text = row.ElementAt(0).Field<double>("federal_tax_percent").ToString();
                textBoxAccountDetailStateTaxPercent.Text = row.ElementAt(0).Field<double>("state_tax_percent").ToString();
                textBoxAccountDetailMedicareTaxPercent.Text = row.ElementAt(0).Field<double>("medicare_tax_percent").ToString();
                textBoxAccountDetailSocialSecurityTaxPercent.Text = row.ElementAt(0).Field<double>("social_security_tax_percent").ToString();
                textBoxAccountDetailAccruedVacationDays.Text = row.ElementAt(0).Field<double>("accrued_vacation_days").ToString();
                textBoxAccountDetailAccruedSickDays.Text = row.ElementAt(0).Field<double>("accrued_sick_days").ToString();
                textBoxAccountDetailFederalTaxWithheld.Text = row.ElementAt(0).Field<double>("federal_tax_withheld").ToString();
                textBoxAccountDetailStateTaxWithheld.Text = row.ElementAt(0).Field<double>("state_tax_withheld").ToString();
                textBoxAccountDetailMedicareTaxWithheld.Text = row.ElementAt(0).Field<double>("medicare_tax_withheld").ToString();
                textBoxAccountDetailSocialSecurityTaxWithheld.Text = row.ElementAt(0).Field<double>("social_security_tax_withheld").ToString();

                comboBoxAccountDetailCheckRunStatus.Text = row.ElementAt(0).Field<string>("check_run_status").ToString();
                comboBoxAccountDetailEmploymentStatus.Text = row.ElementAt(0).Field<string>("employment_status").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void validateControls(Control c)
        {
            if (c.Text.Length == 0)
            {
                throw (new Exception("Fields can't be empty"));
            }

            if (c.Tag == "DateTime")
            {
                DateTime dummy;
                if (!DateTime.TryParse(c.Text, out dummy))
                {
                    throw (new Exception("Please enter a DateTime Value MM/DD/YYYY"));
                }
            }

            if (c.Tag == "Numerical")
            {
                double dummy;
                if (!Double.TryParse(c.Text, out dummy))
                {
                    throw (new Exception("Numerical values only can be entered for numerical fields"));
                }
                if (dummy < 0)
                {
                    throw (new Exception("Numerical values should be postive values"));
                }
            }
        }

        private void buttonEmployeeAccountDetailSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in groupBoxAccountDetail.Controls)
                {
                    validateControls(c);
                }

                Employee employee = new Employee
                {
                    EmployeeID = Convert.ToInt32(labelAccountDetailEmployeeID.Text),
                    EmploymentStatus = comboBoxAccountDetailEmploymentStatus.Text,
                    Name = textBoxAccountDetailEmployeeName.Text,
                    HourlyRate = Convert.ToDouble(textBoxAccountDetailHourlyRate.Text),
                    HoursWorked = Convert.ToDouble(textBoxAccountDetailHoursWorked.Text),
                    CheckRunStatus = comboBoxAccountDetailCheckRunStatus.Text,
                    Occupation = textBoxAccountDetailOccupation.Text,
                    JoinDate = Convert.ToDateTime(textBoxAccountDetailJoinDate.Text),
                    VacationDaysAllowedPerYear = Convert.ToDouble(textBoxAccountDetailVacationDaysAllowedPerYear.Text),
                    AccruedVacationDays = Convert.ToDouble(textBoxAccountDetailAccruedVacationDays.Text),
                    SickDaysAllowedPerYear = Convert.ToDouble(textBoxAccountDetailSickDaysAllowedPerYear.Text),
                    AccruedSickDays = Convert.ToDouble(textBoxAccountDetailAccruedSickDays.Text),
                    FederalTaxPercent = Convert.ToDouble(textBoxAccountDetailFederalTaxPercent.Text),
                    FederalTaxWithheld = Convert.ToDouble(textBoxAccountDetailFederalTaxWithheld.Text),
                    StateTaxPercent = Convert.ToDouble(textBoxAccountDetailStateTaxPercent.Text),
                    StateTaxWithheld = Convert.ToDouble(textBoxAccountDetailStateTaxWithheld.Text),
                    MedicareTaxPercent = Convert.ToDouble(textBoxAccountDetailMedicareTaxPercent.Text),
                    MedicareTaxWithheld = Convert.ToDouble(textBoxAccountDetailMedicareTaxWithheld.Text),
                    SocialSecurityTaxPercent = Convert.ToDouble(textBoxAccountDetailSocialSecurityTaxPercent.Text),
                    SocialSecurityTaxWithheld = Convert.ToDouble(textBoxAccountDetailSocialSecurityTaxWithheld.Text),
                };

                database.UpdateRow(employee, Convert.ToInt32(labelAccountDetailEmployeeID.Text));

                foreach (Control c in groupBoxAccountDetail.Controls)
                {
                    if (c is TextBox || c is ComboBox)
                    {
                        c.Text = "";
                    }
                }
                dataGridViewEmployeeDatabase.DataSource = database.table;
                labelAccountDetailEmployeeID.Text = "";
                MessageBox.Show("Changes to account implemented");
                tabControl1.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPrepareForNextPayPeriod_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Check run status for all employees must be ""mailed"" first");
        }

        private void buttonRunChecksForCurrentPayPeriod_Click(object sender, EventArgs e)
        {
            try
            {
                database.command = new SQLiteCommand("Update employee_table set check_run_status = 'Approved'", database.dbConnection);
                database.command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            database.DrawTables();
            updateForm();
        }

        private void unimplementedButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not implemented");
        }
    }
}
