namespace FactoryDesignPattern_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*IFactory tvFactory = new CreateFactoryTelevision();
			IFactory pcFactory = new CreateFactoryComputer();

			IProduct tvProduct = tvFactory.CreatePrudct();
			IProduct pcProduct = pcFactory.CreatePrudct();

			Console.WriteLine(tvProduct.GetName() + " " + pcProduct.GetName());*/

			Console.WriteLine("Üretmek istediğiniz ürünü girin: TV & PC & Tabled");
			string productName = Console.ReadLine();
			Console.WriteLine("Boyut Girin");
			string inch = Console.ReadLine();

			Console.WriteLine("Marka Girin");
			string brand = Console.ReadLine();

			IFactory factory = SelectFactory.GetFactory(productName,Convert.ToInt32(inch));
			IProduct product = factory.CreatePrudct();

			Console.ReadKey();





		}
	}
}
