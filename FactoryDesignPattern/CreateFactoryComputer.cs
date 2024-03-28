using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern_2
{
	internal class CreateFactoryComputer : IFactory
	{
		public IProduct CreatePrudct()
		{
			return new Computer();
		}
	}
}
