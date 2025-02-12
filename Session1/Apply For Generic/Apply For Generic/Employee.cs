using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Generic
{
    internal struct Employee
    {
        public Employee(int id, string? name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public decimal Salary { get; set; }

        public static bool operator ==(Employee left, Employee right)
        {
            return left.Id==right.Id && left.Name ==right.Name &&left.Salary==right.Salary;
        }
        public static bool operator !=(Employee left, Employee right)
        {
            return left.Id != right.Id || left.Name != right.Name || left.Salary != right.Salary;
        }
    }
}
