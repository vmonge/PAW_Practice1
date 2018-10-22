using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PAW.Practice1.Logic.eValidations
{
    public class TriangleVal
    {

        /*     Función                     Parámetros              Resultado                   Comentarios
               Perímetro De Triángulo      Lista de 3 lados        Perímetro de la figura      Deben ser tres lados válidos
               Área De Triángulo           Lista de 3 lados        Área de la figura           Deben ser tres lados válidos y se puede aplicar la Fórmula de Herón
        */

        public bool TriangleSidesNonNeg(double s1, double s2, double s3) {
            bool result = (s1 > 0.0 && s2 > 0.0 && s3 > 0.0);
            return result;
            // False All triangle sides should be more than 0.0. Err Code: TSNNeg1.
        }


        public bool TriangleInequalityTheorem(double s1, double s2, double s3) { 
        /*  a+b>c
            a+c>b
            b+c>a
        */
            bool result = ((s1 + s2 > s3) && (s1+s3 > s2 ) && (s2+s3 > s1));
            return result;
            // false >  Sizes do not comply with Theorem. Err Code: TrITh1.
            // True > Sizes comply with Theorem
        }

    }
}