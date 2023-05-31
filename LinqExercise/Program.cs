using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            Console.WriteLine($"The sum is {numbers.Sum()}");

            Console.WriteLine($"The average is {numbers.Average()}");
            Console.WriteLine("======================");

            Console.WriteLine("Numbers ascending:");
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("======================");

            Console.WriteLine("Numbers descending:");
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("======================");

            Console.WriteLine("Numbers greater than 6:");
            numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("======================");

            Console.WriteLine("4 Numbers ascending:");
            numbers.OrderBy(x => x).Take(4).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("======================");

            Console.WriteLine("Value of index 4 changed and descending:");
            numbers[4] = 33;
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("======================");

            Console.WriteLine("Employee Section");
            var employees = CreateEmployees();
            Console.WriteLine("======================");

            Console.WriteLine("Employees full names beginning with 'C' or 'S':");
            employees.Where(x => (x.FirstName.StartsWith("S")) || (x.FirstName.StartsWith("C"))).OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine("======================");

            Console.WriteLine("Employees over 26 full names and age, sorted by age then first name:");
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine($"{x.FullName} | {x.Age}"));
            Console.WriteLine("======================");

            Console.WriteLine("The Sum of the employees' years of experience if their years of experience is less than or equal to 10 and their age is greater than 35:");
            Console.WriteLine($"{employees.Where(x => (x.YearsOfExperience <= 10) && (x.Age > 35)).Sum(x => x.YearsOfExperience)}");
            Console.WriteLine("======================");

            Console.WriteLine("The Average of the employees' years of experience if their years of experience is less than or equal to 10 and their age is greater than 35:");
            Console.WriteLine($"{employees.Where(x => (x.YearsOfExperience <= 10) && (x.Age > 35)).Average(x => x.YearsOfExperience)}");
            Console.WriteLine("======================");

            Console.WriteLine("Adding a new employee to the end of the list:");
            var seth = new Employee("Seth", "Bowman", 29, 3);
            employees.Append(seth).ToList().ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine("======================");

            Console.ReadLine();

            Console.WriteLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
