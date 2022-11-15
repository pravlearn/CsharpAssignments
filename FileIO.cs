using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;



namespace assignment5
{
    class directory
    {
        static void Main(string[] args)
        {
            string path;
            string root = @"C:\ Temp";
            string subdir = @"C:\Temp\Pravallika";
            Directory.CreateDirectory(root);
            Directory.CreateDirectory(subdir);
            path = "C:\\Temp\\Pravallika";
            try
            {
                File.ReadAllText(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }






        }
    }



}
