using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Employee
    {
        public Employee() { }
        public Employee(string name, string surname, string ocupation, int experience, double taxes, double amount)
        {
            Name = name;
            Surname = surname;
            Ocupation = ocupation;
            Experience = experience;
            Taxes = taxes;
            Amount = amount;
        }

        public int Experience { get { return Experience; } set { Experience = value; } }
        public string Name { get { return Name; } set { Name = value; } }
        public string Surname { get { return Surname; } set { Surname = value; } }
        public string Ocupation { get { return Ocupation; } set { Ocupation = value; } }
        public double Taxes { get { return Taxes; } set { Taxes = value; } }
        public double Amount { get { return Amount; } set { Amount = value; } }

        public double CalculatorProg()
        {
            return Amount * Experience * (1 - Taxes);
        }

        public void Info()
        {
            Console.WriteLine("Name and surname: {0} {1}", Name, Surname);
            Console.WriteLine("Ocupation: {0}", Ocupation);
            Console.WriteLine("Experience: {0}", Experience);
            Console.WriteLine("An amount: {0}", CalculatorProg());
        }
    }
}
