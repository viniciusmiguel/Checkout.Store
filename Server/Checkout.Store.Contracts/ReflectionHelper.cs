using System.Reflection;

namespace Checkout.Store.Contracts
{
	public class ReflectionHelper {
		public static Assembly ContractsAssembly = typeof(ReflectionHelper).GetTypeInfo().Assembly; 
	}
}
