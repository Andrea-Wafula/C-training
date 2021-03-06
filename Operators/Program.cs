using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arithmentic Operators include Addition + ,Subtraction -, Multiplication *, Division /, Remainder %

            //Types of Increments
            //Prefix Increments 
            int a = 1;
            int b = ++a;
            Console.WriteLine(b);

            //Postfix Increments
            int c = 1;
            int d = c++;
            Console.WriteLine(d);

            // Comparison Operators include Equal to ==, Not Equal to !==, Greater Than >, Less Than <, Greater Than or Equal To >=,
            // Less Than or Equal To <=.

            // Assignment Operators include Assignment =, Additional Assignment +=, Subtraction Assignment -=, Division Assignment /=,
            // Multiplication Assignment *=

            int e = 1;
            int f = e += 3;
            int g = e -= 3;
            int h = e *= 3;
            int i = e /= 3;

            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);

            // Logical Operators include And &&, Or ||, Not !

            Console.WriteLine(a > c && c > e);
            Console.WriteLine(!(a > c || c > e));
            Console.WriteLine(a > c || c == a);
        

            // Bitwise Operators include And &, Or |



        }
    }
}
