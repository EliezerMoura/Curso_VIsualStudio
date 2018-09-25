using System;
using System.Collections.Generic;
using Aula_4___Proposta_1.dominio;

namespace Aula_4___Proposta_1 {
    class Program {
        public static List<Artista> lArtistas = new List<Artista>();
        public static List<Filme> lFilmes = new List<Filme>();

        static void Main(string[] args) {
            int opcao = 0;

            lArtistas.Add(new Artista(101, "Scarlett Johansson", 4000000));
            lArtistas.Add(new Artista(102, "Chris Evans", 2500000));
            lArtistas.Add(new Artista(103, "Robert Downey Jr.", 3000000));
            lArtistas.Add(new Artista(104, "Morgan Freeman", 4000000));
            lArtistas.Sort();

            while (opcao < 5) {
                try {
                    opcao = Tela.MostraMenu();
                }
                catch (Exception e) {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                }
                Console.WriteLine("\n");

                if (opcao == 1) {
                    Tela.MostrarArtistas();
                }
                else if (opcao == 2) {
                    try {
                        Tela.CadastrarArtista();
                    }
                    catch (AulaException e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 3) {
                    try {
                        Tela.CadastrarFilme();
                    }
                    catch (AulaException e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 4) {
                    Tela.MostrarDadosFilme();
                }
            }
        }
    }
}
