using System;
using System.Globalization;

namespace MaquinaDeCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Olá, que tal um cafézinho hoje?");
            Console.WriteLine();
            Console.WriteLine("Esta maquina aceita moedas de: R$0.1, R$0.5, R$0.10, R$0.25, R$0.50, R$1.0");
            Console.WriteLine();

            Console.Write("Insira aqui a quantidade de moedas de R$0.1 centavo: ");
            double moeda1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (moeda1 >= 1)
            {
                Console.WriteLine();
                Console.WriteLine("Erro na leitora de moedas! (Esta maquina temporariamente não aceita este valor em moeda)");
                Console.Write("Deseja continuar (Sim / Não)? ");
                string resp = Console.ReadLine().ToLower();
                if (resp == "sim")
                {

                }
                else
                {
                    return;
                }
            }
            Console.WriteLine();
            Console.Write("Insira aqui a quantidade de moedas de R$0.5 centavos: ");
            double moeda5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (moeda5 >= 1)
            {
                Console.WriteLine();
                Console.WriteLine("Erro na leitora de moedas! (Esta maquina temporariamente não aceita este valor em moeda)");
                Console.Write("Deseja continuar (Sim / Não)? ");
                string resp = Console.ReadLine().ToLower();
                if (resp == "sim")
                {

                }
                else
                {
                    return;
                }
            }
            Console.WriteLine();

            Console.Write("Insira aqui a quantidade de moedas de R$0.10 centavos: ");
            double moeda10 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.Write("Insira aqui a quantidade de moedas de R$0.25 centavos: ");
            double moeda25 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.Write("Insira aqui a quantidade de moedas de R$0.50 centavos: ");
            double moeda50 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.Write("Insira aqui a quantidade de moedas de R$1.0 centavos: ");
            double moeda100 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Cafe c = new Cafe(0.0, 3.5, 4.0, 3.0);

            c.SaldoDeCompra(moeda10, moeda25, moeda50, moeda100);
            Console.WriteLine("Seu saldo de compra é: " + c.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            if (c.Saldo >= 4.0)
            {
                Console.WriteLine("Cafés disponiveis para compra: ");
                Console.WriteLine("Cappuccino (R$ 3.5)");
                Console.WriteLine("Mocha (R$ 4.0)");
                Console.WriteLine("Café com leite (R$ 3.0)");
            }
            else if (c.Saldo >= 3.5)
            {
                Console.WriteLine("Cafés disponiveis para compra: ");
                Console.WriteLine();
                Console.WriteLine("Cappuccino (R$ 3.5)");
                Console.WriteLine("Café com leite (R$ 3.0)");
            }
            else if (c.Saldo >= 3.0)
            {
                Console.WriteLine("Café disponivel para compra: ");
                Console.WriteLine();
                Console.WriteLine("Café com leite (R$ 3.0)");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para a compra de café");
                return;
            }
            Console.WriteLine();
            Console.Write("Qual café você deseja? ");
            string cafeCliente = Console.ReadLine().ToLower();
            c.CafeTroco(cafeCliente);
            Console.WriteLine();
            Console.WriteLine($"Ok, o seu {cafeCliente} já está sendo preparado, aguarde alguns segundos...");
            Console.WriteLine();
            System.Threading.Thread.Sleep(10000);
            if (c.Saldo == 0.0)
            {
                Console.WriteLine("Está pronto seu café, aproveite!!!");
            }
            else
            {
                Console.WriteLine("Está pronto seu café, e seu troco é: " + c.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
