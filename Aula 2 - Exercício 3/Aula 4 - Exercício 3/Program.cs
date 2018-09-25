using System;

namespace Aula_4___Exercício_3 {
    class Program {
        static void Main(string[] args) {
            PortaRetrato p;

            Console.Write("Altura da porta-retrato: ");
            int altura = int.Parse(Console.ReadLine());
            Console.Write("Largura da porta-retrato: ");
            int largura = int.Parse(Console.ReadLine());

            p = new PortaRetrato(altura, largura);

            Console.Write("Altura do foto: ");
            altura = int.Parse(Console.ReadLine());
            Console.Write("Largura do foto: ");
            largura = int.Parse(Console.ReadLine());


            if (p.cabeRetrato(altura, largura))
                Console.WriteLine("SIM");
            else
                Console.WriteLine("NÃO");

            Console.ReadLine();
        }
    }
}
