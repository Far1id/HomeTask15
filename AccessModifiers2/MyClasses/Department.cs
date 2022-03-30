using System;
using System.Collections.Generic;
using System.Text;

namespace MyClasses
{
    public class Department
    {
        public string Name;
        public int EmployeeLimit;
        private int _salaryLimit;
        public Employee[] employees = new Employee[0];

        public int SalaryLimit
        {
            get => _salaryLimit; 
            set
            {
                if (value <= 250)
                    _salaryLimit = value;
            }
        }       
        public void AddEmployee(Employee employee)
        {
            if (employees.Length < EmployeeLimit)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;
                Console.WriteLine(employee.Name + " " + employee.Surname);
            }
            else
                Console.WriteLine("Ishci limiti dolub.");
        }

    }
}
