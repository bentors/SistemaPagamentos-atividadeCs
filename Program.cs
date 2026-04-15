using System;
using SistemaPagamentos.Models;
using SistemaPagamentos.UI;

namespace SistemaPagamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool executando = true;

            while (executando)
            {
                Menu.ExibirMenu();
                
                // Correção do Aviso (Warning): adicionamos o ?? "" para garantir que não seja nulo
                string opcao = Console.ReadLine() ?? "";

                switch (opcao)
                {
                    case "1":
                        ProcessarOpcaoCartao();
                        break;
                    case "2":
                        ProcessarOpcaoBoleto();
                        break;
                    case "3":
                        executando = false;
                        Console.WriteLine("\nSaindo do sistema... Até logo!");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida. Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        static decimal LerValor()
        {
            Console.Write("Informe o valor do pagamento: ");
            
            // Correção do Erro: Declaramos a variável fora do loop para ela existir no return
            decimal valor; 
            
            while (!decimal.TryParse(Console.ReadLine(), out valor) || valor <= 0)
            {
                Console.Write("Formato inválido. Informe um valor numérico válido (ex: 150,50): ");
            }
            
            return valor;
        }

        static void ProcessarOpcaoCartao()
        {
            decimal valor = LerValor();
            Console.Write("Informe o número do cartão: ");
            
            // Correção do Aviso (Warning)
            string numeroCartao = Console.ReadLine() ?? "";

            PagamentoCartao pgto = new PagamentoCartao(valor, numeroCartao);
            pgto.ProcessarPagamento();
        }

        static void ProcessarOpcaoBoleto()
        {
            decimal valor = LerValor();
            Console.Write("Informe o código de barras: ");
            
            // Correção do Aviso (Warning)
            string codigoBarras = Console.ReadLine() ?? "";

            PagamentoBoleto pgto = new PagamentoBoleto(valor, codigoBarras);
            pgto.ProcessarPagamento();
        }
    }
}