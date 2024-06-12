namespace Dranga_Marius_M531.Models
{
	public class Adresa
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public string Strada { get; set; }
		public int Numar { get; set; }
		public int Apartament { get; set; }
		public Adresa()
		{

		}
		public Adresa(string strada, int numar, int apartament)
		{
			Strada = strada;
			Numar = numar;
			Apartament = apartament;
		}

	}
}
