using System;
using System.IO;
using System.Text;

namespace FileDeleter22
{
    class Program
    {
        static void Main(string[] args)
        {
            var defaultColor = Console.ForegroundColor;
            string txtFilePath = Path.Combine(Directory.GetCurrentDirectory(), "arquivos_para_excluir.txt");
            Console.WriteLine("Caminho completo da pasta 'INFRA V1.0.0':");

            Console.InputEncoding = Encoding.Unicode;
            string applicationPath = Console.ReadLine();

            int count = 0;

            var lines = File.ReadLines(txtFilePath);
            foreach (string line in lines)
            {
                string fileToExcludePath = applicationPath + line;
                if (File.Exists(fileToExcludePath))
                {
                    File.Delete(fileToExcludePath);
                    count++;
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Processamento concluído");
            sb.AppendLine("Quantidade de arquivos apagados: " + count);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(sb.ToString());
            Console.ForegroundColor = defaultColor;
            Environment.Exit(0);
        }
    }
}
