using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryDesignPattern_2
{
	internal class Television : IProduct
	{
		int inch;
		public Television(int inch) { 
			this.inch = inch;
		}


		public string GetName(string productName)
		{
			return "Samsung 120 Ekran TV Boyut:"+ inch;
		}

		public double GetPrice()
		{
			return 9999.25;
		}
	}
}
