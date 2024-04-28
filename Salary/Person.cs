using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
            }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Person(string name1, string nam2, int age, double sal)
        {
            this.FirstName = name1;
            this.LastName = nam2;
            this.Age = age;
            this.Salary = sal;
        }

        public string ToString(double percent)
        {
            if (this.age > 30)
            {
                this.salary += this.salary * percent / 100;
            }
            else
            {
                this.salary += this.salary * percent / 200;
            }
            return $"{this.FirstName} {this.LastName} gets {this.Salary:f2} leva";
        }
    }
}
