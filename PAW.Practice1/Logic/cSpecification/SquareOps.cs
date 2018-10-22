using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PAW.Practice1.Logic.cSpecification
{  
    
    /*
        * Función	                Parámetros	    Resultado	                Comentarios

           Perímetro De Cuadrado	Lado	        Perímetro de la figura	    Lado debe ser un valor positivo
           Área De Cuadrado	    Lado	        Área de la figura	        Lado debe ser un valor positivo

       */
    public class SquareOps
    {
        public double SquarePerimeter(double s1) {
            var Axion = new Logic.dAction.SquareAxion();
            double result= Axion.SquarePerimeter(s1);
            return result;
        }
        public double SquareArea(double s1)
        {
            var Axion = new Logic.dAction.SquareAxion();
            double result = Axion.SquareArea(s1);
            return result;
        }
    }
}