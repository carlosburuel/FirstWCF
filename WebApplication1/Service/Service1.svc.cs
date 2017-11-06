using System;
using System.Runtime.Serialization;
using System.ServiceModel.Activation;

namespace WebApplication1.Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 : IService1
    {
        public int DoSquare(int value)
        {
            return value * value;
        }

        public String DoWork()
        {
            return "Hello REST WCF Service!";
        }

        public int DoAddValues(AddValues addValues)
        {
            return addValues.Value1 + addValues.Value2;
        }
    }

    [DataContract]
    public class AddValues
    {
        [DataMember]
        public int Value1 { get; set; }
        [DataMember]
        public int Value2 { get; set; }

        public AddValues()
        {
            Value1 = 0;
            Value2 = 0;
        }
    }
}
