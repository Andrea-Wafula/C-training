using System;
using System.IO;

namespace FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = (@"c:\somefile.jpg");
            File.Copy(@"c:\temp\myfiles.jpg", @"d:\temp\myfiles.jpg", true);
            File.Delete(path);

            if (File.Exists(path))
            {
                //
            }

            var content = File.ReadAllText(path);
            var contents = File.ReadAllBytes(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                //
            }
        }
    }
}
