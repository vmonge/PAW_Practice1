using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PAW.Practice1.Logic.eValidations
{
    public class SquareVal
    {


        /*
         * Función	                Parámetros	    Resultado	                Comentarios

            Perímetro De Cuadrado	Lado	        Perímetro de la figura	    Lado debe ser un valor positivo
            Área De Cuadrado	    Lado	        Área de la figura	        Lado debe ser un valor positivo

        */
        public bool SquareSideNonNeg(double s1) {
            bool result = (s1>0.0);
            return result; 
            // False. The side of this square is negative or Zero.
        }

    }
}