using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PAW.Practice1.Logic
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public double TrianglePerimeter(double s1, double s2, double s3) 
        { 
            var Specification = new Logic.cSpecification.TriangleOps();
            var result = Specification.TrianglePerimeter(s1, s2, s3);
            return result;
        }

        public double TriangleArea(double s1, double s2, double s3) {
            var Specification = new Logic.cSpecification.TriangleOps();
            var result = Specification.TriangleArea(s1, s2, s3);
            return result;
        }

        public double SquarePerimeter(double s1)
        {
            var Specification = new Logic.cSpecification.SquareOps();
            var result = Specification.SquarePerimeter(s1);
            return result;
        }

        public double SquareArea(double s1)
        {
            var Specification = new Logic.cSpecification.SquareOps();
            var result = Specification.SquareArea(s1);
            return result;
        }


        // Composite Stuff 
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
