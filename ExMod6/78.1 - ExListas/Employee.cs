using System.Globalization;

namespace _78._1___ExListas {
    class Employee {

        public string Name { get; set; }
        public int Id { get; private set; }
        public double Salary { get; private set; }

        public Employee(string name, int id, double salary) {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public void IncreaseSalary(double percentege) {
            Salary += Salary * percentege / 100.0;
        }

        public override string ToString() {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
