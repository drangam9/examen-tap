namespace Dranga_Marius_M531.Models
{
	public class Client
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public string Nume { get; set; }
		public string Prenume { get; set; }
		public DateTime DataNasterii { get; set; }
		public Adresa Adresa { get; set; }
		public string TipCredit { get; set; }
		public Client()
		{

		}
		public Client(string nume, string prenume, DateTime dataNasterii, Adresa adresa, string tipCredit)
		{
			Nume = nume;
			Prenume = prenume;
			DataNasterii = dataNasterii;
			Adresa = adresa;
			TipCredit = tipCredit;
		}
	}
}
