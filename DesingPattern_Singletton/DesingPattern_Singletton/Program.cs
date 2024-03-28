namespace DesingPattern_Singletton
{
	public class Program
	{

		static async Task Main(string[] args)
		{

			Console.WriteLine(DateTime.Now.ToLongTimeString());

			//var countryProvider = new CountryProvider();

			//var countries = await countryProvider.GetCountryList();

			//foreach (var country in countries)
			//{
			//	Console.WriteLine(country.Name);
			//}


			//var countryProvider1 = new CountryProvider();

			//var countries1 = await countryProvider.GetCountryList();


			//foreach (var country in countries1)
			//{
			//	Console.WriteLine(country.Name);
			//}
			//Console.WriteLine(DateTime.Now.ToLongTimeString());
			//Console.ReadKey();


			var countryProvider2 = CountryProvider.Instance;
			var countries2 = await countryProvider2.GetCountryList();

			foreach (var country in countries2)
			{
				Console.WriteLine(country.Name);
			}
			Console.WriteLine(DateTime.Now.ToLongTimeString());
			Console.ReadKey();

		}
	}
}