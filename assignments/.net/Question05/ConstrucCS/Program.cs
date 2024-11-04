using System;
namespace ConstrucCS
{
    class Employee
    {
        public int empId;
        public string name;

        public Employee()
        {
            empId = 101;
            name = "John Doe";
            Console.WriteLine("The Default constructor is called");
            Console.WriteLine("Employee ID is {0} and Employee Name is {1}.", empId, name);
        }

        public Employee(int i, string n)
        {
            Console.WriteLine("\nThe Parameterized constructor is called");
            Console.WriteLine("Employee ID is {0} and Employee Name is {1}.", i, n);
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee(202, "Jane Doe");
            Console.ReadKey();
        }
    }
}