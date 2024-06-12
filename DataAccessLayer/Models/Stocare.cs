namespace Dranga_Marius_M531.Models
{
	public class Stocare
	{
		public static readonly List<Banca> banks = new List<Banca> {
			new Banca("BRD", new Adresa("Eminescu", 13, 1), new List<Client>
			{
				new Client("Popescu", "Andrei", new DateTime(1996, 3, 1), new Adresa("Popa", 4, 2), "credit1"),
				new Client("Ionescu", "Elena", new DateTime(1943, 6, 2), new Adresa("Morii", 40, 13), "credit2")
			}, 6.3),
			new Banca("BCR", new Adresa("Creanga", 1, 13), new List<Client>
			{
				new Client("Ilie", "Mihai", new DateTime(1989, 1, 3), new Adresa("Independentei", 47, 5), "credit1"),
				new Client("Popovici", "Maria", new DateTime(1977, 7, 8), new Adresa("Unirii", 34, 3), "credit2")
			}, 6.3)
		};
		public Stocare()
		{

		}
		public List<Banca> GetBanks()
		{
			return banks;
		}
	}
}
