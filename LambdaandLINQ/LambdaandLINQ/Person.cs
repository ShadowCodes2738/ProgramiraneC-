using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaandLINQ
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Person(int age, string name, double salary)
        {
            this.Age = age;
            this.Name = name;
            this.Salary = salary;
        }
        public override string ToString()
        {
            return $"{Age} , {Name} , {Salary}";
        }
    }
}
