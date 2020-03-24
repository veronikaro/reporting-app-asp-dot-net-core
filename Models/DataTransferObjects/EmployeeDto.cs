using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingAppServer.Models.DataTransferObjects
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }

        public string Country { get; set; }

        public string Gender { get; set; }

        public string Department { get; set; }
        public DateTime EmploymentStart { get; set; }

        public string JobTitle { get; set; }

        public int OvertimeHours { get; set; }
        public string FullName { get; set; }
        public decimal MonthSalary { get; set; }
    }
}
