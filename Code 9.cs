using System.IO;
using System;
namespace Day_2
{
        class Employee
        {
            public int EmployeeID { get; set; }
            public string Name { get; set; }
        }
        class Class8
        {
            static void Main()
            {
                Employee emp = new Employee();
                emp.EmployeeID = 101;
                emp.Name = "Dummy1";
                Employee emp2 = new Employee();
                emp.EmployeeID = 102;
                emp.Name = "Dummy2";
                Console.WriteLine(emp.Equals(emp2));
                Console.WriteLine(Equals(emp, emp2));
                Console.ReadLine();
            }
        }
}
