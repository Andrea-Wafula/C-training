using System;
using System.IO;

namespace Path
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\MyRepos\CodeWithMoshTraining\CSharpTraining\HelloWorld\HelloWorld.sln";

            var dotIndex = path.IndexOf(".");
            var extension = path.Substring(dotIndex);


            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File name: " + Path.GetFileName(path));
            Console.WriteLine("File name without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " Path.GetDirectoryName(path)); ;
        }
    }
}
