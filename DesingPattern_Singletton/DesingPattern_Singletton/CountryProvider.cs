using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern_Singletton
{

	public class CountryProvider
	{
		private List<Country> countryList { get; set; }

		private CountryProvider()
		{
			Task.Delay(2000).Wait();
			countryList = new List<Country>()
			{
				new Country(){Name = "Türkiye"},
				new Country(){Name = "Almanya"},
				new Country(){Name = "Hollanda"}
			};
		}


		static bool isCreate = false;

		public static CountryProvider instance;
		public static CountryProvider Instance
		{
			get
			{
				if (isCreate)
				{
					return instance;
				}
				else
				{
					instance = new CountryProvider();
					isCreate = true;
					return instance;
				}
			}

		}

		public async Task<List<Country>> GetCountryList()
		{
			return countryList;
		}
	}
}
