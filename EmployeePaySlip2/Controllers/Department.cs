using EmployeePaySlip2.Interfaces;
using EmployeePaySlip2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePaySlip2.Controllers
{
    public class Department
    {
        private readonly ISalaryIncrease salaryIncrease;
        public Department(ISalaryIncrease salaryIncrease)
        {
            this.salaryIncrease = salaryIncrease;
        }
        public static Employee EmployeePaySlip()
        {
            Employee employee = new Employee();
            employee.Name = "test name";
            employee.Family = "test family";
            employee.phoneNumber = "09123654789";
            employee.IsHire= true;
            employee.Salary = 5500;
            employee.EmployeeHiringTime = DateTime.Now.AddDays(-30);
            return employee;
        }

        public static Employee ViewPaySlip(string name)
        {
            Employee employee = new Employee();
            employee.Name = name;
            employee.Family = "test family";
            employee.phoneNumber = "09123654789";
            employee.IsHire = true;
            employee.Salary = 5500;
            employee.EmployeeHiringTime = DateTime.Now.AddDays(-30);
            return employee;
        }

        public static Employee SalaryIncrease(string name ,int salary)
        {
            Employee employee = new Employee();
            employee.Name = name;
            employee.Family = "test family";
            employee.phoneNumber = "09123654789";
            employee.IsHire = true;
            employee.Salary = 5500 + salary;
            employee.EmployeeHiringTime = DateTime.Now.AddDays(-30);
            return employee;
        }
        public static Employee RecruitmentManagement(string name,bool isHire)
        {
            Employee employee = new Employee();
            employee.Name = name;
            employee.Family = "test family";
            employee.phoneNumber = "09123654789";
            employee.IsHire = isHire;
            employee.Salary = 5500;
            employee.EmployeeHiringTime = DateTime.Now.AddDays(-30);
            return employee;
        }
    }
}
