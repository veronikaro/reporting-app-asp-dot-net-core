using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingAppServer.Models
{
    [Table("employee")]
    public class Employee
    {
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [Column("country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [Column("gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Department is required")]
        [Column("department")]
        public string Department { get; set; }

        [Column("employment_start")]
        public DateTime EmploymentStart { get; set; }

        [Required(ErrorMessage = "Job Title is required")]
        [Column("job_title")]
        public string JobTitle { get; set; }

        [Column("overtime_hours")]
        public int OvertimeHours { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        [Column("full_name")]
        public string FullName { get; set; }

        [Column("month_salary")]
        public decimal MonthSalary { get; set; }

    }
}
