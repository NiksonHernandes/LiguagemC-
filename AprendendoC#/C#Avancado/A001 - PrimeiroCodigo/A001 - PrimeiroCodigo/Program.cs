using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A001___PrimeiroCodigo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tipos de variáveis: 
            //Int, Float, Bool, String e Char

            String entrada = "Hello World!";
           
            Console.Write(entrada + "\n"); //mostra os valores, mas sem quebra de linha
            Console.WriteLine("Meu nome é Nikson"); //mostra os valores com quebra de linha

            //alterar valor da variável: 

            entrada = "Troquei o valor da variável ";
            Console.Write(entrada + "\n");


            Console.ReadLine(); //entrada de dados
        }
    }
}
