using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string arquivo = "teste.txt";
            string path = Path.Combine(pasta, arquivo);

            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine("escrevendo no arquivo de texto...");
            writer.WriteLine("outra linha...");
            writer.Close();

            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                string linha = reader.ReadLine();
                Console.WriteLine(linha);
            }
            Console.ReadLine();

        }
    }
}
