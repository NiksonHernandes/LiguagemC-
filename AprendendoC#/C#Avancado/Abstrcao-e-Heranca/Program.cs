using System;

namespace Abstrcao_e_Heranca
{
    class Program
    {
        class Veiculo//classe base
        {
            public int rodas;
            public int velMax;
            private bool ligado;
            
            public void ligar()
            {
                ligado = true;
            }

            public void desligar()
            {
                ligado = false;
            }

            public string GetLigado()
            {
                if(ligado)
                {
                    return "Sim";
                }
                else
                {
                    return "Não";
                }
            }
        }

        class Carro:Veiculo //classe derivada
        {
            public string nome;
            public string cor;

            public Carro(string Nome, string Cor)
            {
                desligar();
                rodas = 4;
                velMax = 120;
                this.nome = Nome;
                this.cor = Cor;
            }

        }

        static void Main(string[] args)
        {
            Carro c1 = new Carro("Mustang", "Azul");

            Console.WriteLine("Cor: {0}", c1.cor);
            Console.WriteLine("Nome: {0}", c1.nome);
            Console.WriteLine("Rodas: {0}", c1.rodas);
            Console.WriteLine("Velocidade máxima: {0}", c1.velMax);
            Console.WriteLine("Ligado: {0}", c1.GetLigado());



            Console.ReadLine();
        }
    }
}
