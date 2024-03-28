using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern_2
{
	internal class CreateFactoryTelevision : IFactory
	{
		int inch;

		public CreateFactoryTelevision(int inch) {
			this.inch = inch;
		}
		public IProduct CreatePrudct()
		{
			return new Television(inch);
		}
	}
}
