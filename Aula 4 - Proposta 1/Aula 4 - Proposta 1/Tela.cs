using System;
using Aula_4___Proposta_1.dominio;

namespace Aula_4___Proposta_1 {
    class Tela {

        public static int MostraMenu() {
            Console.Clear();

            Console.WriteLine("  1 – Listar artistas ordenadamente \n" +
                "  2 – Cadastrar artista \n" +
                "  3 – Cadastrar filme \n" +
                "  4 – Mostrar dados de um filme \n" +
                "  5 – Sair \n");

            Console.Write("Digite uma opção: ");
            return int.Parse(Console.ReadLine());
        }

        public static void CadastrarArtista() {
            Console.WriteLine("Digite os dados do artista: \n");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Valor do cachê: ");
            double cache = double.Parse(Console.ReadLine());

            Program.lArtistas.Add(new Artista(codigo, nome, cache));
            Program.lArtistas.Sort();
        }

        public static void CadastrarFilme() {
            Console.WriteLine("Digite os dados do filme:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Filme F = new Filme(codigo, titulo, ano);

            Console.Write("Quantas participações tem o filme? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++) {
                Console.WriteLine("Digite os dados da " + (i + 1) + "ª participação: ");
                Console.Write("Artista(código): ");
                int codigoArtista = int.Parse(Console.ReadLine());

                int index = Program.lArtistas.FindIndex(x => x.Codigo == codigoArtista);
                if (index < 0) {
                    throw new AulaException("Artista não cadastrado com este código: " + codigoArtista);
                    i = i - 1;
                }

                Console.Write("Desconto: ");
                double desconto = double.Parse(Console.ReadLine());

                F.participacoes.Add(new Participacao(Program.lArtistas[index], desconto, F));

            }

            Program.lFilmes.Add(F);
        }

        public static void MostrarArtistas() {
            Console.WriteLine("LISTA DE ARTISTAS:");

            for (int i = 0; i < Program.lArtistas.Count; i++)
                Console.WriteLine(Program.lArtistas[i]);

            Console.ReadLine();
        }

        public static void MostrarDadosFilme() {
            Console.Write("Digite o código do filme: ");
            int codF = int.Parse(Console.ReadLine());
            int index = Program.lFilmes.FindIndex(x => x.Codigo == codF);

            if (index < 0)
                throw new AulaException("Não existe filme cadastrado com este código: " + codF);

            Console.WriteLine("Filme " + Program.lFilmes[index]);
            Console.ReadLine();
        }
    }
}

