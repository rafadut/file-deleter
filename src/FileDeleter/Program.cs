using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDeleter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string txtFilePath = Path.Combine(Directory.GetCurrentDirectory(), "arquivos_para_excluir.txt");
            Console.WriteLine("Caminho completo da pasta 'INFRA V1.0.0':");

            string applicationPath = Console.ReadLine();
            var lines = File.ReadLines(txtFilePath);
            foreach (string line in lines)
            {
                string fileToExcludePath = applicationPath + line;
                if (File.Exists(fileToExcludePath))
                {
                    File.Delete(applicationPath + line);
                }
            }
        }
    }
}
