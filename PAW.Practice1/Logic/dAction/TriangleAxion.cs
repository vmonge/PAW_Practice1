using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PAW.Practice1.Logic.dAction
{
    public class TriangleAxion
    {
        private IList<string> myErrorList = new List<string>(new string[] { });
        public IList<string> ErrorList {get{return myErrorList;}}


        // Perimeter Calcs
        internal double TrianglePerimeter(double s1, double s2, double s3)
        {

            double result = 0.0;
            var Validation = new Logic.eValidations.TriangleVal();

            if (Validation.TriangleSidesNonNeg(s1, s2, s3))
            {
                if (Validation.TriangleInequalityTheorem(s1, s2, s3))
                {
                    result = s1 + s2 + s3;
                }
                else { myErrorList.Add("Sizes do not comply with Theorem. Err Code: TrITh1."); }
            }
            else { myErrorList.Add("All triangle sides should be more than 0.0.Err Code: TSNNeg1.}"); }


            return result;
        }


        internal double TriangleAreaHeron(double s1, double s2, double s3)
        {

            double result = 0.0;
            var Validation = new Logic.eValidations.TriangleVal();

            if (Validation.TriangleSidesNonNeg(s1, s2, s3))
            {
                if (Validation.TriangleInequalityTheorem(s1, s2, s3))
                {
                    double smp = (s1 + s2 + s3) / 2; //semiperimeter
                    result = Math.Sqrt( smp*(smp - s1)*(smp - s2)*(smp - s3)) ; 
                }
                else { myErrorList.Add("Sizes do not comply with Theorem. Err Code: TrITh1."); }
            }
            else { myErrorList.Add("All triangle sides should be more than 0.0.Err Code: TSNNeg1.}"); }


            return result;
        }
    }
}