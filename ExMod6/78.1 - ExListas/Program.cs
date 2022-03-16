using System;
using System.Globalization;
using System.Collections.Generic;

namespace _78._1___ExListas {
    class Program {
        static void Main(string[] args) {

            int n, searchId;
            double percentege;
            List<Employee> list = new List<Employee>();
            
            Console.Write("How many employees will be registred? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                int id;
                double sal;
                string name;

                Console.WriteLine($"\nEmployee #{i + 1}:");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                sal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                list.Add(new Employee(name, id, sal));
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);

            if (emp != null) {
                Console.Write("Enter the percentege: ");
                percentege = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentege);
            }
            else {
                Console.WriteLine("This Id does not exist!");
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Updated list of employees:");
            foreach(Employee obj in list) {
                Console.WriteLine(obj);
            }


        }
    }
}
