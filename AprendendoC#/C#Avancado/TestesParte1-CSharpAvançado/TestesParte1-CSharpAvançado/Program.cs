using System;

namespace TestesParte1_CSharpAvançado
{
    class Program
    {
        /*class Aluno
        {
            public static string Nome;
            public static int Nota;
            public static int Serie;

            public Aluno(string nome, int nota, int serie)
            {
                Nome = nome;
                Nota = nota;
                Serie = serie;
            }

            public static string Retorno()
            {
                return string.Format($"O aluno {Nome} obteve a nota {Nota} e esta na {Serie} ano");
            }

        }

        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Nikson", 10, 3);
            var retorna = Aluno.Retorno();
            Console.WriteLine(retorna);
            

            Console.ReadLine();
        }*/

        public static void Metodo(out int Valor)
        {
            Valor = 10;
            Console.WriteLine("Valor = " + Valor);
        }

        static void Main(string[] args)
        {

            int Valor1 = 20;
            Metodo(out Valor1);
            

            Console.WriteLine("Valor = " + Valor1);



            Console.ReadLine();
        }
    }
}
