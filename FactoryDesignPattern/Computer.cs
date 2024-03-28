using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern_2
{
	internal class Computer : IProduct
	{
		public string GetName()
		{
			return "Asus Zenbook";
		}

		public double GetPrice()
		{
			return 35000.99;
		}

		public string CreateCustumpRroduct(string pcName)
		{
			return pcName + "PC Üretildi";
		}


	}
}
