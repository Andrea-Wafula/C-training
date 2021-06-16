using System;

namespace Enums
{

    public enum ShippingMethods
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Converting Enum (ShippingMethods.Express) into an int
            var method = ShippingMethods.Express;
            Console.WriteLine((int)method);

            //Creating (methodId) & converting into enum ShippingMethods
            var methodId = 3;
            Console.WriteLine((ShippingMethods)methodId);

            //Converting method (ShippingMethods.Express) into a string
            Console.WriteLine(method);
            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethods) Enum.Parse(typeof(ShippingMethods), methodName);
        }
    }
}
