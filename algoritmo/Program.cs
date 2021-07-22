using System;

namespace algoritmo
{
    class Program
    {
        static void Main(string[] args)
        {
            Valores valor = new Valores();
            Console.WriteLine("Qual seu nome?");
            valor.Nome = Console.ReadLine();
            Console.WriteLine("Qual sua idade?");
            valor.Idade = int.Parse(Console.ReadLine());
            if (valor.Idade < 18)
            {
                Console.WriteLine("Qual o nome da sua mãe?");
                valor.Mae = Console.ReadLine();
                Console.WriteLine("nome: {0}, idade: {1}, nome da mae: {2}", valor.Nome, valor.Idade, valor.Mae);
            }
            else
            {
                Console.WriteLine("nome: {0}, idade: {1}", valor.Nome, valor.Idade);
            }
            Console.ReadKey();

        }
    }
}
