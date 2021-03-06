using System;
using System.IO;

namespace DirectoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Example
            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"D:\MyRepos\CodeWithMoshTraining\CSharpTraining", "*.sln", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            //Second Example
            var directories = Directory.GetDirectories(@$"D:\MyRepos\CodeWithMoshTraining\CSharpTraining\WorkingWthFiles", "*.*", 
                SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("....");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
