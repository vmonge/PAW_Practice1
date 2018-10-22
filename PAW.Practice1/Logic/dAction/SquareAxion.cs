using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PAW.Practice1.Logic.dAction
{
    public class SquareAxion
    {
        private IList<string> myErrorList = new List<string>(new string[] { });
        public IList<string> ErrorList { get { return myErrorList; } }

        /*
        * Función	                Parámetros	    Resultado	                Comentarios

           Perímetro De Cuadrado	Lado	        Perímetro de la figura	    Lado debe ser un valor positivo
           Área De Cuadrado	    Lado	        Área de la figura	        Lado debe ser un valor positivo

       */
       
        internal double SquarePerimeter( double s1) {
            double result = 0.0;
            var Validation = new Logic.eValidations.SquareVal();
            if (Validation.SquareSideNonNeg(s1) ){
                result = s1 * 4;
            }
            else { myErrorList.Add("The side of this square is negative or Zero."); }
            return result;
        }

        internal double SquareArea(double s1)
        {
            double result = 0.0;
            var Validation = new Logic.eValidations.SquareVal();
            if (Validation.SquareSideNonNeg(s1)) {
                result = s1*s1;
            }
            else { myErrorList.Add("The side of this square is negative or Zero."); }
            return result;
        }
    }
}