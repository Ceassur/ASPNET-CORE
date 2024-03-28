using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern_2
{
	internal static class SelectFactory
	{
		public static IFactory GetFactory(string prodcutName,int inch)
		{
			switch (prodcutName)
			{
				case "TV":
					return new CreateFactoryTelevision(inch);
				case "PC":
					return new CreateFactoryComputer();
                case "Tabled":
                    return new CreateFactoryComputer();
                default:
					return null;
			}
		}
	}
}
