using System;
using System.Collections.Generic;

namespace Aula_4___Exercicio_4 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos funcionáros serão cadastrados? ");
            int qtd = int.Parse(Console.ReadLine());

            List<Funcionario> f = new List<Funcionario>();

            for (int i = 0; i < qtd; i++) {
                Console.WriteLine("\r\n" + "Dados do " + (i+1) + "º funcionário: ");
                Console.Write("CPF: ");
                int cpf = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                f.Add(new Funcionario(cpf, nome, salario)); 
            }

            Console.Write("\r\n" + "Digite o CPF do funcionário que receberá aumento: ");
            int cpf1 = int.Parse(Console.ReadLine());
            int index = f.FindIndex(x => x.CPF == cpf1);

            Console.Write("Digite a porcentagem de aumento: ");
            f[index].AumentaSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine("\r\n" + "Listagem atualizada de funcionários: ");
            for (int i = 0; i < f.Count; i++) {
                Console.WriteLine(f[i]);
            }

            Console.ReadLine();
        }
    }
}
