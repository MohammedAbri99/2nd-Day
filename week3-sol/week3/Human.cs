using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class Human
    {
        int id;
        string name;
        int age ;
        string address;
        string email;

        public int ID
        {
            get { return age; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        public string Address
        {
            set { address = value; }
            get { return address; }
        }
        public string Email
        {
            set { email = value; }
            get { return email;  }
        }
        public Human(string name, int age, string address, string email)
        {
            id += 1;
            this.name = name;
            this.age = age;
            this.address = address;
            this.email = email;
        }
        public void displayInformaton()
        {
            Console.WriteLine(
                $"Hello {this.name}\n" +
                $"your eamil is {this.email}\n" +
                $"you are from {this.address}\n" +
                $"youare {this.age} old"
                );
        }

    }
}
