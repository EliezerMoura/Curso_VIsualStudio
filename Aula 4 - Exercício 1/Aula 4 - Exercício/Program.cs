using System;
using System.Globalization;

namespace Aula_4___Exercício {
    class Program {
        static void Main(string[] args) {
            ContaBancaria c;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            var nome = Console.ReadLine();

            Console.Write("Haverá deposito inicial (s/n)? ");
            if (Console.ReadLine() == "s") {
                Console.Write("Digite o valor do depósito inicial: ");
                var deposito = double.Parse(Console.ReadLine());

                c = new ContaBancaria(numero, nome, deposito);
            } else {
                c = new ContaBancaria(numero, nome);
            }

            Console.WriteLine("\r\n" + "Conta Criada: " + "\r\n" + c + "\r\n");
            Console.Write("Digite um valor para depósito: ");
            c.Depositar(double.Parse(Console.ReadLine()));
            Console.WriteLine("\r\n" + "Conta Atualizada: " + "\r\n" + c + "\r\n");
            
            Console.Write("Digite um valor para saque: ");
            c.Sacar(double.Parse(Console.ReadLine()));
            Console.WriteLine("\r\n" + "Conta Atualizada: \r\n" + c + "\r\n");

            Console.ReadLine();
        }
    }
}
