using System;
using System.Data.Linq.Mapping;

namespace Payroll
{
    //unused 
    //Getting Entity Framework to work with SQLite was a huge pain and so I gave up, probably fixable by reinstalling everything.
    [Table(Name = "employee_table")]
    class Employee
    {
        [Column(Name = "employee_id")]
        public int EmployeeID { get; set; }
        [Column(Name = "employment_status")]
        public string EmploymentStatus { get; set; }
        [Column(Name = "name")]
        public string Name { get; set; }
        [Column(Name = "hourly_rate")]
        public double HourlyRate { get; set; }
        [Column(Name = "hours_worked")]
        public double HoursWorked { get; set; }
        [Column(Name = "check_run_status")]
        public string CheckRunStatus { get; set; }
        [Column(Name = "occupation")]
        public string Occupation { get; set; }
        [Column(Name = "join_date")]
        public DateTime JoinDate { get; set; }
        [Column(Name = "accrued_vacation_days")]
        public double AccruedVacationDays { get; set; }
        [Column(Name = "vacation_days_allowed_per_year")]
        public double VacationDaysAllowedPerYear { get; set; }
        [Column(Name = "accrued_sick_days")]
        public double AccruedSickDays { get; set; }
        [Column(Name = "sick_days_allowed_per_year")]
        public double SickDaysAllowedPerYear { get; set; }

        [Column(Name = "federal_tax_withheld")]
        public double FederalTaxPercent { get; set; }
        [Column(Name = "federal_tax_percent")]
        public double FederalTaxWithheld { get; set; }

        [Column(Name = "state_tax_withheld")]
        public double StateTaxPercent { get; set; }
        [Column(Name = "state_tax_percent")]
        public double StateTaxWithheld { get; set; }

        [Column(Name = "medicare_tax_withheld")]
        public double MedicareTaxPercent { get; set; }
        [Column(Name = "medicare_tax_percent")]
        public double MedicareTaxWithheld { get; set; }

        [Column(Name = "social_security_tax_withheld")]
        public double SocialSecurityTaxPercent { get; set; }
        [Column(Name = "social_security_tax_percent")]
        public double SocialSecurityTaxWithheld { get; set; }
    }
}
