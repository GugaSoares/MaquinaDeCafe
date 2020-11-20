using System;
using System.Collections.Generic;
using System.Text;

namespace MaquinaDeCafe
{
    class Cafe
    {
        public double Saldo { get; private set; }
        public double Cappuccino { get; private set; }
        public double Mocha { get; private set; }
        public double CafeComLeite { get; private set; }

        public Cafe (double saldo, double cappuccino, double mocha, double cafeComLeite)
        {
            Saldo = saldo;
            Cappuccino = cappuccino;
            Mocha = mocha;
            CafeComLeite = cafeComLeite;
        }


        public double SaldoDeCompra(double moeda5, double moeda10, double moeda25, double moeda50, double moeda100)
        {
            moeda5 *= 0.5;
            moeda10 *= 0.10;
            moeda25 *= 0.25;
            moeda50 *= 0.50;
            moeda100 *= 1.0;
            double somaDasMoedas = moeda5 + moeda10 + moeda25 + moeda50 + moeda100;
            Saldo = Saldo + somaDasMoedas;
            return Saldo;
        }
        public void CafeTroco (string cafeSelecionado)
        {
            cafeSelecionado.ToLower();
            if (cafeSelecionado == "cappuccino")
            {
                Saldo -= Cappuccino;
            }
            else if (cafeSelecionado == "mocha")
            {
                Saldo -= Mocha;
            }
            else if (cafeSelecionado == "cafe com leite" || cafeSelecionado == "cafecomleite")
            {
                Saldo -= CafeComLeite;
            }
            else
            {
                return;
            }
        }
    }
}
