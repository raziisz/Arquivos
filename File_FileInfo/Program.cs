using System;
using System.Collections.Generic;
using System.IO;

namespace File_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
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
            */

            /*string path = @"c:\Projetos\file1.txt";
           
            StreamReader sr = null;

            try
            {

                sr = File.OpenText(path);
                while(!sr.EndOfStream){
                    string line = sr.ReadLine();
                    Console.WriteLine(line);

                }
            } catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }

            finally
            {
                if (sr != null) sr.Close();
                
            }
            */

            /*string sourcePath = @"c:\Projetos\file1.txt";
            string targetPath = @"c:\Projetos\file2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using(StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

                using(StreamReader sr = File.OpenText(targetPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

                

               

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            } */

            string path = @"c:\Projetos\myfolder";

            try
            {
                IEnumerable<string> folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\newfolder");

            } catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }


        }
    }
}
