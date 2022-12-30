using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePaySlip2.Models
{
    public class Employee:Person
    {
        public bool IsHire { get; set; }
        public int Salary { get; set; }
        public DateTime EmployeeHiringTime { get; set; }
    }
}
