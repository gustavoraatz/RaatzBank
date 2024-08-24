using System;

namespace RaatzBank
{

    class Program
    {

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Bem-vindo ao RaatzBank!");

            Thread.Sleep(2000);

            Console.WriteLine("O que deseja fazer hoje?");

            Thread.Sleep(2000);

            Console.Clear();

            Console.WriteLine("RaatzBank");
            Console.WriteLine("----------");
            Console.WriteLine("1 - Criar conta");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Transferência");
            Console.WriteLine("5 - Ver saldo");
            Console.WriteLine("6 - Histórico de transações");
            Console.WriteLine("7 - Contas cadastradas");
            Console.WriteLine("0 - Sair");

            short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: CriarConta(); break;
                case 2: Depositar(); break;
                case 3: Sacar(); break;
                case 4: Transferencia(); break;
                case 5: VerSaldo(); break;
                case 6: Historico(); break;
                case 7: ContasCadastradas(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }

        static void CriarConta()
        {
            Console.Clear();

            Console.WriteLine("Insira seu número de cadastro");

        }

        static void Depositar()
        {

        }

        static void Sacar()
        {

        }

        static void Transferencia()
        {

        }

        static void VerSaldo()
        {

        }

    }
}