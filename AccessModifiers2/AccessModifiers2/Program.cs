using System;
using MyClasses;


namespace AccessModifiers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            department.EmployeeLimit = 1;
            Employee employee = new Employee
            {
               Name = "Ferid",
               Surname = "Cahangirli"
            };
            department.AddEmployee(employee);
            Employee employee1 = new Employee
            {
                Name = "Hikmet",
                Surname = "Abbasov"
            };
            department.AddEmployee(employee1);

        }
    }
}
