using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee inform = new Employee();
            inform.Name = "Vladyslav";
            inform.Surname = "Zakharchenko";
            inform.Ocupation = "senior developer";
            inform.Experience = 5;
            inform.Amount = 3000;
            inform.Taxes = 0.3;
            
            inform.Info();
        }
    }
}
