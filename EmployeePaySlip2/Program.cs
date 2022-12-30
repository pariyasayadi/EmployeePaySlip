using EmployeePaySlip2.Controllers;
using EmployeePaySlip2.Interfaces;
using EmployeePaySlip2.Models;
using System.Globalization;

class Program
{
    private readonly ISalaryIncrease salaryIncrease;
    public Program(ISalaryIncrease salaryIncrease)
    {
        this.salaryIncrease = salaryIncrease;
    }
    static void Main(string[] args)
    {
        bool endApp = false;
        // Display title as the C# console calculator app.
        Console.WriteLine("Internal system of employees and manager\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {
            // Declare variables and set to empty.
            string numInput1 = "";
            string numInput2 = "";
            string result = "";
            Employee employee = new Employee();
            Manager manager = new Manager();

            // Ask the user to choose an operator.
            Console.WriteLine("Please select your role from the following list:");
            Console.WriteLine("\tA - Employee");
            Console.WriteLine("\tB - Manager");
            Console.Write("Your option? ");

            string op = Console.ReadLine();
            try
            {
                if (op == "A")
                {
                    employee = DepartmentEmployee.DoOperation();
                    Console.WriteLine("Your Pay Slip: {0:0.##}\n"
                        + "Name:" + employee.Name
                        + "\nfamily:" + employee.Family
                        + "\nSalary:" + employee.Salary
                        + "\nphoneNumber:" + employee.phoneNumber
                        + "\nEmployeeHiringTime:" + employee.EmployeeHiringTime
                        + "\nIsHire:" + employee.IsHire);
                }
                if (op == "B")
                {
                    Console.WriteLine("Please select your action from the following list:");
                    Console.WriteLine("\tA - View an employee's pay slip ");
                    Console.WriteLine("\tB - Increasing the salary of an employee ");
                    Console.WriteLine("\tC - Firing or hiring an employee ");
                    Console.Write("Your option? ");
                    string opM = Console.ReadLine();
                    if (opM == "A")
                    {
                        Console.WriteLine("Please enter the name of the employee:");
                        string nameEmployee = Console.ReadLine();
                        employee = DepartmentManager.ViewPaySlipAnEmployee(nameEmployee);
                        Console.WriteLine("Your Pay Slip: {0:0.##}\n"
                             + "Name:" + employee.Name
                             + "\nfamily:" + employee.Family
                             + "\nSalary:" + employee.Salary
                             + "\nphoneNumber:" + employee.phoneNumber
                             + "\nEmployeeHiringTime:" + employee.EmployeeHiringTime
                             + "\nIsHire:" + employee.IsHire);
                    }
                    if (opM == "B")
                    {
                        Console.WriteLine("Please enter the name of the employee:");
                        string nameEmployee = Console.ReadLine();
                        Console.WriteLine("Please enter the employee's salary increase:");
                        string salaryEmployee = Console.ReadLine();
                        employee = DepartmentManager.SalaryIncrease(nameEmployee, int.Parse(salaryEmployee, NumberStyles.AllowCurrencySymbol));
                        Console.WriteLine("Your Pay Slip: {0:0.##}\n"
                              + "Name:" + employee.Name
                              + "\nfamily:" + employee.Family
                              + "\nSalary:" + employee.Salary
                              + "\nphoneNumber:" + employee.phoneNumber
                              + "\nEmployeeHiringTime:" + employee.EmployeeHiringTime
                              + "\nIsHire:" + employee.IsHire);
                    }
                    if (opM == "C")
                    { 
                        bool isHire = false;
                        Console.WriteLine("Please enter the name of the employee:");
                        string nameEmployee = Console.ReadLine();
                        Console.WriteLine("Do you want to fire the employee?");
                        Console.WriteLine("\tA - Yes");
                        Console.WriteLine("\tB - No");
                        string answer = Console.ReadLine();
                        if (answer == "A")
                        {
                            isHire = false;
                        }else if (answer == "B")
                        {
                            isHire = true;
                        }
                        employee = DepartmentManager.RecruitmentManagement(nameEmployee, isHire);
                        Console.WriteLine("Your Pay Slip: {0:0.##}\n"
                              + "Name:" + employee.Name
                              + "\nfamily:" + employee.Family
                              + "\nSalary:" + employee.Salary
                              + "\nphoneNumber:" + employee.phoneNumber
                              + "\nEmployeeHiringTime:" + employee.EmployeeHiringTime
                              + "\nIsHire:" + employee.IsHire);
                    }
                }



            }
            catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
            }

            Console.WriteLine("------------------------\n");

            // Wait for the user to respond before closing.
            Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n"); // Friendly linespacing.
        }
        return;
    }
}
class DepartmentEmployee
{
    public static Employee DoOperation()
    {
        Employee employee = new Employee();
        employee = Department.EmployeePaySlip();
        return employee;
    }
}
class DepartmentManager
{
    public static Employee ViewPaySlipAnEmployee(string name)
    {
        Employee employee = new Employee();
        employee = Department.ViewPaySlip(name);
        return employee;
    }
    public static Employee SalaryIncrease(string name ,int salary)
    {
        Employee employee = new Employee();
        employee = Department.SalaryIncrease(name ,salary);
        return employee;
    }
    public static Employee RecruitmentManagement(string name ,bool isHire)
    {
        Employee employee = new Employee();
        employee = Department.RecruitmentManagement(name , isHire);
        return employee;
    }

}
