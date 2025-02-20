using System.ServiceModel;

namespace CalculadoraService
{
    class Cliente
    {
        static void Main(string[] args)
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress("http://localhost:8733/CalculadoraService/");
            var factory = new ChannelFactory<ICalculadoraService>(binding, endpoint);
            ICalculadoraService client = factory.CreateChannel();


            int result = client.Sum(12, 18);

            Console.WriteLine("Resultado de la suma es: " + result);

            ((ICommunicationObject)client).Close();
        }

        [ServiceContract]
        public interface ICalculadoraService
        {
            [OperationContract]
            int Sum(int a, int b);
        }

    }

}