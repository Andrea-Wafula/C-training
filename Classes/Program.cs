using Classes.Nation;
using Classes.WatuPekeyake;
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person andrea = new Person();

            int myNumber = 5;

            andrea.FirstName = "Andrea";
            andrea.LastName = "Wafula";
            andrea.Age = 21;

            andrea.Talk();

            County mombasa = new County();
            mombasa.countyName = "Coasto";
            mombasa.countyNumber = 001;
            mombasa.population = 2000000;

        }
    }
}
