using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PAW.Practice1.Logic.cSpecification
{
    public class TriangleOps
    {
        public double TrianglePerimeter(double s1, double s2, double s3)
        {
            var axion = new Logic.dAction.TriangleAxion();
            double result = axion.TrianglePerimeter(s1, s2, s3);
            return result;
        }

        public double TriangleArea(double s1, double s2, double s3)
        {
            var axion = new Logic.dAction.TriangleAxion();
            double result = axion.TriangleAreaHeron(s1, s2, s3);
            return result;
        }
    }
}