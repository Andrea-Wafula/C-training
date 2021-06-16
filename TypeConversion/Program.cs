using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
// The value of (int i) truncates in the value of (byte b) (Data Loss)---
        {
            int i = 1000;
            byte b = (byte)i;
            Console.WriteLine(b);
        

            string number = "1234";
            int j = (int) 1234;
            int k = Convert.ToInt32(number);
            Console.WriteLine(j);
            Console.WriteLine(k);

//Error Block     byte c = Convert.ToByte(number);
//Error Block     Console.WriteLine(c);

// Using the Try-Catch block to undo the error above; converting (string number) into (byte c) by typing the keyword "Try" and Tab twice. 

            try
            {
                byte c = Convert.ToByte(number);
                Console.WriteLine(c);
            }
            catch (Exception)
            {

                Console.WriteLine("The number could not be converted to a byte");
            }

            string str = "True";
            bool d = Convert.ToBoolean(str);
            Console.WriteLine(d);

        }
        

    }
}
