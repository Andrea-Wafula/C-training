using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Andrea";
            var lastName = "Wafula";

            var myName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName ,lastName);

            Console.WriteLine(myFullName);

            var names = new string[3] { "Jack ", " John", " Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = "Hi Andrew\nLook into the following paths\nc:\\folder1\\folder2\\folder3\nc:\\folder4\\folder5\\folder6";
            
            Console.WriteLine(text);


            var text1 = @"Hi Andrew
Look into the following paths
c:\folder1\folder2\folder3
c:\folder4\folder5\folder6";
            Console.WriteLine(text);

        }
    }
}
