using System;
using System.Text.RegularExpressions;

namespace FilePathParse
{
    class Program
    {
        static void Main()
        {
            string path = @"c:\WebServers\home\testsite\www\myfile.txt";
            string fileName = Regex.Match(path, @"\w+\.").Value[..^1];
            string rootFolderName = Regex.Match(path, @":\\\w+").Value[2..];

            Console.WriteLine($"file name: {fileName}");
            Console.WriteLine($"root folder: {rootFolderName}");

            Console.Read();
        }
    }
}
