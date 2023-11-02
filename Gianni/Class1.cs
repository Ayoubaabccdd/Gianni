using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gianni
{
    internal class Calc
    {
        //attributi
        private double num1;
        private double num2;
        //costruttore
        public Calc(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        //metodi
            public double Addizione (double num1, double num2)
            {
                 return num1+num2;
            }
            public double Sottrazione(double num1, double num2)
            {
                 return num2-num1;
            }
            public double Moltiplicazione (double num1, double num2)
            {
                 return num1*num2;
            }
            public double Divisione(double num1, double num2)
            {
                 return num1/num2;
            }
            public void SemplificaFrazione(double num1, double num2)
            {

            }

    }
}
