using System;

namespace EntradaDadosExercicio{
    class Program{
        static void Main(string[] args) {

            Console.WriteLine("Escreva seu nome completo");
            string[] nome = Console.ReadLine().Split(' ');
            Console.WriteLine("Quantos quartos tem sua casa?");
            int numQuartos = Console.Read();
            Console.WriteLine("Escreva o preco de um produto:");
            double precoProduto = Console.Read();
            Console.WriteLine("Escreva seu ultimo nome, idade e altura, na mesma linha:");
            string[] nomeAlturaIdade = Console.ReadLine().Split(' ');

            Console.WriteLine(nome[0] + " " + nome[1]);
            Console.WriteLine(numQuartos);
            Console.WriteLine(precoProduto);
            Console.WriteLine(nomeAlturaIdade[0] + " " + nomeAlturaIdade[1] + " " + nomeAlturaIdade[2]);
        }
    }
}