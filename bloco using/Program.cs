using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloco_using
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                string path = @"C:\Curso C\file01.txt";//recebendo arquivo do computador
                                                       //using (FileStream fs = new FileStream(path, FileMode.Open))// abrindo arquivo do computador na tela
            try
            {
                using (StreamReader sr = File.OpenText(path)) //fechando arquivo do computador
                {
                    //imprimindo na tela os dados do arquivo ate ultima linha
                    while (!sr.EndOfStream)
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }


                }
            }
            catch (IOException e)
            {

                Console.WriteLine("Erro apresentado ");
                Console.WriteLine(e.Message);
            }
            
            }
            
            
    }
}
