using System;

namespace Aula_3___Exercício_2 {
    class Program {
        static void Main(string[] args) {

            Funcionario f;
            f = new Funcionario();

            Console.Write("Nome: ");
            f.nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.salarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Desconto: ");
            f.deconto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(f);
            Console.WriteLine();

            Console.Write("Aumentar salário em %: ");
            f.aumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.Write(f);
            Console.ReadLine();
        }
    }
}
