using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WFA_Cotacao
{
    class Cotacao
    {
        private double valorEmDolar;
        private double valorDoDolar;
        private double valorEmReal;

        public Cotacao()
        {
            this.valorEmDolar = 0;
            this.valorDoDolar = 0;
        }
        public Cotacao(double valorEmDolar, double valorDoDolar)
        {
            this.valorEmDolar = valorEmDolar;
            this.valorDoDolar = valorDoDolar;
        }
        public void setValorEmDolar(double valorEmDolar)
        {
            this.valorEmDolar = valorEmDolar;
        }
        public void setValorDoDolar(double valorDoDolar)
        {
            this.valorDoDolar = valorDoDolar;
        }
        public double getValorEmDolar()
        {
            return this.valorEmDolar;
        }
        public double getValorDoDolar()
        {
            return this.valorDoDolar;
        }
        public double getValorEmReal()
        {
            return this.valorEmReal;
        }
        public void converter()
        {
            this.valorEmReal = this.valorEmDolar * this.valorDoDolar;
        }

    }
}
