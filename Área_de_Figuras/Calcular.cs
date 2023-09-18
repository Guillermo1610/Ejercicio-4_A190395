using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Área_de_Figuras
{
    public class Calcular
    {
        public decimal A {get; set;}
        public decimal B {get; set;}
        public decimal lado {get; set;}
        public decimal radio { get; set;}

        public decimal cuadrado (decimal lado)
        {
            return lado * lado;

        }

        public decimal triangulo (decimal A, decimal B) 
        {
            decimal resultado;
            resultado = A * B;
            return (resultado) / 2;
        }

        public decimal circulo (double radio) 
        {
            double pi = Math.PI;

            return (decimal)(pi * radio * radio);
        }
    }
}