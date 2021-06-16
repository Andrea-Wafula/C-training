using Classes.Nation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.WatuPekeyake
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public DateTime BirthDate;

        public void Eat()
        {

        }

        public void Sleep()
        {

        }

        public void Talk()
        {
            Console.WriteLine("My age is " + Age);
            Console.WriteLine("My name is " + FirstName);
        }     

    }
}
