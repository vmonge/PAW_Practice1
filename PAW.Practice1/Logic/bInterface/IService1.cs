using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PAW.Practice1.Logic.aService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        /* [OperationContract]
         void DoWork();*/


        //Perímetro De Triángulo Lista de 3 lados Perímetro de la figura Deben ser tres lados válidos
        [OperationContract]
        double TrianglePerimeter(double s1, double s2, double s3);


        [OperationContract]
        double TriangleArea(double s1, double s2, double s3);





     
        // COMPOSITE STUFF 
      
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
        [DataContract]
        public class CompositeType
        {
            bool boolValue = true;
            string stringValue = "Hello ";

            [DataMember]
            public bool BoolValue
            {
                get { return boolValue; }
                set { boolValue = value; }
            }

            [DataMember]
            public string StringValue
            {
                get { return stringValue; }
                set { stringValue = value; }
            }
        }
    }
}
