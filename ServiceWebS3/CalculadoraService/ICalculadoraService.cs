
using System.ServiceModel;


namespace CalculadoraService
{
	[ServiceContract]
	public interface ICalculadoraService
	{
		[OperationContract]
		int Sum(int a, int b);
	}

}
