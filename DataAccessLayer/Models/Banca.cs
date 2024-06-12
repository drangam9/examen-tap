namespace Dranga_Marius_M531.Models
{
	public class Banca
	{
		public Guid Id { get; set; }
		public string Nume { get; set; }

		public Adresa Adresa { get; set; }
		public List<Client> Clienti { get; set; }
		public double DobandaGenerala { get; set; }
		public Banca()
		{

		}
		public Banca(string nume, Adresa adresa, List<Client> clienti, double dobandaGenerala)
		{
			Nume = nume;
			Adresa = adresa;
			Clienti = clienti;
			DobandaGenerala = dobandaGenerala;
		}
	}
}
