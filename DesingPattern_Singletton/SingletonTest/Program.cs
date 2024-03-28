namespace SingletonTest
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			
			var brandsProvider = BrandsProvider.Instance;
			var brands1 = await brandsProvider.GetBrandsList();

			foreach (var brands in brands1)
			{
				Console.WriteLine("Alman Araba Markaları: "+brands.Name);
			}
			
			Console.ReadKey();
		}
	}
}