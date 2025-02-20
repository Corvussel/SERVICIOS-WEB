using System;
using System.ServiceModel;


namespace CalculadoraService
{
	[ServiceBehavior(
		InstanceContextMode = InstanceContextMode.PerCall,
		ConcurrencyMode = ConcurrencyMode.Single
	)]
	public class CalculadoraService : ICalculadoraService
	{
		[OperationBehavior(TransactionScopeRequired = false)]
		public int Sum(int a, int b)
		{
			Console.WriteLine("sumando {0} + {1}", a, b);
			return a + b;
		}
	}
}
