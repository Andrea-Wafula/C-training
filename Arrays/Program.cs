using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] world = new string[4];
            world[0] = "Mercury";
            world[1] = "Venus";
            world[2] = "Earth";
            world[3] = "Mars";

            Console.WriteLine(world[0]);



            int[] numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);



            bool[] flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);


            string[] names = new string[3] {"Jack","John","Mary"};
        }
        
    }
}
