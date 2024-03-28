using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTest
{
	public class BrandsProvider
	{
		private List<Brands> brandList { get; set; }

		private BrandsProvider()
		{
			
			brandList = new List<Brands>()
			{
				new Brands(){Name = "BMW"},
				new Brands(){Name = "Mecedes"},
				new Brands(){Name = "Opel"},
				new Brands(){Name = "Audi"},
				new Brands(){Name = "Volkswagen"}
				
			};
		}


		static bool isCreate = false;
		//Instance özelliği aracılığıyla bu sınıfın yalnızca bir örneğine erişilebilir.
		public static BrandsProvider instance;
		public static BrandsProvider Instance
		{
			get
			{
				if (isCreate)
				{
					return instance;
				}
				else
				{
					instance = new BrandsProvider();
					isCreate = true;
					return instance;
				}
			}
		}

		public async Task<List<Brands>> GetBrandsList()
		{
			return brandList;
		}

	}
}
