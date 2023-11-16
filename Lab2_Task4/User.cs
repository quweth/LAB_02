using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class User
    {
        string login; 
        string name;
        string surname;
        int age;
        public readonly DateTime date;
        public string Login
        {
            set { login = value; }
            get { return login; }
        }
        public string Name
        {
            set { name = value; }
            get { return name;}
        }
        public string Surname
        {
            set { surname = value; }
            get { return surname;}
        }
        public int Age
        {
            set { age = value; }
            get { return age;}
        }
        public User()
        {
            date = DateTime.Now;
        }
        public User(string login, string name, string surname, int age)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            date = DateTime.Now;
        }
    }
}
