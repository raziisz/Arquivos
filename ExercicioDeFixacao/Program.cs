using System;
using System.Globalization;
using System.IO;

namespace ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Entre com o caminho do arquivo: ");
            string file = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(file);

                string sourceFolderPath = Path.GetDirectoryName(file);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (var line in lines)
                    {
                        string[] saida = line.Split(',');
                        string name = saida[0];
                        double valor = double.Parse(saida[1], CultureInfo.InvariantCulture);
                        int qtd = int.Parse(saida[2]);

                        Product pro = new Product(name, valor, qtd);


                        sw.WriteLine(pro.Nome + ", " + pro.Total().ToString("F2",CultureInfo.InvariantCulture));

                    }
                }

                using (StreamReader sr = File.OpenText(targetFilePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string linha = sr.ReadLine();
                        Console.WriteLine(linha);
                    }
                }
                
            }catch (IOException e)
            {
                Console.WriteLine("Houve um erro");
                Console.WriteLine(e.Message);


            }
        }
    }
}
