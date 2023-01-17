using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    public class Employeer
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employeer()
        {

        }
        public Employeer(int id, string name, double salary) : this()
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            var increase = (percentage / 100) + 1;
            var result = Salary * increase;
        }
    }
}
