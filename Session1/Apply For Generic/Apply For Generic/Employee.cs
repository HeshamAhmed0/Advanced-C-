using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Generic
{
    internal class Employee
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


        public override bool Equals(object? obj)
        {
            Employee? employee = (Employee?)obj ;
            if(employee is not null)
            {
                return this.Name==employee.Name && this.Salary==employee.Salary && this.Id==employee.Id;
            }
            else
            {
                return false;
            }
        }


        public override int GetHashCode()
        {
            //return this.Id.GetHashCode() +( this.Name?.GetHashCode()??0) + this.Salary.GetHashCode();
            return HashCode.Combine(Id, Name, Salary);
        }





        //public static bool operator ==(Employee left, Employee right)
        //{
        //    return left.Id==right.Id && left.Name ==right.Name &&left.Salary==right.Salary;
        //}
        //public static bool operator !=(Employee left, Employee right)
        //{
        //    return left.Id != right.Id || left.Name != right.Name || left.Salary != right.Salary;
        //}
    }
}
