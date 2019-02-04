﻿using System;
using System.IO;

namespace File_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string sourcePath = @"c:\Projetos\file1.txt";
            string targetPath = @"c:\Projetos\file2.txt";
            

            try{
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            } catch(IOException e)
            {
                Console.WriteLine("An error occrurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
