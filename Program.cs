using System;
using System.Threading;

namespace Stopwatch
{
    public class Program
    {
        static void Main(String[] args)
        {
            Menu();
        }

        static void Menu()
        {   
            Console.Clear();
            Console.WriteLine("============== >> Menu do Cronômetro << ==============");
            Console.WriteLine("Segundos: 10s = 10 segundos.");
            Console.WriteLine("Minutos: 1m = 1 minuto.");
            Console.WriteLine("Pressione 0 para sair.");
            Console.WriteLine("Exemplo de como escolher: 10s | 10m");
            Console.WriteLine("Digite o estilo de tempo em segundos ou minutos: ");

            string dados = (Console.ReadLine() ?? " ").ToLower().Trim();

            if (dados == "0")
            {
                Console.WriteLine("Cronômetro encerrado!.");
                System.Environment.Exit(0);
            }

            if (dados.Length < 2)
            {
                Console.WriteLine("Entrada inválida. Tente novamente.");
                Thread.Sleep(2000);
                Menu();
                return;
            }

            char tipo = dados[^1];
            string numeroParte = dados.Substring(0, dados.Length - 1);

            if (!int.TryParse(numeroParte, out int tempo))
            {
                Console.WriteLine("Tempo inválido. Tente novamente.");
                Thread.Sleep(2000);
                Menu();
                return;
            }

            int multiplicador = 1;
            if (tipo == 'm')
            {
                multiplicador = 60;
            }
            else if (tipo != 's')
            {
                Console.WriteLine("Tipo inválido. Use 's' ou 'm'.");
                Thread.Sleep(2000);
                Menu();
                return;
            }

            PreStart(tempo * multiplicador);
        }

        static void PreStart(int tempo)
        {
            Console.Clear();
            Console.WriteLine("Pronto...");
            Thread.Sleep(1000);
            Console.WriteLine("Definindo...");
            Thread.Sleep(1000);
            Console.WriteLine("Vamos lá!");
            Thread.Sleep(2500);

            Start(tempo);
        }

        static void Start(int tempo)
        {
            int segundosAtual = 0;

            while (segundosAtual != tempo)
            {
                Console.Clear();
                segundosAtual++;
                Console.WriteLine(segundosAtual);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Tempo finalizando.");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey(true);
            Menu();
        }
    }
}