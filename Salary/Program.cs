using System.Collections.Generic;
using System;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            try
            {
                for (int i = 0; i < lines; i++)
                {
                    string[] cmdArgs = Console.ReadLine().Split();
                    Person person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), double.Parse(cmdArgs[3]));
                    persons.Add(person);
                }
            }
            catch
            {
                Console.WriteLine("Insufficent data, make sure you provide first name, last name, age and salary in that order");
                return;
            }
            double bonus = double.Parse(Console.ReadLine());
            persons.ForEach(p => Console.WriteLine(p.ToString(bonus)));
        }
    }
}
