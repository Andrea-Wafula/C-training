﻿using System;

namespace referenceTypesAndValueTypes
{
    public class Person
    {
        public int Age;

    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine("The value of a and b is: {0}, {1}", a, b);
            //OR
            Console.WriteLine(string.Format("a:{0}, b:{1}", a, b));

            int[] array1 = new int[3] { 1, 2, 3 };
            int[] array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0} ,array[2]: {1}", array1[0], array2[0]));


            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
        }
        
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}