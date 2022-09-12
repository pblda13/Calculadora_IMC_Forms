using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoras
{
    public class CalculoImc
    {
        public double P { get; set; }
        public double A { get; set; }  

        public string CalcclassifiIMC(double P,double A)
        {

            double imc = P / (A * A);

            if (imc < 18.49)
            {
                return ("Peso abaixo do normal ");
            }
            else if (imc <= 24.99)
            {
                return ("Peso normal ");
            }
            else if (imc <= 29.99)

            {
                return ("Sobrepeso ");
            }
            else if (imc <= 34.99)
            {
                return ("Grau de Obesidade I ");
            }
            else if (imc <= 39.99)
            {
                return ("Grau de Obesidade II ");
            }
            else
            {
                return ("Obesidade Grau III ");
            }
        }
    }
}
