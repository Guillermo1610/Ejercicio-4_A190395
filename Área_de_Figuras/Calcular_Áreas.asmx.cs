﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Área_de_Figuras
{
    /// <summary>
    /// Descripción breve de Calcular_Áreas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Calcular_Áreas : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public decimal area_cuadrado(decimal lado)
        {
            Calcular area = new Calcular();
            return area.cuadrado(lado);
         }
        
        [WebMethod]
        public decimal area_triangulo (decimal A, decimal B)
        {
            Calcular area = new Calcular();
            return area.triangulo(A, B);
        }

        [WebMethod]
        public decimal area_circulo (double radio)
        {
            Calcular area = new Calcular();
            return area.circulo(radio);
        }
    
    }
}
