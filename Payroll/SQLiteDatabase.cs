using System;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace Payroll
{
    class SQLiteDatabase
    {
        public SQLiteConnection dbConnection;
        public SQLiteCommand command;
        public DataTable table;
        private bool _disposed;

        public SQLiteDatabase()
        {
            dbConnection = new SQLiteConnection(("Data Source=MyDatabase.sqlite;Version=3;"));
            try
            {
                dbConnection.Open();
                //resetDatabase();
                DrawTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DrawTables()
        {
            try
            {
                command = new SQLiteCommand("select * from employee_table order by employee_id asc", dbConnection);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Default employee values for testing
        /// </summary>
        private void resetDatabase()
        {
            command = new SQLiteCommand("drop table employee_table", dbConnection);
            command.ExecuteNonQuery();
            
            command = new SQLiteCommand("create table employee_table (employee_ID INT PRIMARY KEY, employment_status TEXT, name TEXT, hourly_rate REAL, hours_worked REAL," +
                    "check_run_status TEXT, occupation TEXT, join_date datetime, accrued_vacation_days REAL, vacation_days_allowed_per_year REAL," +
                    "accrued_sick_days REAL, sick_days_allowed_per_year REAL, federal_tax_withheld REAL, federal_tax_percent REAL," +
                    "state_tax_withheld REAL, state_tax_percent REAL, medicare_tax_withheld REAL, medicare_tax_percent REAL," +
                    "social_security_tax_withheld REAL, social_security_tax_percent REAL)", dbConnection);
            command.ExecuteNonQuery();

            //first entry
            Employee TestEmployee = new Employee
            {
                EmployeeID = 1,
                EmploymentStatus = "Current",
                Name = "Ken Smith",
                HourlyRate = 21.5,
                HoursWorked = 80.0,
                CheckRunStatus = "Pending",
                Occupation = "Clerk",
                JoinDate = Convert.ToDateTime("1998-01-01, 08:00:00"),
                VacationDaysAllowedPerYear = 20.0,
                AccruedVacationDays = 4.5,
                SickDaysAllowedPerYear = 40.0,
                AccruedSickDays = 5.5,
                FederalTaxPercent = 23.6,
                FederalTaxWithheld = 3857.23,
                StateTaxPercent = 5.0,
                StateTaxWithheld = 1293.34,
                MedicareTaxPercent = 633.23,
                MedicareTaxWithheld = 1.8,
                SocialSecurityTaxPercent = 132.12,
                SocialSecurityTaxWithheld = 0.7,
            };

            CreateRow(TestEmployee);
        }

        public void CreateRow(Employee employee)
        {
            command = new SQLiteCommand("insert into employee_Table(employee_ID, employment_status, name, hourly_rate, hours_worked, check_run_status," +
                                                        "occupation, join_date, accrued_vacation_days, vacation_days_allowed_per_year, accrued_sick_days, sick_days_allowed_per_year," +
                                                        "federal_tax_withheld, federal_tax_percent, state_tax_withheld, state_tax_percent, medicare_tax_withheld, medicare_tax_percent," +
                                                        "social_security_tax_withheld, social_security_tax_percent) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", dbConnection);
            command.Parameters.Add(new SQLiteParameter("@employee_ID", employee.EmployeeID));
            command.Parameters.Add(new SQLiteParameter("@employment_status", employee.EmploymentStatus));
            command.Parameters.Add(new SQLiteParameter("@name", employee.Name));
            command.Parameters.Add(new SQLiteParameter("@hourly_rate", employee.HourlyRate));
            command.Parameters.Add(new SQLiteParameter("@hours_worked", employee.HoursWorked));
            command.Parameters.Add(new SQLiteParameter("@check_run_status", employee.CheckRunStatus));
            command.Parameters.Add(new SQLiteParameter("@occupation", employee.Occupation));
            command.Parameters.Add(new SQLiteParameter("@join_date", employee.JoinDate));
            command.Parameters.Add(new SQLiteParameter("@accrued_vacation_days", employee.AccruedVacationDays));
            command.Parameters.Add(new SQLiteParameter("@vacation_days_allowed_per_year", employee.VacationDaysAllowedPerYear));
            command.Parameters.Add(new SQLiteParameter("@accrued_sick_days", employee.AccruedSickDays));
            command.Parameters.Add(new SQLiteParameter("@sick_days_allowed_per_year", employee.SickDaysAllowedPerYear));
            command.Parameters.Add(new SQLiteParameter("@federal_tax_withheld", employee.FederalTaxWithheld));
            command.Parameters.Add(new SQLiteParameter("@federal_tax_percent", employee.FederalTaxPercent));
            command.Parameters.Add(new SQLiteParameter("@state_tax_withheld", employee.StateTaxWithheld));
            command.Parameters.Add(new SQLiteParameter("@state_tax_percent", employee.StateTaxPercent));
            command.Parameters.Add(new SQLiteParameter("@medicare_tax_withheld", employee.MedicareTaxWithheld));
            command.Parameters.Add(new SQLiteParameter("@medicare_tax_percent", employee.MedicareTaxPercent));
            command.Parameters.Add(new SQLiteParameter("@social_security_tax_withheld", employee.SocialSecurityTaxWithheld));
            command.Parameters.Add(new SQLiteParameter("@social_security_tax_percent", employee.SocialSecurityTaxPercent));

            try
            {
                command.ExecuteNonQuery();
                DrawTables();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal void UpdateRow(Employee employee, int p)
        {
            command = new SQLiteCommand("update employee_Table set employment_status = @employment_status, name = @name, " +
                                        "hourly_rate = @hourly_rate, hours_worked = @hours_worked, check_run_status = @check_run_status, " +
                                        "occupation = @occupation, join_date = @join_date, accrued_vacation_days = @accrued_vacation_days, " +
                                        "vacation_days_allowed_per_year = @vacation_days_allowed_per_year, accrued_sick_days = @accrued_sick_days, " +
                                        "sick_days_allowed_per_year = @sick_days_allowed_per_year, federal_tax_withheld = @federal_tax_withheld, "+
                                        "federal_tax_percent = @federal_tax_percent , state_tax_withheld = @state_tax_withheld, " + 
                                        "state_tax_percent = @state_tax_percent, medicare_tax_withheld = @medicare_tax_withheld, " +
                                        "medicare_tax_percent = @medicare_tax_percent, social_security_tax_withheld = @social_security_tax_withheld, " +
                                        "social_security_tax_percent = @social_security_tax_percent where employee_ID = @employee_ID", dbConnection);
            command.Parameters.Add(new SQLiteParameter("@employee_ID", employee.EmployeeID));
            command.Parameters.Add(new SQLiteParameter("@employment_status", employee.EmploymentStatus));
            command.Parameters.Add(new SQLiteParameter("@name", employee.Name));
            command.Parameters.Add(new SQLiteParameter("@hourly_rate", employee.HourlyRate));
            command.Parameters.Add(new SQLiteParameter("@hours_worked", employee.HoursWorked));
            command.Parameters.Add(new SQLiteParameter("@check_run_status", employee.CheckRunStatus));
            command.Parameters.Add(new SQLiteParameter("@occupation", employee.Occupation));
            command.Parameters.Add(new SQLiteParameter("@join_date", employee.JoinDate));
            command.Parameters.Add(new SQLiteParameter("@accrued_vacation_days", employee.AccruedVacationDays));
            command.Parameters.Add(new SQLiteParameter("@vacation_days_allowed_per_year", employee.VacationDaysAllowedPerYear));
            command.Parameters.Add(new SQLiteParameter("@accrued_sick_days", employee.AccruedSickDays));
            command.Parameters.Add(new SQLiteParameter("@sick_days_allowed_per_year", employee.SickDaysAllowedPerYear));
            command.Parameters.Add(new SQLiteParameter("@federal_tax_withheld", employee.FederalTaxWithheld));
            command.Parameters.Add(new SQLiteParameter("@federal_tax_percent", employee.FederalTaxPercent));
            command.Parameters.Add(new SQLiteParameter("@state_tax_withheld", employee.StateTaxWithheld));
            command.Parameters.Add(new SQLiteParameter("@state_tax_percent", employee.StateTaxPercent));
            command.Parameters.Add(new SQLiteParameter("@medicare_tax_withheld", employee.MedicareTaxWithheld));
            command.Parameters.Add(new SQLiteParameter("@medicare_tax_percent", employee.MedicareTaxPercent));
            command.Parameters.Add(new SQLiteParameter("@social_security_tax_withheld", employee.SocialSecurityTaxWithheld));
            command.Parameters.Add(new SQLiteParameter("@social_security_tax_percent", employee.SocialSecurityTaxPercent));

            try
            {
                command.ExecuteNonQuery();
                DrawTables();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (dbConnection != null) dbConnection.Dispose();
                    if (command != null) command.Dispose();
                    if (table != null) table.Dispose();
                }

                dbConnection = null;
                command = null;
                table = null;
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}