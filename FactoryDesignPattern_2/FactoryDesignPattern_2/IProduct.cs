using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern_2
{
	internal interface IProduct
	{
		string GetName(string productName);
		double GetPrice();

	}
}
